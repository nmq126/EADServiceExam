using ExamWCF.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace ExamWCF.Data
{
    public class Context : DbContext
    {
        public Context() : base("name=ExamDB")
        {
        }
        public DbSet<Employee> Employees { get; set; }
    }
}