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
          
            // Search for the quest with the given ID in the list
            foreach (Quest quest in _quests)
            {
                if (quest.Id == questID)
                {
                    // Return the quest if found
                    return quest;
                }
            }

            // Return null if no quest with the given ID is found
            return null;
        }

        /*
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

        */
      //  Slay the giant centipede terrorizing the Grassy Land  to claim victory.
         //   Collect 5 Centipede eye located in  Grassy land.
          //  Collect  Centipede essence located in Grassy land.

      //  "Eyes of the Grasslands" - Quest to collect 5 Centipede eyes located in the Grassy Land.
//"Essence of the Centipede" - Quest to collect Centipede essence located in the Grassy Land.
//"Confronting the Colossal Centipede" - Quest to slay the giant centipede terrorizing the Grassy Land to claim victory.








        private static List<Quest> _quests = new List<Quest>();     


        static QuestFactory()
        {
            List<ItemQuantity> itemsToComplete = new List<ItemQuantity>();
            List<ItemQuantity> rewardItems = new List<ItemQuantity>();
            itemsToComplete.Add(new ItemQuantity(4001, 3));
            rewardItems.Add(new ItemQuantity(4002, 1));
            itemsToComplete.Add(new ItemQuantity(5003, 2));
            rewardItems.Add(new ItemQuantity(5004, 1));
            itemsToComplete.Add(new ItemQuantity(6003, 6));
            rewardItems.Add(new ItemQuantity(6004, 1));
            _quests = new List<Quest>();
            _quests.Add(new Quest(1, "Bear Claw", "Quest to collect 3 Bear claws located in DawnWood Forest.", 10, 80, itemsToComplete, rewardItems));
            _quests.Add(new Quest(2, "Essence of the Centipede", "Quest to collect Centipede essence 2 located in the Grassy Land.", 2, 10, itemsToComplete, rewardItems));
            _quests.Add(new Quest(3, "Eyes of the Grasslands", "Quest to collect 6 Centipede eyes located in the Grassy Land.", 7, 50, itemsToComplete, rewardItems));
        }
        //ublic Quest(int id,string name,string description,int rewarexpPoints,int rewardGold, List<ItemQuantity> itemsToComplete, List<ItemQuantity> rewardItems)
        // .Similar to the ItemFactory class add a static property quests that holds all Quests for the game.
        //     Inside the static constructor of the QuestFactory class instantiate all the Quests for the game and then add it all to the static property quests.
        //  Under the QuestFactory class add a method named GetQuestByID that should return a Quest for the given ID.
    }
}
