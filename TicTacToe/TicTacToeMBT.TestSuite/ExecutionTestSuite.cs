using System;
using Microsoft.SpecExplorer.Runtime.Testing;
using NUnit.Framework;

namespace TicTacToeMBT.TestSuite
{
    /// <summary>
    /// Test suite execution using NUnit Framework. 
    /// This will execute the generated test suite from SpecExplorer.
    /// Only the deepest exploration tests are selected
    /// </summary>
    [TestFixture]
    public class ExecutionTestSuite : VsTestClassBase
    {
        public ExecutionTestSuite()
        {
            this.SetSwitch("ProceedControlTimeout", "100");
            this.SetSwitch("QuiescenceTimeout", "30000");
        }

        [SetUp]
        public void Setup()
        {
            this.InitializeTestManager();
        }

        [TearDown]
        public void TearDown()
        {
            this.CleanupTestManager();
            TicTacToeMBT.Implementation.Accumulator.Stop();
        }

        #region Selected tests

        #region Test Starting in S341
        [Test]
        public void AccumulatorTestSuiteS341()
        {
            this.Manager.BeginTest("AccumulatorTestSuiteS341");
            this.Manager.Comment("reaching state \'S341\'");
            this.Manager.Comment("executing step \'call Start()\'");
            TicTacToeMBT.Implementation.Accumulator.Start();
            this.Manager.Comment("reaching state \'S342\'");
            this.Manager.Comment("checking step \'return Start\'");
            AssertStart();
            this.Manager.Comment("reaching state \'S343\'");
            this.Manager.Comment("executing step \'call ClearStats()\'");
            TicTacToeMBT.Implementation.Accumulator.ClearStats();
            this.Manager.Comment("reaching state \'S344\'");
            this.Manager.Comment("checking step \'return ClearStats\'");
            AssertClearStats();
            this.Manager.Comment("reaching state \'S345\'");
            this.Manager.Comment("executing step \'call XTurn(\"c9\")\'");
            TicTacToeMBT.Implementation.Accumulator.XTurn("c9");
            this.Manager.Comment("reaching state \'S346\'");
            this.Manager.Comment("checking step \'return XTurn\'");
            AssertXTurn();
            this.Manager.Comment("reaching state \'S347\'");
            this.Manager.Comment("executing step \'call ClearStats()\'");
            TicTacToeMBT.Implementation.Accumulator.ClearStats();
            this.Manager.Comment("reaching state \'S348\'");
            this.Manager.Comment("checking step \'return ClearStats\'");
            AssertClearStats();
            this.Manager.Comment("reaching state \'S349\'");
            this.Manager.Comment("executing step \'call OasFirstPlayer()\'");
            TicTacToeMBT.Implementation.Accumulator.OasFirstPlayer();
            this.Manager.Comment("reaching state \'S350\'");
            this.Manager.Comment("checking step \'return OasFirstPlayer\'");
            AssertSelectOAsFirstPlayer();
            this.Manager.Comment("reaching state \'S351\'");
            this.Manager.Comment("executing step \'call ClearStats()\'");
            TicTacToeMBT.Implementation.Accumulator.ClearStats();
            this.Manager.Comment("reaching state \'S352\'");
            this.Manager.Comment("checking step \'return ClearStats\'");
            AssertClearStats();
            this.Manager.Comment("reaching state \'S353\'");
            this.Manager.Comment("executing step \'call OTurn(\"c9\")\'");
            TicTacToeMBT.Implementation.Accumulator.OTurn("c9");
            this.Manager.Comment("reaching state \'S354\'");
            this.Manager.Comment("checking step \'return OTurn\'");
            AssertOTurn();
            this.Manager.Comment("reaching state \'S355\'");
            this.Manager.Comment("executing step \'call ClearStats()\'");
            TicTacToeMBT.Implementation.Accumulator.ClearStats();
            this.Manager.Comment("reaching state \'S356\'");
            this.Manager.Comment("checking step \'return ClearStats\'");
            AssertClearStats();
            this.Manager.Comment("reaching state \'S357\'");
            this.Manager.Comment("executing step \'call Stop()\'");
            TicTacToeMBT.Implementation.Accumulator.Stop();
            this.Manager.Comment("reaching state \'S358\'");
            this.Manager.Comment("checking step \'return Stop\'");
            AssertStop();
            this.Manager.Comment("reaching state \'S359\'");
            this.Manager.Comment("executing step \'call Start()\'");
            TicTacToeMBT.Implementation.Accumulator.Start();
            this.Manager.Comment("reaching state \'S360\'");
            this.Manager.Comment("checking step \'return Start\'");
            AssertStart();
            this.Manager.Comment("reaching state \'S361\'");
            this.Manager.Comment("executing step \'call ClearStats()\'");
            TicTacToeMBT.Implementation.Accumulator.ClearStats();
            this.Manager.Comment("reaching state \'S362\'");
            this.Manager.Comment("checking step \'return ClearStats\'");
            AssertClearStats();
            this.Manager.Comment("reaching state \'S363\'");
            this.Manager.EndTest();
        }
        #endregion

