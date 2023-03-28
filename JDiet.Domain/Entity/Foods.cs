using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JDiet.Domain.Entity
{
    public class Foods
    {
        public int CarboHydrates { get; set; }
        public int Proteins { get; set; }
        public int Fruits { get; set; }
        public int Vegetables { get; set; }
        public string MacroNutrients { get; set; }
        public string MicroNutrients { get; set; }
    }
}