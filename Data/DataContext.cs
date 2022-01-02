using API_CRUD2.Models;
using Microsoft.EntityFrameworkCore;


namespace API_CRUD2.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {}

        public DbSet<Pessoa> pessoa { get; set; }

    }
}