using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondProgram
{
    public class SnakesAndLadders
    {
        public void SinglePlayer()
        {
            const int startPosition = 0;
            Console.WriteLine("Welcome to Snakes and Ladders Game:");

            //player starts at o
            Console.WriteLine("The Player is at Position: " + startPosition);
      

            int newPosition = 0;
            int numOfDieRoll = 0;

            while (newPosition != 100)
            {
                numOfDieRoll++;

                //check the number obtained on the dice
                Random random = new Random();
                int dieRoll = random.Next(1, 7);
                Console.WriteLine("The number obtained on your dice is: " + dieRoll);

                //checking for option
                int option = random.Next(0, 3);

                switch (option)
                {
                    case 0:
                        Console.WriteLine("You got No Play and hence your new position is: " + newPosition);
                        break;
                    case 1:
                        newPosition += dieRoll;
                        if (newPosition > 100) newPosition -= dieRoll;
                        else Console.WriteLine("You got a Ladder and hence your new position is: " + newPosition);
                        break;
                    case 2:
                        newPosition -= dieRoll;
                        if (newPosition < 0) newPosition = 0;
                        Console.WriteLine("You got a Snake and hence your new position is: " + newPosition);
                        break;
                }
            }

            Console.WriteLine("The total number of times the die was rolled is: " + numOfDieRoll);
        }

        public void TwoPlayers()
        {
            const int startPosition1 = 0;
            const int startPosition2 = 0;

            Console.WriteLine("Welcome to Snakes and Ladders Game");

            //player starts at o
            Console.WriteLine("The Player 1 is at Position: " + startPosition1);
            Console.WriteLine("The Player 2 is at Position: " + startPosition2);

            int newPosition1 = 0;
            int numOfDieRoll1 = 0;
            int numOfDieRoll2 = 0;
            int newPosition2 = 0;

            while (newPosition1 != 100 && newPosition2!=100)
            {
                bool flag1 = true;
                bool flag2 = true;
                Random random = new Random();

                if (flag1)
                {
                    numOfDieRoll1++;

                    //check the number obtained on the dice
                    int dieRoll1 = random.Next(1, 7);
                    Console.WriteLine("The number obtained on Player 1 dice is: " + dieRoll1);

                    //checking for option
                    int option1 = random.Next(0, 3);

                    switch (option1)
                    {
                        case 0:
                            flag2 = true;
                            Console.WriteLine("You got No Play and hence your new position is: " + newPosition1);
                            break;
                        case 1:
                            flag2 = false;
                            newPosition1 += dieRoll1;
                            if (newPosition1 > 100) newPosition1 -= dieRoll1;
                            else
                            {
                                Console.WriteLine("You got a Ladder and hence your new position is: " + newPosition1);
                            }
                            break;
                        case 2:
                            flag2 = true;
                            newPosition1 -= dieRoll1;
                            if (newPosition1 < 0) newPosition1 = 0;
                            Console.WriteLine("You got a Snake and hence your new position is: " + newPosition1);
                            break;
                    }

                    if (newPosition1 == 100)
                    {
                        Console.WriteLine("Player 1 Won");
                        break;
                    }
                }
                
                if(flag2 == true)
                {
                    numOfDieRoll2++;

                    //check the number obtained on the dice
                    int dieRoll2 = random.Next(1, 7);
                    Console.WriteLine("The number obtained on Player 2 dice is: " + dieRoll2);

                    //checking for option
                    int option2 = random.Next(0, 3);

                    switch (option2)
                    {
                        case 0:
                            flag1 = true;
                            Console.WriteLine("You got No Play and hence your new position is: " + newPosition2);
                            break;
                        case 1:
                            flag1 = false;
                            newPosition2 += dieRoll2;
                            if (newPosition2 > 100) newPosition2 -= dieRoll2;
                            else
                            {
                                Console.WriteLine("You got a Ladder and hence your new position is: " + newPosition2);
                            }
                            break;
                        case 2:
                            flag1 = true;
                            newPosition2 -= dieRoll2;
                            if (newPosition2 < 0) newPosition2 = 0;
                            Console.WriteLine("You got a Snake and hence your new position is: " + newPosition2);
                            break;
                    }

                    if (newPosition2 == 100)
                    {
                        Console.WriteLine("Player 2 Won");
                        break;
                    }
                }
                
            }

            Console.WriteLine("The total number of times Player 1 rolled the dice is: " + numOfDieRoll1);
            Console.WriteLine("The total number of times Player 2 rolled the dice is: " + numOfDieRoll2);
        }
    }
}
