using FluentAssertions;
using System;
using TechTalk.SpecFlow;

namespace CricketGame.Specs
{
    [Binding]
    public class PlayerScoreSteps
    {
        private Cricket _game;

        
        [When(@"Player starts a game of cricket")]
        [Given(@"Player has started a game of cricket")]
        public void WhenPlayerHasStartedAGameOfCricket()
        {
            //ScenarioContext.Current.Pending();
            _game = new Cricket();
        }
        [Given(@"Player has scored (.*) runs")]
        public void GivenPlayerHasScoredRuns(int score)
        {
            _game.Score(score);
        }
        [Given(@"Player gets out")]
        public void GivenPlayerGetsOut()
        {
            _game.makePlayerOut();
        }


        [When(@"Player scores (.*) runs")]
        public void WhenPlayerScoresRuns(int score)
        {
            //ScenarioContext.Current.Pending();
            _game.Score(score);
        }

        [Then(@"the player score should be (.*)")]
        public void ThenThePlayerScoreShouldBe(int score)
        {
            _game.PlayerScore.Should().Be(score);
            
        }
        
    }
}
