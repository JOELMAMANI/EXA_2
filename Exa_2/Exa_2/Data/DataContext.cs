using Exa_2.Data.Entity;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace Exa_2.Data
{
    public class DataContext :DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
        public DbSet<Floors> floors { get; set; }
        public DbSet<Irrigation> irrigations { get; set; }
    }
}
