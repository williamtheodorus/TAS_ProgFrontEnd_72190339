using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TAS_ProgFrontEnd_72190339.Models;
using TAS_ProgFrontEnd_72190339.Services;
using Microsoft.AspNetCore.Components;

namespace TAS_ProgFrontEnd_72190339.Pages
{
    public partial class DetailEnrollment
    {
        [Parameter]
        public string id { get; set; }

        [Inject]
        public IEnrollmentService EnrollmentService { get; set; }
        public List<Enrollment> Enrollment { get; set; } = new List<Enrollment>();

        protected override async Task OnInitializedAsync()
        {
            id = id ?? "1";
            Enrollment = (await EnrollmentService.GetById(int.Parse(id))).ToList();
        }
    }
}