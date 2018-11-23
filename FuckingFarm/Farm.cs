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
        public List<Gardenbed> Gardenbeds { get; set; }
        public List<Building> Buildings { get; set; }

        public void AboutNameAndSquare()
        {
            Console.WriteLine($"The name of the farm is {FarmName}. \nThe total square of the farm is {FarmSquare} sq.m..");
        }

        public void AboutGardenbeds()
        {
            Console.WriteLine("The Gardenbeds");
            for (int i = 0; i < Gardenbeds.Count; i++)
                for (int j = 0; j < Gardenbeds[i].Plants.Count; j++)
                {
                    Console.WriteLine("The list of the plants at the gardenbeds includes:");
                    Console.WriteLine($"A {Gardenbeds[i].Plants[j].PlantName} gardenbed;");
                    Console.WriteLine($"It's season of planting is {Gardenbeds[i].Plants[j].PlantSeasonOfPlanting};");
                    Console.WriteLine($"It's season of harvesting is {Gardenbeds[i].Plants[j].PlantSeasonOfHarvesting};");                    
                    Console.WriteLine($"It's square at the gardenbed is {Gardenbeds[i].Plants[j].PlantSquareAtTheGardenbed} sq.m.;");
                }

        }
        public void AboutBuildings()
        {
            
            for (int i = 0; i < Buildings.Count; i++)
                for (int j = 0; j < Buildings[i].Animals.Count; j++)
                {                   
                    
                    Console.WriteLine($"The list of the animals at the farm includes {Buildings[i].Animals[j].AnimalName};");
                    Console.WriteLine($"The product they produce is {Buildings[i].Animals[j].Products};");
                    Console.WriteLine($"They live in a {Buildings[i].BuildingName};");
                    
                    Console.WriteLine($"There are {Buildings[i].BuildingAnimalsQuantity} of them in a building;");
                    Console.WriteLine($"The square of each building is {Buildings[i].BuildingSquare} sq.m.;");                    

                }

            Console.ReadLine();
        }


    }

}
