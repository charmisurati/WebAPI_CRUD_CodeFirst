using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPI_CRUD_Methods.DBContext;
using WebAPI_CRUD_Methods.Models;

namespace WebAPI_CRUD_Methods.Controllers
{
    public class ValuesController : ApiController
    {
        private readonly EmployeeDBContext employeeDBContext;

        public ValuesController()
        {
            this.employeeDBContext = new EmployeeDBContext();
        }

        // GET api/values
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        [ActionName("CreateEmployee")]
        public int CreateEmployee(Employee emp)
        {
            this.employeeDBContext.employees.Add(emp);
            this.employeeDBContext.SaveChanges();
            return emp.Id;
        }

        // PUT api/values/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
