using Microsoft.Pex.Framework;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QuickGraph;
using QuickGraph.Algorithms.ShortestPath;

namespace QuickGraph.Algorithms.ShortestPath
{
    /// <summary>
    /// This class contains parameterized unit tests for DagShortestPathAlgorithm`2
    /// </summary>
    [TestClass]
    [PexClass(typeof(DagShortestPathAlgorithm<, >))]
    public partial class DagShortestPathAlgorithmTVertexTEdgeTest
    {
        [PexMethod]
        public void ComputeNoInit<TVertex,TEdge>(
            [PexAssumeUnderTest]DagShortestPathAlgorithm<TVertex, TEdge> target,
            TVertex s
        )
            where TEdge : IEdge<TVertex>
        {
            target.ComputeNoInit(s);
            // TODO: add assertions to method DagShortestPathAlgorithmTVertexTEdgeTest.ComputeNoInit(DagShortestPathAlgorithm`2<!!0,!!1>, !!0)
        }
        
    }
}
