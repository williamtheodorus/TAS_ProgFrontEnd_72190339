using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TAS_ProgFrontEnd_72190339.Models;
using TAS_ProgFrontEnd_72190339.Services;
using Microsoft.AspNetCore.Components;

namespace TAS_ProgFrontEnd_72190339.Pages
{
    public partial class EditStudent
    {
        public Student Student { get; set; } = new Student();
        [Parameter]
        public string id { get; set; }

        [Inject]
        public IStudentService StudentService { get; set; }

        [Inject]
        public NavigationManager NavigationManager { get; set; }

        protected override async Task OnInitializedAsync()
        {
            Student = await StudentService.GetById(id);
        }

        protected async Task HandleValidSubmit(){
            var result = await StudentService.Update(Student);
            NavigationManager.NavigateTo("studentpage");
        }
    }
}