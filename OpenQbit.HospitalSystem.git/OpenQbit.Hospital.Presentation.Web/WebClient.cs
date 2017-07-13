using OpenQbit.Hospital.Common.Models;
using OpenQbit.Hospital.Common.Models.Management;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Script.Serialization;

namespace OpenQbit.Hospital.Presentation.Web
{
    public class WebClient
    {
        private HttpClient _client;

        private JavaScriptSerializer _jsonSerializer = new JavaScriptSerializer();

        public WebClient()
        {
            _client = new HttpClient();
        }

        public async Task<Attendance> GetAttendance()
        {
            Attendance attendance = new Attendance();

            using (var response = await _client.GetAsync("http://localhost:55882/API/Attendance/GetAttendance"))
            {
                if (response.IsSuccessStatusCode)
                {
                    var jsonString = await response.Content.ReadAsStringAsync();
                    attendance = _jsonSerializer.Deserialize<Attendance>(jsonString);
                }
            }

            return attendance;
        }

        public async Task<Person> GetPerson()
        {
            Person person = new Person();

            using (var response = await _client.GetAsync("http://localhost:55882/API/Person/GetPerson"))
            {
                if (response.IsSuccessStatusCode)
                {
                    var jsonString = await response.Content.ReadAsStringAsync();
                    person = _jsonSerializer.Deserialize<Person>(jsonString);
                }
            }

            return person;
        }

        public async Task<Employee> GetEmployee()
        {
            Employee employee = new Employee();

            using (var response = await _client.GetAsync("http://localhost:55882/API/Employee/GetEmployee"))
            {
                if (response.IsSuccessStatusCode)
                {
                    var jsonString = await response.Content.ReadAsStringAsync();
                    employee = _jsonSerializer.Deserialize<Employee>(jsonString);
                }
            }

            return employee;
        }

        public async Task<Salary> GetSalary()
        {
            Salary salary = new Salary();

            using (var response = await _client.GetAsync("http://localhost:55882/API/Salary/GetSalary"))
            {
                if (response.IsSuccessStatusCode)
                {
                    var jsonString = await response.Content.ReadAsStringAsync();
                    salary = _jsonSerializer.Deserialize<Salary>(jsonString);
                }
            }

            return salary;
        }
    }
}