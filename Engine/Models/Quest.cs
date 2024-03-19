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
    }




}
