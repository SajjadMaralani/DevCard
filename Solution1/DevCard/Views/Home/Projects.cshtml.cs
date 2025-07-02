using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using DevCard.Data;
using DevCard.Models;

namespace DevCard.Views.Home
{
    public class ProjectsModel : PageModel
    {
        private readonly DevCard.Data.DevCardContext _context;

        public ProjectsModel(DevCard.Data.DevCardContext context)
        {
            _context = context;
        }

        public IList<Project> Project { get;set; }

        public async Task OnGetAsync()
        {
            Project = await _context.Project.ToListAsync();
        }
    }
}
