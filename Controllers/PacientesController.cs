using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Projeto_CRUD;
using Projeto_CRUD.Models;

namespace Projeto_CRUD.Controllers
{
    public class PacientesController : Controller
    {
        private readonly ApplicationContext db;

        public PacientesController(ApplicationContext db)
        {
            this.db = db;
        }

        //gets das páginas
        [HttpGet]
        public IActionResult CadastroPaciente()
        {
            return View();
        }

        [HttpGet]
        public IActionResult UpdatePaciente(long id)
        {
            var paciente = db.Paciente.Find(id);

            if (paciente == null)
            {
                TempData["msg"] = "Paciente nulo!";
                return RedirectToAction("Index", "Home"); //não existe
            }

            ViewBag.paciente = paciente;
            return View();
        }

        //MÉTODO VERIFICADOR DE EXISTÊNCIA DE PACIENTE
        private bool PacienteExists(long id)
        {
            return db.Paciente.Any(e => e.id == id);
        }

        //CREATE
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CadastroPaciente([Bind("id,nome,CPF,data,sexo,telefone,email")] Paciente paciente)
        {
            if (ModelState.IsValid)
            {
                db.Add(paciente);

                try
                {
                    db.SaveChanges();
                    return RedirectToAction("Index", "Home");
                } catch (Exception e)
                {
                    System.Diagnostics.Debug.WriteLine(e.StackTrace);
                }
                
            } 
            return View(paciente);
        }

        //READ
        [HttpGet]
        public IActionResult TabelaPacientes()
        {
            ViewBag.listaPacientes = db.Paciente.ToList();
            return View();
        }

        //UPDATE
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult UpdatePaciente(long id, [Bind("id,nome,CPF,data,sexo,telefone,email")] Paciente paciente)
        {

            if (ModelState.IsValid)
            {
                try
                {
                    db.Update(paciente);
                    db.SaveChanges();
                }
                catch (Exception e)
                {
                    if (!PacienteExists(paciente.id))
                    {
                        TempData["msg"] = "Paciente não existe no banco de dados!";
                        System.Diagnostics.Debug.WriteLine(e.StackTrace);

                        return RedirectToAction("Index", "Home");
                    }
                    else
                    {
                        throw;
                    }
                }
            }

            return RedirectToAction("TabelaPacientes", "Pacientes");
        }

        //DELETE
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeletePaciente(long id)
        {
            var paciente = db.Paciente.Find(id);

            if (paciente == null)
            {
                TempData["msg"] = "Paciente inválido!";
                return RedirectToAction("TabelaPacientes", "Pacientes");
            }

            db.Paciente.Remove(paciente);
            db.SaveChanges();
            return RedirectToAction("Index", "Home");
        }

        
    }
}
