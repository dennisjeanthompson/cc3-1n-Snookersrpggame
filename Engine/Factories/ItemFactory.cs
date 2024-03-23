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
            _standardGameItems.Add(new Weapon(100, "Iron Sword", 2, "/ Engine; component / Images / ItemImage /RedSwordzx.png", 1, 3));
            _standardGameItems.Add(new Weapon(100, "Iron Sword", 2, "/ Engine; component / Images / ItemImage /fireezzz.png", 1, 3));
            _standardGameItems.Add(new Weapon(101, "Golden Sword", 6, "/ Engine; component / Images / ItemImage / sowrdssz.jpg", 1,5));
            _standardGameItems.Add(new Weapon(102, "Pink Sword", 5, "/ Engine; component / Images / ItemImage / SwordReed.png", 1, 3));
            _standardGameItems.Add(new Weapon(103, "Blue Sword", 10, "/ Engine; component / Images / ItemImage /glowing_sword_only__3045701784.png", 1, 6));
            _standardGameItems.Add(new GameItem(104, "Potion", 15, "/ Engine; component / Images / ItemImage / Potionz.png"));
            _standardGameItems.Add(new GameItem(106, "skulle", 4, "/ Engine; component / Images / ItemImage / wierd_small_evil_item__3517160176.png"));
            _standardGameItems.Add(new GameItem(107, "Skullz", 10, "/ Engine; component / Images / ItemImage / wierd_small_evil_item_dead__1343190293.png"));

            // int itemTypeId,string name,int price,string imageName)




        }

        public static GameItem  CreateGameItem()
        {
          

            if (_standardGameItems.Count > 0)
            {
             
                return _standardGameItems[0].Clone();

                
            }

            else
            {
              
                return null;
            }



















            /*  foreach(var items in _standardGameItems)
              {
                  return items;
                  if(_standardGameItems != null)
                  {
                      _standardGameItems.Clone()
                  }
                  else { return null; }
              }

                                      */

            /* return _standardGameItems;
             if(_standardGameItems != null)
             {
                 _standardGameItems.Clone();
             }
             else
             {
                 return null;
             }*/
        }
       

    }
}
