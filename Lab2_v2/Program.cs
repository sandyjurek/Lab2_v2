using System;
using System.Security;
using System.Security.Cryptography.X509Certificates;

namespace Deliverable2
{
    class Program
    {
        static void Main(string[] args)
        {
            //declare 3 variables: input will hold the user string input from the console; message will hold the encoded string; checksum will hold the total unicode value of string

            UnicodeEncoding u16 = new UnicodeEncoding(false, true, true);
            Encoder myEnc = u16.GetEncoder();
            Decoder myDec = u16.GetDecoder();

            int message;
            int checksum;

            Console.WriteLine("What is your message? ");
            string input = Console.ReadLine();

            //convert to all upper case

            string ucaseInput = input.ToUpper();
            Console.WriteLine($"Uppercase: {ucaseInput}");

            //go through the string and find the unicode value of each letter in turn

            string GetUnicodeString(string message)
            {
                StringBuilder message = new StringBuilder();

                foreach (char c in message)

                    message.Append("\\u" + ((int)c).ToString("X4");
                message.Append(String.Format("{0:x4}", (int)c));
            }
            return message.ToString();


            //print each value with a dash (-) following it 

            Console.WriteLine(message + "-");
        }


        //add the unicode value for each letter into the checksum
        //      {
        //          input = Char.ConvertFromUtf32(input);
        //      }

        Console.WriteLine(checksum);
            checksum = Char.ConvertFromUtf32(message);
            Show(message);
        Console.WriteLine();

            //add the encoded letter to the message string, followed by a dash


            //output the message and the checksum
            {
                Console.WriteLine(checksum + "-");
            }

}
    }
}