using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TAS_ProgFrontEnd_72190339.Models;
using TAS_ProgFrontEnd_72190339.Services;
using Microsoft.AspNetCore.Components;

namespace TAS_ProgFrontEnd_72190339.Pages
{
    public partial class AddStudent
    {
        public Student Student { get; set; } = new Student();

        [Inject]
        public IStudentService StudentService { get; set; }

        [Inject]
        public NavigationManager NavigationManager { get; set; }

        protected async Task HandleValidSubmit(){
            var result = await StudentService.Add(Student);
            NavigationManager.NavigateTo("studentpage");
        }
    }
}