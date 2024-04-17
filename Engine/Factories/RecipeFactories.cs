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
           wep.AddIngredient(3007, 1);//Satan Body
            wep.AddIngredient(9004, 2);//Satan Legs
            wep.AddIngredient(3009, 1);//Satan Heart
            wep.AddOutputItem(1005, 1);//Satan Feet
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




            /*
             * 
             * 
             * BuildMiscellaneousItem(9001, "Serpent Scale", "/Background/SerpentScale.png", 129);
            BuildMiscellaneousItem(9002, "Toxic Gland", "/Background/ToxicGland.png", 223);
            BuildMiscellaneousItem(9003, "Centepede Essence", "Background/CentepedeEssence.jpg", 113);
            BuildMiscellaneousItem(9004, "Centepede Eye", "Background/EYEcentepede.jpg", 233);
            BuildMiscellaneousItem(9005, "Bear Claw", "/Background/BeareClawz.png", 2909);
            BuildMiscellaneousItem(9006, "Bear Gallblader", "/Background/BearGallblader.png", 999);

            BuildMiscellaneousItem(3007, "Iron", "/Background/BearGallblader.png", 100);
            BuildMiscellaneousItem(3008, "Metal", "/Background/BearGallblader.png", 999);
            BuildMiscellaneousItem(3009, "Grip", "/Background/BearGallblader.png", 999);

             *  BuildWeapon(1001, "Red Sword", "/Background/RedSwordzx.png", 14, 2, 5);
            BuildWeapon(1002, "Fire Sword", "/Background/fireezzz.png", 50, 4, 8);
            BuildWeapon(1003, "Golden Sword", "/Background/sowrdssz.jpg", 100, 8, 19);
            BuildWeapon(1004, "Demon Sword", "/Background/SwordReed.png", 500, 9, 18);
            BuildWeapon(1005, "Blue Sword", "/Background/glowing_sword_only__3045701784.png", 60, 10, 30);
            BuildWeapon(1501, "Bear claw", "/Background/BeareClawz.png", 9999, 80, 100);
            BuildWeapon(1502, "Centepede Essence", "/Background/CentepedeEssence.jpg", 901, 2, 4);
            BuildWeapon(1503, "Centepede Eye", "/Background/EYEcentepede.jpg", 50, 3, 10);
            //  BuildWeapon(1504, "Blood of Satan", "/Background/bottleblood.jpg", 50, 0, 0);//
              
            //Elixir of Resilience
            BuildHealingItem(2001, "Satanic Potion", "/Background/Potionz.png", 510, 29);
            BuildHealingItem(2002, "Blood of Satan", "/Background/bottleblood.jpg", 1000, 50);
            BuildHealingItem(2003, "Centepede Juice", "/CharacterImage/greenpotion.png", 390, 10);
            BuildHealingItem(2004, "Summon Satan", "/BackGround/kingDemon.jpg", 9999, 9999);
            //king demon



            BuildMiscellaneousItem(3001, "Blood of Satan", "/Background/bottleblood.jpg", 31);
            BuildMiscellaneousItem(3002, "Honey", "", 23);
            BuildMiscellaneousItem(3003, "Raisins", "", 25);

            BuildMiscellaneousItem(3004, "Rat feet", "", 5000);
            BuildMiscellaneousItem(3005, "Rat skin", "", 1000);
            BuildMiscellaneousItem(3006, "Rat feces", "", 999);











           
             * 
             * 
             * 
             * 
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