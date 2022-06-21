using System;

namespace Random_number_generator
{
    class Program
    {
        static void Main(string[] args)
        {
            string INPUT_FIRST,INPUT_SECOND;
            int start, end, result;
            bool finalValidation = false;
            Console.WriteLine("-------- Get random number --------");
            while (!finalValidation)
            {
                //Will recive a start number from the user
                Console.WriteLine("Write a start number: ");
                INPUT_FIRST = Console.ReadLine();
                start = Int32.Parse(INPUT_FIRST);
                //Will recive a end number from the user
                Console.WriteLine("Write a end number: ");
                INPUT_SECOND = Console.ReadLine();
                end = Int32.Parse(INPUT_SECOND);

                finalValidation = checkSize(start, end);

                if (finalValidation)
                {
                    result = new Random().Next(start, end);
                    Console.WriteLine("Random number recived is : " + result);
                }

            }


        }

        static bool checkSize(int start, int end)
        {
            if(start >= end)
            {
                Console.WriteLine("Start number must be larger than end number");
                return false;
            }
            return true;
        }
    }
}
