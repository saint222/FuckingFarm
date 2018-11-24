using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuckingFarm
{
   public class Program
    {
       public static void Main(string[] args)
        {
            Product milk = new Product() { ProductName = "milk", ProductWeight = 10};
            Product anEgg = new Product() { ProductName = "eggs", ProductWeight = 20 };
            Product meat = new Product() { ProductName = "meat", ProductWeight = 30 };
            
            Animal aCow = new Animal () {AnimalName = "cows", Products = milk };
            Animal aHen = new Animal() { AnimalName = "hens", Products = anEgg};
            Animal aPig = new Animal() { AnimalName = "pigs", Products = meat };

            Building aCowshed = new Building() { BuildingName = "cowshed", BuildingSquare = 30, BuildingAnimalsQuantity = 20, Animals = new List <Animal>() };
            aCowshed.Animals.Add(aCow);
            aCowshed.Animals.Add(aPig);
            Building aHenhous = new Building() { BuildingName = "pigsty", BuildingSquare = 20, BuildingAnimalsQuantity = 10, Animals = new List <Animal> ()}; 
            aHenhous.Animals.Add(aHen);

            Plant potato = new Plant() { PlantName = "potato", PlantSeasonOfPlanting = "spring", PlantSeasonOfHarvesting = "autumn", PlantSquareAtTheGardenbed = 30};
            Plant cucubbers = new Plant() { PlantName = "cucumber", PlantSeasonOfPlanting = "spring", PlantSeasonOfHarvesting = "summer", PlantSquareAtTheGardenbed = 20};
            Plant garlic = new Plant() { PlantName = "garlic", PlantSeasonOfPlanting = "winter", PlantSeasonOfHarvesting = "summer", PlantSquareAtTheGardenbed = 10};

            Gardenbed gardenbedPotato = new Gardenbed() {GardenbedSquare = 30, Plants = new List <Plant> () };
            Gardenbed gardenbedCucumbers = new Gardenbed() {GardenbedSquare = 20, Plants = new List <Plant> () };
            Gardenbed gardenbedGarlic = new Gardenbed() {GardenbedSquare = 10, Plants = new List <Plant> ()};
            gardenbedPotato.Plants.Add(potato);
            gardenbedCucumbers.Plants.Add(cucubbers);
            gardenbedGarlic.Plants.Add(garlic);

            Farm myFarm = new Farm() { FarmName = "My farm", FarmSquare = 100, Buildings = new List<Building> (), Gardenbeds = new List<Gardenbed> ()};
            myFarm.Gardenbeds.Add(gardenbedPotato);
            myFarm.Gardenbeds.Add(gardenbedCucumbers);
            myFarm.Gardenbeds.Add(gardenbedGarlic);
            myFarm.Buildings.Add(aCowshed);
            myFarm.Buildings.Add(aHenhous);

            myFarm.AboutNameAndSquare();
            myFarm.BuildingsCount();
            myFarm.GardenbedsCount();
            myFarm.AboutGardenbeds();
            myFarm.AboutBuildings();
            

            Console.ReadLine();


        }
        
    }
}
