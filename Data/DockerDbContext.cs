using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using DockerKubernetesPersonal.Models;

namespace DockerKubernetesPersonal.Data
{
    public class DockerDbContext : IdentityDbContext
    {
        public DockerDbContext(DbContextOptions<DockerDbContext> options)
            : base(options)
        {
        }

        public DbSet<Produto>? Produtos { get; set; }
    }
}