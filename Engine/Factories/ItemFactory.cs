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
            _standardGameItems.Add(new Weapon(100, "Iron Sword", 9000, "/ Engine; component / Images / ItemImage /RedSwordzx.png", 1, 3));
            _standardGameItems.Add(new Weapon(101, "Fire Sword", 20000, "/ Engine; component / Images / ItemImage /fireezzz.png", 1, 3));
            _standardGameItems.Add(new Weapon(102, "Golden Sword", 99000, "/ Engine; component / Images / ItemImage / sowrdssz.jpg", 1,5));
            _standardGameItems.Add(new Weapon(103, "Pink Sword", 50000, "/ Engine; component / Images / ItemImage / SwordReed.png", 1, 3));
            _standardGameItems.Add(new Weapon(104, "Blue Sword", 60000, "/ Engine; component / Images / ItemImage /glowing_sword_only__3045701784.png", 1, 6));
            _standardGameItems.Add(new GameItem(201, "Potion", 12000, "/ Engine; component / Images / ItemImage / Potionz.png"));//healing??
            _standardGameItems.Add(new GameItem(202, "skulle", 1000, "/ Engine; component / Images / ItemImage / wierd_small_evil_item__3517160176.png"));
            _standardGameItems.Add(new GameItem(203, "Skullz", 2000, "/ Engine; component / Images / ItemImage / wierd_small_evil_item_dead__1343190293.png"));
            _standardGameItems.Add(new GameItem(204, "Bear Claw", 9500, "/ Engine; component / Images / ItemImage / BeareClawz.png"));
            _standardGameItems.Add(new GameItem(205, "Bear Gallbladder",1200 , "/ Engine; component / Images / ItemImage /BearGallblader.png"));
            _standardGameItems.Add(new GameItem(206, "Centepede Essence", 1000, "/ Engine; component / Images / ItemImage / CentepedeEssence.jpg"));
            _standardGameItems.Add(new GameItem(207, "Centepede Eye", 1000, "/ Engine; component / Images / ItemImage / EYEcentepede.jpg"));
            _standardGameItems.Add(new GameItem(208, "Serpent Scale", 2000, "/ Engine; component / Images / ItemImage / SerpentScale.png"));
            _standardGameItems.Add(new GameItem(209, "Toxic Gland", 3000, "/ Engine; component / Images / ItemImage / ToxicGland.png"));

        


            // int itemTypeId,string name,int price,string imageName)
            //   public Weapon(int itemTypeId, string name, int price, string imageName, int minmimumDamage,int maxmimumDamage) :base(itemTypeId,  name,price, imageName)



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

           
       /* public static GameItem CreateGameItem(int itemTypeID)
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

        */
















    }



}
