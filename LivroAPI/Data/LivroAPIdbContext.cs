using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace LivroAPI.Data
{
    public class LivroAPIdbContext : DbContext
    {
        
        public LivroAPIdbContext() : base("name=LivroAPIdbContext")
        {
        }

        public System.Data.Entity.DbSet<LivroAPI.Models.Livro> Livroes { get; set; }
    }
}
