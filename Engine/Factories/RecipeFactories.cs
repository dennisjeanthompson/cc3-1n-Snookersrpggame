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
           wep.AddIngredient(3007, 1);//
            wep.AddIngredient(9004, 2);//
            wep.AddIngredient(3009, 1);//
            wep.AddOutputItem(1005, 1);//
            _recipes.Add(wep);

            Recipe centJuice = new Recipe(4, "Centepede Juice");
            centJuice.AddIngredient(9003, 1);
            centJuice.AddIngredient(9004, 1);
           
            centJuice.AddOutputItem(2003, 1);
            _recipes.Add(centJuice);

            Recipe SummonSatan = new Recipe(5, "Summon Satan");
            SummonSatan.AddIngredient(3010, 1);
           SummonSatan.AddIngredient(3011, 1);
            SummonSatan.AddIngredient(3012, 1);
            SummonSatan.AddIngredient(3013, 1);
            SummonSatan.AddIngredient(3014, 1);
            SummonSatan.AddIngredient(3015, 1);
            SummonSatan.AddOutputItem(2004, 1);
            _recipes.Add(SummonSatan);




       




        }
        public static Recipe RecipeByID(int id)
        {
            return _recipes.FirstOrDefault(x => x.ID == id);
        }
    }
}