using Microsoft.AspNetCore.Mvc;
using Projeto_CRUD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_CRUD.Controllers
{
    public class TipoExamesController : Controller
    {
        private readonly ApplicationContext db;

        public TipoExamesController(ApplicationContext db)
        {
            this.db = db;
        }

        //gets das páginas
        [HttpGet]
        public IActionResult CadastroTipoExame()
        {
            return View();
        }

        [HttpGet]
        public IActionResult UpdateTipoExame(long id)
        {
            var TipoExame = db.TipoExame.Find(id);

            if (TipoExame == null)
            {
                TempData["msg"] = "Tipo de Exame nulo!";
                return RedirectToAction("Index", "Home"); //não existe
            }

            ViewBag.TipoExame = TipoExame;
            return View();
        }

        //MÉTODO VERIFICADOR DE EXISTÊNCIA DE TIPOEXAME
        private bool TipoExameExists(long id)
        {
            return db.TipoExame.Any(e => e.id == id);
        }

        //CREATE
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CadastroTipoExame([Bind("id,tipo,descricao")] TipoExame TipoExame)
        {
            if (ModelState.IsValid)
            {
                db.Add(TipoExame);

                try
                {
                    db.SaveChanges();
                    return RedirectToAction("Index", "Home");
                }
                catch (Exception e)
                {
                    System.Diagnostics.Debug.WriteLine(e.StackTrace);
                }

            }
            return View(TipoExame);
        }

        //READ
        [HttpGet]
        public IActionResult TabelaTipoExames()
        {
            ViewBag.listaTipoExames = db.TipoExame.ToList();
            return View();
        }

        //UPDATE
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult UpdateTipoExame(long id, [Bind("id,tipo,descricao")] TipoExame TipoExame)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    db.Update(TipoExame);
                    db.SaveChanges();
                }
                catch (Exception e)
                {
                    if (!TipoExameExists(TipoExame.id))
                    {
                        TempData["msg"] = "Tipo de Exame não existe no banco de dados!";
                        System.Diagnostics.Debug.WriteLine(e.StackTrace);

                        return RedirectToAction("Index", "Home");
                    }
                    else
                    {
                        throw;
                    }
                }
            }

            return RedirectToAction("TabelaTipoExames", "TipoExames");
        }

        //DELETE
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteTipoExame(long id)
        {
            var TipoExame = db.TipoExame.Find(id);

            if (TipoExame == null)
            {
                TempData["msg"] = "TipoExame inválido!";
                return RedirectToAction("TabelaTipoExames", "TipoExames");
            }

            db.TipoExame.Remove(TipoExame);
            db.SaveChanges();
            return RedirectToAction("Index", "Home");
        }
    }
}
