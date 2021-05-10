using System;

namespace Prog2
{
    public class Menu
    {
        public enum GameState
        {
            //alla gamestates som spelet kommer behöva. Dessa kommer vi kunna byta mellan för att nya delar a spelet ska spelas
            menu,
            inGame,
            help,
            shop,
            gameLost,
            gameWon,
            quit,
            superQuit
        }
        protected static GameState previousMenu = GameState.menu;
        //Static gör det möjligt att spara värdet i vilken subklass som hellst och sedan komma åt världet vart som hellst utan att returna det. Detta är användbart eftersom state måste returnas.
        protected GameState state = GameState.menu;
        //skapar en instans av enumen GameState så att det är möjligt att byta spelets gamestate i menu eller någon av dess subklasser
        public virtual GameState VisualiseMenu()
        //Eftersom detta är huvudklassen så skrivs virual in istället för override. Om ingen av override metoderna kommer spelas så spelas denna istället
        {
            Console.Clear();
            System.Console.WriteLine("Hello and welcome to EFG, Epic Fighting Game!\n");
            System.Console.WriteLine("This is a tower defense game where you purchase heroes to defeat the hoard of monsters awaiting\n");
            System.Console.WriteLine("What would you like to do?");
            
            System.Console.WriteLine("  Start Game  ");
            System.Console.WriteLine("  Help  ");
            System.Console.WriteLine("  Quit  ");
            //Visar alternativ man kan genomföra

            int selectedOption = 0;
            //håller koll på vilket alternativ som för tillfället är markerat

            while(true)
            {
                Console.CursorTop = 5 + selectedOption;
                Console.CursorLeft = 0;
                Console.Write(">");
                //Skriver ut en pil på markerat alternativ

                ConsoleKeyInfo keyInfo = Console.ReadKey();
                if (keyInfo.Key == ConsoleKey.DownArrow)
                {
                    Console.CursorTop = 5 + selectedOption;
                    Console.CursorLeft = 0;
                    Console.Write(" ");
                    selectedOption++;
                    //Byter ut > med ett mellanslag på tidigare position i listan bland alternativen innan det läggs till 1 i instansen selectedOption så pilen kan ritas ut vid det nya alternativet
                }
                else if (keyInfo.Key == ConsoleKey.UpArrow)
                {
                    Console.CursorTop = 5 + selectedOption;
                    Console.CursorLeft = 0;
                    Console.Write(" ");
                    selectedOption--;
                    //Byter ut > med ett mellanslag på tidigare position i listan bland alternativen innan det tas bort 1 i instansen selectedOption så pilen kan ritas ut vid det nya alternativet
                }
                else if (keyInfo.Key == ConsoleKey.Enter)
                {

                    if (selectedOption == 0)
                    {                    
                        state = GameState.inGame;
                        break;
                        //Byter gamestate till game om man valde det alternativet
                    }
                    else if (selectedOption == 1)
                    {
                        state = GameState.help;
                        previousMenu = GameState.menu;
                        break;
                        //Om spelaren väljer alternativet help så öppnas helpmenyn
                        //Med hjälp av att sätta previousMenu till menu så kan man komma tillbaka till menu om man väljer cancel i help
                    }
                    else if (selectedOption == 2)
                    {
                        state = GameState.quit;
                        previousMenu = GameState.menu;
                        break;
                        //Om spelaren väljer alternativet quit så öppnas quitmenyn
                        //Med hjälp av att sätta previousMenu till menu så kan man komma tillbaka till menu om man väljer cancel i quit
                    }
                }

                if (selectedOption < 0)
                {
                    selectedOption = 2;
                }
                else if (selectedOption > 2)
                {
                    selectedOption = 0;
                }  
                //Ser till att man inte kan komma utanför listan av alternativ. Om man försöker gå utanför nedåt så hamnar man längst upp i listan och tvärtom
            }
            return state;
            //Returnar state så att programmet vet vilket gamestate som ska spelas
            //previousMenu behöver inte bli returnat eftersom det är en static, värdet i index sparas över alla subklasser och huvudklassen
        }
        
    }
}
