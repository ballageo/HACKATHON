using System;
using System.Collections.Generic;
namespace HACKATHON
{
    partial class Program
    {
        static void Main(string[] args)
        {
            
            List<Recipe> NewRecipes = new List<Recipe>();
            NewRecipes.Add(new Recipe("Bread", 5, "The starting point of all bakers!", @"
                            `.--:://+++/////////////////::-.                                       
                        .-:/++//:--.``````````````````````..-:/:-`                                  
                    .:/++/:-.```````````````````````````````````.:/-                                
                 .:+++:.```````````````-/:.````````````````````````.:.                              
               -+++/-````````````````/syyys```````-ss+```````````````..             `..`            
             :++++-````````````````-ss+:-`````````/+osy-```````````````-           -`  `..          
           .++++/.`````````````````/-`````````````````./````````````````-          ..    -`   ```   
          /+++++-````````````````````.+++///:````./+/+/.`````````````````.          ..   .-...```.. 
         ++++++/.``````````...``````+s.     `:-`+/`   ./+````````````````-           -   `. `.`   ..
        :o+++++-.````````...-.`````:s   `.`   .o``.`    .+```````````````.`          -     -`     ..
        so+++++-..````````..```````o. `::dds`  :-:hds`   +```````````````..          -     ..    ..:
       `so+++++:..`````````````````-+ -yhMNh-  /oyNmh`  `/```````````````.`          -`     :....  -
       `so+++++/...```````````````..+- :sys:  -:::+/.  `/-```````````````-           :.```. -`    .-
        +oo+++++-...`````````````````.--.``.-:.``-----..`````````..-.````.          :o` .   -....` -
        .so++++++-...`````````....--..`..--.````````````````````````````-         `/ooo--...--   `.`
         -so++++++:...`````````````-:-.```````````````::.``````````````-         -oooso       ...`  
          .ooo+++++/-..`````````````.-`......```````.:--``````````````-`      `:oooos/              
           `+oo++++++-...`````````````:-   ``.....+dd+```````````````..   `-:+ooooso-               
            `oooooooo+...``````````````oh+-`      +ms````````````````/ooooooooooso:                 
           .:+ooossooo-...``````````````smNmhsoosymd.````````````````/ooooossso/.                   
       `-/o++oossssooo-....`````````````.dmmmmmmmmmo`````````````````:+///:-.                       
     ./o++oossssssooo+.....``````````````:ysshydmmd-`````````````````.`                             
    /o++oos++sooooooo-.....```````````````:sssssmd+```````````````````-                             
   /+++oss-.sooooooo:......````````````````./ooo+-````.```````````````..                            
   ++++sss`+soooooo/......`````````````````````````..--.```````````````-`                           
   `+++osssssssoooo-......``````````````````````````````````````````````-                           
     -/o+oosso..+o+.......``````````````````````````````````````````````.`                          
      `-::/o+:  +o:.......```````````````````````````````````````````````.                          
  .....`   `  ...o-.......```````````````````````````````````````````````-                          
 -```.:. ..`    .o........```````````````````````````````````````````````-                          
.---...-.-     `+o.........```...`````````````````````````````.....``````-                          
:.``.....`    .+oo-........``....```````````````````````````....--.``````-                          
:  -        `/oooo:.........`````````````````````````````````....````````-                          
`..-.`  `..+oooooo/...........```````````````````````````````````````````.                          
     ````  .ooooooo-............````````````````````````````````````````-`                          
            `+sooooo-.............`````````````````````````````````````-.                           
              ./osooo:.................`````````````````````````````..-`                            
                 -/oss+:......................`````````````````....-.`                              
                     .:///:-..................................-...`          "));
            NewRecipes.Add(new Recipe("Cake", 10, "A simple, but delicious treat!", @"                                            
                                         ..`     ````                                           
                                  ``     `-....   .-..-     ```                                   
                                  `..`.`   .::::.```::::.`` `....`                                  
                                  --::-.  `..::``.`..::-..-`.-::--                                  
                                  `://-  -----:-----:-::::-` -//-`                                  
                                   ..-.  .://:`.://--..-/.`  ..-.`                                  
                                  `-.`.`  `-:.`.`.-`...--..  -...`                                  
                                  `.``.  `-..-`.-..-..-.``.  .````                                  
                                  `.` .  `-` .`.-``...-.``.  ..```                                  
                                  `.` .  `-``.`.-``...-.``.  ..```                                  
                                  `.``.```-``.`.-``...-.``.  ..```                                  
                                  `.``-/-:-` .`.:``.+.-.``/---````                                  
                             `-/-/y-``-ysy-``-.:/``.o--.``+oo/``.o/--.`                             
                           -oyhyyyh:` :hhh-``:yy/.`.yso.``+ss/.`.ssooso/.                           
                          :hhho+yhhysosyhh-` :yy/``.yso-..ossoooossoossso`                          
                         `ydhhsshhhhsoshyh+//oyyo+/+yysssoossssssss+/ssyh/                          
                         -dhhhhhhhhhsoshhhhyys+/yyyyyyyss+/ossssssssyyhhso                          
                         :dhyyyshhhhyyyyyyyyyyssyyyyyyyyysssyyyyo:..-+yh+o`                         
                     ````:hoso:-yhhhhyyyyyssyyyssssssoossyysoy+-`   ``./o+````                      
                   `:+:-:yy/:...ohhhhysyo:--/yyyyyyos..-:+++:.`` `` ````-so/:--.`                   
                ./oyyso+ohy-....-shhs+o:.....:syyy++:```````````````````-sso++ooo/-`                
              .+hhhhhhhhhhho:....-:/:-........-/+/-..`````````````````.-osssssssssso:`              
             .yhhhhs++shhhhhhyo/:-...................````````````.--:+ossssssoossssss/              
             odhhhyo/:+hhhhhhhyhyyyso++//:::--------------:::/++oossssssssss+:-+ssssyy.             
            .hhhhhhhyyhhhhhhyo/:ohhhhhhhyyyyssssssssssssssssso+ossssssssssssoo+osyyyhh:             
            :dhhhhhhhhhhhhhhyo+/ohhhhhhhyyyo/:/yyyyyyyyyyyyss+::+ssssssssssssyyyyhhhhyo             
            /dhhhhhhhhhhhhhhhhyyhhhhhhhhyyys+++yyyyyyyyyyyyysssossssssyyyysooosyhhhhy:y`            
            /dhhysyhs/yhhhhhhhyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyysysyyyyyyys+-`````./yhhy-y`            
            -dy++yy/..shhhhhhhyyyyyyyyyyyyyyysssssssssssssssssyyyssyys/.       ``./syso`            
            .yoss+-.../hhhhhhhhyyyyyyo++osyyyyyyyssssss::/ossyyyo+oo/.`       ``````.:`             
            `//-......-yhhhhhhysoyy+:....-oyyyyyyyyy+o+````.-:/+/:-`````    `````````-`             
         `.:+o/......../hhhhhs/+s+-........+yyyyyys//s.``````````````````````````````://-.`         
      `-+shhhyo........./syhy++/-...........+syyyy/++-``````````````````````````````.+ssso+:.       
     .ohhhhhhhho:.........-::-...............-://:-.`.````````````````````````````.-+ssssssss/`     
    -hdhhhhyssyhhs+:-..................................```````````````````````..-/ossssssssssso`    
   .hddhhhs+:--+hhhhyso+::--..............................`````````````...-:/+oossso+//ossssssy/  
            "));
            NewRecipes.Add(new Recipe("Donuts", 25, "Light, tasty, custard-filled treats!", @""));
            NewRecipes.Add(new Recipe("Cheesecake", 50, "A decadent, creamy treat!", @""));
            NewRecipes.Add(new Recipe("Chocolate Chip Chocolates", 80, "Grandma couldn't make them any better!", @""));
            NewRecipes.Add(new Recipe("Pie", 100, "Ooey, gooey, delicoiusness!", @"                                                                                                    
                                              ``                                                    
                                             ```                                                    
                                             ```                                                    
                                             `````                                                  
                                              ```.`                                                 
                                       `       ``````       `                                       
                                      ``        `.```       ``                                      
                                      `.`        ````      ```                                      
                                      `````       ```    `````                                      
                                       `````      ``    `````                                       
                                        `````    ``    `````                                        
                                         ````          ````                                         
                                          ``            ``                                          
                                         ``              ``                                         
                                                                                                    
                                                                                                    
                                             ``````````                                             
                                   `.--:::////////////////:::-.``                                   
                             `.-:://+o/----------------------+o+//::-``                             
                        `.:://::--ohhs----/o:----/:----:+:---:yhy/--:///::.`                        
                   `-:///::------:+s+:-:-ohh/---:yy:---:hyo:--:++:-------::///:-.`                  
              `.:///:::::::::::::::::::::yhy::::ohho:-::shy:::::::::::::::::::::///:-`              
           `-///::::::::::::::::::::::::::::::::/os/::::::::::::::::::::::::::::::::///:.           
         -//:::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::://-`        
       .//::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::/+-       
      -+/:::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::+- `    
./////+//////////////////////////////////////////////////////////////////////////////////////+++++/-
o/////////+++++////////////////////////////////////////////////////////////////////++++++++////////o
:+///////////////++++++++++/////////////////////////////////////////++++++++++++//////////////////+-
 ./+++++++/////////////////++++++++++++++++++++++++++++++++++++++++//////////////////////+++/+++/-` 
    ` .:::+++++++++/++++++++++++++++++++++++++/+++++++++++++++++++/+++++++++++///+++++++/:::        
       :::::///:-::--:/o++++++/://++++++++++++/+/++++++++++++/::-:/+++++++++:--:---://:::::.        
       .:::-------:-----:/:-....:...:/++++/:.``-.`.-//+o++/-...:....-:////:----:-------::::`        
        ::--------:---..........:........`.````-.`````.........:.........------:-------:::-         
        .::-------:----.........:..........``.`-.`````.........:.........------:-------::/`         
         -:::-----:----.........:..........````-.`````.........:.........-----:--------::-          
           `..--::::-.-.........--.........````-.`````.........:.........-----:--:::--.``           
                  `..---------...-...........``-.````.`........:.....---::----..``                  
                           ``...---------------::-----------------....``        "));
            NewRecipes.Add(new Recipe("Cinnamon Roll", 125, "Cinnabon better watch out!", @""));
            NewRecipes.Add(new Recipe("Angel Food Cake", 200, "Light, fluffy. You're pretty sure it just melts in your mouth!", @""));
            NewRecipes.Add(new Recipe("Baked Alaska", 500, "Shit's on fire!!", @""));
            NewRecipes.Add(new Recipe("Baked Salmon", 500, "Hmm.. something smells a bit fishy..", @""));
            NewRecipes.Add(new Recipe("Wedding Cake", 1000, "There's a 50/50 chance this won't work!", @""));
            NewRecipes.Add(new Recipe("JavaScript Celebration Cake", 15000, "Scot with one T will love this. Right in his face.", @"
                                            ..`     ````                                           
                                    ``     `-....   .-..-     ```                                   
                                  `..`.`   .::::.```::::.`` `....`                                  
                                  --::-.  `..::``.`..::-..-`.-::--                                  
                                  `://-  -----:-----:-::::-` -//-`                                  
                                   ..-.  .://:`.://--..-/.`  ..-.`                                  
                                  `-.`.`  `-:.`.`.-`...--..  -...`                                  
                                  `.``.  `-..-`.-..-..-.``.  .````                                  
                                  `.` .  `-` .`.-``...-.``.  ..```                                  
                                  `.` .  `-``.`.-``...-.``.  ..```                                  
                                  `.``.```-``.`.-``...-.``.  ..```                                  
                                  `.``-/-:-` .`.:``.+.-.``/---````                                  
                             `-/-/y-``-ysy-``-.:/``.o--.``+oo/``.o/--.`                             
                           -oyhyyyh:` :hhh-``:yy/.`.yso.``+ss/.`.ssooso/.                           
                          :hhho+yhhysosyhh-` :yy/``.yso-..ossoooossoossso`                          
                         `ydhhsshhhhsoshyh+//oyyo+/+yysssoossssssss+/ssyh/                          
                         -dhhhhhhhhhsoshhhhyys+/yyyyyyyss+/ossssssssyyhhso                          
                         :dhyyyshhhhyyyyyyyyyyssyyyyyyyyysssyyyyo:..-+yh+o`                         
                     ````:hoso:-yhhhhyyyyyssyyyssssssoossyysoy+-`   ``./o+````                      
                   `:+:-:yy/:...ohhhhysyo:--/yyyyyyos..-:+++:.`` `` ````-so/:--.`                   
                ./oyyso+ohy-....-shhs+o:.....:syyy++:```````````````````-sso++ooo/-`                
              .+hhhhhhhhhhho:....-:/:-........-/+/-..`````````````````.-osssssssssso:`              
             .yhhhhs++shhhhhhyo/:-...................````````````.--:+ossssssoossssss/              
             odhhhyo/:+hhhhhhhyhyyyso++//:::--------------:::/++oossssssssss+:-+ssssyy.             
            .hhhhhhhyyhhhhhhyo/:ohhhhhhhyyyyssssssssssssssssso+ossssssssssssoo+osyyyhh:             
            :dhhhhhhhhhhhhhhyo+/ohhhhhhhyyyo/:/yyyyyyyyyyyyss+::+ssssssssssssyyyyhhhhyo             
            /dhhhhhhhhhhhhhhhhyyhhhhhhhhyyys+++yyyyyyyyyyyyysssossssssyyyysooosyhhhhy:y`            
            /dhhysyhs/yhhhhhhhyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyysysyyyyyyys+-`````./yhhy-y`            
            -dy++yy/..shhhhhhhyyyyyyyyyyyyyyysssssssssssssssssyyyssyys/.       ``./syso`            
            .yoss+-.../hhhhhhhhyyyyyyo++osyyyyyyyssssss::/ossyyyo+oo/.`       ``````.:`             
            `//-......-yhhhhhhysoyy+:....-oyyyyyyyyy+o+````.-:/+/:-`````    `````````-`             
         `.:+o/......../hhhhhs/+s+-........+yyyyyys//s.``````````````````````````````://-.`         
      `-+shhhyo........./syhy++/-...........+syyyy/++-``````````````````````````````.+ssso+:.       
     .ohhhhhhhho:.........-::-...............-://:-.`.````````````````````````````.-+ssssssss/`     
    -hdhhhhyssyhhs+:-..................................```````````````````````..-/ossssssssssso`    
   .hddhhhs+:--+hhhhyso+::--..............................`````````````...-:/+oossso+//ossssssy/  "));
            Console.Title = "ASCII Art";
            string title = @"
________  ________  ___  __    ___  ________   ________          ________  ________  ________   ________  ________   ________  ________  ___       
|\   __  \|\   __  \|\  \|\  \ |\  \|\   ___  \|\   ____\        |\   __  \|\   __  \|\   ___  \|\   __  \|\   ___  \|\_____  \|\   __  \|\  \      
\ \  \|\ /\ \  \|\  \ \  \/  /|\ \  \ \  \\ \  \ \  \___|        \ \  \|\ /\ \  \|\  \ \  \\ \  \ \  \|\  \ \  \\ \  \\|___/  /\ \  \|\  \ \  \     
 \ \   __  \ \   __  \ \   ___  \ \  \ \  \\ \  \ \  \  ___       \ \   __  \ \  \\\  \ \  \\ \  \ \   __  \ \  \\ \  \   /  / /\ \   __  \ \  \    
  \ \  \|\  \ \  \ \  \ \  \\ \  \ \  \ \  \\ \  \ \  \|\  \       \ \  \|\  \ \  \\\  \ \  \\ \  \ \  \ \  \ \  \\ \  \ /  /_/__\ \  \ \  \ \__\   
   \ \_______\ \__\ \__\ \__\\ \__\ \__\ \__\\ \__\ \_______\       \ \_______\ \_______\ \__\\ \__\ \__\ \__\ \__\\ \__\\________\ \__\ \__\|__|   
    \|_______|\|__|\|__|\|__| \|__|\|__|\|__| \|__|\|_______|        \|_______|\|_______|\|__| \|__|\|__|\|__|\|__| \|__|\|_______|\|__|\|__|   ___ 
                                                                                                                                               |\__\
                                                                                                                                               \|__|
    Hit <ENTER> to start Playing!";
            System.Console.WriteLine(title);
            // Console.Read();
            System.Console.WriteLine("Welcome to Baking Bonanza!! Type 'Q' or 'quit' to quit at any time, and let Scot with one T win!");
            System.Console.WriteLine("What is your name?");
            string a = Console.ReadLine();
            Baker user = new Baker(a);
            


            while(1==1){
                System.Console.WriteLine($"Hi {user.name}! You have {user.prowess} Baking Prowess, What would you like to do?");
                System.Console.WriteLine("A) Bake");
                System.Console.WriteLine("B) Learn");
                string choice = Console.ReadLine();
                System.Console.Clear();
                if (choice == "A"|| choice == "a") {
                    System.Console.WriteLine("What would you like to bake?");
                    for (int i = 0; i < user.recipes.Count; i++) {
                        System.Console.WriteLine(i + " - " + user.recipes[i].name + " - Prowess Cost: " + user.recipes[i].Cost); 
                    }
                    string ToBake = Console.ReadLine();
                    if(ToBake == "quit"|| ToBake=="Q"){
                        break;
                    }
                    int intBake = Convert.ToInt32(ToBake);
                    if(intBake < user.recipes.Count){
                        user.Bake(user.recipes[intBake]);
                    }else{
                        System.Console.WriteLine("Please enter a valid selection number!");
                    }
                    
                
                }else if (choice == "B"|| choice == "b") {
                    System.Console.WriteLine("What would you like to learn?");
                    for (int i = 0; i < NewRecipes.Count; i++) {
                        System.Console.WriteLine(i + " - " + NewRecipes[i].name + " - Prowess Cost: " + NewRecipes[i].Cost);
                    }
                    int ToLearn = Convert.ToInt32(Console.ReadLine());
                    if(ToLearn < NewRecipes.Count){
                        user.Learn(NewRecipes[ToLearn]);
                    }else{
                        System.Console.WriteLine("Please enter a valid selection number!");
                    }
                }else if(choice == "quit" || choice=="Q" || choice == "q" || choice=="Quit"){
                    break;
                }else{
                    System.Console.WriteLine("Please enter a choice between 'A' or 'B'.");
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