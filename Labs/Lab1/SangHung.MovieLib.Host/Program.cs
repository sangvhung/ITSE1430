using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
   
   //Sang Hung
   //7:30PM ITSE1430
   //Lab1


namespace SangHung.MovieLib.Host
{
    class Program
    {
        static void Main( string[] args )
        {
            bool quit = false;
            while (!quit)
            {
                bool isEqual = quit.Equals(10);

                char choice = DisplayMenu();

                switch (Char.ToUpper(choice))
                {
                    case 'L':
                    ListMovies();
                    break;

                    case 'A':
                    AddMovie();
                    break;

                    case 'R':
                    RemoveMovie();
                    break;

                    case 'Q':
                    quit = true;
                    break;

                    
                };
            }
        }



        static void AddMovie()
        {
            s_title = ReadString("Enter a title:", true);

            s_description = ReadString("Enter a optional description:", false);

            s_length = ReadDecimal("Enter a optional length (in minutes):", 0);

            s_owned = ReadString(" Do you own this movie? (Y/N))", true);


        }


        static void RemoveMovie()
        {
            s_delete = ReadString("Are you sure you want to delete the movie (Y/N)?", true);
            do
            {
                string value = Console.ReadLine();
                Console.WriteLine("Movie has been deleted");

            } while (false);

            
        }

        private static string ReadDecimal( string message, decimal minValue )
        {
            do
            {
                Console.WriteLine(message);

                string value = Console.ReadLine();

                if (Decimal.TryParse(value, out decimal result))
                {
                    if (result >= minValue)
                        return value;

                };

                string msg = String.Format("Value must be >= {0}" + minValue);
                Console.WriteLine(msg);
            } while (true);

        }

            private static string ReadString( string message, bool isRequired )
        {
            do
            {
                Console.WriteLine(message);

                string value = Console.ReadLine();

                if (!isRequired || value != "")
                    return value;

                Console.WriteLine("Value is required");

            } while (true);
        }

            private static char DisplayMenu()
        {
            do
            {
                Console.WriteLine("L)ist Movies");
                Console.WriteLine("A)dd Movies");
                Console.WriteLine("R)emove Movies");
                Console.WriteLine("Q)uit");

                string input = Console.ReadLine();

                input = input.Trim();
                input = input.ToUpper();

                if (String.Compare(input, "L", true) == 0)
                    return input[0];
                else if (input == "A")
                    return input[0];
                else if (input == "R")
                    return input[0];
                else if (input == "Q")
                    return input[0];
                
                  

                Console.WriteLine("Please choose a valid option");




            } while (true);


        }

        static void ListMovies()
        {
            if (!String.IsNullOrEmpty(s_title))
            {
            string msg = $"{s_title}";
                    Console.WriteLine(msg);

            string msg1 = $"{s_description}";
                    Console.WriteLine(msg1);

            string msg2 = $"Run length = {s_length} mins";
                    Console.WriteLine(msg2);

            string msg3 = $"Status = {s_owned}";
                    Console.WriteLine(msg3);

            


            } else
                Console.WriteLine("No movies available");
        }

        //Data for a movie
        static string s_title;
        static string s_description;
        static string s_length;
        static string s_owned;
        static string s_delete;

    }















    
}
