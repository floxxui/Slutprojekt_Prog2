using System;
using System.Collections.Generic;

namespace Prog2
{
    public class Game: Menu
    {

        // public static int RoundCount{get; set;} = 1;
        private static bool roundsCreated = false;
        private Queue<int> Rounds = new Queue<int>();
        private static int playerHP = 50;
        private Round r = new Round();
        public override GameState VisualiseMenu()
        //Overriden checkar i huvudklassen om det finns en metod med samma namn. I så fall kommer denna metod spelas istället ifall denna subklass försöker nås
        {
            int selectedOption = 0;
            //håller koll på vilket alternativ som för tillfället är markerat

            while(true)
            {
                Console.Clear();
                System.Console.WriteLine();

                System.Console.WriteLine("  Start Round  ");
                System.Console.WriteLine("  Shop  ");
                System.Console.WriteLine("  Help  ");
                System.Console.WriteLine("  Quit  ");
                //Visar alternativ man kan genomföra

                Console.CursorTop = 1 + selectedOption;
                Console.CursorLeft = 0;
                Console.Write(">");
                //Skriver ut en pil på markerat alternativ

                ConsoleKeyInfo keyInfo = Console.ReadKey();
                if (keyInfo.Key == ConsoleKey.DownArrow)
                {
                    Console.CursorTop = 1 + selectedOption;
                    Console.CursorLeft = 0;
                    Console.Write(" ");
                    selectedOption++; 
                    //Byter ut > med ett mellanslag på tidigare position i listan bland alternativen innan det läggs till 1 i instansen selectedOption så pilen kan ritas ut vid det nya alternativet
                }
                else if (keyInfo.Key == ConsoleKey.UpArrow)
                {
                    Console.CursorTop = 1 + selectedOption;
                    Console.CursorLeft = 0;
                    Console.Write(" ");
                    selectedOption--;
                    //Byter ut > med ett mellanslag på tidigare position i listan bland alternativen innan det tas bort 1 i instansen selectedOption så pilen kan ritas ut vid det nya alternativet
                }
                else if (keyInfo.Key == ConsoleKey.Enter)
                {
                    if (selectedOption == 0 && Hero.Heroes.Count == 0)
                    {
                        Console.Clear();
                        System.Console.WriteLine("You need to purchase at least 1 hero before starting the game");
                        Console.ReadLine();
                        //Om spelaren inte har köpt något torn men försöker starta spelet så blir man nekad eftersom man inte kan överleva utan ett utplacerat torn
                    }
                    else if (selectedOption == 0 && Hero.Heroes.Count >= 1)
                    {    
                        Console.Clear();
                        Rounds = RoundController();
                        //Om spelaren försöker starta spelet och har ett torn utplacerat så spelas mästa rundan
                    }
                    else if (selectedOption == 1)
                    {
                        state = GameState.shop;
                        break;
                        //Om spelaren väljer alternativet shop så öppnas shopmenyn
                    }
                    else if (selectedOption == 2)
                    {
                        previousMenu = GameState.inGame;
                        state = GameState.help;
                        break;
                        //Om spelaren väljer alternativet help så öppnas helpmenyn
                        //Med hjälp av att sätta previousMenu till inGame så kan man komma tillbaka till spelet om man väljer cancel i help menu
                    }
                    else if (selectedOption == 3)
                    {
                        previousMenu = GameState.inGame;
                        state = GameState.quit;
                        break;
                        //Om spelaren väljer alternativet quit så öppnas quitmenyn
                        //Med hjälp av att sätta previousMenu till inGame så kan man komma tillbaka till spelet om man väljer cancel i quit menu
                    }
                }

                if (selectedOption < 0)
                {
                    selectedOption = 3;                     
                }
                else if (selectedOption > 3)
                {
                    selectedOption = 0;
                }  
                //Ser till att man inte kan komma utanför listan av alternativ. Om man försöker gå utanför nedåt så hamnar man längst upp i listan och tvärtom
            }

            return state;
            //Returnar state så att programmet vet vilket gamestate som ska spelas
            //previousMenu behöver inte bli returnat eftersom det är en static, värdet i index sparas över alla subklasser och huvudklassen
        }

        private Queue<int> RoundController()
        {
            if (roundsCreated == false)
            {
                
                Rounds  = r.GetRound();
                roundsCreated = true;
            }
            
            switch (Rounds.Peek())
            {
                case 1:
                    Round.GetMonster(0);
                    //Hämtar monster från metoden i Round klassen. I metoden läggs monster i en lista
                    playerHP = r.PlayRound(Hero.Heroes);

                    System.Console.WriteLine(Rounds.Count);
                    System.Console.WriteLine(Round.MonstersInRound.Count);
                    Console.ReadLine();
                    //Debug
                    
                    break;
                case 2:
                    Round.GetMonster(1);
                    //Denna metod i varje case hos switch casen gör samma sak
                    break;
                case 3:
                    Round.GetMonster(2);
                    break;
                case 4:
                    Round.GetMonster(3);
                    break;
                case 5:
                    Round.GetMonster(4);
                    break;
                case 6:
                    Round.GetMonster(5);
                    break;
                case 7:
                    Round.GetMonster(6);
                    break;
                case 8:
                    Round.GetMonster(7);
                    break;
                case 9:
                   Round.GetMonster(8);
                    break;
                case 10:
                    Round.GetMonster(9);
                    break;
                //Switch case som checkar vilken runda det är som ska spelas. 
            }
            return Rounds;
        }
    }
}
