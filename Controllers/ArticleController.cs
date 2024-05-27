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
            //Виводить загальний список статей
            List<Article> articles = dataContext.Articles.ToList();
            return View(articles);
        }

        [HttpGet]
        public IActionResult Create()
        {
            //Відкриває вікно створення статті
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
            //Зберігає створену статтю
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
            //Відкриває вікно редагування статей
            var article = dataContext.Articles.FirstOrDefault(a => a.gid == id);
            return View(article);
        }
        [HttpPost]
        public IActionResult Edit(ArticleViewModel viewModel)
        {
            //Зберігає відредаговану статтю
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
