using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Model
{
    public class Tarefa
    {
        public int Id { get; set; }
        [Required]
        public string  Titulo { get; set; }
        [Required]
        public string  Descricao { get; set; }
        //public DateTime  DataInicio { get; set; }
        //public DateTime  DataTermino { get; set; }
        public string   Status { get; set; }
    }
}
