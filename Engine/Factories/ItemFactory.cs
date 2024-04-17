using System.Collections.Generic;
using System.Linq;
using Engine.Actions;
using Engine.Models;
namespace Engine.Factories
{
    public static class ItemFactory
    {
        private static readonly List<GameItem> _standardGameItems = new List<GameItem>();
        static ItemFactory()
        {
            BuildWeapon(1001, "Red Sword", "/Background/RedSwordzx.png", 14, 2, 5);
            BuildWeapon(1002, "Fire Sword", "/Background/fireezzz.png", 50, 4, 8);
            BuildWeapon(1003, "Golden Sword", "/Background/sowrdssz.jpg", 100, 8, 19);
            BuildWeapon(1004, "Demon Sword", "/Background/SwordReed.png", 500, 9, 18);
            BuildWeapon(1005, "Blue Sword", "/Background/glowing_sword_only__3045701784.png", 60, 10, 30);
            BuildWeapon(1501, "Bear claw", "/Background/BeareClawz.png", 9999, 80, 100);
            BuildWeapon(1502, "Centepede Essence", "/Background/CentepedeEssence.jpg", 901, 2, 4);
            BuildWeapon(1503, "Centepede Eye", "/Background/EYEcentepede.jpg", 50, 3, 10);
          //  BuildWeapon(1504, "Blood of Satan", "/Background/bottleblood.jpg", 50, 0, 0);//


            BuildHealingItem(2001, "Satanic Potion", "/Background/Potionz.png", 51, 29);
            BuildHealingItem(2002, "Blood of Satan", "/Background/bottleblood.jpg", 100, 50);

            BuildMiscellaneousItem(3001, "Blood of Satan", "/Background/bottleblood.jpg", 31);
            BuildMiscellaneousItem(3002, "Honey", "", 23);
            BuildMiscellaneousItem(3003, "Raisins", "", 25);
            BuildMiscellaneousItem(9001, "Serpent Scale", "/Background/SerpentScale.png", 129);
            BuildMiscellaneousItem(9002, "Toxic Gland", "/Background/ToxicGland.png", 223);
            BuildMiscellaneousItem(9003, "Centepede Essence", "Background/CentepedeEssence.jpg", 113);
            BuildMiscellaneousItem(9004, "Centepede Eye", "Background/EYEcentepede.jpg", 233);
            BuildMiscellaneousItem(9005, "Bear Claw", "/Background/BeareClawz.png", 2909);
            BuildMiscellaneousItem(9006, "Bear Gallblader", "/Background/BearGallblader.png", 999);
        }

        /*
         * 
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
         */

        public static GameItem CreateGameItem(int itemTypeID)
        {
            return _standardGameItems.FirstOrDefault(item => item.ItemTypeID == itemTypeID)?.Clone();
        }
        private static void BuildMiscellaneousItem(int id, string name,string imagePath, int price)
        {
            _standardGameItems.Add(new GameItem(GameItem.ItemCategory.Miscellaneous, id, name,imagePath, price));
        }
        private static void BuildWeapon(int id, string name,string imagePath ,int price,
                                        int minimumDamage, int maximumDamage)
        {
            GameItem weapon = new GameItem(GameItem.ItemCategory.Weapon, id, name,imagePath, price, true);
            weapon.Action = new AttackWithWeapon(weapon, minimumDamage, maximumDamage);
            _standardGameItems.Add(weapon);
        }
        private static void BuildHealingItem(int id, string name,string imagePath, int price, int hitPointsToHeal)
        {
            GameItem item = new GameItem(GameItem.ItemCategory.Consumable, id, name,imagePath, price);
            item.Action = new Heal(item, hitPointsToHeal);
            _standardGameItems.Add(item);
        }
        public static string ItemName(int itemTypeID)
        {
            return _standardGameItems.FirstOrDefault(i => i.ItemTypeID == itemTypeID)?.Name ?? "";
        }
    }
}