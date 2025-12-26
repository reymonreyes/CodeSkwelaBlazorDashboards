using Microsoft.EntityFrameworkCore;

namespace BlazorDashboards.Data
{
    public class NorthwindContext : DbContext
    {
        public string DbPath;

        public NorthwindContext()
        {
            var folder = Environment.SpecialFolder.LocalApplicationData;
            var path = Environment.GetFolderPath(folder);
            DbPath = System.IO.Path.Join(System.IO.Path.GetDirectoryName(Environment.ProcessPath), "northwind.db");
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite($"Data Source={DbPath}");
        }
    }
}
