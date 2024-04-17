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
        public ItemCategory Category { get; set; } // Add setter for Category
        public int ItemTypeID { get; }
        public string Name { get; set; }
        public int Price { get; set; }
        public bool IsUnique { get; }
        public IAction Action { get; set; }

        public GameItem(ItemCategory category, int itemTypeID, string name, string imagePath, int price,
                        bool isUnique = false, IAction action = null)
        {
            ImagePath = imagePath;
            Category = category; // Initialize Category in the constructor
            ItemTypeID = itemTypeID;
            Name = name;
            Price = price;
            IsUnique = isUnique;
            Action = action;
        }

        public void PerformAction(LivingEntity actor, LivingEntity target)
        {
            // Get the current time
            DateTime currentTime = DateTime.Now;

            // Calculate the time elapsed since the last click
            TimeSpan elapsedTime = currentTime - _lastClickTime;

            // Check if the elapsed time is below the threshold
            if (elapsedTime >= _clickThreshold)
            {
                // Update the last click time only if enough time has passed since the last click
                _lastClickTime = currentTime;

                // Execute the action
                Action?.Execute(actor, target);
            }
        }

        public GameItem Clone()
        {
            return new GameItem(Category, ItemTypeID, Name, ImagePath, Price, IsUnique, Action);
        }

        // Other methods...
    }

}