//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SpecExplorerSayHello.TestSuite {
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Reflection;
    using Microsoft.SpecExplorer.Runtime.Testing;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Spec Explorer", "3.5.3146.0")]
    [Microsoft.VisualStudio.TestTools.UnitTesting.TestClassAttribute()]
    public partial class AccumulatorTestSuite : VsTestClassBase {
        
        public AccumulatorTestSuite() {
            this.SetSwitch("ProceedControlTimeout", "100");
            this.SetSwitch("QuiescenceTimeout", "30000");
        }
        
        #region Test Initialization and Cleanup
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestInitializeAttribute()]
        public virtual void TestInitialize() {
            this.InitializeTestManager();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCleanupAttribute()]
        public virtual void TestCleanup() {
            this.CleanupTestManager();
        }
        #endregion
        
        #region Test Starting in S0
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        public void AccumulatorTestSuiteS0() {
            this.Manager.BeginTest("AccumulatorTestSuiteS0");
            this.Manager.Comment("reaching state \'S0\'");
            this.Manager.Comment("executing step \'call Start()\'");
            SpecExplorerSayHello.Sample.Accumulator.Start();
            this.Manager.Comment("reaching state \'S1\'");
            this.Manager.Comment("checking step \'return Start\'");
            this.Manager.Comment("reaching state \'S20\'");
            this.Manager.Comment("executing step \'call Stop()\'");
            SpecExplorerSayHello.Sample.Accumulator.Stop();
            this.Manager.Comment("reaching state \'S30\'");
            this.Manager.Comment("checking step \'return Stop\'");
            this.Manager.Comment("reaching state \'S40\'");
            this.Manager.EndTest();
        }
        #endregion
        
        #region Test Starting in S10
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        public void AccumulatorTestSuiteS10() {
            this.Manager.BeginTest("AccumulatorTestSuiteS10");
            this.Manager.Comment("reaching state \'S10\'");
            this.Manager.Comment("executing step \'call Start()\'");
            SpecExplorerSayHello.Sample.Accumulator.Start();
            this.Manager.Comment("reaching state \'S11\'");
            this.Manager.Comment("checking step \'return Start\'");
            this.Manager.Comment("reaching state \'S25\'");
            this.Manager.Comment("executing step \'call SayHello(\"Piet\")\'");
            SpecExplorerSayHello.Sample.Accumulator.SayHello("Piet");
            this.Manager.Comment("reaching state \'S35\'");
            this.Manager.Comment("checking step \'return SayHello\'");
            this.Manager.Comment("reaching state \'S45\'");
            this.Manager.Comment("executing step \'call SayHello(\"Tester\")\'");
            SpecExplorerSayHello.Sample.Accumulator.SayHello("Tester");
            this.Manager.Comment("reaching state \'S54\'");
            this.Manager.Comment("checking step \'return SayHello\'");
            this.Manager.Comment("reaching state \'S61\'");
            this.Manager.Comment("executing step \'call SayHello(\"Tester\")\'");
            SpecExplorerSayHello.Sample.Accumulator.SayHello("Tester");
            this.Manager.Comment("reaching state \'S66\'");
            this.Manager.Comment("checking step \'return SayHello\'");
            this.Manager.Comment("reaching state \'S70\'");
            this.Manager.EndTest();
        }
        #endregion
        
        #region Test Starting in S12
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        public void AccumulatorTestSuiteS12() {
            this.Manager.BeginTest("AccumulatorTestSuiteS12");
            this.Manager.Comment("reaching state \'S12\'");
            this.Manager.Comment("executing step \'call Start()\'");
            SpecExplorerSayHello.Sample.Accumulator.Start();
            this.Manager.Comment("reaching state \'S13\'");
            this.Manager.Comment("checking step \'return Start\'");
            this.Manager.Comment("reaching state \'S26\'");
            this.Manager.Comment("executing step \'call SayHello(\"Piet\")\'");
            SpecExplorerSayHello.Sample.Accumulator.SayHello("Piet");
            this.Manager.Comment("reaching state \'S36\'");
            this.Manager.Comment("checking step \'return SayHello\'");
            this.Manager.Comment("reaching state \'S46\'");
            this.Manager.Comment("executing step \'call SayHello(\"Tester\")\'");
            SpecExplorerSayHello.Sample.Accumulator.SayHello("Tester");
            this.Manager.Comment("reaching state \'S55\'");
            this.Manager.Comment("checking step \'return SayHello\'");
            this.Manager.Comment("reaching state \'S62\'");
            this.Manager.Comment("executing step \'call Clear()\'");
            SpecExplorerSayHello.Sample.Accumulator.Clear();
            this.Manager.Comment("reaching state \'S67\'");
            this.Manager.Comment("checking step \'return Clear\'");
            this.Manager.Comment("reaching state \'S71\'");
            this.Manager.EndTest();
        }
        #endregion
        
        #region Test Starting in S14
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        public void AccumulatorTestSuiteS14() {
            this.Manager.BeginTest("AccumulatorTestSuiteS14");
            this.Manager.Comment("reaching state \'S14\'");
            this.Manager.Comment("executing step \'call Start()\'");
            SpecExplorerSayHello.Sample.Accumulator.Start();
            this.Manager.Comment("reaching state \'S15\'");
            this.Manager.Comment("checking step \'return Start\'");
            this.Manager.Comment("reaching state \'S27\'");
            this.Manager.Comment("executing step \'call SayHello(\"Piet\")\'");
            SpecExplorerSayHello.Sample.Accumulator.SayHello("Piet");
            this.Manager.Comment("reaching state \'S37\'");
            this.Manager.Comment("checking step \'return SayHello\'");
            this.Manager.Comment("reaching state \'S47\'");
            this.Manager.Comment("executing step \'call Clear()\'");
            SpecExplorerSayHello.Sample.Accumulator.Clear();
            this.Manager.Comment("reaching state \'S56\'");
            this.Manager.Comment("checking step \'return Clear\'");
            this.Manager.Comment("reaching state \'S63\'");
            this.Manager.EndTest();
        }
        #endregion
        
        #region Test Starting in S16
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        public void AccumulatorTestSuiteS16() {
            this.Manager.BeginTest("AccumulatorTestSuiteS16");
            this.Manager.Comment("reaching state \'S16\'");
            this.Manager.Comment("executing step \'call Start()\'");
            SpecExplorerSayHello.Sample.Accumulator.Start();
            this.Manager.Comment("reaching state \'S17\'");
            this.Manager.Comment("checking step \'return Start\'");
            this.Manager.Comment("reaching state \'S28\'");
            this.Manager.Comment("executing step \'call SayHello(\"Tester\")\'");
            SpecExplorerSayHello.Sample.Accumulator.SayHello("Tester");
            this.Manager.Comment("reaching state \'S38\'");
            this.Manager.Comment("checking step \'return SayHello\'");
            this.Manager.Comment("reaching state \'S48\'");
            this.Manager.EndTest();
        }
        #endregion
        
        #region Test Starting in S18
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        public void AccumulatorTestSuiteS18() {
            this.Manager.BeginTest("AccumulatorTestSuiteS18");
            this.Manager.Comment("reaching state \'S18\'");
            this.Manager.Comment("executing step \'call Start()\'");
            SpecExplorerSayHello.Sample.Accumulator.Start();
            this.Manager.Comment("reaching state \'S19\'");
            this.Manager.Comment("checking step \'return Start\'");
            this.Manager.Comment("reaching state \'S29\'");
            this.Manager.Comment("executing step \'call Clear()\'");
            SpecExplorerSayHello.Sample.Accumulator.Clear();
            this.Manager.Comment("reaching state \'S39\'");
            this.Manager.Comment("checking step \'return Clear\'");
            this.Manager.Comment("reaching state \'S49\'");
            this.Manager.EndTest();
        }
        #endregion
        
        #region Test Starting in S2
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        public void AccumulatorTestSuiteS2() {
            this.Manager.BeginTest("AccumulatorTestSuiteS2");
            this.Manager.Comment("reaching state \'S2\'");
            this.Manager.Comment("executing step \'call Start()\'");
            SpecExplorerSayHello.Sample.Accumulator.Start();
            this.Manager.Comment("reaching state \'S3\'");
            this.Manager.Comment("checking step \'return Start\'");
            this.Manager.Comment("reaching state \'S21\'");
            this.Manager.Comment("executing step \'call SayHello(\"Piet\")\'");
            SpecExplorerSayHello.Sample.Accumulator.SayHello("Piet");
            this.Manager.Comment("reaching state \'S31\'");
            this.Manager.Comment("checking step \'return SayHello\'");
            this.Manager.Comment("reaching state \'S41\'");
            this.Manager.Comment("executing step \'call Stop()\'");
            SpecExplorerSayHello.Sample.Accumulator.Stop();
            this.Manager.Comment("reaching state \'S50\'");
            this.Manager.Comment("checking step \'return Stop\'");
            this.Manager.Comment("reaching state \'S57\'");
            this.Manager.EndTest();
        }
        #endregion
        
        #region Test Starting in S4
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        public void AccumulatorTestSuiteS4() {
            this.Manager.BeginTest("AccumulatorTestSuiteS4");
            this.Manager.Comment("reaching state \'S4\'");
            this.Manager.Comment("executing step \'call Start()\'");
            SpecExplorerSayHello.Sample.Accumulator.Start();
            this.Manager.Comment("reaching state \'S5\'");
            this.Manager.Comment("checking step \'return Start\'");
            this.Manager.Comment("reaching state \'S22\'");
            this.Manager.Comment("executing step \'call SayHello(\"Piet\")\'");
            SpecExplorerSayHello.Sample.Accumulator.SayHello("Piet");
            this.Manager.Comment("reaching state \'S32\'");
            this.Manager.Comment("checking step \'return SayHello\'");
            this.Manager.Comment("reaching state \'S42\'");
            this.Manager.Comment("executing step \'call SayHello(\"Piet\")\'");
            SpecExplorerSayHello.Sample.Accumulator.SayHello("Piet");
            this.Manager.Comment("reaching state \'S51\'");
            this.Manager.Comment("checking step \'return SayHello\'");
            this.Manager.Comment("reaching state \'S58\'");
            this.Manager.EndTest();
        }
        #endregion
        
        #region Test Starting in S6
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        public void AccumulatorTestSuiteS6() {
            this.Manager.BeginTest("AccumulatorTestSuiteS6");
            this.Manager.Comment("reaching state \'S6\'");
            this.Manager.Comment("executing step \'call Start()\'");
            SpecExplorerSayHello.Sample.Accumulator.Start();
            this.Manager.Comment("reaching state \'S7\'");
            this.Manager.Comment("checking step \'return Start\'");
            this.Manager.Comment("reaching state \'S23\'");
            this.Manager.Comment("executing step \'call SayHello(\"Piet\")\'");
            SpecExplorerSayHello.Sample.Accumulator.SayHello("Piet");
            this.Manager.Comment("reaching state \'S33\'");
            this.Manager.Comment("checking step \'return SayHello\'");
            this.Manager.Comment("reaching state \'S43\'");
            this.Manager.Comment("executing step \'call SayHello(\"Tester\")\'");
            SpecExplorerSayHello.Sample.Accumulator.SayHello("Tester");
            this.Manager.Comment("reaching state \'S52\'");
            this.Manager.Comment("checking step \'return SayHello\'");
            this.Manager.Comment("reaching state \'S59\'");
            this.Manager.Comment("executing step \'call Stop()\'");
            SpecExplorerSayHello.Sample.Accumulator.Stop();
            this.Manager.Comment("reaching state \'S64\'");
            this.Manager.Comment("checking step \'return Stop\'");
            this.Manager.Comment("reaching state \'S68\'");
            this.Manager.EndTest();
        }
        #endregion
        
        #region Test Starting in S8
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        public void AccumulatorTestSuiteS8() {
            this.Manager.BeginTest("AccumulatorTestSuiteS8");
            this.Manager.Comment("reaching state \'S8\'");
            this.Manager.Comment("executing step \'call Start()\'");
            SpecExplorerSayHello.Sample.Accumulator.Start();
            this.Manager.Comment("reaching state \'S9\'");
            this.Manager.Comment("checking step \'return Start\'");
            this.Manager.Comment("reaching state \'S24\'");
            this.Manager.Comment("executing step \'call SayHello(\"Piet\")\'");
            SpecExplorerSayHello.Sample.Accumulator.SayHello("Piet");
            this.Manager.Comment("reaching state \'S34\'");
            this.Manager.Comment("checking step \'return SayHello\'");
            this.Manager.Comment("reaching state \'S44\'");
            this.Manager.Comment("executing step \'call SayHello(\"Tester\")\'");
            SpecExplorerSayHello.Sample.Accumulator.SayHello("Tester");
            this.Manager.Comment("reaching state \'S53\'");
            this.Manager.Comment("checking step \'return SayHello\'");
            this.Manager.Comment("reaching state \'S60\'");
            this.Manager.Comment("executing step \'call SayHello(\"Piet\")\'");
            SpecExplorerSayHello.Sample.Accumulator.SayHello("Piet");
            this.Manager.Comment("reaching state \'S65\'");
            this.Manager.Comment("checking step \'return SayHello\'");
            this.Manager.Comment("reaching state \'S69\'");
            this.Manager.EndTest();
        }
        #endregion
    }
}
