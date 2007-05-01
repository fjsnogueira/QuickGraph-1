using System.CodeDom.Compiler;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.CodeDom;
using QuickGraph.Unit;

namespace QuickGraph.Algorithms
{
    
    
    public partial class DoubleDenseMatrixTest
    {
        
        /// <summary>
        ///  Test generated by Pex
        ///</summary>
        [QuickGraph.Unit.TestAttribute()]
        [PexGeneratedBy(typeof(QuickGraph.Algorithms.DoubleDenseMatrixTest), "DoubleDenseMatrixTest.ToString(DoubleDenseMatrix)")]
        [GeneratedCode("Pex", "1.1.20426.0")]
        public void ToString_DoubleDenseMatrix_70429_214620_0_01()
        {
            QuickGraph.Algorithms.Matrix.DoubleDenseMatrix ddm0 = new QuickGraph.Algorithms.Matrix.DoubleDenseMatrix(0, 0, double.MinValue);
            this.ToString(((QuickGraph.Algorithms.Matrix.DoubleDenseMatrix)(ddm0)));
        }
        
        /// <summary>
        ///  Test generated by Pex
        ///</summary>
        [QuickGraph.Unit.TestAttribute()]
        [PexGeneratedBy(typeof(QuickGraph.Algorithms.DoubleDenseMatrixTest), "DoubleDenseMatrixTest.ToString(DoubleDenseMatrix)")]
        [GeneratedCode("Pex", "1.1.20426.0")]
        public void ToString_DoubleDenseMatrix_70429_214620_0_02()
        {
            QuickGraph.Algorithms.Matrix.DoubleDenseMatrix ddm0 = new QuickGraph.Algorithms.Matrix.DoubleDenseMatrix(1, 1, double.MinValue);
            this.ToString(((QuickGraph.Algorithms.Matrix.DoubleDenseMatrix)(ddm0)));
        }
        
        /// <summary>
        ///  Test generated by Pex
        ///</summary>
        ///<remarks>
        ///  <para>
        ///    Test did not terminate within configured Exploration Bounds. This failure may not reproduce without Pex.
        ///  </para>
        ///  <para>
        ///    See http://codebox/pex/Wiki/View.aspx?title=MaxConditions+exceeded for more information.
        ///  </para>
        ///</remarks>
        [QuickGraph.Unit.TestAttribute()]
        [QuickGraph.Unit.IgnoreAttribute("nontermination")]
        [PexGeneratedBy(typeof(QuickGraph.Algorithms.DoubleDenseMatrixTest), "DoubleDenseMatrixTest.ToString(DoubleDenseMatrix)")]
        [GeneratedCode("Pex", "1.1.20426.0")]
        public void ToString_DoubleDenseMatrix_70429_214620_0_03()
        {
            QuickGraph.Algorithms.Matrix.DoubleDenseMatrix ddm0 = new QuickGraph.Algorithms.Matrix.DoubleDenseMatrix(32, 30, double.MinValue);
            this.ToString(((QuickGraph.Algorithms.Matrix.DoubleDenseMatrix)(ddm0)));
        }
    }
}
