using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class MyContext : DbContext, IDisposable
    {
        public MyContext()
            : base(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString)
        {

        }


        public DbSet<Pessoa> Pessoa { get; set; }

        public System.Data.Entity.DbSet<WebApplication1.Models.PessoaViewModel> PessoaViewModels { get; set; }
    }
}