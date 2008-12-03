﻿using System;
using System.Collections.Generic;

using QuickGraph.Collections;
using QuickGraph.Algorithms.Observers;
using QuickGraph.Algorithms.Services;

namespace QuickGraph.Algorithms.Search
{
    /// <summary>
    /// A breath first search algorithm for directed graphs
    /// </summary>
    /// <reference-ref
    ///     idref="gross98graphtheory"
    ///     chapter="4.2"
    ///     />
    [Serializable]
    public sealed class BreadthFirstSearchAlgorithm<TVertex, TEdge> :
        RootedAlgorithmBase<TVertex, IVertexListGraph<TVertex, TEdge>>,
        IVertexPredecessorRecorderAlgorithm<TVertex,TEdge>,
        IDistanceRecorderAlgorithm<TVertex,TEdge>,
        IVertexColorizerAlgorithm<TVertex,TEdge>,
        ITreeBuilderAlgorithm<TVertex, TEdge>
        where TEdge : IEdge<TVertex>
    {
        private IDictionary<TVertex, GraphColor> vertexColors;
        private IQueue<TVertex> vertexQueue;

        public BreadthFirstSearchAlgorithm(IVertexListGraph<TVertex,TEdge> g)
            : this(g, new QuickGraph.Collections.Queue<TVertex>(), new Dictionary<TVertex, GraphColor>())
        {}

        public BreadthFirstSearchAlgorithm(
            IVertexListGraph<TVertex, TEdge> visitedGraph,
            IQueue<TVertex> vertexQueue,
            IDictionary<TVertex, GraphColor> vertexColors
            )
            : this(null, visitedGraph, vertexQueue, vertexColors)
        { }

        public BreadthFirstSearchAlgorithm(
            IAlgorithmComponent host,
            IVertexListGraph<TVertex, TEdge> visitedGraph,
            IQueue<TVertex> vertexQueue,
            IDictionary<TVertex, GraphColor> vertexColors
            )
            :base(host, visitedGraph)
        {
            if (vertexQueue == null)
                throw new ArgumentNullException("vertexQueue");
            if (vertexColors == null)
                throw new ArgumentNullException("vertexColors");

            this.vertexColors = vertexColors;
            this.vertexQueue = vertexQueue;
        }

        public IDictionary<TVertex,GraphColor> VertexColors
        {
            get
            {
                return vertexColors;
            }
        }

        public GraphColor GetVertexColor(TVertex vertex)
        {
            return this.vertexColors[vertex];
        }

        public event VertexEventHandler<TVertex> InitializeVertex;
        private void OnInitializeVertex(TVertex v)
        {
            var eh = this.InitializeVertex;
            if (eh != null)
                eh(this, new VertexEventArgs<TVertex>(v));
        }

        public event VertexEventHandler<TVertex> StartVertex;
        private void OnStartVertex(TVertex v)
        {
            var eh = this.StartVertex;
            if (eh != null)
                eh(this, new VertexEventArgs<TVertex>(v));
        }

        public event VertexEventHandler<TVertex> ExamineVertex;
        private void OnExamineVertex(TVertex v)
        {
            var eh = this.ExamineVertex;
            if (eh != null)
                eh(this, new VertexEventArgs<TVertex>(v));
        }

        public event VertexEventHandler<TVertex> DiscoverVertex;
        private void OnDiscoverVertex(TVertex v)
        {
            var eh = this.DiscoverVertex;
            if (eh != null)
                eh(this, new VertexEventArgs<TVertex>(v));
        }

        public event EdgeEventHandler<TVertex, TEdge> ExamineEdge;
        private void OnExamineEdge(TEdge e)
        {
            var eh = this.ExamineEdge;
            if (eh != null)
                eh(this, new EdgeEventArgs<TVertex, TEdge>(e));
        }

        public event EdgeEventHandler<TVertex, TEdge> TreeEdge;
        private void OnTreeEdge(TEdge e)
        {
            var eh = this.TreeEdge;
            if (eh != null)
                eh(this, new EdgeEventArgs<TVertex, TEdge>(e));
        }

        public event EdgeEventHandler<TVertex, TEdge> NonTreeEdge;
        private void OnNonTreeEdge(TEdge e)
        {
            var eh = this.NonTreeEdge;
            if (eh != null)
                eh(this, new EdgeEventArgs<TVertex, TEdge>(e));
        }

        public event EdgeEventHandler<TVertex, TEdge> GrayTarget;
        private void OnGrayTarget(TEdge e)
        {
            var eh = this.GrayTarget;
            if (eh != null)
                eh(this, new EdgeEventArgs<TVertex, TEdge>(e));
        }

        public event EdgeEventHandler<TVertex, TEdge> BlackTarget;
        private void OnBlackTarget(TEdge e)
        {
            var eh = this.BlackTarget;
            if (eh != null)
                eh(this, new EdgeEventArgs<TVertex, TEdge>(e));
        }

        public event VertexEventHandler<TVertex> FinishVertex;
        private void OnFinishVertex(TVertex v)
        {
            var eh = this.FinishVertex;
            if (eh != null)
                eh(this, new VertexEventArgs<TVertex>(v));
        }

        protected override void Initialize()
        {
            base.Initialize();

            var cancelManager = this.Services.CancelManager;
            // initialize vertex u
            foreach (var v in VisitedGraph.Vertices)
            {
                if (cancelManager.IsCancelling)
                    return;
                VertexColors[v] = GraphColor.White;
                OnInitializeVertex(v);
            }
        }

        protected override void InternalCompute()
        {
            if (this.VisitedGraph.VertexCount == 0)
                return;

            TVertex rootVertex;
            if (!this.TryGetRootVertex(out rootVertex))
            {
                // enqueue roots
                foreach (var root in this.VisitedGraph.Roots())
                    this.EnqueueRoot(root);
            }
            else // enqueue select root only
            {
                this.EnqueueRoot(rootVertex);
            }
            this.FlushVisitQueue();
        }

        public void Visit(TVertex s)
        {
            this.EnqueueRoot(s);
            this.FlushVisitQueue();
        }

        private void EnqueueRoot(TVertex s)
        {
            this.OnStartVertex(s);

            this.VertexColors[s] = GraphColor.Gray;

            OnDiscoverVertex(s);
            this.vertexQueue.Enqueue(s);
        }

        private void FlushVisitQueue()
        {
            var cancelManager = this.Services.CancelManager;

            while (this.vertexQueue.Count != 0)
            {
                if (cancelManager.IsCancelling) return;

                var u = this.vertexQueue.Dequeue();
                this.OnExamineVertex(u);
                foreach (var e in this.VisitedGraph.OutEdges(u))
                {
                    TVertex v = e.Target;
                    this.OnExamineEdge(e);

                    var vColor = this.VertexColors[v];
                    if (vColor == GraphColor.White)
                    {
                        this.OnTreeEdge(e);
                        this.VertexColors[v] = GraphColor.Gray;
                        this.OnDiscoverVertex(v);
                        this.vertexQueue.Enqueue(v);
                    }
                    else
                    {
                        this.OnNonTreeEdge(e);
                        if (vColor == GraphColor.Gray)
                            this.OnGrayTarget(e);
                        else
                            this.OnBlackTarget(e);
                    }
                }
                this.VertexColors[u] = GraphColor.Black;
                this.OnFinishVertex(u);
            }
        }
    }
}
