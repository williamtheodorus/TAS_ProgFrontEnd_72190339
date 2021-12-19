using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TAS_ProgFrontEnd_72190339.Models;
using TAS_ProgFrontEnd_72190339.Services;
using Microsoft.AspNetCore.Components;

namespace TAS_ProgFrontEnd_72190339.Pages
{
    public partial class DetailStudent
    {
        [Parameter]
        public string id { get; set; }

        [Inject]
        public IStudentService StudentService { get; set; }
        public Student Student { get; set; } = new Student();

        protected override async Task OnInitializedAsync()
        {
            id = id ?? "1";
            Student = await StudentService.GetById(int.Parse(id));
        }
    }
}