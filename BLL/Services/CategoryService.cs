using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using BLL.DTOs;
using DAL.EF.Models;
using DAL.Repos;

namespace BLL.Services
{
    public class CategoryService
    {
        public static List<CategoryDTO> GetAll()
        {
            var data = CatRepo.GetAll();
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Category, CategoryDTO>();
            });
            var mapper = new Mapper(config);
            var convertedData = mapper.Map< List < CategoryDTO >> (data);
            return convertedData;

        }
    }
}