        #region Test Starting in S490
        [Test]
        public void AccumulatorTestSuiteS490()
        {
            this.Manager.BeginTest("AccumulatorTestSuiteS490");
            this.Manager.Comment("reaching state \'S490\'");
            this.Manager.Comment("executing step \'call Start()\'");
            TicTacToeMBT.Implementation.Accumulator.Start();
            this.Manager.Comment("reaching state \'S491\'");
            this.Manager.Comment("checking step \'return Start\'");
            AssertStart();
            this.Manager.Comment("reaching state \'S492\'");
            this.Manager.Comment("executing step \'call ClearStats()\'");
            TicTacToeMBT.Implementation.Accumulator.ClearStats();
            this.Manager.Comment("reaching state \'S493\'");
            this.Manager.Comment("checking step \'return ClearStats\'");
            AssertClearStats();
            this.Manager.Comment("reaching state \'S494\'");
            this.Manager.Comment("executing step \'call XTurn(\"c9\")\'");
            TicTacToeMBT.Implementation.Accumulator.XTurn("c9");
            this.Manager.Comment("reaching state \'S495\'");
            this.Manager.Comment("checking step \'return XTurn\'");
            AssertXTurn();
            this.Manager.Comment("reaching state \'S496\'");
            this.Manager.Comment("executing step \'call ClearStats()\'");
            TicTacToeMBT.Implementation.Accumulator.ClearStats();
            this.Manager.Comment("reaching state \'S497\'");
            this.Manager.Comment("checking step \'return ClearStats\'");
            AssertClearStats();
            this.Manager.Comment("reaching state \'S498\'");
            this.Manager.Comment("executing step \'call OasFirstPlayer()\'");
            TicTacToeMBT.Implementation.Accumulator.OasFirstPlayer();
            this.Manager.Comment("reaching state \'S499\'");
            this.Manager.Comment("checking step \'return OasFirstPlayer\'");
            AssertSelectOAsFirstPlayer();
            this.Manager.Comment("reaching state \'S500\'");
            this.Manager.Comment("executing step \'call ClearStats()\'");
            TicTacToeMBT.Implementation.Accumulator.ClearStats();
            this.Manager.Comment("reaching state \'S501\'");
            this.Manager.Comment("checking step \'return ClearStats\'");
            AssertClearStats();
            this.Manager.Comment("reaching state \'S502\'");
            this.Manager.Comment("executing step \'call OTurn(\"c9\")\'");
            TicTacToeMBT.Implementation.Accumulator.OTurn("c9");
            this.Manager.Comment("reaching state \'S503\'");
            this.Manager.Comment("checking step \'return OTurn\'");
            AssertOTurn();
            this.Manager.Comment("reaching state \'S504\'");
            this.Manager.Comment("executing step \'call ClearStats()\'");
            TicTacToeMBT.Implementation.Accumulator.ClearStats();
            this.Manager.Comment("reaching state \'S505\'");
            this.Manager.Comment("checking step \'return ClearStats\'");
            AssertClearStats();
            this.Manager.Comment("reaching state \'S506\'");
            this.Manager.Comment("executing step \'call XTurn(\"c8\")\'");
            TicTacToeMBT.Implementation.Accumulator.XTurn("c8");
            this.Manager.Comment("reaching state \'S507\'");
            this.Manager.Comment("checking step \'return XTurn\'");
            AssertXTurn();
            this.Manager.Comment("reaching state \'S508\'");
            this.Manager.Comment("executing step \'call ClearStats()\'");
            TicTacToeMBT.Implementation.Accumulator.ClearStats();
            this.Manager.Comment("reaching state \'S509\'");
            this.Manager.Comment("checking step \'return ClearStats\'");
            AssertClearStats();
            this.Manager.Comment("reaching state \'S510\'");
            this.Manager.EndTest();
        }
        #endregion

        #region Test Starting in S299
        [Test]
        public void AccumulatorTestSuiteS299()
        {
            this.Manager.BeginTest("AccumulatorTestSuiteS299");
            this.Manager.Comment("reaching state \'S299\'");
            this.Manager.Comment("executing step \'call Start()\'");
            TicTacToeMBT.Implementation.Accumulator.Start();
            this.Manager.Comment("reaching state \'S300\'");
            this.Manager.Comment("checking step \'return Start\'");
            AssertStart();
            this.Manager.Comment("reaching state \'S301\'");
            this.Manager.Comment("executing step \'call ClearStats()\'");
            TicTacToeMBT.Implementation.Accumulator.ClearStats();
            this.Manager.Comment("reaching state \'S302\'");
            this.Manager.Comment("checking step \'return ClearStats\'");
            AssertClearStats();
            this.Manager.Comment("reaching state \'S303\'");
            this.Manager.Comment("executing step \'call XTurn(\"c9\")\'");
            TicTacToeMBT.Implementation.Accumulator.XTurn("c9");
            this.Manager.Comment("reaching state \'S304\'");
            this.Manager.Comment("checking step \'return XTurn\'");
            AssertXTurn();
            this.Manager.Comment("reaching state \'S305\'");
            this.Manager.Comment("executing step \'call ClearStats()\'");
            TicTacToeMBT.Implementation.Accumulator.ClearStats();
            this.Manager.Comment("reaching state \'S306\'");
            this.Manager.Comment("checking step \'return ClearStats\'");
            AssertClearStats();
            this.Manager.Comment("reaching state \'S307\'");
            this.Manager.Comment("executing step \'call OasFirstPlayer()\'");
            TicTacToeMBT.Implementation.Accumulator.OasFirstPlayer();
            this.Manager.Comment("reaching state \'S308\'");
            this.Manager.Comment("checking step \'return OasFirstPlayer\'");
            AssertSelectOAsFirstPlayer();
            this.Manager.Comment("reaching state \'S309\'");
            this.Manager.Comment("executing step \'call ClearStats()\'");
            TicTacToeMBT.Implementation.Accumulator.ClearStats();
            this.Manager.Comment("reaching state \'S310\'");
            this.Manager.Comment("checking step \'return ClearStats\'");
            AssertClearStats();
            this.Manager.Comment("reaching state \'S311\'");
            this.Manager.Comment("executing step \'call OTurn(\"c9\")\'");
            TicTacToeMBT.Implementation.Accumulator.OTurn("c9");
            this.Manager.Comment("reaching state \'S312\'");
            this.Manager.Comment("checking step \'return OTurn\'");
            AssertOTurn();
            this.Manager.Comment("reaching state \'S313\'");
            this.Manager.Comment("executing step \'call ClearStats()\'");
            TicTacToeMBT.Implementation.Accumulator.ClearStats();
            this.Manager.Comment("reaching state \'S314\'");
            this.Manager.Comment("checking step \'return ClearStats\'");
            AssertClearStats();
            this.Manager.Comment("reaching state \'S315\'");
            this.Manager.Comment("executing step \'call NewGame()\'");
            TicTacToeMBT.Implementation.Accumulator.NewGame();
            this.Manager.Comment("reaching state \'S316\'");
            this.Manager.Comment("checking step \'return NewGame\'");
            AssertNewGame();
            this.Manager.Comment("reaching state \'S317\'");
            this.Manager.Comment("executing step \'call ClearStats()\'");
            TicTacToeMBT.Implementation.Accumulator.ClearStats();
            this.Manager.Comment("reaching state \'S318\'");
            this.Manager.Comment("checking step \'return ClearStats\'");
            AssertClearStats();
            this.Manager.Comment("reaching state \'S319\'");
            this.Manager.EndTest();
        }
        #endregion

