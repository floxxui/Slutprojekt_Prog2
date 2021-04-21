using System;
using System.Collections.Generic;

namespace Prog2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Info i anteckningsblock
            //Basically tower defense i konsollen
            
            Menu menu = new Menu();

            Dictionary<Menu.GameState, Menu> menus = new Dictionary<Menu.GameState, Menu>();

            menus.Add(Menu.GameState.menu, new Menu());
            menus.Add(Menu.GameState.help, new Help());

            Menu.GameState currentMenu = Menu.GameState.menu;

            bool gameApplication = true;
            while (gameApplication == true)
            {
                
                currentMenu = menus[currentMenu].Do();


                // switch(menu.state){
                //     case Menu.GameState.menu:
                    // case GameState.help:
                        
                    //     break;
                    // case GameState.inGameRound:
                        
                    //     break;
                    // case GameState.inGamePause:
                    //     System.Console.WriteLine("In game! (det funka!!)");
                    //     break;
                    // case GameState.gameLost:
                        
                    //     break;
                    // case GameState.gameWon:
                        
                    //     break;
                    // case GameState.quit:
                    //     gameApplication = false;
                    // break;
                //}
            }
        }
    }
}
