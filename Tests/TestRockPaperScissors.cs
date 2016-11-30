using Xunit;

namespace RockPaperScissors.Objects
{
  public class RockPaperScissorsTest
  {
    [Fact]
    public void GetWinner_PlayersSameChoice_Draw()
    {
      RPSGame newRPSGame = new RPSGame("1", "1");
      Assert.Equal("It's a draw!", newRPSGame.GetResult());
    }

    [Fact]
    public void GetWinner_PlayerOnePaperPlayerTwoRock_PlayerOneWins()
    {
      RPSGame newRPSGame = new RPSGame("2", "1");
      Assert.Equal("Player 1 Wins!", newRPSGame.GetResult());
    }

    [Fact]
    public void GetWinner_PlayerOneScissorsPlayerTwoPaper_PlayerOneWins()
    {
      RPSGame newRPSGame = new RPSGame("3","2");
      Assert.Equal("Player 1 Wins!", newRPSGame.GetResult());
    }

    [Fact]
    public void GetWinner_PlayerTwoScissorsPlayerOneRock_PlayerOneWins()
    {
      RPSGame newRPSGame = new RPSGame("1","3");
      Assert.Equal("Player 1 Wins!", newRPSGame.GetResult());
    }

    //playerchoice values:  rock = 1, paper = 2, scissors = 3
    [Fact]
    public void GetWinner_PlayerTwoScissorsPlayerOnePaper_PlayerTwoWins()
    {
      RPSGame newRPSGame = new RPSGame("2","3");
      Assert.Equal("Player 2 Wins!", newRPSGame.GetResult());
    }
  }
}
