using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CricketGameResultCalculator;
using CricketGame;
namespace CricketGameResultCalculator.Test
{
    [TestClass]
    public class CheckResultTest
    {
        CheckResult resultObject = new CheckResult();
        [TestMethod]
        public void ResultVariableshouldbeNull()
        {
            Assert.IsTrue(resultObject._result == null);
        }
        [TestMethod]
        public void Player1_Should_Win()
        {
            Cricket Player1 = new Cricket();
            Cricket Player2 = new Cricket();
            Player1.Score(3);
            Player1.Score(4);
            Player1.makePlayerOut();
            Player2.Score(4);
            Player2.Score(2);
            Player2.makePlayerOut();
            resultObject.check(Player1, Player2);
            Assert.AreEqual(resultObject._result, "Player1 won");
        }
        [TestMethod]
        public void Player2_Should_Win()
        {
            Cricket Player1 = new Cricket();
            Cricket Player2 = new Cricket();
            Player1.Score(3);
            Player1.Score(1);
            Player1.makePlayerOut();
            Player2.Score(4);
            Player2.Score(2);
            Player2.makePlayerOut();
            resultObject.check(Player1, Player2);
            Assert.AreEqual(resultObject._result, "Player2 won");
        }
        [TestMethod]
        public void Tie_Should_Happen()
        {
            Cricket Player1 = new Cricket();
            Cricket Player2 = new Cricket();
            Player1.Score(3);
            Player1.Score(3);
            Player1.makePlayerOut();
            Player2.Score(3);
            Player2.Score(3);
            Player2.makePlayerOut();
            resultObject.check(Player1, Player2);
            Assert.AreEqual(resultObject._result, "Tie");
        }
    }
}
