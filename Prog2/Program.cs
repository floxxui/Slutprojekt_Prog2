using System;
using System.Collections.Generic;

namespace Prog2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Dictionary<Menu.GameState, Menu> menus = new Dictionary<Menu.GameState, Menu>();
            //Skapar en dictionary. i dictionaryn sparas ett gamestate och en av klasserna till Menu hirearkin på samma platts i dictionaryn
            
            menus.Add(Menu.GameState.menu, new Menu());
            menus.Add(Menu.GameState.help, new Help());
            menus.Add(Menu.GameState.quit, new Quit());
            menus.Add(Menu.GameState.inGame, new Game());
            menus.Add(Menu.GameState.shop, new Shop());
            //menus.Add(Menu.GameState.gameLost, new Lost());
            //menus.Add(Menu.GameState.gameWon, new Won());
            
            //Lägger till gamestates och klasser från Menu klasshirearkin i dictionaryn
            //Gör att jag kan kalla på klassen med hjälp av gamestates

            Menu.GameState currentMenu = Menu.GameState.menu;
            //Skapar en ny instans av enumen GameState, vilket gör det möjligt att byta mellan states och spela rätt metod baserat på vad spelets gamestate är för tillfället

            while (currentMenu != Menu.GameState.superQuit)
            {
                currentMenu = menus[currentMenu].VisualiseMenu();
                //Kommer spela metoden så länge currentMenu inte är superQuit (gamestate som enbart stänger ner programmet)
                //Checkar dictionaryn menus och spelar metoden VisualiseMenu() baserat på vilket gamestate spelet befinner sig i.
            }
        }

        //current bugs:

        //need to fix:
        //Make it possible to play the game
        
        
    }
}
