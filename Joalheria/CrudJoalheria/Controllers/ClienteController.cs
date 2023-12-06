using CrudJoalheria.Data;
using CrudJoalheria.Models;
using Microsoft.AspNetCore.Mvc;

namespace CrudJoalheria.Controllers
{
    public class ClienteController : Controller
    {
        readonly private ApplicationDBContext _db;

        public ClienteController(ApplicationDBContext db)
        {
            _db = db;
        }


        public IActionResult Index()
        {
            IEnumerable<ClienteModel> Cliente = _db.Cliente;
            return View(Cliente);
        }
        public IActionResult Cadastrar()
        {
            return View();
        }
        [HttpPost]

        public IActionResult Cadastrar(ClienteModel clienteModel)
        {
            if (ModelState.IsValid)
            {
                _db.Cliente.Add(clienteModel);
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

            ClienteModel cliente = _db.Cliente.FirstOrDefault(x => x.Id == id);

            if (cliente == null)
            {
                return NotFound();
            }

            return View(cliente);
        }

        [HttpPost]
        public IActionResult Editar(ClienteModel cliente)
        {
            if (ModelState.IsValid)
            {
                _db.Cliente.Update(cliente);
                _db.SaveChanges();

                return RedirectToAction("Index");
            }
            return View(cliente);
        }

        [HttpGet]
        public IActionResult Excluir(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            ClienteModel cliente = _db.Cliente.FirstOrDefault(x => x.Id == id);

            if (cliente == null)
            {
                return NotFound();
            }

            return View(cliente);
        }

        [HttpPost]
        public IActionResult Excluir(ClienteModel cliente)
        {
            if (cliente == null)
            {
                return NotFound();
            }

            _db.Cliente.Remove(cliente);
            _db.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}







