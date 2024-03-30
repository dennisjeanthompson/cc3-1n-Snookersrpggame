using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Engine.Models
{
    internal static class ItemFactory
    {
        private static List<GameItem> _standardGameItems;
        static ItemFactory() {
        
        _standardGameItems = new List<GameItem>();
            _standardGameItems.Add(new Weapon(100, "Iron Sword", 9000, "/Background/RedSwordzx.png", 1, 3));
            _standardGameItems.Add(new Weapon(101, "Fire Sword", 20000, "/Background/fireezzz.png", 1, 3));
            _standardGameItems.Add(new Weapon(102, "Golden Sword", 99000, "/Background/sowrdssz.jpg", 1,5));
            _standardGameItems.Add(new Weapon(103, "Pink Sword", 50000, "/Background/SwordReed.png", 1, 3));
            _standardGameItems.Add(new Weapon(104, "Blue Sword", 60000, "/Background/glowing_sword_only__3045701784.png", 1, 6));
            _standardGameItems.Add(new GameItem(201, "Potion", 12000, "/Background/Potionz.png"));//healing??
            _standardGameItems.Add(new GameItem(202, "skulle", 1000, "/Background/wierd_small_evil_item__3517160176.png"));
            _standardGameItems.Add(new GameItem(203, "Skullz", 2000, "/Background/wierd_small_evil_item_dead__1343190293.png"));
            _standardGameItems.Add(new GameItem(204, "Bear Claw", 9500, "/Background/BeareClawz.png"));
            _standardGameItems.Add(new GameItem(205, "Bear Gallbladder",1200 , "/Background/BearGallblader.png"));
            _standardGameItems.Add(new GameItem(206, "Centepede Essence", 1000, "/Background/CentepedeEssence.jpg"));
            _standardGameItems.Add(new GameItem(207, "Centepede Eye", 1000, "/Background/EYEcentepede.jpg"));
            _standardGameItems.Add(new GameItem(208, "Serpent Scale", 2000, "/Background/SerpentScale.png"));
            _standardGameItems.Add(new GameItem(209, "Toxic Gland", 3000, "/Background/ToxicGland.png"));
           



        }

        public static GameItem CreateGameItem(int itemTypeID)
   {
       GameItem standardItem = _standardGameItems.FirstOrDefault(item => item.ItemTypeID == itemTypeID);

       if (standardItem != null)
       {
           return standardItem.Clone();
       }
       else
       {
           // Throw an exception if the itemTypeID does not correspond to any item
           throw new ArgumentException($"Item with type ID {itemTypeID} does not exist.", nameof(itemTypeID));
       }
   }

           
     
















    }



}
