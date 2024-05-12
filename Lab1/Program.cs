using System;

namespace Lab1
{
    class Program
    {
        //Create the fields
        public int maxNum = int.MinValue;
        public int minNum = int.MaxValue;
        //-------------------------------
        public int totalOddNum = 0;
        public int totalOddSum = 0;
        //-------------------------------
        public int avgOddNum = 0;
        //-------------------------------
        public int totalEvenNum = 0;
        //-------------------------------
        public int totalEvenSum = 0;
        //-------------------------------
        public int avgEvenNum = 0;
        //-------------------------------
        public bool playAgain(string userSelection)
        {
            if (userSelection == "Y") return true;
            if (userSelection == "y") return true;
            return false;
        }
        //-------------------------------
        public void mainMethod()
        {
            string userInput;
            int userInput2;
            string playAgainInput;
            
            bool run = true;
            
            while (run)
            {
                Console.Write("Enter an Integer: ");
                userInput = Console.ReadLine();
                //-------------------------------
                if (string.IsNullOrEmpty(userInput))
                {
                    if (maxNum == int.MinValue && minNum == int.MaxValue &&
                        totalOddNum == 0 && totalOddSum == 0
                        && avgOddNum == 0 && totalEvenNum == 0
                        && totalEvenSum == 0 && avgEvenNum == 0)
                    {
                        Console.WriteLine("Not enough data. Please try again! ");
                        mainMethod();
                    }
                    else
                    {
                        break;
                    }
                   
                }
                //------------------------------
                try
                {
                    userInput2 = Convert.ToInt32(userInput);
                    Console.WriteLine(userInput2);
                }
                catch (FormatException e)
                {
                    Console.WriteLine("Error: " +  e.Message);
                    Console.WriteLine("Please follow the instructions next time!");
                    maxNum = int.MinValue;
                    minNum = int.MaxValue;
                    //-------------------------------
                    totalOddNum = 0;
                    totalOddSum = 0;
                    //-------------------------------
                    avgOddNum = 0;
                    //-------------------------------
                    totalEvenNum = 0;
                    //-------------------------------
                    totalEvenSum = 0;
                    //-------------------------------
                    avgEvenNum = 0;
                    continue;
                }
                //------------------------------
                maxNum = Math.Max(maxNum, userInput2);
                minNum = Math.Min(minNum, userInput2);
                if (userInput2 % 2 != 0)
                {
                    totalOddNum += 1;
                    totalOddSum += userInput2;
                    avgOddNum = totalOddSum / totalOddNum;
                }
                //------------------------------
                if (userInput2 % 2 == 0)
                {
                    totalEvenNum += 1;
                    totalEvenSum += userInput2;
                    avgEvenNum = totalEvenSum / totalEvenNum;
                }
                //------------------------------
            }  
            Console.WriteLine("The maximum integer you entered is: " + maxNum);
            Console.WriteLine("The Minimum integer you entered is: " + minNum);
            Console.WriteLine("");
            //-------------------------------
            Console.WriteLine("The number of odd integer(s) you entered is: " + totalOddNum);
            Console.WriteLine("The sum of odd integer(s) you entered is: " + totalOddSum);
            Console.WriteLine("The average of odd integer(s) you entered is: " + avgOddNum);
            Console.WriteLine("");
            //-------------------------------
            Console.WriteLine("The number of even integer(s) you entered is: " + totalEvenNum);
            Console.WriteLine("The sum of even integer(s) you entered is: " + totalEvenSum);
            Console.WriteLine("The average of even integer(s) you entered is: " + avgEvenNum);
            Console.WriteLine("");
            //-------------------------------
            Console.Write("Play again? (Y/y): ");
            playAgainInput = Console.ReadLine();
            //Check if the users wants to continue
            if (playAgain(playAgainInput) == true)
            {
                
                maxNum = int.MinValue;
                minNum = int.MaxValue;
                //-------------------------------
                totalOddNum = 0;
                totalOddSum = 0;
                //-------------------------------
                avgOddNum = 0;
                //-------------------------------
                totalEvenNum = 0;
                //-------------------------------
                totalEvenSum = 0;
                //-------------------------------
                avgEvenNum = 0;
                mainMethod();
            }
        }

        static void Main(string[] args)
        {
            Program myOBJ = new Program();
            myOBJ.mainMethod();

        }
    }
}