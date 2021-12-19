using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using TAS_ProgFrontEnd_72190339.Models;
using System.Text.Json;

namespace TAS_ProgFrontEnd_72190339.Services
{
    public class StudentService : IStudentService
    {
        private HttpClient _httpClient;

        public StudentService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IEnumerable<Student>> GetAll()
        {
            var keluars = await _httpClient.GetFromJsonAsync<IEnumerable<Student>>("api/Student");
            return keluars;
        }

        public async Task<Student> GetById(int id)
        {
            var keluar = await _httpClient.GetFromJsonAsync<Student>($"api/Student/{id}");
            return keluar;
        }

        public Task<Student> Add(Student Student)
        {
            throw new NotImplementedException();
        }

        public Task<Student> Update(int id, Student Student)
        {
            throw new NotImplementedException();
        }

        public Task<Student> Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}