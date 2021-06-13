using System;
using System.Collections.Generic;
using System.Text;

namespace ImmoApp.domain
{
    public class Coproprietaire
    {
        public Coproprietaire()
        { 

         }
        public int id { get; set; }
        public string Name { get; set; }
        public string reference { get; set; }
        public string natureBien { get; set; }
    }
}
