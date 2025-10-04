namespace castleofking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool again = true;

            while (again == true)
            {
                int doorsOpened = 0;
                bool gameOver = false;
                Random random = new Random();

                Console.WriteLine("you entered the castle of the king\nthere are 3 doors and you dont know which one the king is behind and which one there is a dragon or treasure");

                while (gameOver == false)
                {
                    Console.WriteLine("choose a door by typing 1 2 or 3");
                    string chosenDoor = Console.ReadLine();


                    if (chosenDoor == "1" || chosenDoor == "2" || chosenDoor == "3")
                    {
                        doorsOpened++;

                        int currentRoom = random.Next(0, 3);

                        if (currentRoom == 0)
                        {
                            Console.WriteLine("you found treasure but not the king there are 3 doors in front of you");
                        }
                        else if (currentRoom == 1)
                        {
                            Console.WriteLine("you encountered a dragon and died");
                            gameOver = true;
                        }
                        else if (currentRoom == 2)
                        {
                            Console.WriteLine($"you find the king you won! it took {doorsOpened} doors to find him");
                            gameOver = true;
                        }


                    }

                    else {
                        Console.WriteLine("invalid choice 1 2 and 3 are the only valid choices");

                    }

                    
                }

                Console.WriteLine("play again? type yes or no");
                string againPrompt = Console.ReadLine().ToLower();
                if (againPrompt == "yes")
                {
                    again = true;
                }
                else
                {
                    again = false;
                }
            }

            Console.WriteLine("close the game now");
        }
    }
}
