using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WordCounter.Controllers;
using WordCounter.Models;
using System;

namespace WordCounter.Tests
{
  [TestClass]
  public class RepeatCountersControllerTest
  {
    // [TestMethod]
    // public void Create_ReturnsCorrectActionType_RedirectToActionResult()
    // {
    //     //Arrange
    //     ItemsController controller = new ItemsController();
    //
    //     //Act
    //     IActionResult view = controller.Create("Walk the dog");
    //
    //     //Assert
    //     Assert.IsInstanceOfType(view, typeof(RedirectToActionResult));
    // }
    //
    // [TestMethod]
    // public void Create_RedirectsToCorrectAction_Index()
    // {
    //     //Arrange
    //     ItemsController controller = new ItemsController();
    //     RedirectToActionResult actionResult = controller.Create("Walk the dog") as RedirectToActionResult;
    //
    //     //Act
    //     string result = actionResult.ActionName;
    //
    //     //Assert
    //     Assert.AreEqual(result, "Index");
    // }
  }
}
