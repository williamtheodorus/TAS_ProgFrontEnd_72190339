using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TAS_ProgFrontEnd_72190339.Models;
using TAS_ProgFrontEnd_72190339.Services;
using Microsoft.AspNetCore.Components;

namespace TAS_ProgFrontEnd_72190339.Pages
{
    public partial class DeleteStudent
    {
        [Parameter]
        public string id { get; set; }

        [Inject]
        public IStudentService StudentService { get; set; }

        [Inject]
        public NavigationManager NavigationManager { get; set; }

        protected override async Task OnInitializedAsync()
        {
            await StudentService.Delete(id);
            NavigationManager.NavigateTo("/studentpage");
        }
    }
}