        #region Test Starting in S427
        [Test]
        public void AccumulatorTestSuiteS427()
        {
            this.Manager.BeginTest("AccumulatorTestSuiteS427");
            this.Manager.Comment("reaching state \'S427\'");
            this.Manager.Comment("executing step \'call Start()\'");
            TicTacToeMBT.Implementation.Accumulator.Start();
            this.Manager.Comment("reaching state \'S428\'");
            this.Manager.Comment("checking step \'return Start\'");
            AssertStart();
            this.Manager.Comment("reaching state \'S429\'");
            this.Manager.Comment("executing step \'call ClearStats()\'");
            TicTacToeMBT.Implementation.Accumulator.ClearStats();
            this.Manager.Comment("reaching state \'S430\'");
            this.Manager.Comment("checking step \'return ClearStats\'");
            AssertClearStats();
            this.Manager.Comment("reaching state \'S431\'");
            this.Manager.Comment("executing step \'call XTurn(\"c9\")\'");
            TicTacToeMBT.Implementation.Accumulator.XTurn("c9");
            this.Manager.Comment("reaching state \'S432\'");
            this.Manager.Comment("checking step \'return XTurn\'");
            AssertXTurn();
            this.Manager.Comment("reaching state \'S433\'");
            this.Manager.Comment("executing step \'call ClearStats()\'");
            TicTacToeMBT.Implementation.Accumulator.ClearStats();
            this.Manager.Comment("reaching state \'S434\'");
            this.Manager.Comment("checking step \'return ClearStats\'");
            AssertClearStats();
            this.Manager.Comment("reaching state \'S435\'");
            this.Manager.Comment("executing step \'call OasFirstPlayer()\'");
            TicTacToeMBT.Implementation.Accumulator.OasFirstPlayer();
            this.Manager.Comment("reaching state \'S436\'");
            this.Manager.Comment("checking step \'return OasFirstPlayer\'");
            AssertSelectOAsFirstPlayer();
            this.Manager.Comment("reaching state \'S437\'");
            this.Manager.Comment("executing step \'call ClearStats()\'");
            TicTacToeMBT.Implementation.Accumulator.ClearStats();
            this.Manager.Comment("reaching state \'S438\'");
            this.Manager.Comment("checking step \'return ClearStats\'");
            AssertClearStats();
            this.Manager.Comment("reaching state \'S439\'");
            this.Manager.Comment("executing step \'call OTurn(\"c9\")\'");
            TicTacToeMBT.Implementation.Accumulator.OTurn("c9");
            this.Manager.Comment("reaching state \'S440\'");
            this.Manager.Comment("checking step \'return OTurn\'");
            AssertOTurn();
            this.Manager.Comment("reaching state \'S441\'");
            this.Manager.Comment("executing step \'call ClearStats()\'");
            TicTacToeMBT.Implementation.Accumulator.ClearStats();
            this.Manager.Comment("reaching state \'S442\'");
            this.Manager.Comment("checking step \'return ClearStats\'");
            AssertClearStats();
            this.Manager.Comment("reaching state \'S443\'");
            this.Manager.Comment("executing step \'call XTurn(\"c4\")\'");
            TicTacToeMBT.Implementation.Accumulator.XTurn("c4");
            this.Manager.Comment("reaching state \'S444\'");
            this.Manager.Comment("checking step \'return XTurn\'");
            AssertXTurn();
            this.Manager.Comment("reaching state \'S445\'");
            this.Manager.Comment("executing step \'call ClearStats()\'");
            TicTacToeMBT.Implementation.Accumulator.ClearStats();
            this.Manager.Comment("reaching state \'S446\'");
            this.Manager.Comment("checking step \'return ClearStats\'");
            AssertClearStats();
            this.Manager.Comment("reaching state \'S447\'");
            this.Manager.EndTest();
        }
        #endregion

        #region Test Starting in S320
        [Test]
        public void AccumulatorTestSuiteS320()
        {
            this.Manager.BeginTest("AccumulatorTestSuiteS320");
            this.Manager.Comment("reaching state \'S320\'");
            this.Manager.Comment("executing step \'call Start()\'");
            TicTacToeMBT.Implementation.Accumulator.Start();
            this.Manager.Comment("reaching state \'S321\'");
            this.Manager.Comment("checking step \'return Start\'");
            AssertStart();
            this.Manager.Comment("reaching state \'S322\'");
            this.Manager.Comment("executing step \'call ClearStats()\'");
            TicTacToeMBT.Implementation.Accumulator.ClearStats();
            this.Manager.Comment("reaching state \'S323\'");
            this.Manager.Comment("checking step \'return ClearStats\'");
            AssertClearStats();
            this.Manager.Comment("reaching state \'S324\'");
            this.Manager.Comment("executing step \'call XTurn(\"c9\")\'");
            TicTacToeMBT.Implementation.Accumulator.XTurn("c9");
            this.Manager.Comment("reaching state \'S325\'");
            this.Manager.Comment("checking step \'return XTurn\'");
            AssertXTurn();
            this.Manager.Comment("reaching state \'S326\'");
            this.Manager.Comment("executing step \'call ClearStats()\'");
            TicTacToeMBT.Implementation.Accumulator.ClearStats();
            this.Manager.Comment("reaching state \'S327\'");
            this.Manager.Comment("checking step \'return ClearStats\'");
            AssertClearStats();
            this.Manager.Comment("reaching state \'S328\'");
            this.Manager.Comment("executing step \'call OasFirstPlayer()\'");
            TicTacToeMBT.Implementation.Accumulator.OasFirstPlayer();
            this.Manager.Comment("reaching state \'S329\'");
            this.Manager.Comment("checking step \'return OasFirstPlayer\'");
            AssertSelectOAsFirstPlayer();
            this.Manager.Comment("reaching state \'S330\'");
            this.Manager.Comment("executing step \'call ClearStats()\'");
            TicTacToeMBT.Implementation.Accumulator.ClearStats();
            this.Manager.Comment("reaching state \'S331\'");
            this.Manager.Comment("checking step \'return ClearStats\'");
            AssertClearStats();
            this.Manager.Comment("reaching state \'S332\'");
            this.Manager.Comment("executing step \'call OTurn(\"c9\")\'");
            TicTacToeMBT.Implementation.Accumulator.OTurn("c9");
            this.Manager.Comment("reaching state \'S333\'");
            this.Manager.Comment("checking step \'return OTurn\'");
            AssertOTurn();
            this.Manager.Comment("reaching state \'S334\'");
            this.Manager.Comment("executing step \'call ClearStats()\'");
            TicTacToeMBT.Implementation.Accumulator.ClearStats();
            this.Manager.Comment("reaching state \'S335\'");
            this.Manager.Comment("checking step \'return ClearStats\'");
            AssertClearStats();
            this.Manager.Comment("reaching state \'S336\'");
            this.Manager.Comment("executing step \'call XasFirstPlayer()\'");
            TicTacToeMBT.Implementation.Accumulator.XasFirstPlayer();
            this.Manager.Comment("reaching state \'S337\'");
            this.Manager.Comment("checking step \'return XasFirstPlayer\'");
            AssertSelectXAsFirstPlayer();
            this.Manager.Comment("reaching state \'S338\'");
            this.Manager.Comment("executing step \'call ClearStats()\'");
            TicTacToeMBT.Implementation.Accumulator.ClearStats();
            this.Manager.Comment("reaching state \'S339\'");
            this.Manager.Comment("checking step \'return ClearStats\'");
            AssertClearStats();
            this.Manager.Comment("reaching state \'S340\'");
            this.Manager.EndTest();
        }
        #endregion

