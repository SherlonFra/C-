using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rock_Paper_Scissor_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            string PlayerChoice, CPUChoice;
            int randomInt;
            Random integer = new Random();
            randomInt = integer.Next(1, 4);
            
            int playerScore = 0;
            int cpuScore = 0;
                
            {
                    Console.WriteLine("**************");
                    Console.WriteLine("*   WELCOME  * "+ "\n*     TO     *" + "\n* ROCK PAPER * " + "\n*   SCISSOR  *");
                    Console.WriteLine("**************");
                    Console.Write("CHOOSE ROCK, PAPER OR SCISSORS:");
                    PlayerChoice = Console.ReadLine();
                    PlayerChoice = PlayerChoice.ToUpper();

                    

                    switch (randomInt)
                    {
                        case 1:
                            CPUChoice = "ROCK";
                            Console.WriteLine("Computer chose ROCK");
                            if (PlayerChoice == "ROCK")
                            {
                                Console.WriteLine("DRAW!!\n\n");
                            }
                            else if (PlayerChoice == "PAPER")
                            {
                                Console.WriteLine("PLAYER WINS!!\n\n");
                                playerScore++;
                            }
                            else if (PlayerChoice == "SCISSORS")
                            {
                                Console.WriteLine("CPU WINS!!\n\n");
                                cpuScore++;
                            }
                            break;
                        case 2:
                            CPUChoice = "PAPER";
                            Console.WriteLine("Computer chose PAPER");
                            if (PlayerChoice == "PAPER")
                            {
                                Console.WriteLine("DRAW!!\n\n");
                            }
                            else if (PlayerChoice == "ROCK")
                            {
                                Console.WriteLine("CPU WINS!!\n\n");
                                cpuScore++;
                            }
                            else if (PlayerChoice == "SCISSORS")
                            {
                                Console.WriteLine("PLAYER WINS!!\n\n");
                                playerScore++;
                            }
                            break;
                        case 3:
                            CPUChoice = "SCISSORS";
                            Console.WriteLine("Computer chose SCISSORS");
                            if (PlayerChoice == "SCISSORS")
                            {
                                Console.WriteLine("DRAW!!\n\n");
                            }
                            else if (PlayerChoice == "ROCK")
                            {
                                Console.WriteLine("PLAYER WINS!!\n\n");
                                playerScore++;
                            }
                            else if (PlayerChoice == "PAPER")
                            {
                                Console.WriteLine("CPU WINS!!\n\n");
                                cpuScore++;
                            }
                            break;
                        default:
                            Console.WriteLine("Please enter a correct value");
                            break;
                    }

                    Console.WriteLine("\n\nSCORES:\tPLAYER:\t{0}\tCPU:\t{1}", playerScore, cpuScore);

                }

                if (playerScore == 3)
                {
                    Console.WriteLine("Player WON!");
                }
                else if (cpuScore == 3)
                {
                    Console.WriteLine("CPU WON!");
                }
                else
                {

                }
            Console.ReadLine();

                


            
        }
    }
}
