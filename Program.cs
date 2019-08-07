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
            NewRecipes.Add(new Recipe("Donuts", 25, "Light, tasty, custard-filled treats!", @"
            
                                                        `://////+++/:.                               
                                                     :+/.       ``.-/+/`                            
                                           `-///////+-             `..-+/`                          
                                         .//-`                       `..:o`                         
                                       ./+`                           `..:o                         
                                      `o-`                   `      `.-::/++/:.                     
                                      /+                           ```    ``.-/+:`                  
       `                              o-                                     `../o.                 
     ://+/.                           o-                                      `..-s`                
    :+` `-o-                          -o                                       `../+                
`.--/o`   -s`                          /+`                                     `..-s                
o/--/s/   `+:  `...`                    -+:`                                   `../o                
:+. `./+   -+-/:--:+:                    `-//:-..`.....`                       `..s.                
 .o-  `//  `s+```  .+/                      `.s/....`           ``            `.-o:                 
  `o-  `+`  +` -+.`./s`                      :o              ````-.`        `.-/+.                  
   `o-  `.  .   .-+o::o.                    .o+:-`           `-:::///:-...-://:.                    
    .o`           +/  -o-                `./o/+so+:`        `///::/+/--::s/.`                       
     //        `.:::` `+/             `-::::-.-/+o+/-..```  ``  ```.::..-o+`                        
     //        -.     -s`           .::-...--::::://++oo+++//////////++++/:/:`                      
     -+`            `:o.          ./:-..--:/+/:-:/::::++::///+ooooo//:::::---::.                    
     `//`          ./+`         ./:.-.-:::/s- -++:-::/+o/:::/:-//::o/::::/::/:-/:`                  
   `   -//-`      `.s.         :/-.:+/::::+/ `yy++:-:+///:::-`sy+/:-o:::/oooo::::/-                 
         o:.`````.:o:         /:..:/o+::::+/ .yyyy-::::/+:::``yyyy:.o:::::::::::////`               
         `:/o++++os-         /:..-///::::::+. .++--:::++::::- -oo/`//:/::::::::::/+:+`              
            +s+/://s.       /:..-:::::::::+/:....:::/s/:oo:::-.``.:::o+:::::::::::/+/+`             
             +s+////s:     -/..-:/:::::::/oyo/:::/+++oo+sso+++++++ooyo/++::::::::/:+o/+             
              /s++/::o+.   o.:+/oo::::::/+//ssssssoooossooooooossssy+:+o+::::::::://++o.            
               -so+/::/o+::/..://::::::::::::/oossso+////++++osyyyyo:::/+/::::::/o+/++++            
                 :oo+//::/o-..::::::::::::::::::/+yso++++oosyysssss::::::::::::::+o+/++o-           
                   -/ooo++o..-::::::::::::::::/+++yyyyyyssssooooss::::::::::::::://:++++/           
                      `-:/o..-::::+o:::::::::/+ooossyyooooo+++oss+/:::::::::::::::::++++o           
                         `o..::::+os/::://////soosssys+++++++oss+//:::::::::::::::::+++os-`         
                          o..::::+//::::://///sooy../+++oooooos///:::::::+::::::::+o++s+++oo+/-`    
                          o:/+/::::::::::::::/sos+      ``````:/::::::::+s/:::::::/+ooso++///+oo+-  
                          /:::oo:::::::/:+:::/sos+            ::-::/+/:::++o::::://:o+++o:-/++//+oo`
                          -/.-//://:::://o++++soss           `/-::/++o/::::+/::::++o++++o   `++:/+oo
                           +-.:::/+/:::/+oo++osoos/         `-+-:++::/+:::/++/:::++sooo+-    /o:/++y
                           -/.:++oo+++++o:://:+ssss+.     `-/++/+/:::o/+++o+o+///+ooos+`    -s/:/+oo
                            :/-/o/++:++o+:://:::/+oss/::////::::::::::+++/::/o++ooooso``.--/o/::/+s.
                             .::++::///::::::::::::::::::::::::::::::::::::::oooooos+-+/:-:/+o+/+s- 
                                 :+/:::::::::::::::::::::::::::/:::::::::::+ssoooss/:o:`    `-/so.  
                                  `:+/:::::::::::::::::::::::::::::::::::+ssooooso-//`        .:s`  
                                    `:++/::::::::::::::::::/::::::::::/ossooooso:.+:          `-s`  
                                       -+oo/:::::::::::::::/::::::/+osssooosso-`.o-           .s.   
                                         `-/oooo+//::::::::://+oosssooossso/.  .o.            .s`   
                               ````..........-:/+ossssssssssssossssssso+/:....-s.            `-y`   
                              `.........-------------::////+++++///::---------+/            `-+/    
                                         ```````````````````````````````````` /+-`          /s:     
                                                                               .s:...`     .++      
                                                                                `-::++...--/+.     "));
            NewRecipes.Add(new Recipe("Cheesecake", 50, "A decadent, creamy treat!", @"
            
                                              `                                                      
                                       `-` ::`-/                                                    
                                 `` .:.-oo///--.`                                                   
                          ``  :-./o+++/--:/oshmmmho`                                                
                        ` .oo+so+/-:/oydhmmmmmmdo:...  ``                                           
                     `` +o++/-:/oydmmyymmmmmmm+`-://- :///:`                                        
                 `:--/+:--:+sdmmmmmmmmmmmmmmmo :////--//////                                        
               :///:-.:ohdmmmmmmmmmmmmmmmmmmmo ://////////-- -                                      
              ``.``+hdmmmmmmmmmmmmmmmdmmmmmmmm:`://////..:``smh+.                                   
                 .:--/+shdmmmmmmmdymmdmmmmmmmmm+..:://:` .+dmmmmds:`                                
                 -oooo+/::-:+sydmmmmmmmmmmmmmmmmdo/:::/+ydmmmmmmmmmh+.                              
                 `..:+ossooo+/::::/oyhdmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmdy:`                           
                 `..``..:/+osssooo+//:::/+oyhdmmmmmmmmmmmmmmmmmmmmmmmdmmdo-                         
                 :o++:-..`..-:/+osssssooo+//::::/+syhdmmmmmmmmmmmmmmmsmmhymy/`                      
                 /ssssoo+/:......-:/+oossssssooo++/::::/+syhdmmmmmmmmmmmddmmmy+.                    
                 /ssssssssso+/:-...`...-:/++oosssssssoo++//:::+osyhdmmmmmmmmmmmho:                  
                 ./+ossssssssssoo+/:-.........-://++oosssssssoo++//:::/+oyhddmmmmmy:`               
                 ```.-/+ossssssssssssoo+/:-..........--::/+++ooossssooo++/:::://osyyy+.             
                 //:-.``.-:+oosssssssssssssoo++/:--............--:://+++ooosoo++/:----.`            
                 +ssoo+/-.```.:/+oossoossssssssssssooo++//:--.....````.....--://+++o+++/:-`         
               .`+sssssssoo+/-.```.-:/+ooosssssssssssssssssssooo+++//:::--.....``.....-::/-         
               ` +ssssssssssssoo+/:.````..-://++o/+oosoossssssssssssssssssooo++++//::-..``          
                 +ssssssssssssssssssoo+/:-.``` `` `..-.:/+++oooooooosssssssso+ssssssssoo++.         
                 /ossssssssssssssssssssssssoo++/::-..``````````.....---:::///++/:ooossssss-         
                 `-/oossssssssssssssssssssssssssssssooo+++///:::--..`````````````..-:/++oo.         
                    `-/oosssssssssssssssssssssssssssssssssssssssssssooo+++//::--....``....          
                       `.:/oossssssssssssssssssssssssssssssssssssssssssssssssssssoo+//:-..          
                           `.-/+oossssssssssssssssssssssssssssssssssssssssssssssoossssooo+`         
                                `.-/+ooossssssssssssssssooosssssssssssssssssssssoossss+/s/`         
                                     `.-:/+ooossssssssss+/ossss/ssssossssssssssssssssssss.          
                                            `.-:/+ooossssssssssossss:osssssssssssssssoosso`         
                                                   `.-:/+ooossssssssssssssssssssssssso/oss.         
                                                          `.-:/oooosssssssssssssso+ossssss-         
                                                               ``.-:/+ooosssssssso/ossssss`         
                                                                      `.-:/+oooossssssssso          
                                                                             ``.-:/+ooooo/          
                                                                                      ``.`          "));
            NewRecipes.Add(new Recipe("Chocolate Chip Chocolates", 80, "Grandma couldn't make them any better!", @"
                                                            ``.`..`                                             
                                  ``-:+//-```./oyhys++://:```                                       
                                `:+yhddddhyyyydddho/:::ohhyyo:``                                    
                              `-shdydddddddddddhhhdy/+ohdddhhhys/-`                                 
                             `-odhyshmmmmmddhddhhhdddddhhdddhddddyo:.`                              
                          `-+ssdy+/::dddmdddhddhhhhdddddhhhhhhdhdddhs/.`                            
                         ./yddddds++ydddddhhhdddhhhddddddddhhhhyhhhddds:.                           
                       `-+hddddddddhdddhhhdddddddddhhsooyddddddddhhhhhdho-`                         
                      `-odddddhhddddddhyhdddddddddds///::dddddddddddhyyhhy/.`                       
                     `-ohdddmmdddhdddhosyhdhddmdhddy+:::/hdhhhhddhddho+//sh+-`                      
                     ./hddddmdddhdhhh+////odddddddddhssyhhhysyyhhhdd//:::/dho.`                     
                    .-yhddyddddhhhddho::::odddmmmdmddsddhysosshdddddds//+sdhy+.`                    
                   `./ysddddhdhhdhddhhhsyyhyydmmdmmddhhhhhyssyhddddhdmdd+yddhy-.                    
                   `.oyhhddydhhddshhyhdddhhdhddddddddhhdsooshhdddmmmdddmmmddhy+.`                   
                   ..+ooo/yhyhdhhhhsshhdddhhhdddddddhhhs///:sddddmmddddmddddhss-.                   
                   `.+/::-+hhddyhysshdddhhyyhhhhhhhhhyhhyooshhdhdmdddddyo+/ohss:.                   
                   ..ssooyyyhdhhyssyhdmdhshyhddddddhhhhhhhyyyyddddmmmddy+-:shss:.                   
                   `.osyyhhhyyhyssyhdmdhhhysosyyddddhddhs+yyyyhdhdddmddddddhyss:.                   
                    .osyhhhhdhsossydddhhy+/:::/ohddhhhddhyyysyyyhddddddddddhsss-.                   
                    `/oodyyyhyoosyddddhhy+:---+ysyhhhhddhyyoosssyhddhyydhdhyss+..                   
                    `.+oyhyyhyssyhhhhhyyhhs+ohhhyossyyddhhysooossyhy+/:/+hysss-.`                   
                     `-+ooyyyyysyhhhsysyhdhyyhdhysoosshhhyyysoooosyo//:-:ysso/..                    
                     ``.+o+oyhyyyyyysoooydhyyhhhysooosyhhyssooosssyo+/::+o+o+..`                    
                      ``.:+oosso+++oyosyhhhyyhhysoooyyyhhyyo+ssyyyyyyysso++/..`                     
                       ```-+oo/-:--:yyyyyyyyyyso+oosyyyyyyysosyysyyyyyooo/-.``                      
                         ``.:++/--:+yyyssyyyyooosoosyyyyyso+//oy+yyssooo+-``                        
                          ```.:+++oosoo+yssyyhhhhhyyyyyyy/:::::ossooooo/..`                         
                            ```.-/+o++ossoossyyysssyyyyyys+::/++ooo++:-.``                          
                               ``.-::++ooooooo/////ossssssooooo++/:-.```                            
                                 ````.-://+oo+:::::+oooooooo++:...```                               
                                    `````..--::...-::////::--.```                                   
                                        ``````````````````````                                      "));
            NewRecipes.Add(new Recipe("Pie", 100, "Ooey, gooey, delicoiusness!", @"                                                                                                    
                                           `.-//++oossyhhhs/.                                       
                       `.-:::::::////+++oooo+////::::::///+syhhhysssoooooo+/:-`                     
                   ./+oo+////////////////::::::::::::::::::::////+oooooo+/////oys/`                 
               `-/o+//:::::::::::::::::::::::::::::::::::::::::::::::::::::::::/smmo.               
            `:+o+/:::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::/ohmy:`            
       `-:/+o//:::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::://oyhyo/-`       
   `/+o+////:::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::///+oso/`    
  :s+/::::::::::::::::::::::::::::::::::::::://+++:::::::::::::::::::::::::::::::::::::::::::/+y`   
 .h/:::::::::::::::::::::::::::::///////+oyhhysoho::::::::::::::::::::::::::::::::::::::::::::/h:   
 +o:::::::::::::::::::::::::/+osssoossssso+/::--m/::::::::::::::::::::::::::::::::::::::::::::/mmo` 
`ss:::::::::/+++++++////+osss+/::-------/+++/:::m::::::::::::::::::::::::::::::::::::::::::::/hsomd.
++h/:::::/+o+/:::::/+ooo+//:----://///ohhhyyhhddd::::::::::::::::::::::::::::::::::::::::::/oy+/:+Nh
y:+s/:::+s/:-----------------/syhhhhhhyssssoossyy/::::::::::::::::::::::::::::::::::::::::/o+/::::mN
h::/o+//s:----------:+oo++osyhysssssosssssssososy/::::::::::::::::::::::::::::::::::::::/://:::::/Ny
o+/::/+o/---------:+syssssssssssssssssssssssososh:::::::::::::::::::::::::::::::::://+++/:::::::+dh.
`s+:::s:-----:/osssysosssssossssssssssssssssssssd/:::::::::::::::::::::::::::://+osyo+/:::::::/sho` 
 `+o/:y------+dssssssssssssssssssyyyysssssssssssyy/::::::::::::::::::::://+osyhhyo+/:::::::/+oy+.   
   ./+y:------hhsssssssssssyyyssssssyyhssssssssssds:/::::::::::///++osyhhhhys+//::::::::/+os+-`     
     `-o:-----/mhsssssssyhyyssssssssssdsssosssssssdo++++ooossyyhhhhhyyoo+//::::::::://oyy/-`        
       .o:-----oNyssosssdsssssyyysssyhssssssssosssyhsssssssooo++///::::::::::::://+osmNh.           
        `++:----smsossoshysssshsssshhssssysssossssm/:::::::::::::::::::::::::://////dNo`            
          -o/:--:smssssssyhhyshsshhsossssssyhyssshy:::::::::::::::::::::::::::::::/dd:              
           `:o/:-:ydssssssssyydhyssssossssssshysshy::::::::::::::::::::::::::::::+dy.               
             `/o/::yhsssssssssssssysssyssosossdsoyd::::::::::::::::::::::::::::/odo`                
               `+o::hyssssssssssssshshyssssyyyysssN/::::::::::::::::::::::::::/yd:                  
                 .s//mysossssssssssshdhyhyyssossssds::::::::::::::::::::::::/ody.                   
                  `o+smhhysssssssoosssyssssssssssshs::::::::::::::::::::::/odd:                     
                    :soooomhsssssossssssssssssssssd+:::::::::::::::::://+ydh/`                      
                     `/oo++ydddddyyysssyhhdhyyddyyd::::::::::::::///+oyhy/.                         
                        `:+ossyyyyddmmmdhyo++++oyy+++++++++ooosyyyyso:.                             
                                 ``..-::////+++++++++o++++//:--.`                                     "));
            NewRecipes.Add(new Recipe("Cinnamon Roll", 125, "Cinnabon better watch out!", @"
                             .o-                                                      +.                        
                +hys                                                     /hh+                       
              `sysoyo                   .-://///////////:-.`            -hssys`                     
              shsoooyo`             .://:.`            ``.-////-.      -ysoosys`                    
             /hyoooooys-         `:+:.`            ````      `.-:/:.` /hsooooyho                    
             yyooooooosy+`   `..:+-   ```             `....`     `.-oyyooooooyyh.                   
            -hysoooooooosyo+//:-:+/.                     `.-`     -sysooooooosyh/                   
            :hysoooooooooosys-   `-//-`               ``.--`   `/sysoooooooooyyh+                   
            -hysoooooooooooyy.     ``-:/::-.``````..----.``    `yyoooooooooosyyh+                   
            `hyysoooooooooys.         ``..--::::::--.```        .syooooooooosyyh/                   
             ohyssooosssys/`                ```````              `/yyssssssssyyy`                   
             `yyyyyyyso/-`                                         `:+syyyyyyyh+`                   
             .o:::-.``                                                ``.:///oo://:-`               
             +:``                                                        ```-/.``..://-`            
            -o.``         .-://+++++/-                    ./++++//:-`  ```.--``    ``.:+/`          
        `-///o-``       `:/ooo+/:---:/o.                -++:--:://+oso/-`..`         ``.-+/`        
      `//-`  `::.`         `sy--:+o+/-:+/             `++::/+oyo//yo.```            `````.:+.       
     -+-       .:-.        /h.  .yhh//o+oo`          -so++yhhs.:o -h:           ```````````-o.      
    :+`          `..``     so   ohhho+ys:oo         -+:-`.hhhyosh- oo         ```.://:--.```:o      
   -o`                     s+   ohhhhhho  ..        `    `hhhhhhh- ++        ``.+++///++++//o+      
   +-      `````````       -y`  .yhhhhy.  -`              :yhhhh+ `s.        ``-s///////////yy      
  `+`    ``.-::::-````      :/`  `/oo/.  .+                ./+/. `+/.`       ``.o+////::::/+dm.     
   +:````-/++///+++-```      `-`        -s.                    -:::--::.      ``:o////---:shoyh`    
   -o--:++////////+o.``            `  .+o.                    .`       .      ```+o///::oyo://hy    
   +h+ys/::::::////o/``      ````.-::ss-                                       ``.o+/+ss+:--://m/   
  -m+/+yy/-----:///+o``      `-//++/ooo:`                        ..            ```:oso/:-----:/yh   
  sh///:/ss+:-::///o+``     `.:oso//++.--.``                   .:.    `..      ```.o+///::---:/+m.  
  ds///---/+so+:///o/```  ``.+o//+s++/`  `                   -/-`  `.:++o-     ````/o///-:---:/+m-  
  ms///:-----:/+oo+oo.`````-o+/:--/+o+-`                  .:+/.`-:/++///o/      ```/o//:-----:/om`  
  yy///:--------:/++o+-...:o//:---//o+oo/-.`          `-/++:-/+++///////o:      ``.o+//:-----:/hy   
  -m+///:--------::///++++++//:::://o:`.-+oo++/::://+oo+-../+///////////s.     ```:o///------:od.   
   +d+///:---------::///////:----://++``   `.--:::--.`   `o+//:::::////+o      ```++//:-----:sd:    
   `odo///:----------::::::------:///o:``                /o/::-----:///o:     ```:o//:-----/yh/.`   
 `.--hdho//::---------------------:://o:.``....`         ++:-------:///o/`   ```-o+/::---/sdd+---.` 
`----hs/yhs+/::---------------------::/++/ssooooo:       o/---------:///++-...-/o+/:--:+yhsoh+-----.
-----yy--/shys+/:---------------------:+shy/:.`.:y+ `..``++----------::///+++++/:::/oyys/:/oh+------
`----oh:--//+yddyso/::---------------:sy/--:oy:-:shosooooy+-------------::::::/+oyyydh:--//oh/-----`
 `.--:ho--:///sy+/+syysso+//::::-----+h-`   .hy+//+ss/  .+y+--------::://+osyyso/:-+h/---//sh:---.` 
    `.sy---////sy/----://+ossyyyssssoyh..`  sy.     .o+   +y///+ossyyysso+/:------/ho---://yy..``   
      -h+---////sh+-------------:::/ohyoooo+h/..`    `y   `so////:::-------------:ys----//oh/       
       +h:--:////oys:--------------+h/`  `-hyo/:/+-   s    oh-------------------/ys----///yy`       
       `sy:--:////+syo-....--------hs    `oy.     /-  :    -h+----------.....`./yo----://oh/        
        `ss:--://///+syo:/++o+/...-h+   `-h/       :        sy-``````        .oy/----://+ys         
         `sy:---//////+yy+-..:yysooh-   `+h-       .        `oso/. ``.-.` `.+yo:----://+yy`         
          `+y/---:////sh:` `/o/.  .o    `/h-`                 `./sosso+os+sy+:-----://+yy.          
            :ys:---:/+h+`  :-     .`     .ho``                    -so```-yy:-----:///+ys.           
             `+yo:---sh.`                `sh:``                     +/  `-h+----:///oyo`            
               .+yo/-yy`                `/yyy:``                    `+  ``yy--:///+sy:              
                 `:sshs`               ```y-/y+.``            ```    `  ``sy////+sy/`               
                    .sh``  `             /:``-oy+-```                   ``yy/+osy/`                 
                     -h+`  +`           --````.yssyo```                 `.hysyo-                    
                      -ys/:+y:`        ``````-ss` .ss:````          `. ``oho:`                      
                        -:::-os/.`````./osooss/`    :sy+:.```````.:+o.`.oy:                         
                              ./oysssys+-`..`         .:osso+++oss+sysys+.                         "));
            NewRecipes.Add(new Recipe("Angel Food Cake", 200, "Light, fluffy. You're pretty sure it just melts in your mouth!", @"
                                                          `                                                      
                                       `-` ::`-/                                                    
                                 `` .:.-oo///--.`                                                   
                          ``  :-./o+++/--:/oshmmmho`                                                
                        ` .oo+so+/-:/oydhmmmmmmdo:...  ``                                           
                     `` +o++/-:/oydmmyymmmmmmm+`-://- :///:`                                        
                 `:--/+:--:+sdmmmmmmmmmmmmmmmo :////--//////                                        
               :///:-.:ohdmmmmmmmmmmmmmmmmmmmo ://////////-- -                                      
              ``.``+hdmmmmmmmmmmmmmmmdmmmmmmmm:`://////..:``smh+.                                   
                 .:--/+shdmmmmmmmdymmdmmmmmmmmm+..:://:` .+dmmmmds:`                                
                 -oooo+/::-:+sydmmmmmmmmmmmmmmmmdo/:::/+ydmmmmmmmmmh+.                              
                 `..:+ossooo+/::::/oyhdmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmdy:`                           
                 `..``..:/+osssooo+//:::/+oyhdmmmmmmmmmmmmmmmmmmmmmmmdmmdo-                         
                 :o++:-..`..-:/+osssssooo+//::::/+syhdmmmmmmmmmmmmmmmsmmhymy/`                      
                 /ssssoo+/:......-:/+oossssssooo++/::::/+syhdmmmmmmmmmmmddmmmy+.                    
                 /ssssssssso+/:-...`...-:/++oosssssssoo++//:::+osyhdmmmmmmmmmmmho:                  
                 ./+ossssssssssoo+/:-.........-://++oosssssssoo++//:::/+oyhddmmmmmy:`               
                 ```.-/+ossssssssssssoo+/:-..........--::/+++ooossssooo++/:::://osyyy+.             
                 //:-.``.-:+oosssssssssssssoo++/:--............--:://+++ooosoo++/:----.`            
                 +ssoo+/-.```.:/+oossoossssssssssssooo++//:--.....````.....--://+++o+++/:-`         
               .`+sssssssoo+/-.```.-:/+ooosssssssssssssssssssooo+++//:::--.....``.....-::/-         
               ` +ssssssssssssoo+/:.````..-://++o/+oosoossssssssssssssssssooo++++//::-..``          
                 +ssssssssssssssssssoo+/:-.``` `` `..-.:/+++oooooooosssssssso+ssssssssoo++.         
                 /ossssssssssssssssssssssssoo++/::-..``````````.....---:::///++/:ooossssss-         
                 `-/oossssssssssssssssssssssssssssssooo+++///:::--..`````````````..-:/++oo.         
                    `-/oosssssssssssssssssssssssssssssssssssssssssssooo+++//::--....``....          
                       `.:/oossssssssssssssssssssssssssssssssssssssssssssssssssssoo+//:-..          
                           `.-/+oossssssssssssssssssssssssssssssssssssssssssssssoossssooo+`         
                                `.-/+ooossssssssssssssssooosssssssssssssssssssssoossss+/s/`         
                                     `.-:/+ooossssssssss+/ossss/ssssossssssssssssssssssss.          
                                            `.-:/+ooossssssssssossss:osssssssssssssssoosso`         
                                                   `.-:/+ooossssssssssssssssssssssssso/oss.         
                                                          `.-:/oooosssssssssssssso+ossssss-         
                                                               ``.-:/+ooosssssssso/ossssss`         
                                                                      `.-:/+oooossssssssso          
                                                                             ``.-:/+ooooo/          
                                                                                      ``.`          
            "));
            NewRecipes.Add(new Recipe("Baked Alaska", 500, "Shit's on fire!!", @"
                                           `:////:://///-``                                                     
                           :::odhyyyyyyyyyyyhhhs/.                                                  
                          .hhdddddhhhhyyyhhhhhhhyy/                                                 
                       `/ohhhhhhhhhhhyyyyyyhyhddyss-                                                
                        ohhhhhhhhhhhhysssyyyssydyoos-                                               
                       /dhhhhhhhhhhysysssyysssydyooo+                                               
                /syssshhhhhddddhdhhhhyyyyyssyhhysssos`                                              
               `hhhhhhhhhhdhhhhdhhhhhhyyyyyyhhsssso+oo.                                             
               -hhhhhhhhhddhddddhhhhyssyhyyso++oosoooosy/`                                          
               oyhhyhhhhddddddddhhhyyyyyyyssssssssssyysssy/                                         
              `sssyyhhhhdddddddhhhhhhhhyyyyyyyyyyyyyyyyyssys.                                       
              -sssssyyyhhhddddddddhhhhhhhhhhyyyyyyyyyyyyyyssy`                                      
              `ssssssysyyyyyhddddddhhhhhhhhhhhhhhyyyyyyyyyyysy:                                     
               shhyyyyyysyssssyhhhdddddddddddhhhhddhhhyyyyyyyyys.                                   
               hhhyyhhhhhyyyssssssyyyhdddddddddddddddddhhhyyyyssy/                                  
              :hysooosyyyyyyyyyysssossyyhhdddddddddddddddhhhyyysss/                                 
              ohhysoooosoosssssyyyyyssssssyyyhhddddddddddddhhhyyyss:                                
              ohhhsssssysosyyyyssyyyyysssssssyyyhhdddddddddddhhhyyys/                               
              /hhyssyssssyysooooosssyyyssyssssssssyyyhdddddddhhhhhhys-                              
              oyyssssyyysoyoosossyysssyyyyssyyysssssssyyhhhddhhhhhhhy:                              
              -ssyyssssyyyhysyyyysssssssyyyysshhyyssosssssyyhhhhhhhyy                               
               yssyyyyysyhyyyssyyyyyoo+ooosssohhhhhyyssoo++osssyyyyys+                              
              .hhyyyssyyoooyyssoosssoo+ssssooyyhhhhhhhyyssooooosssyyyy-                             
              shsyyyysoosyyyyyyyysyysososyyyyysyyyyhysosoosoooosssssss:                             
              -ssysssyyyyyyyssyyyysshsosoossyyyyyyyyysosssssssssosssoo:                             
                -syssssssysssyyossoshhssyysoossyyyyyysssssssyysssssooo`                             
                  `-/+ssssssssssssosyhhhssyysoyysssssosso+oossssossoo+                              
                       -/+sssssssssssssyyysyyshhssyssoooso+++++o+sooo+:                             
                           .-/+sssssssssossyyhhhhsyyyyysssssooooosoooo+                             
                                .:/osoosssssossyyssossysssyyyysosssssso                             
                                     .:/osoosoooooooooooosssyyooso+++os                             
                                          .:/+sooooooooooooooooosoo+oos                             
                                               .:/oooooo+ooooooooooooo+                             
                                                    .-/+osooooossoooooo:                            
                                                         `:/+ossssooooo+                            
                                                              `-/+ososo/                            
                                                                    `                              "));
            NewRecipes.Add(new Recipe("Baked Salmon", 500, "Hmm.. something smells a bit fishy..", @"
                                                            `.-/+ossyhhhhhhddmmmNNNNmdddhss+/-.         
                                                -:+oyhddmdddhhyyyyyyyyyyyyyyyyyyhhhhhdddmmNmdyo:    
                                        `.:+shdmmddhyyyyyyhssssoyhsoooooooooosssysssyyyyyhhhdddmN-  
                                    -+sdmNmdhhyyhhhsssooydho++++oo++++++++++so-.-:ooooosssyyyhdmy`  
                              `-/shNNmmdhhhdyssddhso++++/+oo////////++//////s`.o:hss+++ossshhs:`    
                        `-/+shNMMNmdhhyyymmhooo++++yh+//:/s/::::::os+:::::::+::dNMN+//oy+yh/`       
                  `-/+sydhhhmMNmdhdmmyssooo++++sy/:+::::--------/d+----------:oso/:-:yo/ho` .:++o+/+
             .:+syyyyyyyhdmMNmdhhhmdssooyds///oy/:---------.....mh............-...--y/:do+oso+/+syy+
        .:+syyssssyddmmNMMNddmdyssshy++/o+/:::------...........-Ms`................os/yh+:--/ss+-`  
   `-+syysossyhdmmmmmmNMNddmNmhsoohh+//::::-----..........``````dm.``````````````./ys/-.../ys-`     
 :shysossyhdmmmmmmNNNMNdhhyyyyyo+++//ys:----........````````````-md-````````````-:-.``.-+o/.        
odsssyyhdmdmmmNNNNMMNmdmmyssdmy+///::/:---......````````````.+.``-hmo.`````````````.:+o+.           
dmhhhddmmNNNNNNNNMMmddmmhsoooo//+::----......```````````.-/o+-`````:yds/-```````.:ss/.`             
`-hNmNNNNNNNNNNNMNmdhyyssyo+//+h+----.....``.::::::///+o+/-.`````.```./syyyysoshds-`                
  oMNNNNNNNNNNMMNdmmmysosh+//:::---.....````oo--:---.-:-::-````-s-````````..:syo.                   
  yMNNNNNNNNNNMmddmdyso++//:::---.....``````-s//:////:..-::-`-oo.````````.+ys/`                     
  -ymMNNNNNNNNmdhhyssos+//::---.....``````````.h/---:///-..:oo-```````-+yy+.                        
    .dNNNNNMNmmmdysooyh+/::---....`````````````./+/oo/:-/oo/.`````-/sys/.`                          
    `dNNNNMMmmNmhsoo++//::--.....```````````````````.-:::.```.:+yyyo:`                              
    `hmNNNNmddhysoo+///::--....```````````````````..```.-:+ssso/-`                                  
     `.omMmddhhssoy+/:::--....```````````:```````/doshhhhydy`                                       
        +Nddhmmsohh//::---....```````.-/sd``````-d/-dh/::+s`                                        
        mmdhhdyo+o//::--....`````-/syysNN/`````-h/ -y-`.++`                                         
       -Mddhyyso++/::---....`.-ohhs:.`:h:````.+y- -s.-/+.                                           
       +Ndhhmsooy//::--.....+yyo-`  -//.`.-/oo:`  o++:.                                             
       oNdhyhso+o/::---...+dh:`    -y++oso+:.      `                                                
       oNdhysoo+//::---.-hd/`       ...``                                                           
       +Nhyyhs++//::--.-dN-                                                                         
       -Nhyyso++/::---.oNNh/.`                                                                      
        Ndysso++/::---.ymhdmdhyo+//////+++`                                                         
        ymysso++/::---./dhhyyyyyyysso++++d:                                                         
        :Nysso++/::---../ddhhyyyyysoo++/ys                                                          
         hmsso++/::---...yddddhyyyysssssys                                                          
         -Nhso++/::--::/smmmdddddhysoooshs                                                          
          oNyo++//:::dmmNNNNmmdddddddhdm:                                                           
           yNs++//::oNNNNNNNNNmmddhhyymd                                                            
           `dms++/shmNNNNNNNNNNNNmddddm+                                                            
            `hmsshNNNNNNNNNNNNNNmmNNNs.                                                             
             `sNNNNNNNNNNNNNMNNNNNmmN`                                                              
               /NNNNNNNNNNNNNNMNNNNNm`                                                              
                -hNNNNNNNNNNNNNNNNNo.                                                               
                  /mNNNNNNMNNNNNNNh                                                                 
                   `sNNNNNNNMNNNNNs                                                                 
                     .sNNNNNNNMMy-                                                                  
                       .omNNNNNM                                                                    "));
            NewRecipes.Add(new Recipe("Wedding Cake", 1000, "There's a 50/50 chance this won't work!", @"
                                                                                                                
                                         `-////-    `-////-                                         
                                       `+ysoooosy+`+ysoooosy/                                       
                                       osoooooooosdsooooooooso                                      
                                      `hoooooooooooooooooooooh                                      
                                       ssoooooooooooooooooooso                                      
                                       `osoooooooooooooooooyo`                                      
                                         :ysoooooooooooooss:                                        
                                          `/ysooooooooosy/`                                         
                                       ```..-shsssssssy/`                                           
                               .:::://///:----::::::/++///:::-.                                     
                             -o--.....``````````````````.....-://:-.                                
                             -s```````...``````````````````..```..-:/:`                             
                              d/````-+++++.````./++/.````-++++/`````.o:                             
                              y++//++:---+o.``-o/--/o/:/++:---+o````-d`                             
                              +/-::-------++//o:-----::::--::--y.``:sy                              
                              -s------------:::------:---------/o:+o+/                              
                               h--:----:/+//////++++++++++++////o++/y.                              
                               y://++++/::----................-----:/://::-`                        
                           `-:/+/:-...`````````````````````````````````..--+:                       
                        .:/:--.````````````````````````````````````````````+:                       
                       :+-.```````-:/:-.````````.::.`````````-://:.```````-d`                       
                       -s```````.++/:/++-.````./o//o/.``````++/::/o/.```.:sh                        
                        d/``````o/-----:++/::/+/----+o-```./o------/++//++/o                        
                        ss/.```-y---::---:::::-------:o/::+o:---------::--o:                        
                        :oo+..`o+---:------------------::::---------------y                         
                         h-/+++o------------/:----:---:-------------------y                         
                         s:://////+++++//++++++++++++++++///++::-----::--/o                         
                     `.:/o+:::---.......```````````.......--:::/+++//::--o-                         
                    +/:..````````````````````````````````````````..-::/++y-`                        
                    s.`````````````````````````````````````````````````..:://-`                     
                    oo`````````..---.```````````....```````````.--.`````````.://                    
                    -d/``````.-++//++/````````.-++++-````````./++/++.`````````.s                    
                    `y++-...-+o:-----+o``````./o:--:o/.....-+o/----:s.````````++                    
                     s::/++++:--------s/..`.-o+------/++++++:-------/s```````-d.                    
                     +/----------------++++++:---::--------:----/:---y.`````.sh`                    
                     -o-----------------------------------------:----s:````.+so                     
                     `s---------------------:----------/:------------/+```.+oo-                     
                      s:--:/:-------:/:---:------:-------------------:y..-o+-s`                     
                      +/--------::------------------------------------++++:-:s                      
               .......+s////////////////////////////////////////////////////o+.......               
               ymmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmy               
               /++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++/                         "));
            NewRecipes.Add(new Recipe("JavaScript Celebration Cake", 15000, "Scot with one T will love this. Right in his face.", @"

                                                /:/                                                  
                                          .    ::.:                                                 
                                      /:osshy/` `o:                                                 
                        ---:`       /ssyhhdmdmd+                                                    
                        .:::++.   :syosh:+hmhhhds--.                                                
                                 `:/oydmmyoooosyy`.:sss/:                                           
                                `ooosdhddhddh````++/s/::/o`                                         
                                  +yddhdo:.````.++/y/::::/o` ````````````````````````````````                                       
                                 -ddsyhdho:::``.s:o+::::::/o  ``````````````````````````                                      
                                 `mm::shds.:/.`/+:y::::::::s   ``````````````````````                                     
                                 :dd+-+.-/:.```+/:y::::::::s    `````````````````````````                                    
                                  yhm:+.`-:::..s/:s/::::::/o                   .::::/               
    ..      `-            -/::+o` -dhd/```-:/y`o/:+o::::::o.  ``` ```` `````.`-.``.-.````` ```  ``` 
   -:-::.  -/.::          ----.ohdMMNN--::::-.`:o//s/::::os///++++++//:-::-/:::::+++:-::            
 `` -/.`:: ./``+       `.:/odNMMMMMMMMm-`:::::.`.+o/so:/hMMMMMMMMMMMMMMMMs````-::..:s::-            
o--::::/..:-+`.-/:oydmNMMMMMMMMMMMMMMNMdym/:os+o-``-/+//MMMMMMMMMMMMMMMMMM-``:/`.:+/:::/:           
`:::..:::```````.ohMMMMMMMMMMMMMMMMMMMMNMMsyNNdyNo/sNhsoNMMMMMMMMMMMMMMMMN.`:+```:+/:--.            
 `..--/.````::```+-MMMMMMMMMMMMMMMMMMMNMMMM:hNNomMMNMmmmyo--:+oshdmNMMMMm:::-``.::--:::.            
+:--:::.`````//.::oMMMMMMd+-./MMMMMMMMMMMMMo hmNmMMMNNMmmNm.         ```-:/::/:.  `-:/:o            
::::::+-``````.s+/MMMdo:`     -NMMMMMMMMNMMN``oyhNMMMomNmmNy                                        
    -:-::--:::+..oo:`          .NMMMMMMMMNMM+    oNMM:mmNmdo                                        
   /-::`      `-`               +MMMMMMMMMMMd    `mMM:-my:                                          
   -.                           :MMMMMMMMMMMM`    /MMm-                                             
                                sMMMMMMMMMMMMhhdmNMMMMMm+`                                          
                               -MNNNNNMMNMMMMMMMMMMMMMMMs`                                          
                              `mMMMMMMMMMMMMMMMMMMMMMMMMMNy.                                        
                              .MMMMMMMMMMMMMMMMMMMMMMMMMMMhy                                        
                               -shdmNNNmMMMMMMMMMMMMMMMMMMh`                                       "));
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