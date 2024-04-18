using System.Collections.Generic;
using System.Linq;
using Engine.Models;
namespace Engine.Factories
{
    internal static class QuestFactory
    {
        private static readonly List<Quest> _quests = new List<Quest>();
        static QuestFactory()
        {
            // Declare the items need to complete the quest, and its reward items
            List<ItemQuantity> itemsToComplete = new List<ItemQuantity>();
            List<ItemQuantity> rewardItems = new List<ItemQuantity>();
            List<ItemQuantity> itemsToComplete1 = new List<ItemQuantity>();
            List<ItemQuantity> rewardItems1 = new List<ItemQuantity>();
            List<ItemQuantity> itemsTOcOMPLETE2 = new List<ItemQuantity>();
            List<ItemQuantity> REWARDITEMS2 = new List<ItemQuantity>();
            itemsToComplete.Add(new ItemQuantity(9003, 6));//
            rewardItems.Add(new ItemQuantity(1005, 1));
            //2 
            itemsToComplete1.Add(new ItemQuantity(9005, 3));//bear
            rewardItems1.Add(new ItemQuantity(1004, 1));
            itemsTOcOMPLETE2.Add(new ItemQuantity(9004, 2));
            REWARDITEMS2.Add(new ItemQuantity(1002, 1));
            //itemsToComplete.Add(new ItemQuantity(1503, 6));
            //rewardItems.Add(new ItemQuantity(102, 1));
            // Create the quest
            _quests.Add(new Quest(1,
                                  "Essence of the Centipede",
                                  "Quest to collect 2 Centipede essence  located in the Grassy Land",
                                  itemsTOcOMPLETE2,
                                  40, 1000,
                                  REWARDITEMS2));
            _quests.Add(new Quest(2,
                             "Eyes of the Grasslands",
                             "Quest to collect 6 Centipede eyes  located in the Grassy Land",
                              itemsToComplete,
                              45, 9900,
                        rewardItems));
            _quests.Add(new Quest(3,
                             "Bear Claw",
                             "Quest to collect 3 Bear claws located in DawnWood Forest",
                             itemsToComplete1,
                              199, 8000,
                              rewardItems1));

        









        }
        internal static Quest GetQuestByID(int id)
        {
            return _quests.FirstOrDefault(quest => quest.ID == id);
        }
    }
}