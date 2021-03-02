using DataAcess;
using DataAcess.Repository.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Models.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIListaTarefa.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TarefaController : ControllerBase
    {
        private  AppDataContext _db { get; set; }
        public ITarefaRepository _Tarefa { get; set; }
        public TarefaController(ITarefaRepository tarefa, AppDataContext db)
        {
            _Tarefa = tarefa;
            _db = db;
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_Tarefa.GetAll());
        }

        [HttpGet("byId/{Id}")]
        public IActionResult Get(int id)
        {
            var obj = _Tarefa.Get(id);
            return Ok(obj);
        }

        [HttpGet("status/{Status}")]
        public IActionResult Status(string status)
        {
            var obj = _Tarefa.GetAll(a=> a.Status ==  status);
        
            return Ok(obj);
        }

        [HttpPost]
        public IActionResult Post(Tarefa tarefa)
        {
            if (tarefa != null)
            {
                _Tarefa.Add(tarefa);
                return Ok("Cadastrado com Sucesso");
            }
            else
            {
                return Ok("Erro ao Cadastra");
            }
           
        }

        [HttpPut]

        public IActionResult Put( Tarefa tarefa)
        {
            var obj = _db.Tarefas.AsNoTracking().First(a=> a.Id == tarefa.Id);

            if (obj == null) return BadRequest("Não foi possivel atualizar");

            _Tarefa.Update(tarefa);

            return Ok("Atualizado Com sucesso");
        }


        [HttpDelete("delete/{Id}")]
        public IActionResult Delete(int id)
        {
            if(id != null)
            {
                _Tarefa.Remove(id);
                return Ok("Tarefa Deletada com sucesso");
            }
            else
            {
                return Ok("Erro ao Deletar Tarefa");
            }
        }
    }
}
