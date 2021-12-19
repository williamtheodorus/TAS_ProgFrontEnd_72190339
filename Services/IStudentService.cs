using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TAS_ProgFrontEnd_72190339.Models;

namespace TAS_ProgFrontEnd_72190339.Services
{
    public interface IStudentService
    {
        Task<IEnumerable<Student>> GetAll();
        Task<Student> GetById(int id);
        Task<Student> Add(Student Student);
        Task<Student> Update(int id, Student Student);
        Task<Student> Delete(int id);
    }
}