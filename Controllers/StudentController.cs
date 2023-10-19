using Models;
using Services;
using Microsoft.AspNetCore.Mvc;

namespace Controllers;

[ApiController]
[Route("[controller]")]
public class StudentController : ControllerBase
{
    public StudentController()
    {
    }

    [HttpGet]
    public ActionResult<List<Student>> GetAll() =>
        StudentService.GetAll();

    [HttpGet("{id}")]
    public ActionResult<Student> Get(int id)
    {
        var Student = StudentService.Get(id);

        if(Student == null)
            return NotFound();

        return Student;
    }

    [HttpPost]
    public IActionResult Create(Student Student)
    {
        StudentService.Add(Student);
        return CreatedAtAction(nameof(Get), new { id = Student.Id }, Student);
    }

    [HttpPut("{id}")]
    public IActionResult Update(int id, Student Student)
    {
        if (id != Student.Id)
        return BadRequest();

        var existingStudent = StudentService.Get(id);
        if(existingStudent is null)
            return NotFound();

        StudentService.Update(Student);

        return NoContent();
    }

    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        var Student = StudentService.Get(id);

        if (Student is null)
            return NotFound();

        StudentService.Delete(id);

        return NoContent();
    }
}
