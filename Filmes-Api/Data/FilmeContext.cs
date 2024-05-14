using Filmes_Api.Controllers;
using Filmes_Api.Models;
using Microsoft.EntityFrameworkCore;

namespace Filmes_Api.Data
{
    public class FilmeContext : DbContext
    {
        public FilmeContext(DbContextOptions<FilmeContext> options) : base(options) 
        { 
        
        }

        public DbSet<Filme> Filmes { get; set; }

    }
}
