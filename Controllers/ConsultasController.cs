using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Projeto_CRUD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_CRUD.Controllers
{
    public class ConsultasController : Controller
    {
        private readonly ApplicationContext db;
        private static List<DateTime> datas = new List<DateTime>();

        public ConsultasController(ApplicationContext db)
        {
            this.db = db;
        }

        //método de configuração de agenda definida pelo hospital
        private static void setAgenda()
        {
            // datas e horas padrão disponíveis para marcação de consultas 
            // terças e quintas com horários 08:00 e 10:00
            // a partir do dia 09/11/2021 até 23/11/2021

            if (datas.Count == 0)
            {
                datas.Add(new DateTime(2021, 11, 09, 08, 00, 00));
                datas.Add(new DateTime(2021, 11, 09, 10, 00, 00));

                datas.Add(new DateTime(2021, 11, 11, 08, 00, 00));
                datas.Add(new DateTime(2021, 11, 11, 10, 00, 00));

                datas.Add(new DateTime(2021, 11, 16, 08, 00, 00));
                datas.Add(new DateTime(2021, 11, 16, 10, 00, 00));

                datas.Add(new DateTime(2021, 11, 18, 08, 00, 00));
                datas.Add(new DateTime(2021, 11, 18, 10, 00, 00));

                datas.Add(new DateTime(2021, 11, 23, 08, 00, 00));
                datas.Add(new DateTime(2021, 11, 23, 10, 00, 00));
            }
            
        }

        //gets das páginas
        [HttpGet]
        public IActionResult CadastroConsultaP1()
        {
            ViewBag.listaTipoExames = db.TipoExame.ToList();
            return View();
        }

        [HttpGet]
        public IActionResult CadastroConsultaP2()
        {
            return View();
        }

        [HttpGet]
        public IActionResult CadastroConsultaP3()
        {
            return View();
        }

        [HttpGet]
        public IActionResult ResultadoNegativo()
        {
            return View();
        }

        [HttpGet]
        public IActionResult UpdateConsultaP1(long id)
        {
            var Consulta = db.Consulta.Find(id);

            if (Consulta == null)
            {
                TempData["msg"] = "Consulta nula!";
                return RedirectToAction("Index", "Home"); //não existe
            }

            ViewBag.listaTipoExames = db.TipoExame.ToList();
            ViewBag.listaExames = db.Exame.ToList();
            ViewBag.Consulta = Consulta;
            return View();
        }

        [HttpGet]
        public IActionResult UpdateConsultaP2(long id)
        {
            var Consulta = db.Consulta.Find(id);

            if (Consulta == null)
            {
                TempData["msg"] = "Consulta nula!";
                return RedirectToAction("Index", "Home"); //não existe
            }

            setAgenda();
            ViewBag.datas = datas;
            ViewBag.Consulta = Consulta;
            ViewBag.listaConsultas = db.Consulta.ToList();
            return View();
        }

        //MÉTODO VERIFICADOR DE EXISTÊNCIA DE CONSULTA
        private bool ConsultaExists(long id)
        {
            return db.Consulta.Any(e => e.id == id);
        }

        //CREATE Parte 1
        //busca por CPF
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CadastroConsultaP1(ViewBagModel req)
        {
            if (req == null)
            {
                TempData["msg"] = "string nula";
            }

            foreach (var p in db.Paciente.ToList())
            {
                var cpfSoNumero = String.Join("", System.Text.RegularExpressions.Regex.Split(p.CPF, @"[^\d]"));

                if (p.nome == req.msg || p.CPF == req.msg || cpfSoNumero == req.msg)
                {
                    setAgenda();
                    ViewBag.paciente = p;
                    ViewBag.datas = datas;
                    ViewBag.listaTipoExames = db.TipoExame.ToList();
                    ViewBag.tipoExame = req.msg2;
                    ViewBag.listaExames = db.Exame.ToList();
                    return View("CadastroConsultaP2");
                }
            }

            ViewBag.notFound = "Paciente não encontrado! Deseja ir para a tela de cadastro?";
            return View("ResultadoNegativo");
        }

        //CREATE Parte 2
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CadastroConsultaP2([Bind("id,data,ExameId,PacienteId")] Consulta Consulta)
        {
            if (!ModelState.IsValid)
            {
                setAgenda();
                ViewBag.datas = datas;
                ViewBag.listaConsultas = db.Consulta.ToList();
                return View();
            }

            foreach (var d in db.Consulta.ToList())
            {
                if (d.data == Consulta.data)
                {
                    TempData["msg"] = "Data indisponível, por favor selecione outra!";
                    return RedirectToAction("Index", "Home");
                }
            }

            ViewBag.Consulta = Consulta;
            ViewBag.listaPacientes = db.Paciente.ToList();
            ViewBag.listaTipoExames = db.TipoExame.ToList();
            ViewBag.listaExames = db.Exame.ToList();
            return View("CadastroConsultaP3");
        }

        //CREATE Parte 3
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CadastroConsultaP3([Bind("id,data,ExameId,PacienteId")] Consulta Consulta)
        {
            db.Add(Consulta);

            try
            {
              db.SaveChanges();
              return RedirectToAction("TabelaConsultas", "Consultas");
            }
            catch (Exception e)
            {
              System.Diagnostics.Debug.WriteLine(e.StackTrace);
            }
            
            return RedirectToAction("Index", "Home");
        }

        //READ
        [HttpGet]
        public IActionResult TabelaConsultas()
        {
            if (db.Consulta == null)
            {
                TempData["msg"] = "consulta nula";
            }

            ViewBag.listaPacientes = db.Paciente.ToList();
            ViewBag.listaTipoExames = db.TipoExame.ToList();
            ViewBag.listaExames = db.Exame.ToList();
            ViewBag.listaConsultas = db.Consulta.ToList();
            return View();
        }

        //UPDATE Parte 1
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult UpdateConsultaP1(ViewBagModel req)
        {
            setAgenda();
            ViewBag.datas = datas;
            ViewBag.idTipoExame = Convert.ToInt64(req.msg);
            ViewBag.idConsulta = Convert.ToInt64(req.msg2);
            ViewBag.listaPacientes = db.Paciente.ToList();
            ViewBag.listaTipoExames = db.TipoExame.ToList();
            ViewBag.listaExames = db.Exame.ToList();
            ViewBag.listaConsultas = db.Consulta.ToList();
            return View("UpdateConsultaP2");
        }

        //UPDATE Parte 2
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult UpdateConsultaP2(long id, [Bind("id,data,ExameId,PacienteId")] Consulta Consulta)
        {
            
            foreach (var d in db.Consulta.ToList())
            {
                if (d.data == Consulta.data && d.id != id)
                {
                    TempData["msg"] = "Data indisponível, por favor selecione outra!";
                    return RedirectToAction("Index", "Home");
                }
            }
            
            if (ModelState.IsValid)
            {
                try
                {
                    db.Attach(Consulta);
                    db.Entry(Consulta).Property(p => p.ExameId).IsModified = true;
                    db.Entry(Consulta).Property(p => p.data).IsModified = true;
                    db.SaveChanges();
                }
                catch (Exception e)
                {
                    System.Diagnostics.Debug.WriteLine(e.StackTrace);

                    if (!ConsultaExists(Consulta.id))
                    {
                        TempData["msg"] = "Consulta não existe no banco de dados!";
                        return RedirectToAction("Index", "Home");
                    }
                }
            }

            return RedirectToAction("TabelaConsultas", "Consultas");
        }

        //DELETE
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConsulta(long id)
        {
            var Consulta = db.Consulta.Find(id);

            if (Consulta == null)
            {
                TempData["msg"] = "Consulta inválida!";
                return RedirectToAction("TabelaConsultas", "Consultas");
            }

            db.Consulta.Remove(Consulta);
            db.SaveChanges();
            return RedirectToAction("Index", "Home");
        }
    }
}
