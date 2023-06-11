using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RetroTechLanding.Models
{
    public class MembersModel    
    {
        public string Name { get; set; }
        public string Age { get; set; }
        public string Developer_Lang { get; set; }

        public MembersModel(string name, string age, string devLang)
        {
            Name = name;
            Age = age;
            Developer_Lang = devLang;
        }
    }
}