using System;
using System.Collections.Generic;
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
            _standardGameItems.Add(new Weapon(100, "Iron Sword", 2, "Forgeheart Blade", 1, 3));
            _standardGameItems.Add(new Weapon(101, "Golden Sword", 6, "Sunfire Glimmer",1,5));
            _standardGameItems.Add(new Weapon(102, "Pink Sword", 5, "Rose Blossom Azure ", 1, 3));
            _standardGameItems.Add(new Weapon(103, "Blue Sword", 10, "Azure Frostblade", 1, 6));
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
