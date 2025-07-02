using System.Collections.Generic;
using DevCard.Models;
using Microsoft.AspNetCore.Mvc;

namespace DevCard.ViewComponents
{
    public class LatestArticlesViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var articles = new List<Article>()
            {
                new Article(1, "Learning ASP.NET CORE MVC", "Perfect ASP.NET course", "blog-post-thumb-1.jpg"),
                new Article(2, "Learning Git/Github", "Perfect Git/Github course", "blog-post-thumb-2.jpg"),
                new Article(3, "Learning C#", "Perfect C# course", "blog-post-thumb-3.jpg"),
            };
            return View("_LatestArticles", articles);
        }
    }
}