using CasaCrianca.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic; 

namespace CasaCrianca.Controllers
{
    public class FuncionariosController : Controller
    {
        public IActionResult ListFuncionarios()
        {
            var funcionarios = new List<Funcionarios>
            {
                new Funcionarios { Id = 1, Nome = "Bruno", Cidade = "Assis" , Email = "Bruno@gmail.com" },
                new Funcionarios { Id = 2, Nome = "Begosso", Cidade = "Cadido Mota" , Email = "Begosso@gmail.com" },
                new Funcionarios { Id = 3, Nome = "Talo", Cidade = "Assis" , Email = "Talo@gmail.com" },
                new Funcionarios { Id = 4, Nome = "Diomara", Cidade = "Assis" , Email = "Diomara@gmail.com" },
                new Funcionarios { Id = 5, Nome = "Alex", Cidade = "Assis" , Email = "Alex@gmail.com" }
            };

            return View("Index", funcionarios);
        }
    }
}
