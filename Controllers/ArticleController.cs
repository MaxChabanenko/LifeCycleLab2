using LifeCycleLab.Data;
using LifeCycleLab.Models;
using Microsoft.AspNetCore.Mvc;

namespace LifeCycleLab.Controllers
{
    public class ArticleController : Controller
    {
        private readonly DataContext dataContext;
        public ArticleController(DataContext dataContext)
        {
            this.dataContext = dataContext;
        }
        public ActionResult Index()
        {
            List<Article> articles = dataContext.Articles.ToList();
            return View(articles);
        }

        [HttpGet]
        public IActionResult Create()
        {
            var authors = dataContext.Authors.ToList();

            var viewModel = new ArticleViewModel
            {
                Authors = authors,
                PublishDate = DateTime.Now,
            };
            return View(viewModel);
        }
        [HttpPost]
        public IActionResult Create(ArticleViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                dataContext.Articles.Add(new Article()
                {
                    Title = viewModel.Title,
                    PublishDate = viewModel.PublishDate,
                    Content = viewModel.Content,
                    Authors = viewModel.Authors,
                    LastModifiedDate = DateTime.Now,
                });
            }
            return View();
        }
        [HttpGet]
        public IActionResult Edit(Guid id)
        {
            var article = dataContext.Articles.FirstOrDefault(a => a.gid == id);
            return View(article);
        }
        [HttpPost]
        public IActionResult Edit(ArticleViewModel viewModel)
        {
            dataContext.Articles.Update(new Article()
            {
                Title = viewModel.Title,
                PublishDate = viewModel.PublishDate,
                Content = viewModel.Content,
                Authors = viewModel.Authors,
                LastModifiedDate = DateTime.Now,
            });
            return RedirectToAction("Index", "Article");
        }
    }
}