        #region Test Starting in S364
        [Test]
        public void AccumulatorTestSuiteS364()
        {
            this.Manager.BeginTest("AccumulatorTestSuiteS364");
            this.Manager.Comment("reaching state \'S364\'");
            this.Manager.Comment("executing step \'call Start()\'");
            TicTacToeMBT.Implementation.Accumulator.Start();
            this.Manager.Comment("reaching state \'S365\'");
            this.Manager.Comment("checking step \'return Start\'");
            AssertStart();
            this.Manager.Comment("reaching state \'S366\'");
            this.Manager.Comment("executing step \'call ClearStats()\'");
            TicTacToeMBT.Implementation.Accumulator.ClearStats();
            this.Manager.Comment("reaching state \'S367\'");
            this.Manager.Comment("checking step \'return ClearStats\'");
            AssertClearStats();
            this.Manager.Comment("reaching state \'S368\'");
            this.Manager.Comment("executing step \'call XTurn(\"c9\")\'");
            TicTacToeMBT.Implementation.Accumulator.XTurn("c9");
            this.Manager.Comment("reaching state \'S369\'");
            this.Manager.Comment("checking step \'return XTurn\'");
            AssertXTurn();
            this.Manager.Comment("reaching state \'S370\'");
            this.Manager.Comment("executing step \'call ClearStats()\'");
            TicTacToeMBT.Implementation.Accumulator.ClearStats();
            this.Manager.Comment("reaching state \'S371\'");
            this.Manager.Comment("checking step \'return ClearStats\'");
            AssertClearStats();
            this.Manager.Comment("reaching state \'S372\'");
            this.Manager.Comment("executing step \'call OasFirstPlayer()\'");
            TicTacToeMBT.Implementation.Accumulator.OasFirstPlayer();
            this.Manager.Comment("reaching state \'S373\'");
            this.Manager.Comment("checking step \'return OasFirstPlayer\'");
            AssertSelectOAsFirstPlayer();
            this.Manager.Comment("reaching state \'S374\'");
            this.Manager.Comment("executing step \'call ClearStats()\'");
            TicTacToeMBT.Implementation.Accumulator.ClearStats();
            this.Manager.Comment("reaching state \'S375\'");
            this.Manager.Comment("checking step \'return ClearStats\'");
            AssertClearStats();
            this.Manager.Comment("reaching state \'S376\'");
            this.Manager.Comment("executing step \'call OTurn(\"c9\")\'");
            TicTacToeMBT.Implementation.Accumulator.OTurn("c9");
            this.Manager.Comment("reaching state \'S377\'");
            this.Manager.Comment("checking step \'return OTurn\'");
            AssertOTurn();
            this.Manager.Comment("reaching state \'S378\'");
            this.Manager.Comment("executing step \'call ClearStats()\'");
            TicTacToeMBT.Implementation.Accumulator.ClearStats();
            this.Manager.Comment("reaching state \'S379\'");
            this.Manager.Comment("checking step \'return ClearStats\'");
            AssertClearStats();
            this.Manager.Comment("reaching state \'S380\'");
            this.Manager.Comment("executing step \'call XTurn(\"c7\")\'");
            TicTacToeMBT.Implementation.Accumulator.XTurn("c7");
            this.Manager.Comment("reaching state \'S381\'");
            this.Manager.Comment("checking step \'return XTurn\'");
            AssertXTurn();
            this.Manager.Comment("reaching state \'S382\'");
            this.Manager.Comment("executing step \'call ClearStats()\'");
            TicTacToeMBT.Implementation.Accumulator.ClearStats();
            this.Manager.Comment("reaching state \'S383\'");
            this.Manager.Comment("checking step \'return ClearStats\'");
            AssertClearStats();
            this.Manager.Comment("reaching state \'S384\'");
            this.Manager.EndTest();
        }
        #endregion

