using System;
using System.Collections.Generic;

namespace Prog2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Info i anteckningsblock
            Dictionary<Menu.GameState, Menu> menus = new Dictionary<Menu.GameState, Menu>();

            menus.Add(Menu.GameState.menu, new Menu());
            menus.Add(Menu.GameState.help, new Help());
            menus.Add(Menu.GameState.quit, new Quit());
            menus.Add(Menu.GameState.inGame, new Game());
            menus.Add(Menu.GameState.shop, new Shop());

            Menu.GameState currentMenu = Menu.GameState.menu;

            while (currentMenu != Menu.GameState.superQuit)
            {
                currentMenu = menus[currentMenu].VisualiseMenu();
                // case GameState.gameLost
                // case GameState.gameWon
            }
        }
    }
}
