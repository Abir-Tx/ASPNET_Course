using CatNewsAPI.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CatNewsAPI
{
    public class CFDatabaseContext:DbContext
    {
        public DbSet<News> Cats { get; set; }
    }
}