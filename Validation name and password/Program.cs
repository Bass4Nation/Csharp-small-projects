using System;
using System.Text.RegularExpressions;

namespace Validation_name_and_password
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--------- Validation of a username and a password ------------");

            // Could be instead a API input or username/password recived from a another place
            string USERNAME = "Bass4Nation", PASSWORD = "TEstIng#123";

            usernameChecker(USERNAME);
            passwordChecker(PASSWORD);


            Console.WriteLine("Finished checking password");
        }

        static void usernameChecker (string username)
        {

        }

        static void passwordChecker(string password)
        {
            // USING Regex to check password. Higher/lower case, symbols, amount
            var reg = new Regex(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{8,15}$");

            if (reg.IsMatch(password))
            {
                Console.WriteLine("twsets");
            }
            else
            {
                Console.WriteLine("Password needs at least: 1 capital, 1 small letter, 1 symbol and 1 number \n And at least 8 character in length ");
            }
        }
    }
}
