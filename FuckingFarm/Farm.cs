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

        public void AboutNameAndSquare ()
        {
            Console.WriteLine($"The name of the farm is {FarmName}. \nThe total square of the farm is {FarmSquare} sq.m..");
        }

        public void AboutGardenbeds ()
        {
            Console.WriteLine("The list of the gardenbeds is:");
            for (int i = 0; i < Gardenbeds.Count; i++)
            for (int j = 0; j < Gardenbeds[i].Plants.Count; j++)
            {
                Console.WriteLine($"A {Gardenbeds[i].Plants[j].PlantName} gardenbed;");
            }
            Console.ReadLine();
        }

    }

}
