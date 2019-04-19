using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Aplicacao;
using Dominio.Entidades;
using Infraestrutura.Contexto;
using Infraestrutura.Repositorios;

namespace MVC.Controllers
{
    public class VeiculosController : Controller
    {
        private VeiculoServico _veiculoService;
        private EmpresaContext _contexto;
        private VeiculoRepositorio _veiculoRepositorio;

        public VeiculosController()
        {
            _contexto = new EmpresaContext();
            _veiculoRepositorio = new VeiculoRepositorio(_contexto);
            _veiculoService = new VeiculoServico(_veiculoRepositorio);
        }

        // GET: Veiculoes
        public ActionResult Index()
        {
            return View(_veiculoService.GetAll());
        }

        // GET: Veiculoes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Veiculo veiculo = _veiculoService.Get(id);
            if (veiculo == null)
            {
                return HttpNotFound();
            }
            return View(veiculo);
        }

        // GET: Veiculoes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Veiculoes/Create
        // Para se proteger de mais ataques, ative as propriedades específicas a que você quer se conectar. Para 
        // obter mais detalhes, consulte https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Placa,Renavan")] Veiculo veiculo)
        {
            if (ModelState.IsValid)
            {
                _veiculoService.Add(veiculo);
                return RedirectToAction("Index");
            }

            return View(veiculo);
        }

        // GET: Veiculoes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Veiculo veiculo = _veiculoService.Get(id);
            if (veiculo == null)
            {
                return HttpNotFound();
            }
            return View(veiculo);
        }

        // POST: Veiculoes/Edit/5
        // Para se proteger de mais ataques, ative as propriedades específicas a que você quer se conectar. Para 
        // obter mais detalhes, consulte https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Veiculo veiculo) //Neste o Id ja chega zerado
        {
            if (ModelState.IsValid)
            {
                _veiculoService.Update(veiculo);
                return RedirectToAction("Index");
            }
            return View(veiculo);
        }

        // GET: Veiculoes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Veiculo veiculo = _veiculoService.Get(id);
            if (veiculo == null)
            {
                return HttpNotFound();
            }
            return View(veiculo);
        }

        // POST: Veiculoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Veiculo veiculo = _veiculoService.Get(id);
            _veiculoService.Delete(veiculo);
            return RedirectToAction("Index");
        }
    }
}
