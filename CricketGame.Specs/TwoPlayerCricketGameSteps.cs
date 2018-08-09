using FluentAssertions;
using System;
using TechTalk.SpecFlow;

namespace CricketGame.Specs
{
    [Binding]
    public class TwoPlayerCricketGameSteps
    {
        private Cricket _Player1;
        private Cricket _Player2;
        private CheckResult Finalresult;

        [Given(@"Player (.*) has started a game of cricket")]
        public void GivenPlayerHasStartedAGameOfCricket(int PlayerName)
        {
            if(PlayerName==1)
            {
                _Player1 = new Cricket();
                
            }
            else
            {
                _Player2 = new Cricket();
                
            }
        }
        [Given(@"Player (.*) has scored (.*) runs")]
        public void GivenPlayerHasScoredRuns(int PlayerName, int score)
        {
            if(PlayerName==1)
            {
                _Player1.Score(score);
            }
            else
            {
                _Player2.Score(score);
            }
        }

        [Given(@"Player (.*) gets out")]
        public void GivenPlayerGetsOut(int PlayerName)
        {
            if(PlayerName==1)
            {
                _Player1.makePlayerOut();
            }
            else
            {
                _Player2.makePlayerOut();
            }
        }
        [When(@"Player (.*) gets out")]
        public void WhenPlayerGetsOut(int PlayerNumber)
        {
            Finalresult = new CheckResult();
            Finalresult.check(_Player1, _Player2);
        }
        [Then(@"Result should be (.*)")]
        public void ThenResultShouldBePlayerWon(String result)
        {
            Finalresult._result.Should().Be(result);
        }

    }
}
