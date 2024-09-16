﻿using EmployeeCRUD.Models;
using EmployeeCRUD.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeCRUD.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly EmployeeRepository emp;
        public EmployeeController(EmployeeRepository employeeRepository)
        {
            this.emp = employeeRepository;
        }

        [HttpGet]
        public async Task<ActionResult> EmployeeList()
        {
            var allEmployees = await emp.GetAllEmployees();
            return Ok(allEmployees);
        }

        public async Task<ActionResult> AddEmployee(Employee vm)
        {
            await emp.SaveEmployee(vm);
            return Ok(vm);
        }

    }
}
