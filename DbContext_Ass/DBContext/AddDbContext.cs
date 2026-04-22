using DbContext_Ass.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbContext_Ass.DBContext
{
    public class AddDbContext :DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.\SQL2026;Database=DbBOOKSTORE;Trusted_Connection=True;TrustServerCertificate=True;");
        }
        public DbSet<BookInfoo> Books { get; set; }
        public DbSet<AuthorsInfo> AuthorsInfo { get; set; }
        public DbSet<Categories> Categories { get; set; }
    }
}
