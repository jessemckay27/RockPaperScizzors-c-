using System.Collections.Generic;
using System;

namespace RockPaperScissors.Objects
{
  public class RPSGame
  {
    private int _playerOneChoice; //may need to be an int
    private int _playerTwoChoice; //may need to be an int

    public string GetPlayerOneChoice()
    {
      return _playerOneChoice;
    }

    public string GetPlayerTwoChoice()
    {
      return _playerTwoChoice;
    }


    public RockPaperScissors( string user1choice, string user2choice)
    {
      _playerOneChoice = int.Parse(user1choice);
      _playerTwoChoice = int.Parse(user2choice);
    }

    //playerchoice values:  rock = 1, paper = 2, scissors = 3

    public string GetResult()
    {
      if (_playerOneChoice == _playerTwoChoice)
      {
        return "It's a draw!";
        // Console.WriteLine("It's a draw!");
      }
      else if (_playerOneChoice - _playerTwoChoice == 1 || _playerOneChoice + _playerTwoChoice == 4)
      //           rock(1)      - scissors(3)      == 4
      //          paper(2)      -     rock(1)      == 1
      //       scissors(3)      -    paper(2)      == 1
      {
        return "Player 1 Wins!"
      }
      else
      {
        return "Player 2 Wins!"
      }


    }

  }
}
