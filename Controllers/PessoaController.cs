using ClassLibrary1.Impl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class PessoaController : Controller
    {
        // GET: Pessoa
        public ActionResult Index()
        {
            ViewBag.Mensagem = "Minha primeira View";
            return View();
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(PessoaViewModel model)
        {
            ModelState.Remove("Codigo");
            if (ModelState.IsValid)
            {
                //Pessoa p = new Pessoa();
                //p.Codigo = model.Codigo;
                //p.Nome = model.Nome;
                //p.Sobrenome = model.Sobrenome;
                //p.Cpf = model.Sobrenome;
                //p.DataNascimento = model.DataNascimento;
                //p.Email = model.Email;
                //p.Telefone = model.Telefone;
                //p.Texto = model.Texto;


                // Criar mapeamento


                var p = AutoMapper.Mapper.Map<PessoaViewModel, Pessoa>(model);
                //Transformar um objeto em outro
                PessoaService srv = new PessoaService();
                srv.Salvar(p);
                return View("List", srv.Listar());
            }
            else
            {
                return View(model);
            }


        }

        public ActionResult List()
        {
            PessoaService srv = new PessoaService();
            return View(srv.Listar());
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            //Recuperar objeto com ID
            //Enviar objeto encontrado para a View de edição

            PessoaService srv = new PessoaService();

            var pessoa = srv.Obter(id);

            var pessoaVM = AutoMapper.Mapper.Map<Pessoa, PessoaViewModel>(pessoa);

            var pessoaVM2 = AutoMapper.Mapper.Map(pessoa, typeof(Pessoa), typeof(PessoaViewModel));

            bool conv = pessoaVM.Nome == (pessoaVM2 as PessoaViewModel).Nome;

            //var pessoaVM = AutoMapper.Mapper.Map<Pessoa, PessoaViewModel>(pessoa);
            if ((pessoaVM.Codigo % 2) == 0)
                pessoaVM.Ativo = true;
            return View("Create", pessoaVM);
        }
        [HttpPost]
        public ActionResult Edit(Pessoa model)
        {
            //Recuperar objeto com ID
            //Enviar objeto encontrado para a View de edição

            if (ModelState.IsValid)
            {
                PessoaService srv = new PessoaService();
                srv.Salvar(model);
                return View("List", srv.Listar());
            }
            else
            {
                return View("Create", model);
            }

        }

        public ActionResult Delete(int id)
        {
            PessoaService srv = new PessoaService();
            srv.Delete(id);
            return View("List", new List<Pessoa>());

        }
        // GET: Tip/Details/5
        public ActionResult Details(int id)
        {
            PessoaService srv = new PessoaService();
            return View(srv.Obter(id));

        }
    }
}