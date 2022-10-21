using Xunit;
using WolffGoals.Controllers;
using WolffGoals.Models;
using Microsoft.AspNetCore.Mvc;

public class testclass 
{
    //SIMPLE MATH UNIT TEST (I did this to better understand how unit tests work)
    [Fact]
    public void PassingMultiplyTest()
    {
        Assert.Equal(4, GoalController.Multiply(2, 2));
    }

    [Fact]
    public void FailingMultiplyTest()
    {
        Assert.NotEqual(5, GoalController.Multiply(2, 2));
    }

    //GET BY ID TEST
    [Fact]
    public void GetGoalById_OkResult()
    {
        var goalId = 2;
        var controller = new GoalController();
        var goal = controller.Get(goalId);
        Assert.IsType<Microsoft.AspNetCore.Mvc.ActionResult<Goal>>(goal);
    }
}