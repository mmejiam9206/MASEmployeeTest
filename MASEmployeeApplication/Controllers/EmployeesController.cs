using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using MASEmployeeApplication.Models;

namespace MASEmployeeApplication.Controllers
{
    public class EmployeesController : ApiController
    {
        private HttpEmployeeClient client;
        private EmployeeFactory factory;
        public EmployeesController()
        {
            client = new HttpEmployeeClient();
            factory = new EmployeeFactory();
        }

        // GET: api/Employees
        public async Task<String> Get()
        {
            string employeesJson = await client.GetEmployees();
            List<AbstractEmployee> employees = new List<AbstractEmployee>();

            List<RawEmployee> rawEmployees = JsonConvert.DeserializeObject<List<RawEmployee>>(employeesJson);

            foreach (RawEmployee rawEmployee in rawEmployees)
            {
                AbstractEmployee employee = factory.BuildEmployee(rawEmployee);

                employees.Add(employee);

            }

            return JsonConvert.SerializeObject(employees);
        }

        // GET: api/Employees/5
        public async Task<String> Get(int id)
        {
            string employeesJson = await client.GetEmployees();
            List<AbstractEmployee> employees = new List<AbstractEmployee>();

            List<RawEmployee> rawEmployees = JsonConvert.DeserializeObject<List<RawEmployee>>(employeesJson);

            RawEmployee rawEmployee = (from rawEmp in rawEmployees where rawEmp.Id == id select rawEmp).FirstOrDefault();

            if (rawEmployee != null)
            {
                AbstractEmployee employee = factory.BuildEmployee(rawEmployee);
                employees.Add(employee);
            }
            return JsonConvert.SerializeObject(employees);

        }

        // POST: api/Employees
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Employees/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Employees/5
        public void Delete(int id)
        {
        }
    }
}
