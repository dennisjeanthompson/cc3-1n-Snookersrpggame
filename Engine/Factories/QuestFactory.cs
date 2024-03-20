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
      
    }
}
