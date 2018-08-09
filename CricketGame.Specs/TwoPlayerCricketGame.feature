Feature: TwoPlayerCricketGame
	In order to declare a winner
	As a Administer
	I want to compare score of two players

@mytag
Scenario: Player 1 and Player 2 are playing and one of them wins
	Given Player 1 has started a game of cricket
	And Player 1 has scored 4 runs
	And Player 1 has scored 6 runs
	And Player 1 has scored 3 runs
	And Player 1 has scored 4 runs
	And Player 1 gets out
	Given Player 2 has started a game of cricket
	And Player 2 has scored 2 runs
	And Player 2 has scored 3 runs
	And Player 2 has scored 4 runs
	And Player 2 gets out
	When Player 2 gets out
	Then Result should be Player1 won

Scenario: Player 1 and Player 2 are playing and Tie Happens
	Given Player 1 has started a game of cricket
	And Player 1 has scored 4 runs
	And Player 1 has scored 6 runs
	And Player 1 has scored 3 runs
	And Player 1 gets out
	Given Player 2 has started a game of cricket
	And Player 2 has scored 2 runs
	And Player 2 has scored 3 runs
	And Player 2 has scored 4 runs
	And Player 2 has scored 4 runs
	And Player 2 gets out
	When Player 2 gets out
	Then Result should be Tie