using System;
using System.Collections.Generic;
using System.Linq;
using Engine.Models;
namespace Engine.Factories
{
    public static class TraderFactory
    {
        private static readonly List<Trader> _traders = new List<Trader>();
        static TraderFactory()
        {
            Trader susan = new Trader("Alma");
            susan.AddItemToInventory(ItemFactory.CreateGameItem(1002));//weapons
            susan.AddItemToInventory(ItemFactory.CreateGameItem(1003));
            susan.AddItemToInventory(ItemFactory.CreateGameItem(1004));
            susan.AddItemToInventory(ItemFactory.CreateGameItem(1005));
            Trader farmerTed = new Trader("Lynx");
            farmerTed.AddItemToInventory(ItemFactory.CreateGameItem(2001));//potions
            farmerTed.AddItemToInventory(ItemFactory.CreateGameItem(2002));
           // farmerTed.AddItemToInventory(ItemFactory.CreateGameItem(1003));
            //farmerTed.AddItemToInventory(ItemFactory.CreateGameItem(2002));

            Trader peteTheHerbalist = new Trader("Benu");
         
            peteTheHerbalist.AddItemToInventory(ItemFactory.CreateGameItem(3002));//ingrients
            peteTheHerbalist.AddItemToInventory(ItemFactory.CreateGameItem(3003));
           // peteTheHerbalist.AddItemToInventory(ItemFactory.CreateGameItem(1504));
            peteTheHerbalist.AddItemToInventory(ItemFactory.CreateGameItem(3001));


            // peteTheHerbalist.AddItemToInventory(ItemFactory.CreateGameItem(1002));
            //peteTheHerbalist.AddItemToInventory(ItemFactory.CreateGameItem(1004));
            AddTraderToList(susan);
            AddTraderToList(farmerTed);
            AddTraderToList(peteTheHerbalist);
            /*
        * 
        * d  asdaw          
        * _    BuildWeapon(1002, "Fire Sword", 50, 1, 3);
           BuildWeapon(1003, "Golden Sword", 100, 2, 8);
           BuildWeapon(1004, "Demon Sword", 500, 4, 10);
           BuildWeapon(1005, "Blue Sword", 60, 1, 3);
           BuildWeapon(1501, "Bear claw", 9999, 80, 100);
           BuildWeapon(1502, "Centepede Essence", 901, 10, 80);
           BuildWeapon(1503, "Centepede Eye", 50, 2, 19);
           BuildHealingItem(2001, "Satanic Potion", 51, 29);
           BuildMiscellaneousItem(3001, "Crook", 31);
           BuildMiscellaneousItem(3002, "Honey", 23);
           BuildMiscellaneousItem(3003, "Raisins", 25);
           BuildMiscellaneousItem(9001, "Serpent Scale", 129);
           BuildMiscellaneousItem(9002, "Toxic Gland", 223);
           BuildMiscellaneousItem(9003, "Centepede Essence", 113);
           BuildMiscellaneousItem(9004, "Centepede Eye", 233);
           BuildMiscellaneousItem(9005, "Bear Claw", 2909);
           BuildMiscellaneousItem(9006, "Bear Gallblader", 999);
        */
        }
        public static Trader GetTraderByName(string name)
        {
            return _traders.FirstOrDefault(t => t.Name == name);
        }
        private static void AddTraderToList(Trader trader)
        {
            if (_traders.Any(t => t.Name == trader.Name))
            {
                throw new ArgumentException($"There is already a trader named '{trader.Name}'");
            }
            _traders.Add(trader);
        }
    }
}