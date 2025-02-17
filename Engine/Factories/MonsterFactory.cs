﻿using System;
using Engine.Models;
namespace Engine.Factories
{
    public static class MonsterFactory
    {
        public static Monster GetMonster(int monsterID)
        {
            switch (monsterID)
            {
                case 1:
                    Monster snake =
                        new Monster("Anaconda", "Anaconda2.jpg", 10, 17, 11, 19);
                    snake.CurrentWeapon = ItemFactory.CreateGameItem(1501);
                    AddLootItem(snake, 9001, 25);
                    AddLootItem(snake, 9002, 75);
                    return snake;
                case 2:
                    Monster rat =
                        new Monster("Centipede", "Centipede.png", 20,23, 399, 1000);
                    rat.CurrentWeapon = ItemFactory.CreateGameItem(1502);
                    AddLootItem(rat, 9003, 25);
                    AddLootItem(rat, 9004, 75);
                    return rat;
                case 3:
                    Monster giantSpider =
                        new Monster("Wild Bear", "WildBear.png", 10, 99, 909, 9999);
                    giantSpider.CurrentWeapon = ItemFactory.CreateGameItem(1503);
                    AddLootItem(giantSpider, 9005, 25);
                    AddLootItem(giantSpider, 9006, 75);
                    return giantSpider;


                case 4:
                    Monster snake1 =
                        new Monster("Anaconda", "Anaconda2.jpg", 10, 30, 11, 19);
                    snake1.CurrentWeapon = ItemFactory.CreateGameItem(1501);
                    AddLootItem(snake1, 9001, 25);
                    AddLootItem(snake1, 9002, 75);
                    return snake1;






                default:
                    throw new ArgumentException(string.Format("MonsterType '{0}' does not exist", monsterID));
            }
        }
        private static void AddLootItem(Monster monster, int itemID, int percentage)
        {
            if (RandomNumberGenerator.NumberBetween(1, 100) <= percentage)
            {
                monster.AddItemToInventory(ItemFactory.CreateGameItem(itemID));
            }
        }
    }
}