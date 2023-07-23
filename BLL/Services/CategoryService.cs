using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Repos;

namespace BLL.Services
{
    public class CategoryService
    {
        public static dynamic GetAll()
        {
            return CatRepo.GetAll();
        }
    }
}
