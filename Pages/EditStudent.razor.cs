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
        [Parameter]
        public string id { get; set; }

        [Inject]
        public Student Student { get; set; } = new Student();
        public IStudentService StudentService { get; set; }

    }
}