using Microsoft.Pex.Framework;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QuickGraph;
using QuickGraph.Algorithms.Search;
using QuickGraph.Algorithms.Services;
using QuickGraph.Collections;
using System.Collections.Generic;

namespace QuickGraph.Algorithms.Search
{
    /// <summary>
    /// This class contains parameterized unit tests for BreadthFirstSearchAlgorithm`2
    /// </summary>
    [TestClass]
    [PexClass(typeof(BreadthFirstSearchAlgorithm<, >))]
    public partial class BreadthFirstSearchAlgorithmTVertexTEdgeTest
    {
        [PexMethod]
        public BreadthFirstSearchAlgorithm<TVertex, TEdge> Constructor<TVertex,TEdge>(IVertexListGraph<TVertex, TEdge> g)
            where TEdge : IEdge<TVertex>
        {
            BreadthFirstSearchAlgorithm<TVertex, TEdge> target
               = new BreadthFirstSearchAlgorithm<TVertex, TEdge>(g);
            return target;
            // TODO: add assertions to method BreadthFirstSearchAlgorithmTVertexTEdgeTest.Constructor(IVertexListGraph`2<!!0,!!1>)
        }
        
        [PexMethod]
        public BreadthFirstSearchAlgorithm<TVertex, TEdge> Constructor01<TVertex,TEdge>(
            IVertexListGraph<TVertex, TEdge> visitedGraph,
            IQueue<TVertex> vertexQueue,
            IDictionary<TVertex, GraphColor> vertexColors
        )
            where TEdge : IEdge<TVertex>
        {
            BreadthFirstSearchAlgorithm<TVertex, TEdge> target
               = new BreadthFirstSearchAlgorithm<TVertex, TEdge>
                  (visitedGraph, vertexQueue, vertexColors);
            return target;
            // TODO: add assertions to method BreadthFirstSearchAlgorithmTVertexTEdgeTest.Constructor01(IVertexListGraph`2<!!0,!!1>, IQueue`1<!!0>, IDictionary`2<!!0,GraphColor>)
        }
        
        [PexMethod]
        public BreadthFirstSearchAlgorithm<TVertex, TEdge> Constructor02<TVertex,TEdge>(
            IAlgorithmComponent host,
            IVertexListGraph<TVertex, TEdge> visitedGraph,
            IQueue<TVertex> vertexQueue,
            IDictionary<TVertex, GraphColor> vertexColors
        )
            where TEdge : IEdge<TVertex>
        {
            BreadthFirstSearchAlgorithm<TVertex, TEdge> target
               = new BreadthFirstSearchAlgorithm<TVertex, TEdge>
                  (host, visitedGraph, vertexQueue, vertexColors);
            return target;
            // TODO: add assertions to method BreadthFirstSearchAlgorithmTVertexTEdgeTest.Constructor02(IAlgorithmComponent, IVertexListGraph`2<!!0,!!1>, IQueue`1<!!0>, IDictionary`2<!!0,GraphColor>)
        }
        
        [PexMethod]
        public GraphColor GetVertexColor<TVertex,TEdge>(
            [PexAssumeUnderTest]BreadthFirstSearchAlgorithm<TVertex, TEdge> target,
            TVertex vertex
        )
            where TEdge : IEdge<TVertex>
        {
            GraphColor result = target.GetVertexColor(vertex);
            return result;
            // TODO: add assertions to method BreadthFirstSearchAlgorithmTVertexTEdgeTest.GetVertexColor(BreadthFirstSearchAlgorithm`2<!!0,!!1>, !!0)
        }
        
        [PexMethod]
        public void VertexColorsGet<TVertex,TEdge>(
            [PexAssumeUnderTest]BreadthFirstSearchAlgorithm<TVertex, TEdge> target
        )
            where TEdge : IEdge<TVertex>
        {
            IDictionary<TVertex, GraphColor> result = target.VertexColors;
            PexStore.ValueForValidation<IDictionary<TVertex, GraphColor>>("result", result);
            // TODO: add assertions to method BreadthFirstSearchAlgorithmTVertexTEdgeTest.VertexColorsGet(BreadthFirstSearchAlgorithm`2<!!0,!!1>)
        }
        
        [PexMethod]
        public void Visit<TVertex,TEdge>(
            [PexAssumeUnderTest]BreadthFirstSearchAlgorithm<TVertex, TEdge> target,
            TVertex s
        )
            where TEdge : IEdge<TVertex>
        {
            target.Visit(s);
            // TODO: add assertions to method BreadthFirstSearchAlgorithmTVertexTEdgeTest.Visit(BreadthFirstSearchAlgorithm`2<!!0,!!1>, !!0)
        }
        
    }
}
