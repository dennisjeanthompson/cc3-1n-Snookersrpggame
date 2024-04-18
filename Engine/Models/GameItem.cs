using Engine.Actions;
using System;
namespace Engine.Models
{
    public class GameItem
    {
        private DateTime _lastClickTime;
        private readonly TimeSpan _clickThreshold = TimeSpan.FromSeconds(1);

        public enum ItemCategory
        {
            Miscellaneous, 
            Weapon,
            Consumable
        }

        public string ImagePath { get; set; }
        public ItemCategory Category { get; set; } 
        public int ItemTypeID { get; }
        public string Name { get; set; }
        public int Price { get; set; }
        public bool IsUnique { get; }
        public IAction Action { get; set; }

        public GameItem(ItemCategory category, int itemTypeID, string name, string imagePath, int price,
                        bool isUnique = false, IAction action = null)
        {
            ImagePath = imagePath;
            Category = category; 
            ItemTypeID = itemTypeID;
            Name = name;
            Price = price;
            IsUnique = isUnique;
            Action = action;
        }

        public void PerformAction(LivingEntity actor, LivingEntity target)
        {
            
            DateTime currentTime = DateTime.Now;

            TimeSpan elapsedTime = currentTime - _lastClickTime;

            
            if (elapsedTime >= _clickThreshold)
            {
               
                _lastClickTime = currentTime;

                
                Action?.Execute(actor, target);
            }
        }

        public GameItem Clone()
        {
            return new GameItem(Category, ItemTypeID, Name, ImagePath, Price, IsUnique, Action);
        }

       
    }

}