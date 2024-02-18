using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Engine.Models;
namespace Engine.Factories
{
    internal class WorldFactory
    {
        internal World CreateWorld()
        {
            World newWorld = new World();
            newWorld.AddLocation(-2, -1, "Farmer's Field",//"Farmer's Field"
                "There are rows of corn growing here, with giant rats hiding between them.",
                "/Engine;component/Images/Locations/BenuFarmField.jpeg");
            newWorld.AddLocation(-1, -1, "Farmer's House",//"Farmer's House",
                "This is the house of your neighbor, Farmer Ted.",
                "/Engine;component/Images/Locations/BenuFarmHouse.jpeg");
            newWorld.AddLocation(0, -1, "Home",//"Home"
                "This is your home",
                "/Engine;component/Images/Locations/Home.jpeg");
            newWorld.AddLocation(-1, 0, "Trading Shop",//"Trading Shop"
                "The shop of Susan, the trader.",
                "/Engine;component/Images/Locations/AlmaMarketShop.jpeg");
            newWorld.AddLocation(0, 0, "Town square",//Town square"
                "This place is the Kingdom of Eldoria.",
                "/Engine;component/Images/Locations/EldoriaTownSquare.png");
            newWorld.AddLocation(1, 0, "Town Gate",//Town Gate
                "There is a gate here, protecting the town from giant spiders.",
                "/Engine;component/Images/Locations/TownGate.jpeg");
            newWorld.AddLocation(2, 0, "Spider Forest",//"Spider Forest"
                "The trees in this forest are covered with spider webs.",
                "/Engine;component/Images/Locations/DawnWoodForest.jpeg");
            newWorld.AddLocation(0, 1, "Herbalist's hut",//"Herbalist's hut"
                "You see a small hut, with plants drying from the roof.",
                "/Engine;component/Images/Locations/LynxCabin.jpeg");
            newWorld.AddLocation(0, 2, "Herbalist's garden",//"Herbalist's garden"
                "There are many plants here, with snakes hiding behind them.",
                "/Engine;component/Images/Locations/GrassyLand.jpeg");
            return newWorld;
        }
    }
}
