using System;

namespace Prog2
{
    public class Shop: Menu
    {
        private int money = 100;
        //Pengar som spelaren har
        public override GameState VisualiseMenu()
        //Overriden checkar i huvudklassen om det finns en metod med samma namn. I så fall kommer denna metod spelas istället ifall denna subklass försöker nås
        {
            int selectedOption = 0;
            //håller koll på vilket alternativ som för tillfället är markerat

            while(true)
            {
                Console.Clear();
                System.Console.WriteLine("What would you like to do?\n");

                System.Console.WriteLine("  Buy Tower  ");
                System.Console.WriteLine("  Upgrade Tower  ");
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
                        BuyTower();
                        //Tar spelaren in i metoden (Där man ska kunna köpa towers och lägga in den i en lista med alla towers man äger)
                    }
                    else if (selectedOption == 1)
                    {
                        UpgradeTower();
                        //Tar spelaren in i metoden (Där man ska kunna uppgradera towers som finns i listan med ägda towers)
                    }
                    else if (selectedOption == 2)
                    {
                        state = GameState.inGame;
                        break;
                        //Flyttar tillbaka spelaren till game
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
        }

        private void BuyTower()
        {
            int selectedOption = 0;
            //håller koll på vilket alternativ som för tillfället är markerat

            while(true)
            {
                Console.Clear();
                System.Console.WriteLine("What would you like to buy?\n");

                System.Console.WriteLine("  Attack Hero  ");
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
                    Console.Clear();
                    if(selectedOption == 0 && money >= 40)
                    {
                        while (true)
                        {
                            System.Console.WriteLine("Price: " + 40);
                            System.Console.WriteLine("Current money: " + money);
                            System.Console.WriteLine("\nHow many would you like to buy?");
                            //Skriver ut hur mycket pengar spelaren har och hur mycket ett tower kostar
                        
                            string answer = Console.ReadLine();
                            bool succeeded = int.TryParse(answer, out int amount);
                            //Försöker konvertera string till en int
                        
                        
                            if (succeeded == true && money >= 40 * amount)
                            {
                                for (int i = amount; i > 0; i--)
                                {
                                    Hero.Heroes.Add(new AttackHero());
                                }
                                money =- AttackHero.Price * amount;
                                System.Console.WriteLine("You have purchased " + amount + " attack heroes");
                                //System.Console.WriteLine(Hero.Heroes.Count);
                                Console.ReadLine();
                                break;
                                //Om TryParse returna true och man har tillräckligt mycket pengar för antal towers så kommer dessa towers läggas in i Heroes listan i Hero klassen och summan pengar kommer dras från spelarens pengarkonto
                            }
                            else if (succeeded == true && money <= 40 * amount)
                            {
                                Console.Clear();
                                System.Console.WriteLine("You do not have enough money for this action");
                                Console.ReadLine();
                            }
                            else if (succeeded == true && amount == 0)
                            {
                                break;
                            }
                            else
                            {
                                System.Console.WriteLine("Please write a number");
                                System.Console.ReadLine();
                                Console.Clear();
                            }
                        }
                    }
                    else if(selectedOption == 0 && money < 40)
                    {
                        Console.Clear();
                        System.Console.WriteLine("You do not have enough money to buy an attack hero");
                        Console.ReadLine();
                    }
                    else if (selectedOption == 1)
                    {
                        break;
                    }
                }

                //Fixa så man kan köpa attack hero o så att den läggs in i listan med towers. Flera?


                if (selectedOption < 0)
                {
                    selectedOption = 1;
                }
                else if (selectedOption > 1)
                {
                    selectedOption = 0;
                }
                //Ser till att man inte kan komma utanför listan av alternativ. Om man försöker gå utanför nedåt så hamnar man längst upp i listan och tvärtom
            }
        }

        private void UpgradeTower()
        {
            Console.Clear();
            System.Console.WriteLine("Upgrade tower test");
            Console.ReadLine();
            //Debug stuff
        }
    }
}
