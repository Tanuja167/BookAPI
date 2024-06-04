using BookAPI.Models;
using BookAPI.Services;

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BookAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IStudentService service;
        public StudentController(IStudentService service)
        {
            this.service = service;
        }

        // GET: api/<BookController>
        [HttpGet]
        [Route("GetStudents")]
        public async Task<IActionResult> Get()
        {
            try
            {
                var list = await service.GetStudents();
                return Ok(list);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status204NoContent);
            }
        }

        // GET api/<BookController>/5
        [HttpGet]
        [Route("GetStudentById/{id}")]
        public async Task<IActionResult> Get(int id)
        {
            try
            {
                var model = await service.GetStudentById(id);
                return Ok(model);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        // POST api/<BookController>
        [HttpPost]
        [Route("AddStudent")]
        public async Task<IActionResult> Post([FromBody][Bind(include: "Name,Percentage,City")] Student student)
        {
            try
            {
                var result = await service.AddStudent(student);
                if (result >= 1)
                    return StatusCode(StatusCodes.Status201Created);
                else
                {
                    return StatusCode(StatusCodes.Status503ServiceUnavailable);
                }
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        // PUT api/<BookController>/5
        [HttpPut]
        [Route("UpdateStudent")]
        public async Task<IActionResult> Put([FromBody] Student student)
        {
            try
            {
                var result = await service.UpdateStudent(student);
                if (result >= 1)
                    return StatusCode(StatusCodes.Status201Created);
                else
                {
                    return StatusCode(StatusCodes.Status503ServiceUnavailable);
                }
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        // DELETE api/<BookController>/5
        [HttpDelete]
        [Route("DeleteStudent/{id}")]

        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                var result = await service.DeleteStudent(id);
                if (result >= 1)
                    return StatusCode(StatusCodes.Status201Created);
                else
                {
                    return StatusCode(StatusCodes.Status503ServiceUnavailable);
                }
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }
    }
}