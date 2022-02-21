using System;
using System.Collections.Generic;
using System.Text;

namespace C_sharp_tutorial
{
    public class RPS
    {
        public RPS() {
            while (true) {
                Console.WriteLine("1 for rock, 2 for paper, 3 for scissors");
                //potentially could fail if the user doesn't input a num
                int input = Int32.Parse(Console.ReadLine());

                //computer player's random gen
                Random rnd = new Random();
                int computer_input = rnd.Next(1, 4);

                if (computer_input == input)
                {
                    Console.WriteLine("Tie");
                }
                else if (input == 1)
                {
                    if (computer_input == 2)
                    {
                        Console.WriteLine("You win");
                    }
                    if (computer_input == 3)
                    {
                        Console.WriteLine("You lose");
                    }
                }
                else if (input == 2)
                {
                    if (computer_input == 1)
                    {
                        Console.WriteLine("You lose");
                    }
                    if (computer_input == 3)
                    {
                        Console.WriteLine("You win");
                    }
                }
                else if (input == 3)
                {
                    if (computer_input == 1)
                    {
                        Console.WriteLine("You lose");
                    }
                    if (computer_input == 2)
                    {
                        Console.WriteLine("You win");
                    }
                }
                Console.WriteLine("computer choice was {0}", computer_input);
            }
        }
    }
}
