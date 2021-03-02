using Models.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class TarefaVM
    {
        public IEnumerable<Tarefa> Tarefas { get; set; }
        public Tarefa Tarefa { get; set; }
    }
}