        #region Test Starting in S511
        [Test]
        public void AccumulatorTestSuiteS511()
        {
            this.Manager.BeginTest("AccumulatorTestSuiteS511");
            this.Manager.Comment("reaching state \'S511\'");
            this.Manager.Comment("executing step \'call Start()\'");
            TicTacToeMBT.Implementation.Accumulator.Start();
            this.Manager.Comment("reaching state \'S512\'");
            this.Manager.Comment("checking step \'return Start\'");
            AssertStart();
            this.Manager.Comment("reaching state \'S513\'");
            this.Manager.Comment("executing step \'call ClearStats()\'");
            TicTacToeMBT.Implementation.Accumulator.ClearStats();
            this.Manager.Comment("reaching state \'S514\'");
            this.Manager.Comment("checking step \'return ClearStats\'");
            AssertClearStats();
            this.Manager.Comment("reaching state \'S515\'");
            this.Manager.Comment("executing step \'call XTurn(\"c9\")\'");
            TicTacToeMBT.Implementation.Accumulator.XTurn("c9");
            this.Manager.Comment("reaching state \'S516\'");
            this.Manager.Comment("checking step \'return XTurn\'");
            AssertXTurn();
            this.Manager.Comment("reaching state \'S517\'");
            this.Manager.Comment("executing step \'call ClearStats()\'");
            TicTacToeMBT.Implementation.Accumulator.ClearStats();
            this.Manager.Comment("reaching state \'S518\'");
            this.Manager.Comment("checking step \'return ClearStats\'");
            AssertClearStats();
            this.Manager.Comment("reaching state \'S519\'");
            this.Manager.Comment("executing step \'call OasFirstPlayer()\'");
            TicTacToeMBT.Implementation.Accumulator.OasFirstPlayer();
            this.Manager.Comment("reaching state \'S520\'");
            this.Manager.Comment("checking step \'return OasFirstPlayer\'");
            AssertSelectOAsFirstPlayer();
            this.Manager.Comment("reaching state \'S521\'");
            this.Manager.Comment("executing step \'call ClearStats()\'");
            TicTacToeMBT.Implementation.Accumulator.ClearStats();
            this.Manager.Comment("reaching state \'S522\'");
            this.Manager.Comment("checking step \'return ClearStats\'");
            AssertClearStats();
            this.Manager.Comment("reaching state \'S523\'");
            this.Manager.Comment("executing step \'call OTurn(\"c9\")\'");
            TicTacToeMBT.Implementation.Accumulator.OTurn("c9");
            this.Manager.Comment("reaching state \'S524\'");
            this.Manager.Comment("checking step \'return OTurn\'");
            AssertOTurn();
            this.Manager.Comment("reaching state \'S525\'");
            this.Manager.Comment("executing step \'call ClearStats()\'");
            TicTacToeMBT.Implementation.Accumulator.ClearStats();
            this.Manager.Comment("reaching state \'S526\'");
            this.Manager.Comment("checking step \'return ClearStats\'");
            AssertClearStats();
            this.Manager.Comment("reaching state \'S527\'");
            this.Manager.Comment("executing step \'call XTurn(\"c1\")\'");
            TicTacToeMBT.Implementation.Accumulator.XTurn("c1");
            this.Manager.Comment("reaching state \'S528\'");
            this.Manager.Comment("checking step \'return XTurn\'");
            AssertXTurn();
            this.Manager.Comment("reaching state \'S529\'");
            this.Manager.Comment("executing step \'call ClearStats()\'");
            TicTacToeMBT.Implementation.Accumulator.ClearStats();
            this.Manager.Comment("reaching state \'S530\'");
            this.Manager.Comment("checking step \'return ClearStats\'");
            AssertClearStats();
            this.Manager.Comment("reaching state \'S531\'");
            this.Manager.EndTest();
        }
        #endregion

        #region Test Starting in S406
        [Test]
        public void AccumulatorTestSuiteS406()
        {
            this.Manager.BeginTest("AccumulatorTestSuiteS406");
            this.Manager.Comment("reaching state \'S406\'");
            this.Manager.Comment("executing step \'call Start()\'");
            TicTacToeMBT.Implementation.Accumulator.Start();
            this.Manager.Comment("reaching state \'S407\'");
            this.Manager.Comment("checking step \'return Start\'");
            AssertStart();
            this.Manager.Comment("reaching state \'S408\'");
            this.Manager.Comment("executing step \'call ClearStats()\'");
            TicTacToeMBT.Implementation.Accumulator.ClearStats();
            this.Manager.Comment("reaching state \'S409\'");
            this.Manager.Comment("checking step \'return ClearStats\'");
            AssertClearStats();
            this.Manager.Comment("reaching state \'S410\'");
            this.Manager.Comment("executing step \'call XTurn(\"c9\")\'");
            TicTacToeMBT.Implementation.Accumulator.XTurn("c9");
            this.Manager.Comment("reaching state \'S411\'");
            this.Manager.Comment("checking step \'return XTurn\'");
            AssertXTurn();
            this.Manager.Comment("reaching state \'S412\'");
            this.Manager.Comment("executing step \'call ClearStats()\'");
            TicTacToeMBT.Implementation.Accumulator.ClearStats();
            this.Manager.Comment("reaching state \'S413\'");
            this.Manager.Comment("checking step \'return ClearStats\'");
            AssertClearStats();
            this.Manager.Comment("reaching state \'S414\'");
            this.Manager.Comment("executing step \'call OasFirstPlayer()\'");
            TicTacToeMBT.Implementation.Accumulator.OasFirstPlayer();
            this.Manager.Comment("reaching state \'S415\'");
            this.Manager.Comment("checking step \'return OasFirstPlayer\'");
            AssertSelectOAsFirstPlayer();
            this.Manager.Comment("reaching state \'S416\'");
            this.Manager.Comment("executing step \'call ClearStats()\'");
            TicTacToeMBT.Implementation.Accumulator.ClearStats();
            this.Manager.Comment("reaching state \'S417\'");
            this.Manager.Comment("checking step \'return ClearStats\'");
            AssertClearStats();
            this.Manager.Comment("reaching state \'S418\'");
            this.Manager.Comment("executing step \'call OTurn(\"c9\")\'");
            TicTacToeMBT.Implementation.Accumulator.OTurn("c9");
            this.Manager.Comment("reaching state \'S419\'");
            this.Manager.Comment("checking step \'return OTurn\'");
            AssertOTurn();
            this.Manager.Comment("reaching state \'S420\'");
            this.Manager.Comment("executing step \'call ClearStats()\'");
            TicTacToeMBT.Implementation.Accumulator.ClearStats();
            this.Manager.Comment("reaching state \'S421\'");
            this.Manager.Comment("checking step \'return ClearStats\'");
            AssertClearStats();
            this.Manager.Comment("reaching state \'S422\'");
            this.Manager.Comment("executing step \'call XTurn(\"c5\")\'");
            TicTacToeMBT.Implementation.Accumulator.XTurn("c5");
            this.Manager.Comment("reaching state \'S423\'");
            this.Manager.Comment("checking step \'return XTurn\'");
            AssertXTurn();
            this.Manager.Comment("reaching state \'S424\'");
            this.Manager.Comment("executing step \'call ClearStats()\'");
            TicTacToeMBT.Implementation.Accumulator.ClearStats();
            this.Manager.Comment("reaching state \'S425\'");
            this.Manager.Comment("checking step \'return ClearStats\'");
            AssertClearStats();
            this.Manager.Comment("reaching state \'S426\'");
            this.Manager.EndTest();
        }
        #endregion

