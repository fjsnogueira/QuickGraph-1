using Microsoft.Pex.Framework;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QuickGraph;
using QuickGraph.Algorithms.Search;
using QuickGraph.Algorithms.Services;
using System.Collections.Generic;

namespace QuickGraph.Algorithms.Search
{
    /// <summary>
    /// This class contains parameterized unit tests for UndirectedDepthFirstSearchAlgorithm`2
    /// </summary>
    [TestClass]
    [PexClass(typeof(UndirectedDepthFirstSearchAlgorithm<, >))]
    public partial class UndirectedDepthFirstSearchAlgorithmTVertexTEdgeTest
    {
        [PexMethod]
        public UndirectedDepthFirstSearchAlgorithm<TVertex, TEdge> Constructor<TVertex,TEdge>(IUndirectedGraph<TVertex, TEdge> g)
            where TEdge : IEdge<TVertex>
        {
            UndirectedDepthFirstSearchAlgorithm<TVertex, TEdge> target
               = new UndirectedDepthFirstSearchAlgorithm<TVertex, TEdge>(g);
            return target;
            // TODO: add assertions to method UndirectedDepthFirstSearchAlgorithmTVertexTEdgeTest.Constructor(IUndirectedGraph`2<!!0,!!1>)
        }
        
        [PexMethod]
        public UndirectedDepthFirstSearchAlgorithm<TVertex, TEdge> Constructor01<TVertex,TEdge>(
            IUndirectedGraph<TVertex, TEdge> visitedGraph,
            IDictionary<TVertex, GraphColor> colors
        )
            where TEdge : IEdge<TVertex>
        {
            UndirectedDepthFirstSearchAlgorithm<TVertex, TEdge> target
               = new UndirectedDepthFirstSearchAlgorithm<TVertex, TEdge>
                  (visitedGraph, colors);
            return target;
            // TODO: add assertions to method UndirectedDepthFirstSearchAlgorithmTVertexTEdgeTest.Constructor01(IUndirectedGraph`2<!!0,!!1>, IDictionary`2<!!0,GraphColor>)
        }
        
        [PexMethod]
        public UndirectedDepthFirstSearchAlgorithm<TVertex, TEdge> Constructor02<TVertex,TEdge>(
            IAlgorithmComponent host,
            IUndirectedGraph<TVertex, TEdge> visitedGraph,
            IDictionary<TVertex, GraphColor> colors
        )
            where TEdge : IEdge<TVertex>
        {
            UndirectedDepthFirstSearchAlgorithm<TVertex, TEdge> target
               = new UndirectedDepthFirstSearchAlgorithm<TVertex, TEdge>
                  (host, visitedGraph, colors);
            return target;
            // TODO: add assertions to method UndirectedDepthFirstSearchAlgorithmTVertexTEdgeTest.Constructor02(IAlgorithmComponent, IUndirectedGraph`2<!!0,!!1>, IDictionary`2<!!0,GraphColor>)
        }
        
        [PexMethod]
        public GraphColor GetVertexColor<TVertex,TEdge>(
            [PexAssumeUnderTest]UndirectedDepthFirstSearchAlgorithm<TVertex, TEdge> target,
            TVertex vertex
        )
            where TEdge : IEdge<TVertex>
        {
            GraphColor result = target.GetVertexColor(vertex);
            return result;
            // TODO: add assertions to method UndirectedDepthFirstSearchAlgorithmTVertexTEdgeTest.GetVertexColor(UndirectedDepthFirstSearchAlgorithm`2<!!0,!!1>, !!0)
        }
        
        
        [PexMethod]
        public void MaxDepthGetSet<TVertex,TEdge>(
            [PexAssumeUnderTest]UndirectedDepthFirstSearchAlgorithm<TVertex, TEdge> target,
            int value
        )
            where TEdge : IEdge<TVertex>
        {
            target.MaxDepth = value;
            int result = target.MaxDepth;
            PexStore.ValueForValidation<int>("result", result);
            PexAssert.AreEqual((object)value, (object)result);
            // TODO: add assertions to method UndirectedDepthFirstSearchAlgorithmTVertexTEdgeTest.MaxDepthGetSet(UndirectedDepthFirstSearchAlgorithm`2<!!0,!!1>, Int32)
        }
        
        [PexMethod]
        public void VertexColorsGet<TVertex,TEdge>(
            [PexAssumeUnderTest]UndirectedDepthFirstSearchAlgorithm<TVertex, TEdge> target
        )
            where TEdge : IEdge<TVertex>
        {
            IDictionary<TVertex, GraphColor> result = target.VertexColors;
            PexStore.ValueForValidation<IDictionary<TVertex, GraphColor>>("result", result);
            // TODO: add assertions to method UndirectedDepthFirstSearchAlgorithmTVertexTEdgeTest.VertexColorsGet(UndirectedDepthFirstSearchAlgorithm`2<!!0,!!1>)
        }
        
        [PexMethod]
        public void Visit<TVertex,TEdge>(
            [PexAssumeUnderTest]UndirectedDepthFirstSearchAlgorithm<TVertex, TEdge> target,
            TVertex u,
            int depth
        )
            where TEdge : IEdge<TVertex>
        {
            target.Visit(u, depth);
            // TODO: add assertions to method UndirectedDepthFirstSearchAlgorithmTVertexTEdgeTest.Visit(UndirectedDepthFirstSearchAlgorithm`2<!!0,!!1>, !!0, Int32)
        }
        
    }
}
