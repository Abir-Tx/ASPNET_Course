using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CatNewsAPI.Models
{
    public class Cat
    {
        // Cat API properties for the database table
        public int Id { get; set; }
        public String Title { get; set; }
        public String Description { get; set; }
        public DateTime Date { get; set; }
        public int CatId { get; set; }

    }
}