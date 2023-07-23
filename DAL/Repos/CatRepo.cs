using DAL.EF;
using DAL.EF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    public class CatRepo
    {
        public static List<Category> GetAll()
        {
            var db = new CatNewsContext();
            return db.categories.ToList();
        }
    }
}
