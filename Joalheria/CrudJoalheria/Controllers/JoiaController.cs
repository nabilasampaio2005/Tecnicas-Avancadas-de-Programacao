using CrudJoalheria.Data;
using CrudJoalheria.Models;
using Microsoft.AspNetCore.Mvc;

namespace CrudJoalheria.Controllers
{
	public class JoiaController : Controller
	{
		readonly private ApplicationDBContext _db;

		public JoiaController(ApplicationDBContext db)
		{
			_db = db;
		}


		public IActionResult Index()
		{
			IEnumerable<JoiaModel> Joia = _db.Joia;
			return View(Joia);
		}
		public IActionResult Cadastrar()
		{
			return View();
		}
		[HttpPost]

		public IActionResult Cadastrar(JoiaModel joiaModel) {
			if (ModelState.IsValid)
			{
				_db.Joia.Add(joiaModel);
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

			JoiaModel joia = _db.Joia.FirstOrDefault(x => x.Id == id);

			if (joia == null)
			{
				return NotFound();
			}

			return View(joia);
		}

		[HttpPost]
		public IActionResult Editar(JoiaModel joia)
		{
			if (ModelState.IsValid)
			{
				_db.Joia.Update(joia);
				_db.SaveChanges();

				return RedirectToAction("Index");
			}
			return View(joia);
		}

		[HttpGet]
		public IActionResult Excluir(int? id)
		{
			if (id == null || id == 0)
			{
				return NotFound();
			}

			JoiaModel joia = _db.Joia.FirstOrDefault(x => x.Id == id);

			if (joia == null)
			{
				return NotFound();
			}

			return View(joia);
		}

		[HttpPost]
		public IActionResult Excluir(JoiaModel joia)
		{
			if (joia == null)
			{
				return NotFound();
			}

			_db.Joia.Remove(joia);
			_db.SaveChanges();

			return RedirectToAction("Index");
		}
	}
}







