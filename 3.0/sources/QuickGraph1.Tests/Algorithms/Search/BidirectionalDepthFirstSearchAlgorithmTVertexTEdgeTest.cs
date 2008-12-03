using Microsoft.Pex.Framework;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QuickGraph;
using QuickGraph.Algorithms.Search;
using QuickGraph.Algorithms.Services;
using System.Collections.Generic;

namespace QuickGraph.Algorithms.Search
{
    /// <summary>
    /// This class contains parameterized unit tests for BidirectionalDepthFirstSearchAlgorithm`2
    /// </summary>
    [TestClass]
    [PexClass(typeof(BidirectionalDepthFirstSearchAlgorithm<, >))]
    public partial class BidirectionalDepthFirstSearchAlgorithmTVertexTEdgeTest
    {
        [PexMethod]
        public BidirectionalDepthFirstSearchAlgorithm<TVertex, TEdge> Constructor<TVertex,TEdge>(IBidirectionalGraph<TVertex, TEdge> g)
            where TEdge : IEdge<TVertex>
        {
            BidirectionalDepthFirstSearchAlgorithm<TVertex, TEdge> target
               = new BidirectionalDepthFirstSearchAlgorithm<TVertex, TEdge>(g);
            return target;
            // TODO: add assertions to method BidirectionalDepthFirstSearchAlgorithmTVertexTEdgeTest.Constructor(IBidirectionalGraph`2<!!0,!!1>)
        }
        
        [PexMethod]
        public BidirectionalDepthFirstSearchAlgorithm<TVertex, TEdge> Constructor01<TVertex,TEdge>(
            IBidirectionalGraph<TVertex, TEdge> visitedGraph,
            IDictionary<TVertex, GraphColor> colors
        )
            where TEdge : IEdge<TVertex>
        {
            BidirectionalDepthFirstSearchAlgorithm<TVertex, TEdge> target
               = new BidirectionalDepthFirstSearchAlgorithm<TVertex, TEdge>
                  (visitedGraph, colors);
            return target;
            // TODO: add assertions to method BidirectionalDepthFirstSearchAlgorithmTVertexTEdgeTest.Constructor01(IBidirectionalGraph`2<!!0,!!1>, IDictionary`2<!!0,GraphColor>)
        }
        
        [PexMethod]
        public BidirectionalDepthFirstSearchAlgorithm<TVertex, TEdge> Constructor02<TVertex,TEdge>(
            IAlgorithmComponent host,
            IBidirectionalGraph<TVertex, TEdge> visitedGraph,
            IDictionary<TVertex, GraphColor> colors
        )
            where TEdge : IEdge<TVertex>
        {
            BidirectionalDepthFirstSearchAlgorithm<TVertex, TEdge> target
               = new BidirectionalDepthFirstSearchAlgorithm<TVertex, TEdge>
                  (host, visitedGraph, colors);
            return target;
            // TODO: add assertions to method BidirectionalDepthFirstSearchAlgorithmTVertexTEdgeTest.Constructor02(IAlgorithmComponent, IBidirectionalGraph`2<!!0,!!1>, IDictionary`2<!!0,GraphColor>)
        }
        
        [PexMethod]
        public GraphColor GetVertexColor<TVertex,TEdge>(
            [PexAssumeUnderTest]BidirectionalDepthFirstSearchAlgorithm<TVertex, TEdge> target,
            TVertex vertex
        )
            where TEdge : IEdge<TVertex>
        {
            GraphColor result = target.GetVertexColor(vertex);
            return result;
            // TODO: add assertions to method BidirectionalDepthFirstSearchAlgorithmTVertexTEdgeTest.GetVertexColor(BidirectionalDepthFirstSearchAlgorithm`2<!!0,!!1>, !!0)
        }
        
        [PexMethod]
        public void MaxDepthGetSet<TVertex,TEdge>(
            [PexAssumeUnderTest]BidirectionalDepthFirstSearchAlgorithm<TVertex, TEdge> target,
            int value
        )
            where TEdge : IEdge<TVertex>
        {
            target.MaxDepth = value;
            int result = target.MaxDepth;
            PexStore.ValueForValidation<int>("result", result);
            PexAssert.AreEqual((object)value, (object)result);
            // TODO: add assertions to method BidirectionalDepthFirstSearchAlgorithmTVertexTEdgeTest.MaxDepthGetSet(BidirectionalDepthFirstSearchAlgorithm`2<!!0,!!1>, Int32)
        }
        
        [PexMethod]
        public void VertexColorsGet<TVertex,TEdge>(
            [PexAssumeUnderTest]BidirectionalDepthFirstSearchAlgorithm<TVertex, TEdge> target
        )
            where TEdge : IEdge<TVertex>
        {
            IDictionary<TVertex, GraphColor> result = target.VertexColors;
            PexStore.ValueForValidation<IDictionary<TVertex, GraphColor>>("result", result);
            // TODO: add assertions to method BidirectionalDepthFirstSearchAlgorithmTVertexTEdgeTest.VertexColorsGet(BidirectionalDepthFirstSearchAlgorithm`2<!!0,!!1>)
        }
        
        [PexMethod]
        public void Visit<TVertex,TEdge>(
            [PexAssumeUnderTest]BidirectionalDepthFirstSearchAlgorithm<TVertex, TEdge> target,
            TVertex u,
            int depth
        )
            where TEdge : IEdge<TVertex>
        {
            target.Visit(u, depth);
            // TODO: add assertions to method BidirectionalDepthFirstSearchAlgorithmTVertexTEdgeTest.Visit(BidirectionalDepthFirstSearchAlgorithm`2<!!0,!!1>, !!0, Int32)
        }
        
    }
}
