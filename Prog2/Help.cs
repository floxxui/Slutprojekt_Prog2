using System;

namespace Prog2
{
    public class Help: Menu
    {
        public override GameState VisualiseMenu()
        //Overriden checkar i huvudklassen om det finns en metod med samma namn. I så fall kommer denna metod spelas istället ifall denna subklass försöker nås
        {
            int selectedOption = 0;
            //håller koll på vilket alternativ som för tillfället är markerat

            while(true)
            {
                Console.Clear();
                System.Console.WriteLine("What do you need help with?\n");

                System.Console.WriteLine("  How to play  ");
                System.Console.WriteLine("  About towers  ");
                System.Console.WriteLine("  About monsters  ");
                System.Console.WriteLine("  About rounds  ");
                System.Console.WriteLine("  Return  ");
                //Visar alternativ man kan genomföra
                
                Console.CursorTop = 2 + selectedOption;
                Console.CursorLeft = 0;
                Console.Write(">");
                //Skriver ut en pil på markerat alternativ

                ConsoleKeyInfo keyInfo = Console.ReadKey();
                if (keyInfo.Key == ConsoleKey.DownArrow)
                {
                    Console.CursorTop = 2 + selectedOption;
                    Console.CursorLeft = 0;
                    Console.Write(" ");
                    selectedOption++;
                    //Byter ut > med ett mellanslag på tidigare position i listan bland alternativen innan det läggs till 1 i instansen selectedOption så pilen kan ritas ut vid det nya alternativet
                }
                else if (keyInfo.Key == ConsoleKey.UpArrow)
                {
                    Console.CursorTop = 2 + selectedOption;
                    Console.CursorLeft = 0;
                    Console.Write(" ");
                    selectedOption--;
                    //Byter ut > med ett mellanslag på tidigare position i listan bland alternativen innan det tas bort 1 i instansen selectedOption så pilen kan ritas ut vid det nya alternativet
                }
                else if (keyInfo.Key == ConsoleKey.Enter)
                {

                    if (selectedOption == 0)
                    {                    
                        HowToPlay();
                        //Spelar metoden HowToPlay() om alternativet blivit valt
                    }
                    else if (selectedOption == 1)
                    {
                        AboutTowers();
                        //Spelar metoden om alternativet blivit valt
                    }
                    else if (selectedOption == 2)
                    {
                        AboutMonsters();
                        //Spelar metoden om alternativet blivit valt
                    }
                    else if (selectedOption == 3)
                    {
                        AboutRounds();
                        //Spelar metoden  om alternativet blivit valt
                    }
                    else if (selectedOption == 4)
                    {
                        if (previousMenu == GameState.menu)
                        {
                            state = GameState.menu;
                            break;
                            //Om man valde help från menu så byts gamestate tillbaka till menu
                        }
                        else if (previousMenu == GameState.inGame)
                        {
                            state = GameState.inGame;
                            break;
                            //Om man valde help från inGame så byts gamestate tillbaka till inGame
                        }   
                    }
                }

                if (selectedOption < 0)
                {
                    selectedOption = 4;
                }
                else if (selectedOption > 4)
                {
                    selectedOption = 0;
                }
                //Ser till att man inte kan komma utanför listan av alternativ. Om man försöker gå utanför nedåt så hamnar man längst upp i listan och tvärtom
            }

            return state;
            //Returnar state så att programmet vet vilket gamestate som ska spelas
        }

        private void HowToPlay()
        {
            Console.Clear();
            System.Console.WriteLine("When you start the game, you will be put into a menu where you can select in between 4 options\n");
            System.Console.WriteLine("1. Play Round\n If you select this, the next round in the tower defense game will start.\n");
            System.Console.WriteLine("2. Shop\n If this is selected, you will be taken to the shop. Here, you can buy new towers and upgrade those you own.\n");
            System.Console.WriteLine("3. Help\n This will take you back to this lobby, where you can get necessary information about what to do, towers and so on\n");
            System.Console.WriteLine("4. Quit\n Takes you back to the menu. Save data will be removed.\n");
            System.Console.WriteLine("When you start a round, the towers will have 60 seconds on avarage to defeat a monster.\n Some will have to be defeated in a shorter time.");
            System.Console.WriteLine("You have 50 lives every single game. If you loose all these lives, you loose.\n If you finish 10 rounds without loosing all your lives, you win.");
            Console.ReadLine();
            //Bara massa text som förklarar hur man spelar spelet
        }
        private void AboutTowers()
        {
            Console.Clear();
            System.Console.WriteLine("In the game, there are 3 different towers:\n");
            System.Console.WriteLine("1. Attack Hero\n There are three different types of attack heroes, where either damaged is increased but accuracy is decreased or the other way around.\nThis tower at least double damage at all times, and after upgrade, it deals an extra 2 damage.\n");
            System.Console.WriteLine("2. Speed Hero\n This hero attacks twice as fast, and deal an extra two damage after upgrade.\n");
            System.Console.WriteLine("3. Effect Hero\n This hero leaves an effect on the monster which deals 1 damage for every 10 steps. After it's upgraded, stepcount is reduced from 10 to 5.");
            Console.ReadLine();
            //Bara massa text som beskriver alla hero's som finns

        }
        private void AboutMonsters()
        {
            Console.Clear();
            System.Console.WriteLine("monsterTest");
            Console.ReadLine();
            //debugging grej
        }
        private void AboutRounds()
        {
            Console.Clear();
            System.Console.WriteLine("RoundTest");
            Console.ReadLine();
            //debugging grej
        }
    }
}
