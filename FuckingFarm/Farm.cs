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
                    Console.WriteLine($"The product they produce is {Buildings[i].Animals[j].Products.ProductName};");
                    Console.WriteLine($"The product's weight is {Buildings[i].Animals[j].Products.ProductWeight};");
                    Console.WriteLine($"They live in a {Buildings[i].BuildingName};");                    
                    Console.WriteLine($"There are {Buildings[i].BuildingAnimalsQuantity} of them in a building;");
                    Console.WriteLine($"The square of each building is {Buildings[i].BuildingSquare} sq.m.;");
                }
            
        }
        public void GardenbedsCount()
        {
            int gardenbedsCount = Gardenbeds.Count;
            Console.WriteLine($"There are {gardenbedsCount} gardenbeds at the farm;");            
        }

        public void BuildingsCount()
        {
            int buildingsCount = Buildings.Count;
            Console.WriteLine($"There are {buildingsCount} buildings at the farm;");
        }

        
        public void PercentOfFullnessGardenbeds()
        {
            Console.WriteLine("кот!=код:)");
            double percentOfFullness = Gardenbeds[0].Plants[0].PlantSquareAtTheGardenbed * 100 / Gardenbeds[0].GardenbedSquare;
            Console.WriteLine($"The potato gardenbed percent of fullness is {percentOfFullness} %;");
            double percentOfFullness_1 = Gardenbeds[1].Plants[0].PlantSquareAtTheGardenbed * 100 / Gardenbeds[1].GardenbedSquare;
            Console.WriteLine($"The cucumber gardenbed percent of fullness is {percentOfFullness_1} %;");
            double percentOfFullness_2 = Gardenbeds[2].Plants[0].PlantSquareAtTheGardenbed * 100 / Gardenbeds[2].GardenbedSquare;
            Console.WriteLine($"The garlic gardenbed percent of fullness is {percentOfFullness_2} %;");
            Console.WriteLine("код!=кот:)");
        }

        public void PercentOfFullnessBuildings ()
        {
            int animalsCount = Buildings[0].Animals.Count * 100 / Buildings [0].BuildingAnimalsQuantity;
            Console.WriteLine($"The cowshed percent of fullness is {animalsCount} %;");
            int animalsCount_1 = Buildings[1].Animals.Count * 100 / Buildings[1].BuildingAnimalsQuantity;
            Console.WriteLine($"The henhous percent of fullness is {animalsCount_1} %;");
        }

    }
    
}
