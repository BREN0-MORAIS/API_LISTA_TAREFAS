using Models.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAcess.Repository.Interface
{
    public interface ITarefaRepository : IRepository<Tarefa>
    {
        public void AtualizarStatus(Tarefa tarefa);
        public IEnumerable<Tarefa> GetAll(Expression<Func<Tarefa, bool>> cond);
    }
}
