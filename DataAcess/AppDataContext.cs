using Microsoft.EntityFrameworkCore;
using Models.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcess
{
    public class AppDataContext : DbContext
    {
        private AppDataContext _db;
        public AppDataContext(DbContextOptions<AppDataContext> db):base(db)  {}
        public DbSet<Tarefa> Tarefas { get; set; }
    }
}
