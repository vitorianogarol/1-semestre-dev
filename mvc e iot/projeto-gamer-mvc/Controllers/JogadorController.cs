using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using projeto_gamer_mvc.Infra;
using projeto_gamer_mvc.Models;

namespace projeto_gamer_mvc.Controllers
{
    [Route("[controller]")]
    public class JogadorController : Controller
    {
        private readonly ILogger<JogadorController> _logger;

        public JogadorController(ILogger<JogadorController> logger)
        {
            _logger = logger;
        }

        Context c = new Context();

        [Route("Listar")]
        public IActionResult Index()
        {

            ViewBag.UserName = HttpContext.Session.GetString("UserName");
            ViewBag.Jogador = c.Jogador.ToList();
            ViewBag.Equipe = c.Equipe.ToList();
            return View();
        }

        [Route("Cadastrar")]
        public IActionResult Cadastrar(IFormCollection form)
        {
            Jogador novoJogador = new Jogador();

            novoJogador.Nome = form["Nome"].ToString();
            novoJogador.Email = form["Email"].ToString();
            novoJogador.Senha = form["Senha"].ToString();
            novoJogador.IdEquipe = int.Parse(form["Equipe"]);
            // novoJogador.Equipe = c.Equipe.First(e => e.IdEquipe == int.Parse(form["Equipe"]));

            c.Jogador.Add(novoJogador);

            c.SaveChanges();

            return LocalRedirect("~/Jogador/Listar");
        }

        [Route("Excluir/{id}")]
        public IActionResult Excluir(int id)
        {
            Jogador j = c.Jogador.First(j => j.IdJogadorme == id);
            c.Jogador.Remove(j);
            c.SaveChanges();
            return LocalRedirect("~/Jogador/Listar");
        }

        [Route("Editar/{id}")]
        public IActionResult Editar(int id)
        {
            Jogador j = c.Jogador.First(j => j.IdJogadorme == id);

            ViewBag.UserName = HttpContext.Session.GetString("UserName");
            ViewBag.Jogador = j;
            ViewBag.Equipe = c.Equipe.ToList();

            return View("Edit");
        }

        [Route("Atualizar")]
        public IActionResult Atualizar(IFormCollection form)
        {
            Jogador novoJogador = new Jogador();
            novoJogador.Nome = form["Nome"].ToString();
            novoJogador.Email = form["Email"].ToString();
            novoJogador.Senha = form["Senha"].ToString();
            novoJogador.IdEquipe = int.Parse(form["IdEquipe"].ToString());
            novoJogador.IdJogadorme = int.Parse(form["IdJogadorme"].ToString());

            Jogador jogador = c.Jogador.First(j => j.IdJogadorme == novoJogador.IdJogadorme);

            jogador.Nome = novoJogador.Nome;
            jogador.Email = novoJogador.Email;
            jogador.Senha = novoJogador.Senha;
            jogador.IdEquipe = novoJogador.IdEquipe;

            c.Jogador.Update(jogador);

            c.SaveChanges();

            return LocalRedirect("~/Jogador/Listar");
        }




        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}