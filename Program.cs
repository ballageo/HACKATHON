using System;
using System.Collections.Generic;
namespace HACKATHON
{
    class Program
    {
        class Recipe {
            private string Name;
            private int ProwessCost;
            private string Description;
            public Recipe(string name, int cost, string descrip) {
                Name = name;
                ProwessCost = cost;
                Description = descrip;
            }
            public int CostToLearn {
                get {
                    return ProwessCost;
                }
            }
        }
        class Baker {
            Random rand = new Random();
            private string Name;
            private int BakingProwess;
            private List<Recipe> MyRecipes = new List<Recipe>();
            public Baker(string name) {
                Name = name;
                BakingProwess = 100;
                MyRecipes.Add(new Recipe("EzBake-Oven", 0, "So simple, a Scot with one T could do it!"));
            }
            public void Learn(Recipe recipe) {
                int LearnChance = rand.Next(BakingProwess);
                if (BakingProwess - recipe.CostToLearn >= LearnChance) {
                    MyRecipes.Add(recipe);
                    BakingProwess -= recipe.CostToLearn;
                } else {
                    System.Console.WriteLine("You aren't good enough, you probably feel like Scot with one T right now, don't you?");
                    BakingProwess -= recipe.CostToLearn/2;
                }
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}

            Random rand = new Random();



int failChance = rand.Next(BakingProwess);
if (failChance >= recipe.requiredProwess) {

}
List<Recipe> YourRecipes;
List<Recipe> NewRecipes;

MyRecipes 
EZBake Oven - requires 0 prowess;  when baked= gain 1 Prowess; 100% chance to be baked

NewRecipes 
// Cake;- requires 10 prowess; when baked = gain req/2; if failed to bake = prowess - req/2; if failedToLearn = prowess - req/10;
// Cheesecake; - requires 50 prowess; when baked = gain req/2; if failedToLearn = prowess - req/10;
// Tiramisu; requires 500 prowess; when baked = gain req/2; if failedToLearn = prowess - req/10;
// BakedAlaska; requires 1000 prowess; when baked = gain req/2; if failedToLearn = prowess - req/10;
// Stripper Cake; requires 5000 prowess; when baked = gain req/2; if failedToLearn = prowess - req/10;