using Microsoft.AspNetCore.Mvc;
using Projeto.Data;
using Projeto.Models;

namespace Projeto.Controllers
{
    public class CadastroController : Controller
    {
        readonly private ApplicationDbContext _db;
        public CadastroController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            IEnumerable<CadastroanimalModel> cadastro = _db.Cadastro;
            return View(cadastro);
        }

        public IActionResult Cadastrar()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Cadastrar(CadastroanimalModel cadastro)
        {
            if (ModelState.IsValid)
            {
                _db.Cadastro.Add(cadastro);
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

            CadastroanimalModel cadastro = _db.Cadastro.FirstOrDefault(x => x.Id == id);

            if (cadastro == null)
            {
                return NotFound();
            }

            return View(cadastro);
        }

        [HttpPost]
        public IActionResult Editar(CadastroanimalModel cadastro)
        {
            if (ModelState.IsValid)
            {
                _db.Cadastro.Update(cadastro);
                _db.SaveChanges();

                return RedirectToAction("Index");
            }
            return View(cadastro);
        }
        [HttpGet]

        public IActionResult Excluir(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            CadastroanimalModel cadastro = _db.Cadastro.FirstOrDefault(x => x.Id == id);

            if (cadastro == null)
            {
                return NotFound();
            }
            return View(cadastro);
        }
        [HttpPost]
        public IActionResult Excluir(CadastroanimalModel cadastro)
        {
            if (cadastro == null)
            {
                return NotFound();
            }
            _db.Cadastro.Remove(cadastro);
            _db.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}

