using Microsoft.AspNetCore.Mvc;

[Route("students")]
[ApiController]
public class StudentsController: ControllerBase
{   
    [HttpGet]
    [Route("all")]
    public ActionResult GetAllStudents()
    {
        var students = new string[] {"sangeer", "kaatsuro"};
        if (students == null)
        {
            return NotFound();
        }
        return Ok(students);
    }

}