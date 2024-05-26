using LifeCycleLab.Models;
using Microsoft.AspNetCore.Mvc;

namespace LifeCycleLab.Controllers
{
    public class MagazineController : Controller
    {
        public ActionResult Index()
        {
            List<Magazine> magazines = new List<Magazine>
        {
            new Magazine
            {
                gid = Guid.NewGuid(),
                Title = "Tech Trends",
                Issue = "Spring 2024",
                PublishDate = new DateTime(2024, 3, 15),
                LastModifiedDate = DateTime.Now,
                Articles = new List<Article>
                {
                    new Article
                    {
                        gid = Guid.NewGuid(),
                        Title = "Future of Artificial Intelligence",
                        Content = "Content of the article about the future of AI.",
                        PublishDate = new DateTime(2024, 3, 10),
                        LastModifiedDate = DateTime.Now,
                        Author = new Author
                        {
                            gid = Guid.NewGuid(),
                            FirstName = "Alex",
                            SecondName = "John",
                            LastName = "Smith",
                            BirthDate = new DateTime(1985, 7, 20),
                            LastModifiedDate = DateTime.Now,
                            Articles = null // Set to null to avoid circular reference
                        }
                    },
                    new Article
                    {
                        gid = Guid.NewGuid(),
                        Title = "Blockchain Technology Explained",
                        Content = "Content of the article about blockchain technology.",
                        PublishDate = new DateTime(2024, 3, 12),
                        LastModifiedDate = DateTime.Now,
                        Author = new Author
                        {
                            gid = Guid.NewGuid(),
                            FirstName = "Emily",
                            SecondName = "Rose",
                            LastName = "Johnson",
                            BirthDate = new DateTime(1990, 4, 5),
                            LastModifiedDate = DateTime.Now,
                            Articles = null // Set to null to avoid circular reference
                        }
                    }
                }
            },
            new Magazine
            {
                gid = Guid.NewGuid(),
                Title = "Science Insights",
                Issue = "Summer 2024",
                PublishDate = new DateTime(2024, 6, 15),
                LastModifiedDate = DateTime.Now,
                Articles = new List<Article>
                {
                    new Article
                    {
                        gid = Guid.NewGuid(),
                        Title = "Exploring Space Travel",
                        Content = "Content of the article about space exploration.",
                        PublishDate = new DateTime(2024, 6, 5),
                        LastModifiedDate = DateTime.Now,
                        Author = new Author
                        {
                            gid = Guid.NewGuid(),
                            FirstName = "Michael",
                            SecondName = "David",
                            LastName = "Brown",
                            BirthDate = new DateTime(1978, 10, 15),
                            LastModifiedDate = DateTime.Now,
                            Articles = null // Set to null to avoid circular reference
                        }
                    }
                }
            },
            new Magazine
            {
                gid = Guid.NewGuid(),
                Title = "Health & Wellness",
                Issue = "Fall 2024",
                PublishDate = new DateTime(2024, 9, 15),
                LastModifiedDate = DateTime.Now,
                Articles = new List<Article>
                {
                    new Article
                    {
                        gid = Guid.NewGuid(),
                        Title = "Nutrition and Fitness Tips",
                        Content = "Content of the article about nutrition and fitness.",
                        PublishDate = new DateTime(2024, 9, 10),
                        LastModifiedDate = DateTime.Now,
                        Author = new Author
                        {
                            gid = Guid.NewGuid(),
                            FirstName = "Sophia",
                            SecondName = "Marie",
                            LastName = "Wilson",
                            BirthDate = new DateTime(1989, 2, 28),
                            LastModifiedDate = DateTime.Now,
                            Articles = null // Set to null to avoid circular reference
                        }
                    }
                }
            }
        };
            return View(magazines);
        }

        [HttpGet]
        public IActionResult Create()
        {
            var articles = new List<Article>
        {
            new Article
            {
                gid = Guid.NewGuid(),
                Title = "Exploring Artificial Intelligence",
                Content = "Content of the article about exploring AI.",
                PublishDate = new DateTime(2024, 3, 10),
                LastModifiedDate = DateTime.Now,
                Author = new Author
                {
                    gid = Guid.NewGuid(),
                    FirstName = "Alex",
                    SecondName = "John",
                    LastName = "Smith",
                    BirthDate = new DateTime(1985, 7, 20),
                    LastModifiedDate = DateTime.Now,
                    Articles = null // Set to null to avoid circular reference
                }
            },
            new Article
            {
                gid = Guid.NewGuid(),
                Title = "Understanding Blockchain Technology",
                Content = "Content of the article about understanding blockchain.",
                PublishDate = new DateTime(2024, 3, 12),
                LastModifiedDate = DateTime.Now,
                Author = new Author
                {
                    gid = Guid.NewGuid(),
                    FirstName = "Emily",
                    SecondName = "Rose",
                    LastName = "Johnson",
                    BirthDate = new DateTime(1990, 4, 5),
                    LastModifiedDate = DateTime.Now,
                    Articles = null // Set to null to avoid circular reference
                }
            },
            new Article
            {
                gid = Guid.NewGuid(),
                Title = "Future of Space Travel",
                Content = "Content of the article about the future of space travel.",
                PublishDate = new DateTime(2024, 6, 5),
                LastModifiedDate = DateTime.Now,
                Author = new Author
                {
                    gid = Guid.NewGuid(),
                    FirstName = "Michael",
                    SecondName = "David",
                    LastName = "Brown",
                    BirthDate = new DateTime(1978, 10, 15),
                    LastModifiedDate = DateTime.Now,
                    Articles = null // Set to null to avoid circular reference
                }
            }
        };

            var viewModel = new MagazineViewModel
            {
                Articles = articles,
                PublishDate = DateTime.Now,
            };
            return View(viewModel);
        }
        [HttpPost]
        public IActionResult Create(MagazineViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("Index", "Magazine");
            }
            return View();
        }
        [HttpGet]
        public IActionResult Edit(Guid id)
        {
            var magazine  =new MagazineViewModel
            {
                Title = "Tech Trends",
                Issue = "Spring 2024",
                PublishDate = new DateTime(2024, 3, 15),
                Articles = new List<Article>
                {
                    new Article
                    {
                        gid = Guid.NewGuid(),
                        Title = "Future of Artificial Intelligence",
                        Content = "Content of the article about the future of AI.",
                        PublishDate = new DateTime(2024, 3, 10),
                        LastModifiedDate = DateTime.Now,
                        Author = new Author
                        {
                            gid = Guid.NewGuid(),
                            FirstName = "Alex",
                            SecondName = "John",
                            LastName = "Smith",
                            BirthDate = new DateTime(1985, 7, 20),
                            LastModifiedDate = DateTime.Now,
                            Articles = null // Set to null to avoid circular reference
                        }
                    },
                    new Article
                    {
                        gid = Guid.NewGuid(),
                        Title = "Blockchain Technology Explained",
                        Content = "Content of the article about blockchain technology.",
                        PublishDate = new DateTime(2024, 3, 12),
                        LastModifiedDate = DateTime.Now,
                        Author = new Author
                        {
                            gid = Guid.NewGuid(),
                            FirstName = "Emily",
                            SecondName = "Rose",
                            LastName = "Johnson",
                            BirthDate = new DateTime(1990, 4, 5),
                            LastModifiedDate = DateTime.Now,
                            Articles = null // Set to null to avoid circular reference
                        }
                    }
                }
            };
            return View(magazine);
        }
        [HttpPost]
        public IActionResult Edit(MagazineViewModel newArticle)
        {
            return RedirectToAction("Index", "Magazine");
        }
    }
}
