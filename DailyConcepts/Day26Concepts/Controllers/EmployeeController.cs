using Day26Concepts.Model;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Day26Concepts.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        //[HttpGet]
        //public string GetEmployee()
        //{
        //    return "All employees";
        //}

        //[HttpGet]
        //public EmployeeModel GetEmployees()
        //{
        //    return new EmployeeModel() { Id = 1, Name = "Employee 1" };
        //}

        //[HttpGet]
        //public List<EmployeeModel> GetListEmployees()
        //{
        //    return new List<EmployeeModel>() {
        //        new EmployeeModel() { Id = 1,Name = "Employee 1"},
        //        new EmployeeModel() { Id = 2,Name = "Employee 2"},};
        //}

        //[HttpGet]
        //public IEnumerable<EmployeeModel> GetIEnumerableEmployees()
        //{
        //    return new List<EmployeeModel>() {
        //        new EmployeeModel() { Id = 1,Name = "Employee 1"},
        //        new EmployeeModel() { Id = 2,Name = "Employee 2"},
        //        new EmployeeModel() { Id = 3,Name = "Employee 3"},};
        //}

        //public IAsyncEnumerator<EmployeeModel> GetAsyncEmployees()
        //{
        //    return new List<EmployeeModel>() {
        //        new EmployeeModel() { Id = 1,Name = "Employee 1"},
        //        new EmployeeModel() { Id = 2,Name = "Employee 2"},};
        //}

        [HttpGet("{id}")]
        public IActionResult GetEmployees(int id)
        {
            if (id == 0)
            {
                return NotFound();
            }
            return Ok(new List<EmployeeModel>() {
                new EmployeeModel() { Id = 1,Name = "Employee 1"},
                new EmployeeModel() { Id = 2,Name = "Employee 2"}}
            );
        }

        //[HttpGet("{id}/basic")]
        //public ActionResult<EmployeeModel> GetEmployeeBasicDetails(int id)
        //{
        //    if (id == 0)
        //    {
        //        return NotFound();
        //    }
        //    return new EmployeeModel() { Id = 1, Name = "Employee 6" };
        //}
    }
}
