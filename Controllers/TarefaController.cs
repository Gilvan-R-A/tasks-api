using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace DesafioAPI.Controller
{   
    [ApiController]
    [Route("[controller]")]
    public class TarefaController : ControllerBase
    {
        private readonly OrganizadorContext _context;

        public TarefaController(OrganizadorContext context)
        {
            _context = context;
        }

    [HttpGet("{id}")]
    public IActionResult ObterPorId(int id){
            return Ok();
        }


    [HttpPost]
    public IActionResult Criar(Tarefa tarefa){
        if(tarefa.Data == DateTime.MinValue)
                return BadRequest(new { Erro = "A data da tarefa não pode ser vazia" });

            _context.Add(tarefa);
            _context.SaveChanges();

            return CreatedAtAction(nameof(ObterPorId), new { id = tarefa.Id }, tarefa);
        }

    public IActionResult Atualizar(int id, Tarefa tarefa){
            var tarefaBanco = _context.Tarefas.Find(id);
            return Ok();
        }


































































    }
}