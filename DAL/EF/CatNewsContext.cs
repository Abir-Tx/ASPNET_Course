using DAL.EF.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EF
{
    internal class CatNewsContext: DbContext
    {
        public DbSet<Category> categories { get; set; }
    }
}
