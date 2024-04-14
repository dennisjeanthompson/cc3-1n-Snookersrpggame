using Engine.Actions;
namespace Engine.Models
{
    public class GameItem
    {
        public enum ItemCategory
        {
            Miscellaneous,
            Weapon,
            Consumable
        }
        public string ImagePath { get; set; }
        public ItemCategory Category { get; }
        public int ItemTypeID { get; }
        public string Name { get; }
        public int Price { get; }
        public bool IsUnique { get; }
        public IAction Action { get; set; }
        public GameItem(ItemCategory category, int itemTypeID, string name,string imagePath, int price,
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
            Action?.Execute(actor, target);
        }
        public GameItem Clone()
        {
            return new GameItem(Category, ItemTypeID, Name,ImagePath, Price, IsUnique, Action);
        }
       
            
            // Other properties...
        

    }
}