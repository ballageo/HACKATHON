using System;
using System.Collections.Generic;
namespace HACKATHON
{
    partial class Program
    {
        class Baker {
            Random rand = new Random();
            private string Name;
            private int BakingProwess;
            private int BakingBoost;
            private bool BakeWin = false;
            private List<Utensil> MyUtensils = new List<Utensil>();
            private List<Recipe> MyRecipes = new List<Recipe>();
            public Baker(string name) {
                Name = name;
                BakingProwess = 100;
                MyRecipes.Add(new Recipe("EzBake-Oven Cookie", 5, "So simple, a Scot with one T could do it!"));
                // System.Console.WriteLine($"{name} starts with {BakingProwess} Baking Prowess!");
            }
            public void Learn(Recipe recipe) {
                int LearnChance = rand.Next(BakingProwess);
                if ((BakingProwess - recipe.Cost/1.6) >= LearnChance/1.15) {
                    MyRecipes.Add(recipe);
                    BakingProwess -= recipe.Cost;
                    System.Console.Clear();
                    System.Console.WriteLine($"You spent {recipe.Cost} Baking Prowess to learn how to bake {recipe.name}!");
                } else {
                    BakingProwess -= recipe.Cost/2;
                    System.Console.Clear();
                    System.Console.WriteLine($"You aren't good enough, you probably feel like Scot with one T right now, don't you? Your prowess is now {BakingProwess}");
                }
            }
            
            public void Bake(Recipe recipe) {
                int BakeChance = rand.Next(BakingProwess);
                if (BakeChance + BakingBoost > recipe.Cost/2) {
                    BakingProwess += recipe.Cost;
                    System.Console.Clear();
                    System.Console.WriteLine($"You baked the {recipe.name}! You gained {recipe.Cost} Baking Prowess!");
                    // System.Console.WriteLine($"Prowess - {BakingProwess}!");
                    if(recipe.name == "JavaScript Celebration Cake"){
                        BakeWin = true;
                    }
                } else {
                    
                    BakingProwess -= recipe.Cost/2;
                    System.Console.Clear();
                    System.Console.WriteLine($"You burnt the {recipe.name} to ashes! You lost {recipe.Cost/2} Baking Prowess! You suck!");
                    // System.Console.WriteLine($"Prowess - {BakingProwess}!");
                }
            }
            
            public void BuyUtensil (Utensil utensil) {
                if (BakingProwess > utensil.Cost) {
                    MyUtensils.Add(utensil);
                    BakingProwess -= utensil.Cost;
                    BakingBoost += utensil.Boost;
                    System.Console.Clear();
                    System.Console.WriteLine($"You bought the {utensil.name} with {utensil.Cost} Baking Prowess! Your BakingBoost is now {BakingBoost}!");
                } else {
                    System.Console.Clear();
                    System.Console.WriteLine($"You are too poor to buy that item. Why don't you go beg on the street, you loser? Your prowess is now {BakingProwess}");
                }
            }
            public string name {
                get {
                    return Name;
                }
            }
            public bool bakewin {
                get {
                    return BakeWin;
                }
            }
            public List<Recipe> recipes {
                get {
                    return MyRecipes;
                }
                set {
                    ;
                }
            }
            public List<Utensil> utensils {
                set {
                    int Boost = 0;
                    for (var i = 0; i < MyUtensils.Count; i++) {
                        Boost += MyUtensils[i].Boost;
                    }
                    BakingBoost = Boost;
                }
            }
            public int boost {
                get {
                    return BakingBoost;
                }
            }
            public int prowess{
                get{
                    return BakingProwess;
                }
            }
        }
    }
}
// Cake;- requires 10 prowess; when baked = gain req/2; if failed to bake = prowess - req/2; if failedToLearn = prowess - req/10;
// Cheesecake; - requires 50 prowess; when baked = gain req/2; if failedToLearn = prowess - req/10;
// Tiramisu; requires 500 prowess; when baked = gain req/2; if failedToLearn = prowess - req/10;
// BakedAlaska; requires 1000 prowess; when baked = gain req/2; if failedToLearn = prowess - req/10;
// Stripper Cake; requires 5000 prowess; when baked = gain req/2; if failedToLearn = prowess - req/10;