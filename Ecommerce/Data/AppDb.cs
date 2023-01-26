using Ecommerce.Models;
using Microsoft.EntityFrameworkCore;

namespace Ecommerce.Data
{
    public class AppDb : DbContext
    {
        public AppDb(DbContextOptions<AppDb> options) : base(options)
        {


        }
        public DbSet<Actor> actors { get; set; }
        public DbSet<producer> producers { get; set; }


    }
}
