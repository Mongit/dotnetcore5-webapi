using dotnet5_webapi.Models;
using Microsoft.EntityFrameworkCore;

namespace dotnet5_webapi.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<Contact> Contacts { get; set; }
    }
}
