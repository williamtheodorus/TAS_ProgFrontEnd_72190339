using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TAS_ProgFrontEnd_72190339.Models;

namespace TAS_ProgFrontEnd_72190339.Services
{
    public interface IEnrollmentService
    {
        Task<IEnumerable<Enrollment>> GetById(int id);
    }
}