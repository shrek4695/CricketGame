using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CricketGame.Test
{
    [TestClass]
    public class CricketGameTest
    {
        Cricket game = new Cricket();
        CheckResult resultObject = new CheckResult();
        [TestMethod]
        public void PlayerScore_NewGame_ShouldbeZero()
        {
            
            Assert.IsTrue(game.PlayerScore == 0);
        }
        [TestMethod]
        public void Score_ValidRuns_ShouldUpdatePlayersScore()
        {
            
            game.Score(3);

            Assert.IsTrue(game.PlayerScore == 3);
        }
       [TestMethod]
        public void Score_InvalidRuns_ShouldNotUpdatePlayersScore()
        {
            var game = new Cricket();
            game.Score(-7);
            Assert.IsTrue(game.PlayerScore == 0);
        }
        [TestMethod]
        public void Player_Should_Get_Out()
        {
            var game = new Cricket();
            game.Score(3);
            game.makePlayerOut();
            Assert.IsTrue(game.Out == true);
        }
        [TestMethod]
        public void PlayerScore_Should_Not_Increase_After_Out()
        {
            var game = new Cricket();
            game.Score(3);
            game.makePlayerOut();
            game.Score(2);
            Assert.IsTrue(game.PlayerScore == 3);
        }
        
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