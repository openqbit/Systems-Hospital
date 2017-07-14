using OpenQbit.Hospital.Common.Models;
using OpenQbit.Hospital.Service.Repository.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace OpenQbit.Hospital.Service.PayrollService
{
    public class PayrollService : IPayrollService
    {
        // Do not Make Any Change
        private HttpClient _client;

        private JavaScriptSerializer _jsonSerializer = new JavaScriptSerializer();

        public PayrollService()
        {
            _client = new HttpClient();
        }

        public async Task<Person> GetPerson()
        {

            Person person = new Person();

            using (var response = await _client.GetAsync("http://localhost:55882/API/Person/GetPerson"))
            {
                if (response.IsSuccessStatusCode)
                {
                    var jsonString = await response.Content.ReadAsStringAsync();
                    //  person = _jsonSerializer.Deserialize<Person>(jsonString);
                    person = Mappers.APIPersonMapper.MapPerson(_jsonSerializer.Deserialize<API.PersonAPIModal>(jsonString));
                }
            }

            return person;
        }

        public async Task<bool> WritePerson(Person person)
        {

            API.PersonAPIModal personAPI = Mappers.APIPersonMapper.MapApiPerson(person);
            string jsonString = "";  // ConvertToJsonQuaryString(personAPI);
            bool responseStat = false;

            // should use stringBuilder to combine strings
            using (var response = await _client.GetAsync("http://localhost:55882/API/Person/GetPerson" + jsonString))
            {
                if (response.IsSuccessStatusCode)
                {
                    var jsonStringResponse = await response.Content.ReadAsStringAsync();
                    //  person = _jsonSerializer.Deserialize<Person>(jsonString);
                    responseStat = _jsonSerializer.Deserialize<bool>(jsonString));
                }
            }

            return responseStat;
        }
    }
}
