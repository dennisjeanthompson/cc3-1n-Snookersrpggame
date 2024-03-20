using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Models
{
    public class Quest
    {
        public int Id { get; set; } 
        public string Name { get; set; }    
        public string Description { get; set; }
        public int RewardExpPoints { get; set; }
        public int RewardGold { get; set; }
   
      // RewardItems: List<ItemQuantity>
            public List<ItemQuantity> ItemsToComplete { get; set; }
        public List<ItemQuantity> RewardItems { get; set; }




        public Quest(int id,string name,string description,int rewarexpPoints,int rewardGold, List<ItemQuantity> itemsToComplete, List<ItemQuantity> rewardItems)

        {
            Id = id;
            Name = name;
            Description = description;
            RewardExpPoints = rewarexpPoints;
            RewardGold = rewardGold;
            ItemsToComplete = itemsToComplete;
            RewardItems = rewardItems;


        }




    }

   


}
