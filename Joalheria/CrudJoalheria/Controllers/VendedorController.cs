using CrudJoalheria.Data;
using CrudJoalheria.Models;
using Microsoft.AspNetCore.Mvc;

namespace CrudJoalheria.Controllers
{
    public class VendedorController : Controller
    {
        readonly private ApplicationDBContext _db;

        public VendedorController(ApplicationDBContext db)
        {
            _db = db;
        }


        public IActionResult Index()
        {
            IEnumerable<VendedorModel> Vendedor = _db.Vendedor;
            return View(Vendedor);
        }
        public IActionResult Cadastrar()
        {
            return View();
        }
        [HttpPost]

        public IActionResult Cadastrar(VendedorModel vendedorModel)
        {
            if (ModelState.IsValid)
            {
                _db.Vendedor.Add(vendedorModel);
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

            VendedorModel vendedor = _db.Vendedor.FirstOrDefault(x => x.Id == id);

            if (vendedor == null)
            {
                return NotFound();
            }

            return View(vendedor);
        }

        [HttpPost]
        public IActionResult Editar(VendedorModel vendedor)
        {
            if (ModelState.IsValid)
            {
                _db.Vendedor.Update(vendedor);
                _db.SaveChanges();

                return RedirectToAction("Index");
            }
            return View(vendedor);
        }

        [HttpGet]
        public IActionResult Excluir(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            VendedorModel vendedor = _db.Vendedor.FirstOrDefault(x => x.Id == id);

            if (vendedor == null)
            {
                return NotFound();
            }

            return View(vendedor);
        }

        [HttpPost]
        public IActionResult Excluir(VendedorModel vendedor)
        {
            if (vendedor == null)
            {
                return NotFound();
            }

            _db.Vendedor.Remove(vendedor);
            _db.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}







