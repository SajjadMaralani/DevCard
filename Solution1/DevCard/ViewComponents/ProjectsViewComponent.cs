using System.Collections.Generic;
using DevCard.Models;
using Microsoft.AspNetCore.Mvc;


namespace DevCard.ViewComponents
{
    public class ProjectsViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var projects = new List<Project>()
            {
                new Project(1,"taxi", "requesting taxi online for inner city", "Atriya"),
                new Project(2,"fast food", "requesting fast food online for whole city", "Atriya"),
                new Project(3,"schools", "integrated school management system", "Atriya"),
                new Project(4,"spaceship", "NASA Spacecraft Management Program", "NASA"),
            };
            return View("_Projects", projects);
        }
    }
}