using System;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            //declare 3 variables: input will hold the user string input from the console; message will hold the encoded string; checksum will hold the total unicode value of string
            string input = "";
            string message = "";
            int checksum = 0;



            Console.WriteLine("Enter the word");
            input = Console.ReadLine();



            // convert to uppercase
            input = input.ToUpper();



            // Get the unicode values of each character
            foreach (char c in input)
            {
                int unicodeValue = (int)c;
                message += string.Format("{0:x4}", unicodeValue);
                message = message + " - ";



                checksum = checksum + unicodeValue;
            }



            // Print 
            Console.WriteLine("Upper case =>  " + input);
            Console.WriteLine("Unicode message =>  " + message);
            Console.WriteLine("Checksum => " + checksum);



            Console.ReadLine();
        }



    }
}