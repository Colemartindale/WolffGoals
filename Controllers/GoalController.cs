using WolffGoals.Models;
using WolffGoals.Services;
using Microsoft.AspNetCore.Mvc;

namespace WolffGoals.Controllers;

[ApiController]
[Route("[controller]")]
public class GoalController : ControllerBase
{
    public GoalController()
    {
    }

    // GET all action
    [HttpGet]
    public ActionResult<List<Goal>> GetAll() => 
        GoalService.GetAll();

    //GET by id action
    [HttpGet("{id}")]
    public ActionResult<Goal> Get(int id)
    {
        var goal = GoalService.Get(id);

        if(goal == null)
            return NotFound();

        return goal;
    }

    //POST action
    [HttpPost]
    public IActionResult Create(Goal goal)
    {
        GoalService.Add(goal);
        return CreatedAtAction(nameof(Create), new { id = goal.Id, dateCreated = goal.DateCreated }, goal);
    }

    //PUT action
    [HttpPut("{id}")]
    public IActionResult Update(int id, Goal goal)
    {
        if (id != goal.Id)
            return BadRequest();
        
        var existingGoal = GoalService.Get(id);
        if(existingGoal is null)
            return NotFound();
        
        GoalService.Update(goal);

        return NoContent();
    }

    //DELETE action
    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        var goal = GoalService.Get(id);

        if(goal is null)
            return NotFound();
        
        GoalService.Delete(id);

        return NoContent();
    }
}

//use for testing in HTTPREPL

//POST
//"{"content": "", "isComplete": false}"

//PUT
//"{"id": ,"content": "", "isComplete": true}"