        #region Test Starting in S469
        [Test]
        public void AccumulatorTestSuiteS469()
        {
            this.Manager.BeginTest("AccumulatorTestSuiteS469");
            this.Manager.Comment("reaching state \'S469\'");
            this.Manager.Comment("executing step \'call Start()\'");
            TicTacToeMBT.Implementation.Accumulator.Start();
            this.Manager.Comment("reaching state \'S470\'");
            this.Manager.Comment("checking step \'return Start\'");
            AssertStart();
            this.Manager.Comment("reaching state \'S471\'");
            this.Manager.Comment("executing step \'call ClearStats()\'");
            TicTacToeMBT.Implementation.Accumulator.ClearStats();
            this.Manager.Comment("reaching state \'S472\'");
            this.Manager.Comment("checking step \'return ClearStats\'");
            AssertClearStats();
            this.Manager.Comment("reaching state \'S473\'");
            this.Manager.Comment("executing step \'call XTurn(\"c9\")\'");
            TicTacToeMBT.Implementation.Accumulator.XTurn("c9");
            this.Manager.Comment("reaching state \'S474\'");
            this.Manager.Comment("checking step \'return XTurn\'");
            AssertXTurn();
            this.Manager.Comment("reaching state \'S475\'");
            this.Manager.Comment("executing step \'call ClearStats()\'");
            TicTacToeMBT.Implementation.Accumulator.ClearStats();
            this.Manager.Comment("reaching state \'S476\'");
            this.Manager.Comment("checking step \'return ClearStats\'");
            AssertClearStats();
            this.Manager.Comment("reaching state \'S477\'");
            this.Manager.Comment("executing step \'call OasFirstPlayer()\'");
            TicTacToeMBT.Implementation.Accumulator.OasFirstPlayer();
            this.Manager.Comment("reaching state \'S478\'");
            this.Manager.Comment("checking step \'return OasFirstPlayer\'");
            AssertSelectOAsFirstPlayer();
            this.Manager.Comment("reaching state \'S479\'");
            this.Manager.Comment("executing step \'call ClearStats()\'");
            TicTacToeMBT.Implementation.Accumulator.ClearStats();
            this.Manager.Comment("reaching state \'S480\'");
            this.Manager.Comment("checking step \'return ClearStats\'");
            AssertClearStats();
            this.Manager.Comment("reaching state \'S481\'");
            this.Manager.Comment("executing step \'call OTurn(\"c9\")\'");
            TicTacToeMBT.Implementation.Accumulator.OTurn("c9");
            this.Manager.Comment("reaching state \'S482\'");
            this.Manager.Comment("checking step \'return OTurn\'");
            AssertOTurn();
            this.Manager.Comment("reaching state \'S483\'");
            this.Manager.Comment("executing step \'call ClearStats()\'");
            TicTacToeMBT.Implementation.Accumulator.ClearStats();
            this.Manager.Comment("reaching state \'S484\'");
            this.Manager.Comment("checking step \'return ClearStats\'");
            AssertClearStats();
            this.Manager.Comment("reaching state \'S485\'");
            this.Manager.Comment("executing step \'call XTurn(\"c2\")\'");
            TicTacToeMBT.Implementation.Accumulator.XTurn("c2");
            this.Manager.Comment("reaching state \'S486\'");
            this.Manager.Comment("checking step \'return XTurn\'");
            AssertXTurn();
            this.Manager.Comment("reaching state \'S487\'");
            this.Manager.Comment("executing step \'call ClearStats()\'");
            TicTacToeMBT.Implementation.Accumulator.ClearStats();
            this.Manager.Comment("reaching state \'S488\'");
            this.Manager.Comment("checking step \'return ClearStats\'");
            AssertClearStats();
            this.Manager.Comment("reaching state \'S489\'");
            this.Manager.EndTest();
        }
        #endregion

        #region Test Starting in S532
        [Test]
        public void AccumulatorTestSuiteS532()
        {
            this.Manager.BeginTest("AccumulatorTestSuiteS532");
            this.Manager.Comment("reaching state \'S532\'");
            this.Manager.Comment("executing step \'call Start()\'");
            TicTacToeMBT.Implementation.Accumulator.Start();
            this.Manager.Comment("reaching state \'S533\'");
            this.Manager.Comment("checking step \'return Start\'");
            AssertStart();
            this.Manager.Comment("reaching state \'S534\'");
            this.Manager.Comment("executing step \'call ClearStats()\'");
            TicTacToeMBT.Implementation.Accumulator.ClearStats();
            this.Manager.Comment("reaching state \'S535\'");
            this.Manager.Comment("checking step \'return ClearStats\'");
            AssertClearStats();
            this.Manager.Comment("reaching state \'S536\'");
            this.Manager.Comment("executing step \'call XTurn(\"c9\")\'");
            TicTacToeMBT.Implementation.Accumulator.XTurn("c9");
            this.Manager.Comment("reaching state \'S537\'");
            this.Manager.Comment("checking step \'return XTurn\'");
            AssertXTurn();
            this.Manager.Comment("reaching state \'S538\'");
            this.Manager.Comment("executing step \'call ClearStats()\'");
            TicTacToeMBT.Implementation.Accumulator.ClearStats();
            this.Manager.Comment("reaching state \'S539\'");
            this.Manager.Comment("checking step \'return ClearStats\'");
            AssertClearStats();
            this.Manager.Comment("reaching state \'S540\'");
            this.Manager.Comment("executing step \'call OasFirstPlayer()\'");
            TicTacToeMBT.Implementation.Accumulator.OasFirstPlayer();
            this.Manager.Comment("reaching state \'S541\'");
            this.Manager.Comment("checking step \'return OasFirstPlayer\'");
            AssertSelectOAsFirstPlayer();
            this.Manager.Comment("reaching state \'S542\'");
            this.Manager.Comment("executing step \'call ClearStats()\'");
            TicTacToeMBT.Implementation.Accumulator.ClearStats();
            this.Manager.Comment("reaching state \'S543\'");
            this.Manager.Comment("checking step \'return ClearStats\'");
            AssertClearStats();
            this.Manager.Comment("reaching state \'S544\'");
            this.Manager.Comment("executing step \'call OTurn(\"c9\")\'");
            TicTacToeMBT.Implementation.Accumulator.OTurn("c9");
            this.Manager.Comment("reaching state \'S545\'");
            this.Manager.Comment("checking step \'return OTurn\'");
            AssertOTurn();
            this.Manager.Comment("reaching state \'S546\'");
            this.Manager.Comment("executing step \'call ClearStats()\'");
            TicTacToeMBT.Implementation.Accumulator.ClearStats();
            this.Manager.Comment("reaching state \'S547\'");
            this.Manager.Comment("checking step \'return ClearStats\'");
            AssertClearStats();
            this.Manager.Comment("reaching state \'S548\'");
            this.Manager.Comment("executing step \'call XTurn(\"c8\")\'");
            TicTacToeMBT.Implementation.Accumulator.XTurn("c8");
            this.Manager.Comment("reaching state \'S549\'");
            this.Manager.Comment("checking step \'return XTurn\'");
            AssertXTurn();
            this.Manager.Comment("reaching state \'S550\'");
            this.Manager.Comment("executing step \'call ClearStats()\'");
            TicTacToeMBT.Implementation.Accumulator.ClearStats();
            this.Manager.Comment("reaching state \'S551\'");
            this.Manager.Comment("checking step \'return ClearStats\'");
            AssertClearStats();
            this.Manager.Comment("reaching state \'S552\'");
            this.Manager.EndTest();
        }
        #endregion

