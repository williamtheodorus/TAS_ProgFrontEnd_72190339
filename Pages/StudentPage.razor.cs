using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TAS_ProgFrontEnd_72190339.Models;
using TAS_ProgFrontEnd_72190339.Services;
using Microsoft.AspNetCore.Components;

namespace TAS_ProgFrontEnd_72190339.Pages
{
    public partial class StudentPage
    {
        public IEnumerable<Student> Stud { get; set; }

        [Inject]
        public IStudentService StudentService { get; set; }

        protected override async Task OnInitializedAsync()
        {
            Stud = (await StudentService.GetAll()).ToList();
        }
    }
}