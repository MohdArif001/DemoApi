using DemoApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoApi.Repositery.Interface
{
    public interface IEmployee
    {
         List<Employee> GetEmployees();
        Employee PostEmployees(Employee employee);
        Employee GetEmployeeById(int id);
    }
}
