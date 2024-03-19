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






        private static List<Quest> _quests;     


        static QuestFactory()
        {
            _quests = new List<Quest>();

        }

       // .Similar to the ItemFactory class add a static property quests that holds all Quests for the game.
       //     Inside the static constructor of the QuestFactory class instantiate all the Quests for the game and then add it all to the static property quests.
     //  Under the QuestFactory class add a method named GetQuestByID that should return a Quest for the given ID.
    }
}
