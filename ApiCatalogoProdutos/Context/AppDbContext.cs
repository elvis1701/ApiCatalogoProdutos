using ApiCatalogoProdutos.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiCatalogoProdutos.Context
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) 
            : base(options)
        {   }

        public AppDbContext()
        { }

        public DbSet<Categoria> Categorias { get; set; }

        public DbSet<Produto> Produtos { get; set; }
    }
}
