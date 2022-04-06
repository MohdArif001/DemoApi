﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoApi.Models
{
    public class ApplicationDbContext:DbContext
    {
      public  DbSet<Employee> Employees { get; set; }
     protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(Connection.ConnectionStr);
        }
    }
}
