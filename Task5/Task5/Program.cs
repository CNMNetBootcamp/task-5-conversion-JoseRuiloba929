using System;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {

            // setup
            int conversionType = 0;
            Single inputValue = 0;
            Double cupToQuartsConstant = 4;
            Double cupToGallonConstant = 16;
            string textNote = string.Empty;
            string numberValue = string.Empty;
            string TryAgain = "N";
            bool IsString = true;
            //input
            do
            {
                do
                {
                    Console.WriteLine("Please select the numeric value of the type of conversion you want to do");
                    Console.WriteLine("1 converts cups to quarts/gallons");
                    Console.WriteLine("2 quarts to cups");
                    numberValue = Console.ReadLine();
                    IsString = int.TryParse(numberValue, out conversionType);
                    if (conversionType < 1 || conversionType > 2)
                    {
                        Console.WriteLine("Please enter a valid number");
                    }
                } while (conversionType < 1 || conversionType > 2);

                do
                {
                    Console.WriteLine("Please enter a numeric value");
                    numberValue = Console.ReadLine();
                    IsString = Single.TryParse(numberValue, out inputValue);
                    if (!IsString)
                    {
                        Console.WriteLine("invalid value, Please enter a number");
                    }
                } while (!IsString);

                //process
                if (conversionType == 1)
                {
                    textNote = inputValue + "cups  is " + inputValue / cupToQuartsConstant + "quarts and " + inputValue / cupToGallonConstant + "gallons";
                }
                else if (conversionType == 2)
                {
                    textNote = inputValue + " quarts is equal to " + inputValue * cupToQuartsConstant + "cups";
                }

                //output

                Console.WriteLine(textNote);
                Console.WriteLine("do you want to with another value Y or N?");
                TryAgain = Console.ReadLine().Substring(0, 1).ToUpper();
            } while (TryAgain == "Y");

        }
    }
}

