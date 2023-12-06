using Microsoft.AspNetCore.Mvc;
using petshop.Data;
using petshop.Models;

namespace petshop.Controllers
{
    public class PetController : Controller
    {
            readonly private ApplicationDBContext _db;

            public PetController(ApplicationDBContext db)
            {
                _db = db;
            }


            public IActionResult Index()
            {
                IEnumerable<PetModel> Pet = _db.Pet;
                return View(Pet);
            }
            public IActionResult Cadastrar()
            {
                return View();
            }
            [HttpPost]

            public IActionResult Cadastrar(PetModel PetModel)
            {
                if (ModelState.IsValid)
                {
                    _db.Pet.Add(PetModel);
                    _db.SaveChanges();

                    return RedirectToAction("Index");
                }
                return View();
            }


            [HttpGet]
            public IActionResult Editar(int? id)
            {
                if (id == null || id == 0)
                {
                    return NotFound();
                }

                PetModel Pet = _db.Pet.FirstOrDefault(x => x.Id == id);

                if (Pet == null)
                {
                    return NotFound();
                }

                return View(Pet);
            }

            [HttpPost]
            public IActionResult Editar(PetModel Pet)
            {
                if (ModelState.IsValid)
                {
                    _db.Pet.Update(Pet);
                    _db.SaveChanges();

                    return RedirectToAction("Index");
                }
                return View(Pet);
            }

            [HttpGet]
            public IActionResult Excluir(int? id)
            {
                if (id == null || id == 0)
                {
                    return NotFound();
                }

                PetModel Pet = _db.Pet.FirstOrDefault(x => x.Id == id);

                if (Pet == null)
                {
                    return NotFound();
                }

                return View(Pet);
            }

            [HttpPost]
            public IActionResult Excluir(PetModel Pet)
            {
                if (Pet == null)
                {
                    return NotFound();
                }

                _db.Pet.Remove(Pet);
                _db.SaveChanges();

                return RedirectToAction("Index");
            }
        }
    }
