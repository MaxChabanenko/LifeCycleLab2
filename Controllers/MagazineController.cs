using LifeCycleLab.Data;
using LifeCycleLab.Models;
using Microsoft.AspNetCore.Mvc;

namespace LifeCycleLab.Controllers
{
    public class MagazineController : Controller
    {
        private readonly DataContext dataContext;
        public MagazineController(DataContext dataContext)
        {
            this.dataContext = dataContext;
        }
        public ActionResult Index()
        {
            List<Magazine> magazines = dataContext.Magazines.ToList();
            return View(magazines);
        }

        [HttpGet]
        public IActionResult Create()
        {
            var articles = dataContext.Articles.ToList();

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
                dataContext.Magazines.Add(new Magazine()
                {
                    Title = viewModel.Title,
                    Issue = viewModel.Issue,
                    PublishDate = viewModel.PublishDate,
                    Articles = viewModel.Articles,
                    LastModifiedDate = DateTime.Now,
                });
            }
            return View();
        }
        [HttpGet]
        public IActionResult Edit(Guid id)
        {
            var magazine = dataContext.Magazines.FirstOrDefault(m => m.gid == id);
            return View(magazine);
        }
        [HttpPost]
        public IActionResult Edit(MagazineViewModel newMagazine)
        {
            dataContext.Magazines.Update(new Magazine()
            {
                gid = newMagazine.gid,
                Title = newMagazine.Title,
                Issue = newMagazine.Issue,
                Articles = newMagazine.Articles,
                LastModifiedDate = DateTime.Now,
            });
            return RedirectToAction("Index", "Magazine");
        }
    }
}
