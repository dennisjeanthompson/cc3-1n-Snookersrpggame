using Engine.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Xml.Linq;
namespace Engine.Factories
{
    internal class QuestFactory

    {
       
        public static Quest GetQuestByID(int questID)
        {
          
          
            foreach (Quest quest in _quests)
            {
                if (quest.Id == questID)
                {
                   
                    return quest;
                }
            }

      
            return null;
        }

      






        private static List<Quest> _quests = new List<Quest>();     


        static QuestFactory()
        {
            List<ItemQuantity> itemsToComplete = new List<ItemQuantity>();
            List<ItemQuantity> rewardItems = new List<ItemQuantity>();
            itemsToComplete.Add(new ItemQuantity(204, 3));
            rewardItems.Add(new ItemQuantity(104, 1));
            itemsToComplete.Add(new ItemQuantity(206, 2));
            rewardItems.Add(new ItemQuantity(101, 1));
            itemsToComplete.Add(new ItemQuantity(207, 6));
            rewardItems.Add(new ItemQuantity(102, 1));
            _quests = new List<Quest>();
            _quests.Add(new Quest(1, "Bear Claw", "Quest to collect 3 Bear claws located in DawnWood Forest.", 10, 80, itemsToComplete, rewardItems));
            _quests.Add(new Quest(2, "Essence of the Centipede", "Quest to collect Centipede essence 2 located in the Grassy Land.", 2, 10, itemsToComplete, rewardItems));
            _quests.Add(new Quest(3, "Eyes of the Grasslands", "Quest to collect 6 Centipede eyes located in the Grassy Land.", 7, 50, itemsToComplete, rewardItems));





        }
      
    }
}
//add item
/*
__standardGameItems.Add(new Weapon(100, "Iron Sword", 2, "/ Engine; component / Images / ItemImage /RedSwordzx.png", 1, 3));
            _standardGameItems.Add(new Weapon(101, "Fire Sword", 2, "/ Engine; component / Images / ItemImage /fireezzz.png", 1, 3));
            _standardGameItems.Add(new Weapon(102, "Golden Sword", 6, "/ Engine; component / Images / ItemImage / sowrdssz.jpg", 1,5));
            _standardGameItems.Add(new Weapon(103, "Pink Sword", 5, "/ Engine; component / Images / ItemImage / SwordReed.png", 1, 3));
            _standardGameItems.Add(new Weapon(104, "Blue Sword", 10, "/ Engine; component / Images / ItemImage /glowing_sword_only__3045701784.png", 1, 6));
            _standardGameItems.Add(new GameItem(201, "Potion", 15, "/ Engine; component / Images / ItemImage / Potionz.png"));//healing??
            _standardGameItems.Add(new GameItem(202, "skulle", 4, "/ Engine; component / Images / ItemImage / wierd_small_evil_item__3517160176.png"));
            _standardGameItems.Add(new GameItem(203, "Skullz", 10, "/ Engine; component / Images / ItemImage / wierd_small_evil_item_dead__1343190293.png"));
            _standardGameItems.Add(new GameItem(204, "Bear Claw", 9500, "/ Engine; component / Images / ItemImage / BeareClawz.png"));
            _standardGameItems.Add(new GameItem(205, "Bear Gallbladder",1200 , "/ Engine; component / Images / ItemImage /BearGallblader.png"));
            _standardGameItems.Add(new GameItem(206, "Centepede Essence", 1000, "/ Engine; component / Images / ItemImage / CentepedeEssence.jpg"));
            _standardGameItems.Add(new GameItem(207, "Centepede Eye", 1000, "/ Engine; component / Images / ItemImage / EYEcentepede.jpg"));
            _standardGameItems.Add(new GameItem(208, "Serpent Scale", 2000, "/ Engine; component / Images / ItemImage / SerpentScale.png"));
            _standardGameItems.Add(new GameItem(209, "Toxic Gland", 3000, "/ Engine; component / Images / ItemImage / ToxicGland.png"));
*/
