using LifeCycleLab.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LifeCycleLab.Controllers
{
    public class AuthorController : Controller
    {
        public ActionResult Index()
        {
            List<Author> authors = new List<Author>
        {
            new Author
            {
                gid = Guid.NewGuid(),
                FirstName = "John",
                SecondName = "Michael",
                LastName = "Doe",
                BirthDate = new DateTime(1980, 5, 15),
                LastModifiedDate = DateTime.Now,
                Articles = new List<Article>
                {
                    new Article
                    {
                        gid = Guid.NewGuid(),
                        Title = "Understanding C#",
                        Content = "Content of the article about understanding C#.",
                        PublishDate = new DateTime(2020, 1, 10),
                        LastModifiedDate = DateTime.Now,
                        Author = null // Set later to avoid circular reference
                    },
                    new Article
                    {
                        gid = Guid.NewGuid(),
                        Title = "Advanced C# Techniques",
                        Content = "Content of the article about advanced C# techniques.",
                        PublishDate = new DateTime(2021, 3, 22),
                        LastModifiedDate = DateTime.Now,
                        Author = null // Set later to avoid circular reference
                    }
                }
            },
            new Author
            {
                gid = Guid.NewGuid(),
                FirstName = "Jane",
                SecondName = "Elizabeth",
                LastName = "Smith",
                BirthDate = new DateTime(1975, 8, 25),
                LastModifiedDate = DateTime.Now,
                Articles = new List<Article>
                {
                    new Article
                    {
                        gid = Guid.NewGuid(),
                        Title = "Introduction to Python",
                        Content = "Content of the article about introduction to Python.",
                        PublishDate = new DateTime(2019, 7, 14),
                        LastModifiedDate = DateTime.Now,
                        Author = null // Set later to avoid circular reference
                    },
                    new Article
                    {
                        gid = Guid.NewGuid(),
                        Title = "Python Data Science",
                        Content = "Content of the article about Python for data science.",
                        PublishDate = new DateTime(2020, 11, 5),
                        LastModifiedDate = DateTime.Now,
                        Author = null // Set later to avoid circular reference
                    }
                }
            },
            new Author
            {
                gid = Guid.NewGuid(),
                FirstName = "Emily",
                SecondName = "Rose",
                LastName = "Johnson",
                BirthDate = new DateTime(1990, 2, 10),
                LastModifiedDate = DateTime.Now,
                Articles = new List<Article>
                {
                    new Article
                    {
                        gid = Guid.NewGuid(),
                        Title = "Java Basics",
                        Content = "Content of the article about Java basics.",
                        PublishDate = new DateTime(2021, 6, 1),
                        LastModifiedDate = DateTime.Now,
                        Author = null // Set later to avoid circular reference
                    },
                    new Article
                    {
                        gid = Guid.NewGuid(),
                        Title = "Spring Framework Overview",
                        Content = "Content of the article about Spring Framework.",
                        PublishDate = new DateTime(2022, 2, 28),
                        LastModifiedDate = DateTime.Now,
                        Author = null // Set later to avoid circular reference
                    }
                }
            }
        };
            return View(authors);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(AuthorViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("Index", "Author");
            }
            //save author ,
            //author = new Author(viewModel)
            //await dbContext.Authors.AddAsync(author);
            //await dbContext.SaveChanges();
            //бля может д
            return View();
        }
        [HttpGet]
        public IActionResult Edit(Guid id)
        {
            //await dbContext.Authors.FindAsync(id);
            var author = new Author
            {
                gid = Guid.NewGuid(),
                FirstName = "John",
                SecondName = "Michael",
                LastName = "Doe",
                BirthDate = new DateTime(1980, 5, 15),
                LastModifiedDate = DateTime.Now,
                Articles = new List<Article>
                {
                    new Article
                    {
                        gid = Guid.NewGuid(),
                        Title = "Understanding C#",
                        Content = "Content of the article about understanding C#.",
                        PublishDate = new DateTime(2020, 1, 10),
                        LastModifiedDate = DateTime.Now,
                        Author = null // Set later to avoid circular reference
                    },
                    new Article
                    {
                        gid = Guid.NewGuid(),
                        Title = "Advanced C# Techniques",
                        Content = "Content of the article about advanced C# techniques.",
                        PublishDate = new DateTime(2021, 3, 22),
                        LastModifiedDate = DateTime.Now,
                        Author = null // Set later to avoid circular reference
                    }
                }
            };
            return View(author);
        }
        [HttpPost]
        public IActionResult Edit(Author newAuthor)
        {
            //var author =  await dbContext.Authors.FindAsync(author.Id);
            //update with new values author = newAuthor
            //await dbContext.SaveChanges();

            return RedirectToAction("Index", "Author");
        }

    }
}
