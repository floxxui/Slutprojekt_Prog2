using System;

namespace Prog2
{
    public class Game: Menu
    {

        public static int RoundCount{get; set;} = 1;
        //håller koll på vilken runda som ska spelas. Skulle gå att ta bort genom att byta ut dess position med queue'n, men har inte hunnit fixa
        //temporär lösning

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
                        PlayRound();
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

        private void PlayRound()
        {
            Round r = new Round();

            switch (RoundCount)
            {
                case 1:
                    System.Console.WriteLine("yees");
                    Console.ReadLine();

                    Round.Round1GetMonster();
                    //Hämtar monster från metoden i Round klassen. I metoden läggs monster i en lista
                    
                    System.Console.WriteLine(Round.Rounds.Count);
                    System.Console.WriteLine(Round.MonstersInRound.Count);
                    Console.ReadLine();
                    //Debug

                    //Round1Play();
                    break;
                case 2:
                    Round.Round2GetMonster();
                    //Hämtar monster från metoden i Round klassen. I metoden läggs monster i en lista
                    break;
                case 3:
                    Round.Round3GetMonster();
                    //Denna (och alla andra metoder med liknande namn i switch casen) gör samma sak som den gör för runda 1 och 2
                    break;
                case 4:
                    Round.Round4GetMonster();
                    break;
                case 5:
                    Round.Round5GetMonster();
                    break;
                case 6:
                    Round.Round6GetMonster();
                    break;
                case 7:
                    Round.Round7GetMonster();
                    break;
                case 8:
                    Round.Round8GetMonster();
                    break;
                case 9:
                    Round.Round9GetMonster();
                    break;
                case 10:
                    Round.Round10GetMonster();
                    break;


                //Switch case som checkar vilken runda det är som ska spelas. 
            }
        }

        // private void Round1Play()
        // {

        // }

    }
}
