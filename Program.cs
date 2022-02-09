//Programmer: Caleb Brown
//Assignment: T-3 - Using Iterative Statements
//Description: CAD to USD Conversion Table
//Date: 2/5/2022

using System;

namespace T_3_Using_Iterative_Statements
{
    class Program
    {
        static void Main(string[] args)
        {
            //defining variables and datatypes
            int userInput;                 // defining user's input as an int datatype
            int generations = 200;         // [dev note] Update this variable to specify the # of generations the loop goes through. 
            int lowerInput = 5;            // [dev note] Update this variable to change lower input parameter.
            int upperInput = 25;           // [dev note] Update this variable to change upper input parameter.
            int CADlimit = 200;            // [dev note] Update this variable to change CAD conversion table limit.
            double conVar = 0.792367;      // [dev note] Update this variable if CAD conversion rate to USD changes in the future.
            decimal USD;                   // defining USD as a decimal datatype
            double rUSD, CAD;              // defining rUSD and CAD as a double datatype


            //try catch logic to confirm valid input
            try
            {
                //ask the user for an input
                Console.Write("Please enter a CAD amount between" + " " + lowerInput + " " + "and" + " " + upperInput + ": ");
                userInput = (int)Convert.ToDouble(Console.ReadLine());

                //test user's input to stay within set parameters
                if (userInput >= lowerInput && userInput <= upperInput)
                {
                    Console.WriteLine();                                         //prints blank console line
                    Console.WriteLine("CAD Increment Value:" + " " + userInput);     //prints increment value based on user input
                    Console.WriteLine();                                         //prints blank console line
                    Console.WriteLine("{0,-6} {1,13}", "CAD", "USD");                //prints headers
                    for (int i = 0; i <= generations; i++)                                   //for loop
                    {
                        USD = (decimal)(i * userInput * conVar);
                        rUSD = (double)decimal.Round(USD, 2);                    //rounded USD value
                        CAD = (double)(i * userInput);
                        Console.WriteLine("{0,-6} {1,13}", CAD, rUSD);           //formats columns and prints results
                        if (CAD >= CADlimit)                                     //stops the loop if CAD >= CADlimit. [Important] to know that not all incremental values end at 200 even.
                        {
                            break;                                               //breaks the loop
                        }
                    }
                    Console.ReadLine();
                }
                else                                                             //else statement to catch values outside given parameters
                {
                    Console.WriteLine("Error: Please enter a CAD amount between" + " " + lowerInput + " " + "and" + " " + upperInput + ": ");
                    Console.WriteLine("Press any key to exit the program");
                    Console.ReadKey(true);
                }
            }
            catch           //catches any invalid inputs the user inputs
            {
                Console.WriteLine("Error: Please enter a CAD amount between" + " " + lowerInput + " " + "and" + " " + upperInput + ": ");
                Console.WriteLine("Press any key to exit the program");
                Console.ReadKey(true);
            }//End of catch
        }
    }
}
