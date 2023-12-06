using Microsoft.EntityFrameworkCore;
using petshop.Models;

namespace petshop.Data
{
    public class ApplicationDBContext : DbContext 
    { 
    public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
    {

    }
        public DbSet<PetModel> Pet { get; set; }

    }
}

