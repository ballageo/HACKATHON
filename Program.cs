using System;
using System.Collections.Generic;
namespace HACKATHON
{
    partial class Program
    {
        static void Main(string[] args)
        {
            
            List<Recipe> NewRecipes = new List<Recipe>();
            NewRecipes.Add(new Recipe("Bread", 5, "The starting point of all bakers!"));
            NewRecipes.Add(new Recipe("Cake", 10, "A simple, but delicious treat!"));
            NewRecipes.Add(new Recipe("Donuts", 25, "Light, tasty, custard-filled treats!"));
            NewRecipes.Add(new Recipe("Cheesecake", 50, "A decadent, creamy treat!"));
            NewRecipes.Add(new Recipe("Chocolate Chip Chocolates", 80, "Grandma couldn't make them any better!"));
            NewRecipes.Add(new Recipe("Pie", 100, "Ooey, gooey, delicoiusness!"));
            NewRecipes.Add(new Recipe("Cinnamon Roll", 125, "Cinnabon better watch out!"));
            NewRecipes.Add(new Recipe("Angel Food Cake", 200, "Light, fluffy. You're pretty sure it just melts in your mouth!"));
            NewRecipes.Add(new Recipe("Baked Alaska", 500, "Shit's on fire!!"));
            NewRecipes.Add(new Recipe("Baked Salmon", 500, "Hmm.. something smells a bit fishy.."));
            NewRecipes.Add(new Recipe("Wedding Cake", 1000, "There's a 50/50 chance this won't work!"));
            NewRecipes.Add(new Recipe("JavaScript Celebration Cake", 50000, "Scot with one T will love this. Right in his face."));
            
            System.Console.WriteLine("Welcome to Baking Bonanza!! Type 'Q' or 'quit' to quit at any time, and let Scot with one T win!");
            System.Console.WriteLine("What is your name?");
            string a = Console.ReadLine();
            Baker user = new Baker(a);
            
            while(1==1){
                System.Console.WriteLine($"Hi {user.name}! What would you like to do?");
                System.Console.WriteLine("A) Bake");
                System.Console.WriteLine("B) Learn");
                string choice = Console.ReadLine();
                if (choice == "A"|| choice == "a") {
                    System.Console.WriteLine("What would you like to bake?");
                    for (int i = 0; i < user.recipes.Count; i++) {
                        System.Console.WriteLine(i + " - " + user.recipes[i].name);
                    }
                    string ToBake = Console.ReadLine();
                    if(ToBake == "quit"|| ToBake=="Q"){
                        break;
                    }
                    int intBake = Convert.ToInt32(ToBake);
                    
                    user.Bake(user.recipes[intBake]);
                }
                if (choice == "B"|| choice == "b") {
                    System.Console.WriteLine("What would you like to learn?");
                    for (int i = 0; i < NewRecipes.Count; i++) {
                        System.Console.WriteLine(i + " - " + NewRecipes[i].name + " - Prowess Cost: " + NewRecipes[i].Cost);
                    }
                    int ToLearn = Convert.ToInt32(Console.ReadLine());
                    user.Learn(NewRecipes[ToLearn]);
                }
                if(choice == "quit" || choice=="Q"){
                    break;
                }
            }
            // string  = Console.ReadLine();
            
        }
    }
}


// int failChance = rand.Next(BakingProwess);
// if (failChance >= recipe.requiredProwess) {

// }
// List<Recipe> YourRecipes;

// MyRecipes 
// EZBake Oven - requires 0 prowess;  when baked= gain 1 Prowess; 100% chance to be baked

// NewRecipes 
// Cake;- requires 10 prowess; when baked = gain req/2; if failed to bake = prowess - req/2; if failedToLearn = prowess - req/10;
// Cheesecake; - requires 50 prowess; when baked = gain req/2; if failedToLearn = prowess - req/10;
// Tiramisu; requires 500 prowess; when baked = gain req/2; if failedToLearn = prowess - req/10;
// BakedAlaska; requires 1000 prowess; when baked = gain req/2; if failedToLearn = prowess - req/10;
// Stripper Cake; requires 5000 prowess; when baked = gain req/2; if failedToLearn = prowess - req/10;