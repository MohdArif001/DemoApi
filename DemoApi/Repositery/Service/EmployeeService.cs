using DemoApi.Models;
using DemoApi.Repositery.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoApi.Repositery.Service
{
    public class EmployeeService:IEmployee
    {
        private readonly ApplicationDbContext dbContext;

        public EmployeeService(ApplicationDbContext _dbContext)
        {
            dbContext = _dbContext;
        }

        public Employee GetEmployeeById(int id)
        {
            var emp = dbContext.Employees.SingleOrDefault(e => e.Id == id);
            return emp;
        }

        public List<Employee> GetEmployees()
        {
            return dbContext.Employees.ToList();
            
        }

        public Employee PostEmployees(Employee employee)
        {
            dbContext.Employees.Add(employee);
            dbContext.SaveChanges();
            return employee;
        }
    }
}
