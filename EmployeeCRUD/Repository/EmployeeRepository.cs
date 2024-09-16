﻿using EmployeeCRUD.Data;
using EmployeeCRUD.Models;
using Microsoft.EntityFrameworkCore;

namespace EmployeeCRUD.Repository
{
    public class EmployeeRepository
    {
        private readonly AppDbContext db;
        public EmployeeRepository(AppDbContext dbContext)
        {
            this.db = dbContext;
            
        }
        public async Task<List<Employee>> GetAllEmployees()
        {
            return await db.Employees.ToListAsync();
        }

        public async Task SaveEmployee(Employee emp)
        {
            await db.Employees.AddAsync(emp);
            await db.SaveChangesAsync();
        }
    }
}
