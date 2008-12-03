using Microsoft.Pex.Framework;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QuickGraph;
using QuickGraph.Algorithms.ShortestPath;

namespace QuickGraph.Algorithms.ShortestPath
{
    /// <summary>
    /// This class contains parameterized unit tests for DijkstraShortestPathAlgorithm`2
    /// </summary>
    [TestClass]
    [PexClass(typeof(DijkstraShortestPathAlgorithm<, >))]
    public partial class DijkstraShortestPathAlgorithmTVertexTEdgeTest
    {
        [PexMethod]
        public void ComputeNoInit<TVertex,TEdge>(
            [PexAssumeUnderTest]DijkstraShortestPathAlgorithm<TVertex, TEdge> target,
            TVertex s
        )
            where TEdge : IEdge<TVertex>
        {
            target.ComputeNoInit(s);
            // TODO: add assertions to method DijkstraShortestPathAlgorithmTVertexTEdgeTest.ComputeNoInit(DijkstraShortestPathAlgorithm`2<!!0,!!1>, !!0)
        }
        
    }
}
