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

            BuildWeapon(1006, "Chain Sword", "/CharacterImage/ChainSwrd.jpg", 4669, 14, 39);
            BuildWeapon(1007, "Amino Sword", "/CharacterImage/AminoSword.jpg", 6000, 30, 52);
            BuildWeapon(1008, "Albino Sword", "/CharacterImage/GreensW.jpg", 6091, 28, 46);

            BuildWeapon(1501, "Bear claw", "/Background/BeareClawz.png", 9999, 80, 100);
            BuildWeapon(1502, "Centepede Essence", "/Background/CentepedeEssence.jpg", 901, 2, 4);
            BuildWeapon(1503, "Centepede Eye", "/Background/EYEcentepede.jpg", 50, 3, 10);
            //  BuildWeapon(1504, "Blood of Satan", "/Background/bottleblood.jpg", 50, 0, 0);//
              
            //Elixir of Resilience
            BuildHealingItem(2001, "Satanic Potion", "/Background/Potionz.png", 510, 29);
            BuildHealingItem(2002, "Blood of Satan", "/Background/bottleblood.jpg", 1000, 50);
            BuildHealingItem(2003, "Centepede Juice", "/CharacterImage/greenpotion.png", 390, 10);
            //
            //
            BuildHealingItem(2004, "Violet Potion", "/CharacterImage/PorionGreen.png", 121, 10);
            BuildHealingItem(2005, "Angel Potion", "/CharacterImage/VioletPotion.jpg", 200, 20);

            BuildHealingItem(2004, "Summon Satan", "/BackGround/kingDemon.jpg", 9999, 9999);
            //king demon



            BuildMiscellaneousItem(3001, "Egg ", "/Background/bottleblood.jpg", 31);
            BuildMiscellaneousItem(3002, "Tongue", "", 23);
            BuildMiscellaneousItem(3003, "Coke", "", 25);

            BuildMiscellaneousItem(3004, "Rat feet", "", 5000);
            BuildMiscellaneousItem(3005, "Rat skin", "", 1000);
            BuildMiscellaneousItem(3006, "Rat feces", "", 999);




            BuildMiscellaneousItem(3001, "Blood of Satan", "/Background/bottleblood.jpg", 31);
            BuildMiscellaneousItem(3002, "Honey", "", 23);
            BuildMiscellaneousItem(3003, "Raisins", "", 25);

            BuildMiscellaneousItem(3004, "Rat feet", "", 5000);
            BuildMiscellaneousItem(3005, "Rat skin", "", 1000);
            BuildMiscellaneousItem(3006, "Rat feces", "", 999);

            BuildMiscellaneousItem(3010, "Satan Body", "", 1200);
            BuildMiscellaneousItem(3011, "Satan Legs", "", 1000);
            BuildMiscellaneousItem(3012, "Satan Heart", "", 1900);

            BuildMiscellaneousItem(3013, "Satan Feet", "", 500);
            BuildMiscellaneousItem(3014, "Satan Genetelia", "", 2090);
            BuildMiscellaneousItem(3015, "Satan Arms", "",400 );





            BuildMiscellaneousItem(9001, "Serpent Scale", "/Background/SerpentScale.png", 129);
            BuildMiscellaneousItem(9002, "Toxic Gland", "/Background/ToxicGland.png", 223);
            BuildMiscellaneousItem(9003, "Centepede Essence", "Background/CentepedeEssence.jpg", 113);
            BuildMiscellaneousItem(9004, "Centepede Eye", "Background/EYEcentepede.jpg", 233);
            BuildMiscellaneousItem(9005, "Bear Claw", "/Background/BeareClawz.png", 2909);
            BuildMiscellaneousItem(9006, "Bear Gallblader", "/Background/BearGallblader.png", 999);

            BuildMiscellaneousItem(3007, "Iron", "/Background/BearGallblader.png", 100);
            BuildMiscellaneousItem(3008, "Metal", "/Background/BearGallblader.png", 999);
            BuildMiscellaneousItem(3009, "Grip", "/Background/BearGallblader.png", 999);


        }

      

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