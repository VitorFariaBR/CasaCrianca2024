using CasaCrianca.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic; 

namespace CasaCrianca.Controllers
{
    public class AlunosController : Controller
    {
        public IActionResult ListAlunos()
        {
            var alunos = new List<Alunos>
            {
                new Alunos { Id = 1, Nome = "Vitor", DataDeNascimento = "20/02/2015"},
                new Alunos { Id = 2, Nome = "Maria", DataDeNascimento = "15/12/2002" },
                new Alunos { Id = 3, Nome = "João", DataDeNascimento = "06/11/2003" },
                new Alunos { Id = 4, Nome = "Bruno", DataDeNascimento = "08/07/2007" },
                new Alunos { Id = 5, Nome = "Carlos", DataDeNascimento = "10/02/2005" },
                new Alunos { Id = 5, Nome = "Gabriel", DataDeNascimento = "01/02/2002" },
                new Alunos { Id = 6, Nome = "Lucas", DataDeNascimento = "05/02/2005" },
                new Alunos { Id = 7, Nome = "Pedro", DataDeNascimento = "12/02/2010" }
            };

            return View("Index", alunos);
        }
    }
}
