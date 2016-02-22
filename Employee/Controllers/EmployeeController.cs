using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using Employee.Models;

namespace Employee.Controllers
{
    public class EmployeeController : ApiController
    {

        private EmployeeDetailEntities2 dbDetails = new EmployeeDetailEntities2();


        // GET: api/Employees/1
        /*[ResponseType(typeof(Employee.Models.Employee))]
        public IHttpActionResult GetEmployees(int EmployeeId)
        {
            Employee.Models.Employee employee = dbDetails.Employees.Find(EmployeeId);
            if (employee == null)
            {
                return NotFound();

            }
            return Ok(employee);
        }*/

        // GET: api/EmployeesAPI
        [HttpGet]
        [Route("P1/GetEmployees")]
        public IEnumerable<Employee.Models.Employee> GetEmployees()
         {
             return dbDetails.Employees;
         }


        // GET api/values/5
        [HttpGet]
        [Route("P1/GetEmployees/{id}")]
        public Employee.Models.Employee GetEmployees(int id)
        {
            Employee.Models.Employee employee = dbDetails.Employees.Find(id);
            return employee;
        }

      

        //POST api/<controller>
        [HttpPost]
        [Route("P1/PostEmployees")]
        public Boolean Post(Employee.Models.Employee emp)
        {
            if (!ModelState.IsValid)
            {
                return false;
            }

            dbDetails.Employees.Add(emp);
            dbDetails.SaveChanges();
            return true;
        }

        // PUT api/<controller>/5
        [HttpPost]
        [Route("P1/PutEmployees")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}