using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Random_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            string player1, player2;
            int playerhealth = 100;
            int player2health = 100;
            int kick = 10, punch = 5, energyblast = 20, specialmove = 50;
            int[] moves = new int[4] { kick, punch, energyblast, specialmove};
            bool fightagain = true;

            Random random = new Random();
            int cpuattack = random.Next(0, moves.Length);

            while (fightagain == true)
            {


                while (playerhealth <= 100 && player2health <= 100)
             
                    {




                        Console.WriteLine("WELCOME YOU WILL FIGHT TO THE DEATH!!!");
                        Console.WriteLine("Player 1: Choose your attack: Kick, Punch, Energyblast, Specialmove ");
                        player1 = Console.ReadLine();
                        player1 = player1.ToLower();


                        if (player1 == "kick")
                        {
                            player2health -= kick;
                            Console.WriteLine("Player 2 took " + kick + " damage. ");
                            Console.WriteLine("Player 2's health is down to " + (player2health) + ".");

                            Console.ReadLine();
                        }
                        else if (player1 == "punch")
                        {
                            player2health -= punch;
                            Console.WriteLine("Player 2 took " + punch + " damage. ");
                            Console.WriteLine("Player 2's health is down to " + (player2health) + ".");

                            Console.ReadLine();
                        }
                        else if (player1 == "energyblast")
                        {
                            player2health -= energyblast;
                            Console.WriteLine("Player 2 took " + energyblast + " damage. ");
                            Console.WriteLine("Player 2's health is down to " + (player2health) + ".");

                            Console.ReadLine();
                        }
                        else if (player1 == "specialmove")
                        {
                            player2health -= specialmove;
                            Console.WriteLine("Player 2 took " + specialmove + " damage. ");
                            Console.WriteLine("Player 2's health is down to " + (player2health) + ".");

                            Console.ReadLine();
                        }

                        playerhealth -= moves[cpuattack];
                        Console.WriteLine("Player 2 used" + "\nPlayer 1 took " + moves[cpuattack] + " damage. ");
                        Console.WriteLine("Player 1's health is down to " + (playerhealth) + ".");
                        Console.ReadLine();
                      
                        if (playerhealth == 0)
                        {
                            Console.WriteLine("Player 2 is the winner");
                        }
                        else if (player2health == 0)
                        {
                            Console.WriteLine("player 1 is the winner");
                        }








                    }

                        Console.WriteLine("Enter yes to play again, no to quit");
                        string restart = Console.ReadLine();
                        restart = restart.ToLower();

                        if (restart == "yes")
                        {
                            fightagain = true;
                        }
                        else
                        {
                            fightagain = false;
                        }
                    
            }
        }



    }
}
