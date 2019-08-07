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
            private bool BakeWin = false;
            private List<Recipe> MyRecipes = new List<Recipe>();
            public Baker(string name) {
                Name = name;
                BakingProwess = 100;
                MyRecipes.Add(new Recipe("EzBake-Oven Cookie", 5, "So simple, a Scot with one T could do it!", @"                                                              .://+dh+                              
                                                          :+syyssssssyhds                           
                                                      `:oyysssssssssssssyy+                         
                                                   `syhssssssooooosyssssssyy.                       
                                                    +hso+++oosshyhhhssssssssh`                      
                                                    mhdyyyhddmhyhsoddysssssyh+                      
o+++////////:///////////////////o                   :`dhyo::ho+yyyo/-+shyhysss                      
h/:::::::::-----................s                    `hddyss:-:/No+-/..:dm/s/o.                     
h/:::::::::::::::::::-----......s                      s-oyd-/-.omy...../:/o/s`                     
h/:::::://///+++++++ooooo+++++//o::::::::::::--.       .o/yN/:-.....//..-:/yds+//:-.                
hoosssssssoo+//:--..............-://///////////y        s..-/////::/os...:s+:yhss//+o+/-            
hsoo++++++//++++/////////o////////////////////oy        o:...+ooo:/+o/..:s/-.oyyoosso+/+o/          
y++///////////++ooo++++++h+//////:-...........+s         ://..-+o+/:--:so:..-syysso////+//s:        
y+++///////////////////::y+.............-/++/.+s           `::////+oosdhy:--+yhsdo+////oy+/+o`      
y++++////////////////:://y+...-:/++osyyhhyyyd.+s                 /soosyymsooo/ysdo+/////dyo+/s.     
y+++++///////////////////y+.shhhyyyyyyyyyyyyd.+s                o+//+sydhh+///odmoo/////hoys+/s-    
y++++++//////////////////y+.mhhhhhhyyyyyyyyyd-+s   --.` `.-::///os+/+oohsydysss+hsooo++oh+:sy+/s:   
y+++++++/////////////////y+.dhhhhhhhhhhyyyyyd-+s` ohssssssoosh/---+oyyy-  :+oo+/ohso+++oy+/:sso+s/  
s++++++++///////////////+y+-dhhhhhhhhhhhhhhyh-+s``+hdhyhhhdhyhhoosyyo++/::::/dyh+....-:+ds+::hoooy/ 
s+++++++++//////////////+y+-dsyyyyyyyyyhhdddd-oo/dhhyhhs+os+oysso+++dhyooooosossd/--:oss//:::oyoyd+ 
s++++++++++//////////////y+-hoooosyyyhddhhhddosso++sy++:::/:://+dsydmmhyssssssssydssy+::::::::dhyyd.
s++++++++++//////////////y+.hyhdddhhhyyyyhhysooo+oss+////++++odso+hyssssssssssssymo++:::::::::hsosyo
s+++++++++++/////////////y+.hdhhhhhyyyyyyydyyoo+//:::-.``.----y/++dysssssssyyhdhhso+++/:::::::do+oy+
o++++++++++++///////////:y+.hhhhhhhhyyyyyyyyy.y:``.-+sy/-::::::`  :yhhdddhhyyssssyhdo/++so//:+ho+sd.
o+++++++++++++//////////:y+.hhhdddhhhhhhhhyyy:dsshhhhhhdyo/:         ```h++++++osho`    /yyyyhs++sd 
o++++++++++++++///////::/yo.yoooooooossshdmNmdhhhhhddys++///           `h+++++ooh/      `h++os+++sh 
o+++++++++++++++////::///yo.yo+ooooyhdmmdhhhhhhdhso////:.               y+++++osy+       -h++++++oy/
oo+++++++++++++++/:://///so.ssyhhddhhyhhhhdhso/://::`                   s++++++oys        h+++++++sh
+o++++++++++++++++///////ss.dhhhhhhhddhyo+::++y/                        :s+++++oyy        s+++++++sh
+o+++++++++++++++++//////sysddhysso+//+o++o/::y:                         y+++++osy        o+++++++ss
/o++++++++++++++++++/////ss+//+oooooo+/:::::::y:                        :ys++++oys        o+++++++ss
/o+++++++++++++++++++////oy+o+/:::::::::::::::h:                        /hysooosh/        .hso+++oyh
/s+++++++++++++++++++////oy.......--------:++/.                     /osyhhhhddddm`        .hhysoosys
`:/oso++++++++++++++++///oy............://:`                       yhyyyyyyyhhddm/        /hhhhhddm`
     `:/+oso+++++++++++//oy........-///.                          +mddhhdddmmmdyo-       /hyyyyyhhd-
          `-/+oso+++++++/oh.....://:`                             `/shdhyo+/-`          `mmdddddddm/
                -:+oso+++oh.-///.                                                        +ydmmmmdyo.
                     .:/+sh/:`                                                               ``     "));
            }
            public void Learn(Recipe recipe) {
                int LearnChance = rand.Next(BakingProwess);
                if (BakingProwess - recipe.Cost/1.6 >= LearnChance/1.15) {
                    MyRecipes.Add(recipe);
                    BakingProwess -= recipe.Cost;
                    System.Console.Clear();
                    System.Console.WriteLine($"You have learned how to bake {recipe.name}! Your prowess is now {BakingProwess}");
                } else {
                    BakingProwess -= recipe.Cost/2;
                    System.Console.Clear();
                    System.Console.WriteLine($"You aren't good enough, you probably feel like Scot with one T right now, don't you? Your prowess is now {BakingProwess}");
                }
            }
            
            public void Bake(Recipe recipe) {
                int BakeChance = rand.Next(BakingProwess);
                if (BakeChance > recipe.Cost/2) {
                    BakingProwess += recipe.Cost;
                    System.Console.Clear();
                    Console.WriteLine(recipe.ASCII);
                    System.Console.WriteLine($"You baked the {recipe.name}!");
                    System.Console.WriteLine($"Prowess - {BakingProwess}!");
                    if(recipe.name == "JavaScript Celebration Cake"){
                        BakeWin = true;
                    }
                } else {
                    
                    BakingProwess -= recipe.Cost/2;
                    System.Console.Clear();
                    System.Console.WriteLine($"You burnt the {recipe.name} to ashes!");
                    System.Console.WriteLine($"Prowess - {BakingProwess}!");
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