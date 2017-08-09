using System;
using System.Collections.Generic;

namespace RpsGame.Models
{
  public class Rps
  {
    private string _playerOne;
    private string _playerTwo;

    public Rps()
    {
    }

    public Rps(string one, string two)
    {
      _playerOne = one;
      _playerTwo = two;
    }
    public string GetP1()
    {
      return _playerOne;
    }
    public string GetP2()
    {
      return _playerTwo;
    }

    public string GetPlayerOneInput()
    {
      Console.WriteLine("Enter r, p, or s: ");
      _playerOne = Console.ReadLine();
      if(_playerOne == "r")
      {
        return "rock";
      }
      else if(_playerOne == "s")
      {
        return "scissors";
      }
      else
      {
        return "paper";
      }
    }

    public string GetPlayerTwoInput()
    {
      Console.WriteLine("Enter r, p, or s: ");
      _playerTwo = Console.ReadLine();
      if(_playerOne == "r")
      {
        return "rock";
      }
      else if(_playerOne == "s")
      {
        return "scissors";
      }
      else
      {
        return "paper";
      }
    }

    public void SetP1Choice(string p1Choice)
    {
      _playerOne = p1Choice;
    }
    public void SetP2Choice(string p2Choice)
    {
      _playerTwo = p2Choice;
    }
    public string GetComputerChoice()
    {
      Random random = new Random();
      int randomNumber = random.Next(0,3);
      List<string> choiceList = new List<string>{"rock", "paper", "scissors"};
      string compChoice = choiceList[randomNumber];
      return compChoice;
    }
    public string CompareInputs()
    {
      string p1Win = "Player 1 Wins!";
      string p2Win = "Player 2 Wins!";

      if(_playerOne == _playerTwo)
      {
      return "Draw";
      }
      //Player One Win Conditions
      else if(_playerOne == "rock" && _playerTwo == "scissors")
      {
        return p1Win;
      }
      else if(_playerOne == "paper" && _playerTwo == "rock")
      {
        return p1Win;
      }
      else if(_playerOne == "scissors" && _playerTwo == "paper")
      {
        return p1Win;
      }
      //Player Two Win Conditions
      else if(_playerTwo == "rock" && _playerOne == "scissors")
      {
        return p2Win;
      }
      else if(_playerTwo == "paper" && _playerOne == "rock")
      {
        return p2Win;
      }
      else
      {
        return p2Win;
      }
    }
  }
}
