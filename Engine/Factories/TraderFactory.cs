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
            susan.AddItemToInventory(ItemFactory.CreateGameItem(1006));
            susan.AddItemToInventory(ItemFactory.CreateGameItem(1007));
            susan.AddItemToInventory(ItemFactory.CreateGameItem(1008));
            Trader farmerTed = new Trader("Lynx");
            farmerTed.AddItemToInventory(ItemFactory.CreateGameItem(2001));//potions
            farmerTed.AddItemToInventory(ItemFactory.CreateGameItem(2002));

            farmerTed.AddItemToInventory(ItemFactory.CreateGameItem(2004));
            farmerTed.AddItemToInventory(ItemFactory.CreateGameItem(2005));
            // farmerTed.AddItemToInventory(ItemFactory.CreateGameItem(1003));
            //farmerTed.AddItemToInventory(ItemFactory.CreateGameItem(2002));

            Trader peteTheHerbalist = new Trader("Benu");
         
            peteTheHerbalist.AddItemToInventory(ItemFactory.CreateGameItem(3002));//ingrients
            peteTheHerbalist.AddItemToInventory(ItemFactory.CreateGameItem(3003));
           // peteTheHerbalist.AddItemToInventory(ItemFactory.CreateGameItem(1504));
            peteTheHerbalist.AddItemToInventory(ItemFactory.CreateGameItem(3001));
            peteTheHerbalist.AddItemToInventory(ItemFactory.CreateGameItem(3004));
            peteTheHerbalist.AddItemToInventory(ItemFactory.CreateGameItem(3005));
            peteTheHerbalist.AddItemToInventory(ItemFactory.CreateGameItem(3006));
            peteTheHerbalist.AddItemToInventory(ItemFactory.CreateGameItem(3007));
            peteTheHerbalist.AddItemToInventory(ItemFactory.CreateGameItem(3008));
            peteTheHerbalist.AddItemToInventory(ItemFactory.CreateGameItem(3009));
            peteTheHerbalist.AddItemToInventory(ItemFactory.CreateGameItem(9003));
            peteTheHerbalist.AddItemToInventory(ItemFactory.CreateGameItem(9004));
            peteTheHerbalist.AddItemToInventory(ItemFactory.CreateGameItem(1501));


            peteTheHerbalist.AddItemToInventory(ItemFactory.CreateGameItem(3010));
            peteTheHerbalist.AddItemToInventory(ItemFactory.CreateGameItem(3011));
            peteTheHerbalist.AddItemToInventory(ItemFactory.CreateGameItem(3012));
            peteTheHerbalist.AddItemToInventory(ItemFactory.CreateGameItem(3013));
            peteTheHerbalist.AddItemToInventory(ItemFactory.CreateGameItem(3014));
            peteTheHerbalist.AddItemToInventory(ItemFactory.CreateGameItem(3015));








            peteTheHerbalist.AddItemToInventory(ItemFactory.CreateGameItem(9001));
           peteTheHerbalist.AddItemToInventory(ItemFactory.CreateGameItem(1503));
          
            AddTraderToList(susan);
            AddTraderToList(farmerTed);
            AddTraderToList(peteTheHerbalist);
        
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