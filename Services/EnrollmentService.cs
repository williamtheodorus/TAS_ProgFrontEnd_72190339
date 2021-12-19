using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using TAS_ProgFrontEnd_72190339.Models;

namespace TAS_ProgFrontEnd_72190339.Services
{
    public class EnrollmentService : IEnrollmentService
    {
        private HttpClient _httpClient;

        public EnrollmentService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<IEnumerable<Enrollment>> GetById(int id)
        {
            var tampil = await _httpClient.GetFromJsonAsync<IEnumerable<Enrollment>>($"/enrollment/{id}");
            return tampil;
        }
    }
}