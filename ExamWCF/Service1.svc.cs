using ExamWCF.Data;
using ExamWCF.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace ExamWCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        private Context db;
        public Service1()
        {
            db = new Context();
        }

        public List<Employee> FindByDepartment(string department)
        {
            return db.Employees.Where(e => e.Department.Equals(department)).ToList();
        }
        public List<Employee> GetAll()
        {
            List<Employee> list = new List<Employee>();
            return db.Employees.ToList() == null ? null : db.Employees.ToList();
        }
        public Employee Save(Employee employee)
        {
            db.Employees.Add(employee);
            db.SaveChanges();
            return employee;
        }
    }
}
