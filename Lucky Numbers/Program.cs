﻿using System;

namespace Lucky_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //declare global variables

            int startNum = 0;
            int endNum = 0;            
            double jackPotAmt = 60000.00;            
            double userWon = 0;
            string playAgain = "";
            int[] userNumbers = new int[6];
            int isValidNum = 0;
            int count = 0;

            //start our do loop which will allow the
            //game to be played once before we check the exit condition

            //Tell the user you're starting the game
            //and give some simple directions 


            do
            {
                count = 0;
                // Console.WriteLine(count);
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("WELCOME!");
                Console.WriteLine();
                Console.WriteLine("Let's Play Lucky Numbers! The Jackpot is worth $" + jackPotAmt + "!");
                Console.WriteLine();
                Console.WriteLine("You will be asked to enter a starting and an ending number, this will set the range of eligible numbers to play.");
                Console.WriteLine();
                Console.WriteLine("Obviously the starting number must be lower than the ending number!");
                Console.WriteLine();


            //ask the user for a starting number and ending number for our range
           

                Console.WriteLine("Please enter a starting number.");
                startNum = int.Parse(Console.ReadLine());
                Console.WriteLine();
                Console.WriteLine("Please enter an ending number.");
                endNum = int.Parse(Console.ReadLine());
                Console.WriteLine();


                //Now we'll ask the user to input 6 numbers they think will match 
                //the lucky numbers automatically generated by the lottery.
                //each number entered is compared to the start and end number range to be sure they're valid;
                //if not, don't decrement i and get a new value until
                //there are 6 valid entries            
                //then populate an array with the numbers the user enters;

                Console.WriteLine("You will now be asked to enter 6 lucky numbers.");
                Console.WriteLine();


                for (int i = 0; i < userNumbers.Length; i++)
                {
                    Console.WriteLine("Please enter a lucky number");
                    userNumbers[i] = int.Parse(Console.ReadLine());
                    isValidNum = userNumbers[i];
                    //   Console.WriteLine(userNumbers[i]);
                    if ((isValidNum < startNum) || (isValidNum >= endNum))
                    {
                        Console.WriteLine("The number you chose is not within your range.");
                        Console.WriteLine();
                        Console.WriteLine("Please pick a lucky number greater than " + startNum + " and less than " + endNum);
                        i--;

                    }
                    else
                    {
                        Console.WriteLine();
                        //   Console.WriteLine(isValidNum == userNumbers[i]);

                    }

                }


                //now we'll use the random number generator using
                // startNum and endNum to set the range
                //of numbers to be generated
                //and populate the array

                //display the winning numbers

                Console.WriteLine("Let's see what tonight's winning number are!");
                Console.WriteLine("They are:");
                Random r = new Random();
                int[] randomNumbers = new int[6];

                for (int i = 0; i < randomNumbers.Length; i++)
                {
                    randomNumbers[i] = r.Next(startNum, endNum);
                    Console.WriteLine("Lucky Number: " + randomNumbers[i]);
                    Console.WriteLine();
                    Console.WriteLine();
                }


                //Now we need to check and see how many matches the user
                //had with the randomly generated numbers and keep track
                //of how many times the user guessed correctly
                //and diplay which lucky numbers they matched



                for (int i = 0; i < userNumbers.Length; i++)
                {

                    if (userNumbers[i] == randomNumbers[0])
                    {
                        Console.WriteLine("You matched Lucky Number " + randomNumbers[0]);
                        count++;
                    }

                    else if (userNumbers[i] == randomNumbers[1])
                    {
                        Console.WriteLine("You matched Lucky Number " + randomNumbers[1]);
                        count++;
                    }

                    else if (userNumbers[i] == randomNumbers[2])
                    {
                        Console.WriteLine("You matched Lucky Number " + randomNumbers[2]);
                        count++;
                    }

                    else if (userNumbers[i] == randomNumbers[3])
                    {
                        Console.WriteLine("You matched Lucky Number " + randomNumbers[3]);
                        count++;
                    }

                    else if (userNumbers[i] == randomNumbers[4])
                    {
                        Console.WriteLine("You matched Lucky Number " + randomNumbers[4]);
                        count++;
                    }
                    else if (userNumbers[i] == randomNumbers[5])
                    {
                        Console.WriteLine("You matched Lucky Number " + randomNumbers[5]);
                        count++;
                    }

                    
                }
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("You guessed " + count + " number(s) correctly!");
                Console.WriteLine();

                //now we have to figure out how much our player won
                //and let them know!

                if (count == 1)
                {
                    userWon = (jackPotAmt * .0058);
                    Console.WriteLine("You won $" + userWon + "! Congratulations!");
                }
                else if (count == 2)
                {
                    userWon = (jackPotAmt * .0125);
                    Console.WriteLine("You won $" + userWon + "! Congratulations!");
                }
                else if (count == 3)
                {
                    userWon = (jackPotAmt * .025);
                    Console.WriteLine("You won $" + userWon + "! Congratulations!");
                }
                else if (count == 4)
                {
                    userWon = (jackPotAmt * .05);
                    Console.WriteLine("You won $" + userWon + "! Congratulations!");
                }

                else if (count == 5)
                {
                    userWon = (jackPotAmt * .1);
                    Console.WriteLine("You won $" + userWon + "! Congratulations!");
                }

                else if (count == 6)
                {
                    userWon = (jackPotAmt * 1);
                    Console.WriteLine("You won $" + userWon + "! Congratulations!");
                }
                else if (count == 0)
                    Console.WriteLine("Sorry, you didn't win anything this time. Better luck next time!");


                //ask the user if they would like to play again.
                //if they type yes, start all over again;
                //if they type no, 
                //say thanks for playing
                //if they enter anything else, treat it as a no

                Console.WriteLine();
                Console.WriteLine("Would you like to play Lucky Numbers again? Type Yes or No");
                playAgain = Console.ReadLine().ToLower();               

                if (playAgain == "no")
                {
                    Console.WriteLine();
                    Console.WriteLine("Thanks for Playing!");
                }
                else if (playAgain != "yes")  
                {                           
                    playAgain = "no";
                    Console.WriteLine("Thanks for Playing!");
                }

            } while (playAgain != "no");



            
        }
    }
}
