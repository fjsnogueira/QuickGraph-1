using Microsoft.Pex.Framework;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QuickGraph;
using QuickGraph.Algorithms.ShortestPath;

namespace QuickGraph.Algorithms.ShortestPath
{
    /// <summary>
    /// This class contains parameterized unit tests for UndirectedDijkstraShortestPathAlgorithm`2
    /// </summary>
    [TestClass]
    [PexClass(typeof(UndirectedDijkstraShortestPathAlgorithm<, >))]
    public partial class UndirectedDijkstraShortestPathAlgorithmTVertexTEdgeTest
    {
        [PexMethod]
        public void ComputeNoInit<TVertex,TEdge>(
            [PexAssumeUnderTest]UndirectedDijkstraShortestPathAlgorithm<TVertex, TEdge> target,
            TVertex s
        )
            where TEdge : IEdge<TVertex>
        {
            target.ComputeNoInit(s);
            // TODO: add assertions to method UndirectedDijkstraShortestPathAlgorithmTVertexTEdgeTest.ComputeNoInit(UndirectedDijkstraShortestPathAlgorithm`2<!!0,!!1>, !!0)
        }        
    }
}
