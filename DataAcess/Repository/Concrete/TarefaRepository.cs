using DataAcess.Repository.Interface;
using Models.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcess.Repository.Concrete
{
    public class TarefaRepository : Repository<Tarefa>, ITarefaRepository
    {
        public readonly AppDataContext _db;
        public TarefaRepository(AppDataContext db) : base(db)
        {
            _db = db;
                
        }


        public void AtualizarStatus(Tarefa tarefa)
        {
            if (tarefa.Status == Status.INICIAR)
            {
                tarefa.Status = Status.ANDAMENTO;

            }
            else if (tarefa.Status == Status.ANDAMENTO)
            {
                tarefa.Status = Status.CONCLUIDO;
            }

            _db.Tarefas.Update(tarefa);
            _db.SaveChanges();

        }


      
    }

  
}
