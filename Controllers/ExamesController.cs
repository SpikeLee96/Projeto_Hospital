using Microsoft.AspNetCore.Mvc;
using Projeto_CRUD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_CRUD.Controllers
{
    public class ExamesController : Controller
    {
        private readonly ApplicationContext db;

        public ExamesController(ApplicationContext db)
        {
            this.db = db;
        }

        //gets das páginas
        [HttpGet]
        public IActionResult CadastroExame()
        {
            ViewBag.tiposExame = db.TipoExame.ToList();
            return View();
        }

        [HttpGet]
        public IActionResult UpdateExame(long id)
        {
            var Exame = db.Exame.Find(id);

            if (Exame == null)
            {
                TempData["msg"] = "Exame nulo!";
                return RedirectToAction("Index", "Home"); //não existe
            }

            ViewBag.tiposExame = db.TipoExame.ToList();
            ViewBag.listaExames = db.Exame.ToList();
            ViewBag.Exame = Exame;
            return View();
        }

        //MÉTODO VERIFICADOR DE EXISTÊNCIA DE EXAME
        private bool ExameExists(long id)
        {
            return db.Exame.Any(e => e.id == id);
        }

        //CREATE
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CadastroExame([Bind("id,nomeExame,observacoes,TipoExameId")] Exame Exame)
        {

            //associar com id do tipo do exame passado via formulário

            if (ModelState.IsValid)
            {
                db.Add(Exame);

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
            return View(Exame);
        }

        //READ
        [HttpGet]
        public IActionResult TabelaExames()
        {
            System.Diagnostics.Debug.WriteLine(db.Exame);
            if(db.Exame == null)
            {
                TempData["msg"] = "exame nulo";
            }

            ViewBag.listaTipoExames = db.TipoExame.ToList();
            ViewBag.listaExames = db.Exame.ToList();
            return View();
        }

        //UPDATE
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult UpdateExame(long id, [Bind("id,nomeExame,observacoes,TipoExameId")] Exame Exame)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    db.Update(Exame);
                    db.SaveChanges();
                }
                catch (Exception e)
                {
                    if (!ExameExists(Exame.id))
                    {
                        TempData["msg"] = "Exame não existe no banco de dados!";
                        System.Diagnostics.Debug.WriteLine(e.StackTrace);

                        return RedirectToAction("Index", "Home");
                    }
                    else
                    {
                        throw;
                    }
                }
            }

            return RedirectToAction("TabelaExames", "Exames");
        }

        //DELETE
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteExame(long id)
        {
            var Exame = db.Exame.Find(id);

            if (Exame == null)
            {
                TempData["msg"] = "Exame inválido!";
                return RedirectToAction("TabelaExames", "Exames");
            }

            db.Exame.Remove(Exame);
            db.SaveChanges();
            return RedirectToAction("Index", "Home");
        }


    }
}

