using Microsoft.EntityFrameworkCore;
using ProjectAPI.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.DataAccessLayer.Concrete
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localDb)\\MSSQLLocalDb; Database=DBProject; Trusted_Connection=true;MultipleActiveResultSets=True;");
        }

        public DbSet<Sikayet> Sikayets { get; set; }
    }
}