        #region Test Starting in S448
        [Test]
        public void AccumulatorTestSuiteS448()
        {
            this.Manager.BeginTest("AccumulatorTestSuiteS448");
            this.Manager.Comment("reaching state \'S448\'");
            this.Manager.Comment("executing step \'call Start()\'");
            TicTacToeMBT.Implementation.Accumulator.Start();
            this.Manager.Comment("reaching state \'S449\'");
            this.Manager.Comment("checking step \'return Start\'");
            AssertStart();
            this.Manager.Comment("reaching state \'S450\'");
            this.Manager.Comment("executing step \'call ClearStats()\'");
            TicTacToeMBT.Implementation.Accumulator.ClearStats();
            this.Manager.Comment("reaching state \'S451\'");
            this.Manager.Comment("checking step \'return ClearStats\'");
            AssertClearStats();
            this.Manager.Comment("reaching state \'S452\'");
            this.Manager.Comment("executing step \'call XTurn(\"c9\")\'");
            TicTacToeMBT.Implementation.Accumulator.XTurn("c9");
            this.Manager.Comment("reaching state \'S453\'");
            this.Manager.Comment("checking step \'return XTurn\'");
            AssertXTurn();
            this.Manager.Comment("reaching state \'S454\'");
            this.Manager.Comment("executing step \'call ClearStats()\'");
            TicTacToeMBT.Implementation.Accumulator.ClearStats();
            this.Manager.Comment("reaching state \'S455\'");
            this.Manager.Comment("checking step \'return ClearStats\'");
            AssertClearStats();
            this.Manager.Comment("reaching state \'S456\'");
            this.Manager.Comment("executing step \'call OasFirstPlayer()\'");
            TicTacToeMBT.Implementation.Accumulator.OasFirstPlayer();
            this.Manager.Comment("reaching state \'S457\'");
            this.Manager.Comment("checking step \'return OasFirstPlayer\'");
            AssertSelectOAsFirstPlayer();
            this.Manager.Comment("reaching state \'S458\'");
            this.Manager.Comment("executing step \'call ClearStats()\'");
            TicTacToeMBT.Implementation.Accumulator.ClearStats();
            this.Manager.Comment("reaching state \'S459\'");
            this.Manager.Comment("checking step \'return ClearStats\'");
            AssertClearStats();
            this.Manager.Comment("reaching state \'S460\'");
            this.Manager.Comment("executing step \'call OTurn(\"c9\")\'");
            TicTacToeMBT.Implementation.Accumulator.OTurn("c9");
            this.Manager.Comment("reaching state \'S461\'");
            this.Manager.Comment("checking step \'return OTurn\'");
            AssertOTurn();
            this.Manager.Comment("reaching state \'S462\'");
            this.Manager.Comment("executing step \'call ClearStats()\'");
            TicTacToeMBT.Implementation.Accumulator.ClearStats();
            this.Manager.Comment("reaching state \'S463\'");
            this.Manager.Comment("checking step \'return ClearStats\'");
            AssertClearStats();
            this.Manager.Comment("reaching state \'S464\'");
            this.Manager.Comment("executing step \'call XTurn(\"c3\")\'");
            TicTacToeMBT.Implementation.Accumulator.XTurn("c3");
            this.Manager.Comment("reaching state \'S465\'");
            this.Manager.Comment("checking step \'return XTurn\'");
            AssertXTurn();
            this.Manager.Comment("reaching state \'S466\'");
            this.Manager.Comment("executing step \'call ClearStats()\'");
            TicTacToeMBT.Implementation.Accumulator.ClearStats();
            this.Manager.Comment("reaching state \'S467\'");
            this.Manager.Comment("checking step \'return ClearStats\'");
            AssertClearStats();
            this.Manager.Comment("reaching state \'S468\'");
            this.Manager.EndTest();
        }
        #endregion

