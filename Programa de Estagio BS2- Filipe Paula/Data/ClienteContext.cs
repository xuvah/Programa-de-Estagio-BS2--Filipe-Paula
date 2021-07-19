using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Programa_de_Estagio_BS2__Filipe_Paula.Models;

namespace Programa_de_Estagio_BS2__Filipe_Paula.Data
{
    public class ClienteContext : DbContext
    {
        private const string ConnectionString = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=ClientDataBase;Data Source=DESKTOP-UJ6B7VT\\SQLEXPRESS";

        public DbSet <Cliente> Cliente { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Integrated Security = SSPI; Persist Security Info = False; Initial Catalog = ClientDataBase; Data Source = DESKTOP - UJ6B7VT\\SQLEXPRESS");
        }
    }

}
