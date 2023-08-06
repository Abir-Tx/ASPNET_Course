using DAL.EF.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EF
{
    public class PreRegContext : DbContext
    {
        public DbSet<Course> Courses { get; set; }
        public DbSet<Student> students { get; set; }

    }
}
