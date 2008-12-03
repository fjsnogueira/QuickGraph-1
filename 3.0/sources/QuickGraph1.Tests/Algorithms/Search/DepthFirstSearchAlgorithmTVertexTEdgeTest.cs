using Microsoft.Pex.Framework;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QuickGraph;
using QuickGraph.Algorithms.Search;
using QuickGraph.Algorithms.Services;
using System.Collections.Generic;

namespace QuickGraph.Algorithms.Search
{
    /// <summary>
    /// This class contains parameterized unit tests for DepthFirstSearchAlgorithm`2
    /// </summary>
    [TestClass]
    [PexClass(typeof(DepthFirstSearchAlgorithm<, >))]
    public partial class DepthFirstSearchAlgorithmTVertexTEdgeTest
    {
        [PexMethod]
        public DepthFirstSearchAlgorithm<TVertex, TEdge> Constructor<TVertex,TEdge>(IVertexListGraph<TVertex, TEdge> g)
            where TEdge : IEdge<TVertex>
        {
            DepthFirstSearchAlgorithm<TVertex, TEdge> target
               = new DepthFirstSearchAlgorithm<TVertex, TEdge>(g);
            return target;
            // TODO: add assertions to method DepthFirstSearchAlgorithmTVertexTEdgeTest.Constructor(IVertexListGraph`2<!!0,!!1>)
        }
        
        [PexMethod]
        public DepthFirstSearchAlgorithm<TVertex, TEdge> Constructor01<TVertex,TEdge>(
            IVertexListGraph<TVertex, TEdge> visitedGraph,
            IDictionary<TVertex, GraphColor> colors
        )
            where TEdge : IEdge<TVertex>
        {
            DepthFirstSearchAlgorithm<TVertex, TEdge> target
               = new DepthFirstSearchAlgorithm<TVertex, TEdge>(visitedGraph, colors);
            return target;
            // TODO: add assertions to method DepthFirstSearchAlgorithmTVertexTEdgeTest.Constructor01(IVertexListGraph`2<!!0,!!1>, IDictionary`2<!!0,GraphColor>)
        }
        
        [PexMethod]
        public DepthFirstSearchAlgorithm<TVertex, TEdge> Constructor02<TVertex,TEdge>(
            IAlgorithmComponent host,
            IVertexListGraph<TVertex, TEdge> visitedGraph,
            IDictionary<TVertex, GraphColor> colors
        )
            where TEdge : IEdge<TVertex>
        {
            DepthFirstSearchAlgorithm<TVertex, TEdge> target
               = new DepthFirstSearchAlgorithm<TVertex, TEdge>(host, visitedGraph, colors);
            return target;
            // TODO: add assertions to method DepthFirstSearchAlgorithmTVertexTEdgeTest.Constructor02(IAlgorithmComponent, IVertexListGraph`2<!!0,!!1>, IDictionary`2<!!0,GraphColor>)
        }
        
        [PexMethod]
        public GraphColor GetVertexColor<TVertex,TEdge>(
            [PexAssumeUnderTest]DepthFirstSearchAlgorithm<TVertex, TEdge> target,
            TVertex vertex
        )
            where TEdge : IEdge<TVertex>
        {
            GraphColor result = target.GetVertexColor(vertex);
            return result;
            // TODO: add assertions to method DepthFirstSearchAlgorithmTVertexTEdgeTest.GetVertexColor(DepthFirstSearchAlgorithm`2<!!0,!!1>, !!0)
        }
        [PexMethod]
        public void MaxDepthGetSet<TVertex,TEdge>(
            [PexAssumeUnderTest]DepthFirstSearchAlgorithm<TVertex, TEdge> target,
            int value
        )
            where TEdge : IEdge<TVertex>
        {
            target.MaxDepth = value;
            int result = target.MaxDepth;
            PexStore.ValueForValidation<int>("result", result);
            PexAssert.AreEqual((object)value, (object)result);
            // TODO: add assertions to method DepthFirstSearchAlgorithmTVertexTEdgeTest.MaxDepthGetSet(DepthFirstSearchAlgorithm`2<!!0,!!1>, Int32)
        }
        
        [PexMethod]
        public void VertexColorsGet<TVertex,TEdge>(
            [PexAssumeUnderTest]DepthFirstSearchAlgorithm<TVertex, TEdge> target
        )
            where TEdge : IEdge<TVertex>
        {
            IDictionary<TVertex, GraphColor> result = target.VertexColors;
            PexStore.ValueForValidation<IDictionary<TVertex, GraphColor>>("result", result);
            // TODO: add assertions to method DepthFirstSearchAlgorithmTVertexTEdgeTest.VertexColorsGet(DepthFirstSearchAlgorithm`2<!!0,!!1>)
        }
        
        [PexMethod]
        public void Visit<TVertex,TEdge>(
            [PexAssumeUnderTest]DepthFirstSearchAlgorithm<TVertex, TEdge> target,
            TVertex root
        )
            where TEdge : IEdge<TVertex>
        {
            target.Visit(root);
            // TODO: add assertions to method DepthFirstSearchAlgorithmTVertexTEdgeTest.Visit(DepthFirstSearchAlgorithm`2<!!0,!!1>, !!0, Int32)
        }
        
    }
}
