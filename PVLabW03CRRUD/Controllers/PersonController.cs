using Microsoft.AspNetCore.Mvc;
using PVLabW03CRRUD.Models.Entities;
using PVLabW03CRRUD.Services;


namespace PVLabW03CRRUD.Controllers {
    public class PersonController : Controller {
        private readonly IPersonRepository _personRepo;

        public PersonController(IPersonRepository personRepo) {
            _personRepo = personRepo;
        }

        public IActionResult Index() {
            var model = _personRepo.ReadAll();
            return View(model);
        }

        public IActionResult Create() {
            return View();
        }


        [HttpPost]
        public IActionResult Create(Person newPerson) {
            if (ModelState.IsValid) {
                _personRepo.Create(newPerson);
                return RedirectToAction("Index");
            }
            return View(newPerson);
        }

        public IActionResult Details(int id) {
            var person = _personRepo.Read(id);
            if (person == null) {
                return RedirectToAction("Index");
            }
            return View(person);
        }
    }
}
