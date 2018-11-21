using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuckingFarm
{
    public class Farm
    {
        public string FarmName { get; set; }
        public double FarmSquare { get; set; }
        public List <Gardenbed> Gardenbeds { get; set; }
        public List <Building> Buildings { get; set; }
    }
}
