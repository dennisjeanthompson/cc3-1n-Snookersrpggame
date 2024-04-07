﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Engine.Models;
namespace Engine.Factories
{
internal static  class WorldFactory
    {
        public  static World  CreateWorld()
        {
            World newWorld = new World();
            newWorld.AddLocation(0, -1, "Player's Home", "This is the place where you currently live", "/Engine;component/Images/Locations/Home.jpg");
            newWorld.AddLocation(-1, -1, "Benu Farm House", "This is your neighbour's house  named Benu", "/Engine;component/Images/Locations/BenuFarmHouse.jpg");
            newWorld.LocationAt(-1, -1).QuestsAvailableHere.Add(QuestFactory.GetQuestByID(1));
            newWorld.AddLocation(-2, -1, "Benu's Farm Field", "This place is Benu's Corn field. Its a grassy field with wild animals", "/Engine;component/Images/Locations/BenuFarmField.jpg");
            newWorld.LocationAt(-2, -1).AddMonster(2, 100);
            newWorld.AddLocation(0, 1, "Lynx Cabin", "This is shop of Lynx where you can trade, buy items and potions of Lynx ", "/Engine;component/Images/Locations/LynxCabin.png");
            newWorld.LocationAt(0,1).QuestsAvailableHere.Add(QuestFactory.GetQuestByID(2));
            newWorld.LocationAt(0, 1).QuestsAvailableHere.Add(QuestFactory.GetQuestByID(3));
            newWorld.AddLocation(0, 2, "Grassy Land", "This place is filled with tall grasses where wild giant animals live.", "/Engine;component/Images/Locations/GrassyLand.png");
            newWorld.LocationAt(0, 2).AddMonster(1, 100);
            newWorld.AddLocation(1, 0, "Town Gate", "A huge gate in the town protecting from the Wild Bear and unknown creatures", "/Engine;component/Images/Locations/TownGate.png");
  
            newWorld.AddLocation(2, 0, "Dawn Wood Forest", "A place filled with tall trees and wild giant animals", "/Engine;component/Images/Locations/DawnWoodForest.png");
            newWorld.LocationAt(2, 0).AddMonster(3, 100);
            newWorld.AddLocation(-1, 0, "Alma Market Shop", "The market shop of Alma. He sells weapons and other items", "/Engine;component/Images/Locations/AlmaMarketSquare.jpg");
            newWorld.AddLocation(0, 0, "Eldoria Town Square", "A beautiful town of Eldoria", "/Engine;component/Images/Locations/EldoriaTownSquare.png");





            return newWorld;
        }
    }
}
