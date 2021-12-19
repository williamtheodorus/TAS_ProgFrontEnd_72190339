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

        public async Task<Student> GetById(string id)
        {
            var keluar = await _httpClient.GetFromJsonAsync<Student>($"api/Student/{id}");
            return keluar;
        }

        public Task<Student> Add(Student Student)
        {
            throw new NotImplementedException();
        }

        public async Task<Student> Update(Student Student)
        {
            var response = await _httpClient.PutAsJsonAsync("api/Student/",Student);
            if(response.IsSuccessStatusCode){
                return await JsonSerializer.DeserializeAsync<Student>(await response.Content.ReadAsStreamAsync());
            }else{
                throw new Exception("Gagal Update Employee");
            }
        }

        public async Task Delete(string id)
        {
            await _httpClient.DeleteAsync($"api/Student/{id}");
        }
    }
}