        #region Test Starting in S385
        [Test]
        public void AccumulatorTestSuiteS385()
        {
            this.Manager.BeginTest("AccumulatorTestSuiteS385");
            this.Manager.Comment("reaching state \'S385\'");
            this.Manager.Comment("executing step \'call Start()\'");
            TicTacToeMBT.Implementation.Accumulator.Start();
            this.Manager.Comment("reaching state \'S386\'");
            this.Manager.Comment("checking step \'return Start\'");
            AssertStart();
            this.Manager.Comment("reaching state \'S387\'");
            this.Manager.Comment("executing step \'call ClearStats()\'");
            TicTacToeMBT.Implementation.Accumulator.ClearStats();
            this.Manager.Comment("reaching state \'S388\'");
            this.Manager.Comment("checking step \'return ClearStats\'");
            AssertClearStats();
            this.Manager.Comment("reaching state \'S389\'");
            this.Manager.Comment("executing step \'call XTurn(\"c9\")\'");
            TicTacToeMBT.Implementation.Accumulator.XTurn("c9");
            this.Manager.Comment("reaching state \'S390\'");
            this.Manager.Comment("checking step \'return XTurn\'");
            AssertXTurn();
            this.Manager.Comment("reaching state \'S391\'");
            this.Manager.Comment("executing step \'call ClearStats()\'");
            TicTacToeMBT.Implementation.Accumulator.ClearStats();
            this.Manager.Comment("reaching state \'S392\'");
            this.Manager.Comment("checking step \'return ClearStats\'");
            AssertClearStats();
            this.Manager.Comment("reaching state \'S393\'");
            this.Manager.Comment("executing step \'call OasFirstPlayer()\'");
            TicTacToeMBT.Implementation.Accumulator.OasFirstPlayer();
            this.Manager.Comment("reaching state \'S394\'");
            this.Manager.Comment("checking step \'return OasFirstPlayer\'");
            AssertSelectOAsFirstPlayer();
            this.Manager.Comment("reaching state \'S395\'");
            this.Manager.Comment("executing step \'call ClearStats()\'");
            TicTacToeMBT.Implementation.Accumulator.ClearStats();
            this.Manager.Comment("reaching state \'S396\'");
            this.Manager.Comment("checking step \'return ClearStats\'");
            AssertClearStats();
            this.Manager.Comment("reaching state \'S397\'");
            this.Manager.Comment("executing step \'call OTurn(\"c9\")\'");
            TicTacToeMBT.Implementation.Accumulator.OTurn("c9");
            this.Manager.Comment("reaching state \'S398\'");
            this.Manager.Comment("checking step \'return OTurn\'");
            AssertOTurn();
            this.Manager.Comment("reaching state \'S399\'");
            this.Manager.Comment("executing step \'call ClearStats()\'");
            TicTacToeMBT.Implementation.Accumulator.ClearStats();
            this.Manager.Comment("reaching state \'S400\'");
            this.Manager.Comment("checking step \'return ClearStats\'");
            AssertClearStats();
            this.Manager.Comment("reaching state \'S401\'");
            this.Manager.Comment("executing step \'call XTurn(\"c6\")\'");
            TicTacToeMBT.Implementation.Accumulator.XTurn("c6");
            this.Manager.Comment("reaching state \'S402\'");
            this.Manager.Comment("checking step \'return XTurn\'");
            AssertXTurn();
            this.Manager.Comment("reaching state \'S403\'");
            this.Manager.Comment("executing step \'call ClearStats()\'");
            TicTacToeMBT.Implementation.Accumulator.ClearStats();
            this.Manager.Comment("reaching state \'S404\'");
            this.Manager.Comment("checking step \'return ClearStats\'"); 
            AssertClearStats();
            this.Manager.Comment("reaching state \'S405\'");
            this.Manager.EndTest();
        }
        #endregion

        #endregion

        #region test helpers

        public void AssertClearStats()
        {
            NUnit.Framework.Assert.AreEqual(0, TicTacToeMBT.Implementation.Accumulator.GetOWins());
            NUnit.Framework.Assert.AreEqual(0, TicTacToeMBT.Implementation.Accumulator.GetXWins());
            NUnit.Framework.Assert.AreEqual(0, TicTacToeMBT.Implementation.Accumulator.GetCatWins());
            NUnit.Framework.Assert.AreEqual(0, TicTacToeMBT.Implementation.Accumulator.GetORecord());
            NUnit.Framework.Assert.AreEqual(0, TicTacToeMBT.Implementation.Accumulator.GetXRecord());
            NUnit.Framework.Assert.AreEqual(0, TicTacToeMBT.Implementation.Accumulator.GetCatRecord());
        }

        public void AssertNewGame()
        {
            AssertEmptyGameBoard();
        }

        public void AssertXTurn()
        {
            AssertPlayerTurn(Implementation.Player.X);
        }

        public void AssertOTurn()
        {
            AssertPlayerTurn(Implementation.Player.O);
        }

        public void AssertStart()
        {
            NUnit.Framework.Assert.AreNotEqual(null, Implementation.Accumulator.GetDriver());
        }

        public void AssertStop()
        {
            NUnit.Framework.Assert.AreEqual(null, Implementation.Accumulator.GetDriver());
        }

        public void AssertSelectXAsFirstPlayer()
        {
            NUnit.Framework.Assert.AreEqual(true, Implementation.Accumulator.IsXAsFirstPlayer());
            AssertEmptyGameBoard();
        }

        public void AssertSelectOAsFirstPlayer()
        {
            AssertEmptyGameBoard();
        }

        private void AssertEmptyGameBoard()
        {
            NUnit.Framework.Assert.AreEqual("", TicTacToeMBT.Implementation.Accumulator.GetSquareValue("c1"));
            NUnit.Framework.Assert.AreEqual("", TicTacToeMBT.Implementation.Accumulator.GetSquareValue("c2"));
            NUnit.Framework.Assert.AreEqual("", TicTacToeMBT.Implementation.Accumulator.GetSquareValue("c3"));
            NUnit.Framework.Assert.AreEqual("", TicTacToeMBT.Implementation.Accumulator.GetSquareValue("c4"));
            NUnit.Framework.Assert.AreEqual("", TicTacToeMBT.Implementation.Accumulator.GetSquareValue("c5"));
            NUnit.Framework.Assert.AreEqual("", TicTacToeMBT.Implementation.Accumulator.GetSquareValue("c6"));
            NUnit.Framework.Assert.AreEqual("", TicTacToeMBT.Implementation.Accumulator.GetSquareValue("c7"));
            NUnit.Framework.Assert.AreEqual("", TicTacToeMBT.Implementation.Accumulator.GetSquareValue("c8"));
            NUnit.Framework.Assert.AreEqual("", TicTacToeMBT.Implementation.Accumulator.GetSquareValue("c9"));
        }

        private void AssertPlayerTurn(Implementation.Player player)
        {
            NUnit.Framework.Assert.AreEqual(player.ToString(), Implementation.Accumulator.GetValueFromLastTurn(player));
        }

        #endregion
    }
}
