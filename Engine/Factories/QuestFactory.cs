using System.Collections.Generic;
using System.Linq;
using Engine.Models;
namespace Engine.Factories
{
    internal static class QuestFactory
    {
        private static readonly List<Quest> _quests = new List<Quest>();
        static QuestFactory()
        {
            // Declare the items need to complete the quest, and its reward items
            List<ItemQuantity> itemsToComplete = new List<ItemQuantity>();
            List<ItemQuantity> rewardItems = new List<ItemQuantity>();
            List<ItemQuantity> itemsToComplete1 = new List<ItemQuantity>();
            List<ItemQuantity> rewardItems1 = new List<ItemQuantity>();
            List<ItemQuantity> itemsTOcOMPLETE2 = new List<ItemQuantity>();
            List<ItemQuantity> REWARDITEMS2 = new List<ItemQuantity>();
            itemsToComplete.Add(new ItemQuantity(9003, 6));//
            rewardItems.Add(new ItemQuantity(1005, 1));
            //2 
            itemsToComplete1.Add(new ItemQuantity(9005, 3));//bear
            rewardItems1.Add(new ItemQuantity(1004, 1));
            itemsTOcOMPLETE2.Add(new ItemQuantity(9004, 2));
            REWARDITEMS2.Add(new ItemQuantity(1002, 1));
            //itemsToComplete.Add(new ItemQuantity(1503, 6));
            //rewardItems.Add(new ItemQuantity(102, 1));
            // Create the quest
            _quests.Add(new Quest(1,
                                  "Essence of the Centipede",
                                  "Quest to collect 2 Centipede essence  located in the Grassy Land",
                                  itemsTOcOMPLETE2,
                                  40, 1000,
                                  REWARDITEMS2));
            _quests.Add(new Quest(2,
                             "Eyes of the Grasslands",
                             "Quest to collect 6 Centipede eyes  located in the Grassy Land",
                              itemsToComplete,
                              45, 9900,
                        rewardItems));
            _quests.Add(new Quest(3,
                             "Bear Claw",
                             "Quest to collect 3 Bear claws located in DawnWood Forest",
                             itemsToComplete1,
                              199, 8000,
                              rewardItems1));

            /* itemsToComplete.Add(new ItemQuantity(204, 3));
            rewardItems.Add(new ItemQuantity(104, 1));
            itemsToComplete.Add(new ItemQuantity(206, 2));
            rewardItems.Add(new ItemQuantity(101, 1));
            itemsToComplete.Add(new ItemQuantity(207, 6));
            rewardItems.Add(new ItemQuantity(102, 1));
             *  BuildWeapon(1001, "Red Sword", 1, 1, 2);
            BuildWeapon(1002, "Fire Sword", 50, 1, 3);
            BuildWeapon(1003, "Golden Sword", 100, 2, 8);
            BuildWeapon(1004, "Demon Sword", 500, 4, 10);
            BuildWeapon(1005, "Blue Sword", 60, 1, 3);
            BuildWeapon(1501, "Bear claw", 9999, 80, 100);
            BuildWeapon(1502, "Centepede Essence", 901, 10, 80);
            BuildWeapon(1503, "Centepede Eye", 50, 2, 19);
            BuildHealingItem(2001, "Satanic Potion", 51, 29);
            BuildMiscellaneousItem(3001, "Crook", 31);
            BuildMiscellaneousItem(3002, "Honey", 23);
            BuildMiscellaneousItem(3003, "Raisins", 25);
            BuildMiscellaneousItem(9001, "Serpent Scale", 129);
            BuildMiscellaneousItem(9002, "Toxic Gland", 223);
            BuildMiscellaneousItem(9003, "Centepede Essence", 113);
            BuildMiscellaneousItem(9004, "Centepede Eye", 233);
            BuildMiscellaneousItem(9005, "Bear Claw", 2909);
            BuildMiscellaneousItem(9006, "Bear Gallblader", 999);
             * d  asdaw          
             * _standardGameItems.Add(new Weapon(100, "Red Sword", 9000, "/Background/RedSwordzx.png", 1, 3));
                _standardGameItems.Add(new Weapon(101, "Fire Sword", 20000, "/Background/fireezzz.png", 1, 3));
                _standardGameItems.Add(new Weapon(102, "Golden Sword", 99000, "/Background/sowrdssz.jpg", 1,5));
                _standardGameItems.Add(new Weapon(103, "Demon Sword", 50000, "/Background/SwordReed.png", 1, 3));
                _standardGameItems.Add(new Weapon(104, "Blue Sword", 60000, "/Background/glowing_sword_only__3045701784.png", 1, 6));
                _standardGameItems.Add(new GameItem(201, "Potion", 12000, "/Background/Potionz.png"));//healing??//N
                _standardGameItems.Add(new GameItem(202, "Evil Skull", 1000, "/Background/wierd_small_evil_item__3517160176.png"));
                _standardGameItems.Add(new GameItem(203, "Satan Skull", 2000, "/Background/wierd_small_evil_item_dead__1343190293.png"));
                _standardGameItems.Add(new GameItem(204, "Bear Claw", 9500, "/Background/BeareClawz.png"));
                _standardGameItems.Add(new GameItem(205, "Bear Gallbladder",1200 , "/Background/BearGallblader.png"));
                _standardGameItems.Add(new GameItem(206, "Centepede Essence", 1000, "/Background/CentepedeEssence.jpg"));
                _standardGameItems.Add(new GameItem(207, "Centepede Eye", 1000, "/Background/EYEcentepede.jpg"));
                _standardGameItems.Add(new GameItem(208, "Serpent Scale", 2000, "/Background/SerpentScale.png"));
                _standardGameItems.Add(new GameItem(209, "Toxic Gland", 3000, "/Background/ToxicGland.png"));
             * 
             * 
             *   _quests.Add(new Quest(1, "Bear Claw", "Quest to collect 3 Bear claws located in DawnWood Forest.", 10, 80, itemsToComplete, rewardItems));
                 _quests.Add(new Quest(2, "Essence of the Centipede", "Quest to collect Centipede essence 2 located in the Grassy Land.", 2, 10, itemsToComplete, rewardItems));
                 _quests.Add(new Quest(3, "Eyes of the Grasslands", "Quest to collect 6 Centipede eyes located in the Grassy Land.", 7, 50, itemsToComplete, rewardItems));

             * 
             * 
             * 
             * 
             * 
             * 
             * 
             * 
             * 
             */











        }
        internal static Quest GetQuestByID(int id)
        {
            return _quests.FirstOrDefault(quest => quest.ID == id);
        }
    }
}