using System;

namespace Prog2
{
    public class Lose: Menu
    {
        public override GameState VisualiseMenu()
        {
            Console.Clear();
            System.Console.WriteLine("You lost!");
            Console.ReadKey();

            state = GameState.superQuit;
            return state;
        }
    }
}
