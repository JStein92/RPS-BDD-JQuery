using RpsGame.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;

namespace RpsGame.Test
{
  [TestClass]
  public class RpsGameTest
  {
    [TestMethod]
    public void GetPlayerOneInput_VerifyUserInputRock_True()
    {
      //Arrange
      Rps rock = new Rps();
      string expected = "rock";
      //Act
      string result = rock.GetPlayerOneInput();
      //Assert
      Assert.AreEqual(expected, result);
    }
    [TestMethod]
    public void GetPlayerTwoInput_VerifyUserInputPaper_True()
    {
      Rps paper = new Rps();
      string expected = "paper";

      string result = paper.GetPlayerTwoInput();

      Assert.AreEqual(expected, result);
    }
    [TestMethod]
    public void CompareInputs_InputsMatch_True()
    {
      Rps draw = new Rps();
      string expected = "Draw";

      draw.GetPlayerOneInput();
      draw.GetPlayerTwoInput();
      string result = draw.CompareInputs();

      Assert.AreEqual(expected, result);
    }

    [TestMethod]
    public void CompareInputs_ScissorsBeatsPaper_True()
    {
      Rps test = new Rps("scissors", "paper");
      string expected = "Player 1 Wins!";

      string result = test.CompareInputs();

      Assert.AreEqual(expected, result);
    }
  }
}
