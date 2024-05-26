using LifeCycleLab.Models;
using Microsoft.AspNetCore.Mvc;

namespace LifeCycleLab.Controllers
{
    public class ArticleController : Controller
    {
        public ActionResult Index()
        {
            List<Article> articles = new List<Article>
        {
            new Article
            {
                gid = Guid.NewGuid(),
                Title = "Understanding C#",
                Content = "Content of the article about understanding C#.",
                PublishDate = new DateTime(2020, 1, 10),
                LastModifiedDate = DateTime.Now,
                Author = new Author
                {
                    gid = Guid.NewGuid(),
                    FirstName = "John",
                    SecondName = "Michael",
                    LastName = "Doe",
                    BirthDate = new DateTime(1980, 5, 15),
                    LastModifiedDate = DateTime.Now,
                    Articles = null // Set to null to avoid circular reference
                }
            },
            new Article
            {
                gid = Guid.NewGuid(),
                Title = "Introduction to Python",
                Content = "Content of the article about introduction to Python.",
                PublishDate = new DateTime(2019, 7, 14),
                LastModifiedDate = DateTime.Now,
                Author = new Author
                {
                    gid = Guid.NewGuid(),
                    FirstName = "Jane",
                    SecondName = "Elizabeth",
                    LastName = "Smith",
                    BirthDate = new DateTime(1975, 8, 25),
                    LastModifiedDate = DateTime.Now,
                    Articles = null // Set to null to avoid circular reference
                }
            },
            new Article
            {
                gid = Guid.NewGuid(),
                Title = "Java Basics",
                Content = "Content of the article about Java basics.",
                PublishDate = new DateTime(2021, 6, 1),
                LastModifiedDate = DateTime.Now,
                Author = new Author
                {
                    gid = Guid.NewGuid(),
                    FirstName = "Emily",
                    SecondName = "Rose",
                    LastName = "Johnson",
                    BirthDate = new DateTime(1990, 2, 10),
                    LastModifiedDate = DateTime.Now,
                    Articles = null // Set to null to avoid circular reference
                }
            }
        };
            return View(articles);
        }

        [HttpGet]
        public IActionResult Create()
        {
            var authors = new List<Author>
        {
            new Author { gid = Guid.NewGuid(), FirstName = "John", SecondName = "Michael", LastName = "Doe", BirthDate = new DateTime(1980, 5, 15) },
            new Author { gid = Guid.NewGuid(), FirstName = "Jane", SecondName = "Elizabeth", LastName = "Smith", BirthDate = new DateTime(1975, 8, 25) },
            new Author { gid = Guid.NewGuid(), FirstName = "Emily", SecondName = "Rose", LastName = "Johnson", BirthDate = new DateTime(1990, 2, 10) }
        };

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
                return RedirectToAction("Index", "Article");
            }
            return View();
        }
        [HttpGet]
        public IActionResult Edit(Guid id)
        {
            var authors = new List<Author>
        {
            new Author { gid = Guid.NewGuid(), FirstName = "John", SecondName = "Michael", LastName = "Doe", BirthDate = new DateTime(1980, 5, 15) },
            new Author { gid = Guid.NewGuid(), FirstName = "Jane", SecondName = "Elizabeth", LastName = "Smith", BirthDate = new DateTime(1975, 8, 25) },
            new Author { gid = Guid.NewGuid(), FirstName = "Emily", SecondName = "Rose", LastName = "Johnson", BirthDate = new DateTime(1990, 2, 10) }
        };
            var article = new ArticleViewModel
            {
                Title = "Understanding C#",
                Content = "Content of the article about understanding C#.",
                Authors = authors,
                PublishDate = DateTime.Now,
                
            };
            return View(article);
        }
        [HttpPost]
        public IActionResult Edit(ArticleViewModel newArticle)
        {
            return RedirectToAction("Index", "Article");
        }
    }
}
