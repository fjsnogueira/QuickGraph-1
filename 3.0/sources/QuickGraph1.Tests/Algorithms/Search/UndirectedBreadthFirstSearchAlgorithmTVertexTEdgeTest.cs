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
    /// This class contains parameterized unit tests for UndirectedBreadthFirstSearchAlgorithm`2
    /// </summary>
    [TestClass]
    [PexClass(typeof(UndirectedBreadthFirstSearchAlgorithm<, >))]
    public partial class UndirectedBreadthFirstSearchAlgorithmTVertexTEdgeTest
    {
        [PexMethod]
        public UndirectedBreadthFirstSearchAlgorithm<TVertex, TEdge> Constructor<TVertex,TEdge>(IUndirectedGraph<TVertex, TEdge> g)
            where TEdge : IEdge<TVertex>
        {
            UndirectedBreadthFirstSearchAlgorithm<TVertex, TEdge> target
               = new UndirectedBreadthFirstSearchAlgorithm<TVertex, TEdge>(g);
            return target;
            // TODO: add assertions to method UndirectedBreadthFirstSearchAlgorithmTVertexTEdgeTest.Constructor(IUndirectedGraph`2<!!0,!!1>)
        }
        
        [PexMethod]
        public UndirectedBreadthFirstSearchAlgorithm<TVertex, TEdge> Constructor01<TVertex,TEdge>(
            IUndirectedGraph<TVertex, TEdge> visitedGraph,
            IQueue<TVertex> vertexQueue,
            IDictionary<TVertex, GraphColor> vertexColors
        )
            where TEdge : IEdge<TVertex>
        {
            UndirectedBreadthFirstSearchAlgorithm<TVertex, TEdge> target
               = new UndirectedBreadthFirstSearchAlgorithm<TVertex, TEdge>
                  (visitedGraph, vertexQueue, vertexColors);
            return target;
            // TODO: add assertions to method UndirectedBreadthFirstSearchAlgorithmTVertexTEdgeTest.Constructor01(IUndirectedGraph`2<!!0,!!1>, IQueue`1<!!0>, IDictionary`2<!!0,GraphColor>)
        }
        
        [PexMethod]
        public UndirectedBreadthFirstSearchAlgorithm<TVertex, TEdge> Constructor02<TVertex,TEdge>(
            IAlgorithmComponent host,
            IUndirectedGraph<TVertex, TEdge> visitedGraph,
            IQueue<TVertex> vertexQueue,
            IDictionary<TVertex, GraphColor> vertexColors
        )
            where TEdge : IEdge<TVertex>
        {
            UndirectedBreadthFirstSearchAlgorithm<TVertex, TEdge> target
               = new UndirectedBreadthFirstSearchAlgorithm<TVertex, TEdge>
                  (host, visitedGraph, vertexQueue, vertexColors);
            return target;
            // TODO: add assertions to method UndirectedBreadthFirstSearchAlgorithmTVertexTEdgeTest.Constructor02(IAlgorithmComponent, IUndirectedGraph`2<!!0,!!1>, IQueue`1<!!0>, IDictionary`2<!!0,GraphColor>)
        }
        
        [PexMethod]
        public GraphColor GetVertexColor<TVertex,TEdge>(
            [PexAssumeUnderTest]UndirectedBreadthFirstSearchAlgorithm<TVertex, TEdge> target,
            TVertex vertex
        )
            where TEdge : IEdge<TVertex>
        {
            GraphColor result = target.GetVertexColor(vertex);
            return result;
            // TODO: add assertions to method UndirectedBreadthFirstSearchAlgorithmTVertexTEdgeTest.GetVertexColor(UndirectedBreadthFirstSearchAlgorithm`2<!!0,!!1>, !!0)
        }
        
        
        [PexMethod]
        public void VertexColorsGet<TVertex,TEdge>(
            [PexAssumeUnderTest]UndirectedBreadthFirstSearchAlgorithm<TVertex, TEdge> target
        )
            where TEdge : IEdge<TVertex>
        {
            IDictionary<TVertex, GraphColor> result = target.VertexColors;
            PexStore.ValueForValidation<IDictionary<TVertex, GraphColor>>("result", result);
            // TODO: add assertions to method UndirectedBreadthFirstSearchAlgorithmTVertexTEdgeTest.VertexColorsGet(UndirectedBreadthFirstSearchAlgorithm`2<!!0,!!1>)
        }
        
        [PexMethod]
        public void Visit<TVertex,TEdge>(
            [PexAssumeUnderTest]UndirectedBreadthFirstSearchAlgorithm<TVertex, TEdge> target,
            TVertex s
        )
            where TEdge : IEdge<TVertex>
        {
            target.Visit(s);
            // TODO: add assertions to method UndirectedBreadthFirstSearchAlgorithmTVertexTEdgeTest.Visit(UndirectedBreadthFirstSearchAlgorithm`2<!!0,!!1>, !!0)
        }
        
    }
}
