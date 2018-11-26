using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuckingFarm
{
    public class Building
    {
        public string BuildingName { get; set; }
        public double BuildingSquare { get; set; }
        public int BuildingAnimalsQuantity { get; set; }
        public List <Animal> Animals { get; set; }



        //public void AnimalsCount()
        //{
        //    int animalsCount = Animals.Count;
        //    Console.WriteLine($"There are {animalsCount} buildings at the farm;");
        //}
    }
}
