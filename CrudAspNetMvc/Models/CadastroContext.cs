using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CrudAspNetMvc.Models
{
    public class CadastroContext:DbContext
    {
        public CadastroContext():base("Cadastro")
        {

        }

        public DbSet<Cliente> Clientes { get; set; }
    }
}