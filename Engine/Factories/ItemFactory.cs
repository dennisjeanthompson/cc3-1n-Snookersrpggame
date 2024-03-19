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
            _standardGameItems.Add(new Weapon(100, "Iron Sword", 1, "Forgeheart Blade", 1, 3));
            _standardGameItems.Add(new Weapon(101, "Golden Sword", 6, "Sunfire Glimmer",1,4));



            // If the GameItem is not null return a clone of the GameItem. Else return null.




        }
     
        public static GameItem  CreateGameItem()
        {
            // return _standardGameItems.FirstOrDefault(item => item.ItemTypeID == itemId);
            //If the GameItem is not null return a clone of the GameItem. Else return null.

            if (_standardGameItems.Count > 0)
            {
                // Return the first item from the list (index 0)
                return _standardGameItems[0].Clone();

                
            }

            else
            {
                // If the list is empty, return null
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
