using System;
using System.Collections.Generic;
namespace HACKATHON
{
    partial class Program
    {
        static void Main(string[] args)
        {
            List<Utensil> NewUtensils = new List<Utensil>();
            NewUtensils.Add(new Utensil("Spatula", 10, 5, "A nice, sturdy spatula to scrape the sides of your bowl with!"));
            NewUtensils.Add(new Utensil("Whisk", 50, 20, "Made of titanium to ensure it doesn't break!"));
            NewUtensils.Add(new Utensil("Mixing Bowl", 150, 50, "Stainless steel, cause ain't nobody got time for no plastic garbage!"));
            NewUtensils.Add(new Utensil("Stand Mixer", 500, 150, "You got a KitchenAid sponsorship, you in the big leagues now!"));
            
            List<Recipe> NewRecipes = new List<Recipe>();
            NewRecipes.Add(new Recipe("Bread", 5, "The starting point of all bakers!"));
            NewRecipes.Add(new Recipe("Cake", 10, "A simple, but delicious treat!"));
            NewRecipes.Add(new Recipe("Donuts", 25, "Light, tasty, custard-filled treats!"));
            NewRecipes.Add(new Recipe("Cheesecake", 50, "A decadent, creamy treat!"));
            NewRecipes.Add(new Recipe("Chocolate Chip Cookies", 80, "Grandma couldn't make them any better!"));
            NewRecipes.Add(new Recipe("Pie", 100, "Ooey, gooey, delicoiusness!"));
            NewRecipes.Add(new Recipe("Cinnamon Roll", 125, "Cinnabon better watch out!"));
            NewRecipes.Add(new Recipe("Angel Food Cake", 200, "Light, fluffy. You're pretty sure it just melts in your mouth!"));
            NewRecipes.Add(new Recipe("Baked Alaska", 500, "Shit's on fire!!"));
            NewRecipes.Add(new Recipe("Baked Salmon", 500, "Hmm.. something smells a bit fishy.."));
            NewRecipes.Add(new Recipe("Wedding Cake", 1000, "There's a 50/50 chance this won't work!"));
            NewRecipes.Add(new Recipe("JavaScript Celebration Cake", 15000, "Scot with one T will love this. Right in his face."));
            
            System.Console.WriteLine("Welcome to Baking Bonanza!! Type 'Q' or 'quit' to quit at any time, and let Scot with one T win!");
            System.Console.WriteLine("What is your name?");
            string a = Console.ReadLine();
            Baker user = new Baker(a);
            // Regex regex = new Regex("^[0-9]+$");
            
            while(1==1){
                System.Console.WriteLine($"Hi {user.name}! You have {user.prowess} Baking Prowess, What would you like to do?");
                System.Console.WriteLine("A) Bake A Recipe");
                System.Console.WriteLine("B) Learn New Recipe");
                System.Console.WriteLine("C) Buy A Utensil");
                string choice = Console.ReadLine();
                System.Console.Clear();
                if (choice == "A"|| choice == "a") {
                    System.Console.WriteLine($"What would you like to bake? You currently have {user.prowess} Baking Prowess!");
                    for (int i = 0; i < user.recipes.Count; i++) {
                        System.Console.WriteLine(i + " - " + user.recipes[i].name + " - Prowess Cost: " + user.recipes[i].Cost); 
                    }
                    string ToBake = Console.ReadLine();
                    if(ToBake == "quit"|| ToBake=="Q" || ToBake=="q"){
                        break;
                    }
                    // int intBake = 0;
                    bool IsInt = Int32.TryParse(ToBake, out int intBake);
                    if (IsInt) {
                        user.Bake(user.recipes[intBake]);
                    }else{
                        System.Console.WriteLine("Please enter a valid selection number!");
                    }
                    // if(intBake < user.recipes.Count){
                }
                else if (choice == "B"|| choice == "b") {
                    System.Console.WriteLine($"What would you like to learn? You currently have {user.prowess} Baking Prowess!");
                    for (int i = 0; i < NewRecipes.Count; i++) {
                        System.Console.WriteLine(i + " - " + NewRecipes[i].name + " - Prowess Cost: " + NewRecipes[i].Cost);
                    }
                    string ToLearn = Console.ReadLine();
                    if(ToLearn == "quit"|| ToLearn=="Q" || ToLearn=="q"){
                        break;
                    }
                    bool IsInt = Int32.TryParse(ToLearn, out int intLearn);
                    if (IsInt) {
                        if (intLearn <= NewRecipes.Count) {
                        user.Learn(NewRecipes[intLearn]);
                        }else {
                        System.Console.WriteLine("Please enter a valid selection number!");
                    }
                    } else {
                        System.Console.WriteLine("Please enter a valid selection number!");
                    }
                    // int intLearn = Convert.ToInt32(ToLearn);
                    // if(intLearn < NewRecipes.Count){
                    //     user.Learn(NewRecipes[intLearn]);
                    // }else{
                    // }
                }
                else if (choice == "C"|| choice == "c") {
                    System.Console.WriteLine($"What would you like to buy? You currently have {user.prowess} Baking Prowess!");
                    for (int i = 0; i < NewUtensils.Count; i++) {
                        System.Console.WriteLine(i + " - " + NewUtensils[i].name + " - Prowess Cost: " + NewUtensils[i].Cost);
                    }
                    int ToBuy = Convert.ToInt32(Console.ReadLine());
                    if(ToBuy < NewRecipes.Count){
                        user.BuyUtensil(NewUtensils[ToBuy]);
                    }else{
                        System.Console.WriteLine("Please enter a valid selection number!");
                    }
                }
                else if(choice == "quit" || choice=="Q" || choice == "q"){
                    break;
                } else {
                    System.Console.WriteLine("Please enter a choice between 'A', 'B', or 'C'.");
                }
                if(user.bakewin){
                    System.Console.WriteLine("You threw JavaScript celebration cake in Scot with one T's face and won the game!!!");
                    break;
                }
                if(user.prowess < 0){
                        System.Console.WriteLine("You lost loser! Try again and next time don't be a Scot with one T!");
                        break;
                    }
            }
        }
    }
}
