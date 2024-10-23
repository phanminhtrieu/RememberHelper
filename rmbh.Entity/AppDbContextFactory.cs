using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rmbh.Entity
{
    public class AppDbContextFactory : IDesignTimeDbContextFactory<AppDbContext>
    {
        public AppDbContext CreateDbContext(string[] args = null)
        {
            var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();
            //optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb; Database=SchoolDb; Trusted_Connection=True;");
            optionsBuilder.UseSqlServer("Server=DESKTOP-4F8D9JD\\SQLEXPRESSTTRIEU; Database=SchoolDb; Trusted_Connection=True;");

            return new AppDbContext(optionsBuilder.Options);
        }
    }
}
