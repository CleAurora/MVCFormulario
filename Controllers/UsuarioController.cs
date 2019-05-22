using System;
using ex2WebMVC.Models;
using ex2WebMVC.Repositorio;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ex2WebMVC.Controllers
{
    public class UsuarioController : Controller //tem que herdar essa classe do controller
    {
        [HttpGet]//Get: quando a gente vai acessar via URL
        public IActionResult Index(){

            return View();
        }
        [HttpPost]
        public IActionResult Cadastrar(IFormCollection form){//vai fazer a gente capturar as informações do nosso formulário
            UsuarioModel usuario = new UsuarioModel(
                nome: form["nome"],
                email: form["email"],
                senha: form["senha"],
                dataNascimento: DateTime.Parse(form["dataNascimento"])

            );
            UsuarioRepositorio usuarioRepositorio = new UsuarioRepositorio();

            usuarioRepositorio.CadastrarUsuario(usuario);

            return RedirectToAction("Index", "Usuario");
        }

        [HttpGet]
        public IActionResult Listar(){
            UsuarioRepositorio usuarioRepositorio = new UsuarioRepositorio();
            ViewData["usuarios"] = usuarioRepositorio.Listar();

            return View();
        }// fim listar

        [HttpGet]
        public IActionResult Editar(int id){
            UsuarioRepositorio usuarioRepositorio = new UsuarioRepositorio();
            UsuarioModel usuarioRecuperado = usuarioRepositorio.BuscarPorId(id);
            if(usuarioRecuperado != null){
                ViewBag.usuario = usuarioRecuperado; //Viewbag é o elemento que armazena meu usuario recuperado e o transfere para a minha View
            }else{
                TempData["mensagem"] = "Usuário não encontrado";
                return RedirectToAction("Listar");
            }
            return View();
        }//serve para eu buscar o usuario e levar para a view
    
        [HttpPost]
        public IActionResult Editar(IFormCollection form){
            UsuarioModel usuario = new UsuarioModel(
                id: int.Parse(form["id"]),
                nome: form["nome"],
                email: form["email"],
                senha: form["senha"],
                dataNascimento: DateTime.Parse(form["dataNascimento"])
            );
            UsuarioRepositorio usuarioRepositorio = new UsuarioRepositorio();
            usuarioRepositorio.EditarUsuario(usuario);

            TempData["mensagem"] = $"{usuario.Nome} editado com sucesso";
            return RedirectToAction("Listar");
        }
    }
}