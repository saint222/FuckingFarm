using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuckingFarm
{
   public class Plant
    {
        public string PlantName { get; set; }
        public Season PlantSeasonOfPlanting { get; set; }
        public Season PlantSeasonOfHarvesting { get; set; }
        public double PlantSquareAtTheGardenbed { get; set; }


        public void AddAPlant()
        {
            Plant bean = new Plant() { PlantName = "bean", PlantSeasonOfPlanting = Season.spring, PlantSeasonOfHarvesting = Season.autumn, PlantSquareAtTheGardenbed = 7 };
        }
    }


}
