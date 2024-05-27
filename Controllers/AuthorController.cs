using LifeCycleLab.Data;
using LifeCycleLab.Models;
using Microsoft.AspNetCore.Mvc;

namespace LifeCycleLab.Controllers
{
    public class AuthorController : Controller
    {
        private readonly DataContext dataContext;
        public AuthorController(DataContext dataContext)
        {
            this.dataContext = dataContext;
        }
        public ActionResult Index()
        {
            //Виводить усіх авторів
            List<Author> authors = dataContext.Authors.ToList();
            return View(authors);
        }

        [HttpGet]
        public IActionResult Create()
        {
            //Відкриває вікно створення автора
            return View();
        }
        [HttpPost]
        public IActionResult Create(AuthorViewModel viewModel)
        {
            //Зберігає створенного автора
            if (ModelState.IsValid)
            {
                dataContext.Authors.Add(new Author()
                {
                    FirstName = viewModel.FirstName,
                    SecondName = viewModel.SecondName,
                    LastName = viewModel.LastName,
                    BirthDate = viewModel.BirthDate,
                    LastModifiedDate = DateTime.Now
                });
            }
            return View();
        }
        [HttpGet]
        public IActionResult Edit(Guid id)
        {
            //Відкриває вікно редагування автора
            var author = dataContext.Authors.FirstOrDefault(a => a.gid == id);
            return View(author);
        }
        [HttpPost]
        public IActionResult Edit(Author newAuthor)
        {
            //Зберігає відредагованого автора
            dataContext.Authors.Update(newAuthor);

            return RedirectToAction("Index", "Author");
        }

    }
}
