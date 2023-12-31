﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
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
        [ActionName("GetAllEmployee")]
        public IEnumerable<Employee> Get()
        {
            return this.employeeDBContext.employees.ToList();

        }

        // GET api/values/5        
        [ActionName("GetEmployeeById")]
        public async Task<Employee> Get(int id)
        {
            return await this.employeeDBContext.employees.Where(x => x.Id == id).FirstAsync();
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
        [ActionName("DeleteEmployeeById")]
        public void Delete(int id)
        {
            Employee emp = this.employeeDBContext.employees.Where(x => x.Id == id).First();
            this.employeeDBContext.employees.Remove(emp);
            this.employeeDBContext.SaveChanges();
        }
    }
}
