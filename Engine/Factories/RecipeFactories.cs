using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using Engine.Models;
namespace Engine.Factories
{
    public static class RecipeFactory
    {
        private static readonly List<Recipe> _recipes = new List<Recipe>();
        static RecipeFactory()
        {
            Recipe granolaBar = new Recipe(1, "Satanic Potion");
            granolaBar.AddIngredient(3001, 1);
            granolaBar.AddIngredient(3002, 1);
            granolaBar.AddIngredient(3003, 1);
            granolaBar.AddOutputItem(2001, 1);
            _recipes.Add(granolaBar);


            Recipe ratJuice = new Recipe(2, "Rat Juice");
            ratJuice.AddIngredient(3004, 1);
            ratJuice.AddIngredient(3005, 1);
            ratJuice.AddIngredient(3006, 1);
            ratJuice.AddOutputItem(2002, 1);
            _recipes.Add(ratJuice);


            Recipe wep = new Recipe(3, "Viper Sword");
           wep.AddIngredient(3007, 1);
            wep.AddIngredient(9004, 2);
            wep.AddIngredient(3009, 1);
            wep.AddOutputItem(1005, 1);
            _recipes.Add(wep);

            Recipe centJuice = new Recipe(4, "Centepede Juice");
            centJuice.AddIngredient(9003, 1);
            centJuice.AddIngredient(9004, 1);
           
            centJuice.AddOutputItem(2003, 1);
            _recipes.Add(centJuice);




            /*
      *d  asdaw
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
        public static Recipe RecipeByID(int id)
        {
            return _recipes.FirstOrDefault(x => x.ID == id);
        }
    }
}