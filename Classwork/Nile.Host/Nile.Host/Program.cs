using System;



namespace Nile.Host
{
    class Program
    {
        static void Main( string[] args )
        {
            bool quit = false;
            while (!quit)
            {
                //Equality
                bool isEqual = quit.Equals(10);
                    //Display menu
                    char choice = DisplayMenu();

                //Process menu selection
                switch (Char.ToUpper(choice))
                {
                    //case 'l':
                    case 'L': ListProducts(); break;

                    //case 'a':
                    case 'A': AddProducts(); break;

                    //case 'q':
                    case 'Q': quit = true; break;
                    
                };
            };

        }

        static void AddProducts()
        {
            //Get name
            _name = ReadString("Enter name: ", true);

            //Get price
            _price = ReadDecimal("Enter price: ", 0);
            //Get description
            _description = ReadString("Enter optional description:", false);

        }

        private static decimal ReadDecimal( string message, decimal minValue )
        {
            do
            {
                Console.WriteLine(message);

                string value = Console.ReadLine();

                //if (Decimal.TryParse(value, out decimal result)) && result >= MinValue
                //return result;
                if (Decimal.TryParse(value, out decimal result))
                {
                    //If not required or not empty
                    if (result >= minValue)
                        return result;

                };
                //Formatting strings
                //Consol.WriteLine("Value must be >= {0}"+ minValue);
                string msg= String.Format("Value must be >= {0}" + minValue);
                Console.WriteLine(msg);
            } while (true);
        }

        private static string ReadString( string message, bool isRequired)
        {
            do
            {
                Console.WriteLine(message);

                string value = Console.ReadLine();

                //If not required or not empty
                if (!isRequired || value != "")
                    return value;

                
                Console.WriteLine("Value is required");
            } while (true);
        }

        private static char DisplayMenu()
        {
            do
            {
                Console.WriteLine("L)ist Products");
                Console.WriteLine("A)dd Products");
                Console.WriteLine("Q)uit");

                string input = Console.ReadLine();

                //Remove whitespace
                input = input.Trim();
                //input.ToLower();
                input = input.ToUpper();

                //Padding
                //input.PadLeft(10);

                //Starts with
                //input.StartsWith(@"\");
                //input.EndsWith(@"\");

                //Substring
                //string newValue = input.Substring(0, 10);

                //if (input == "L") 
                if (String.Compare(input, "L", true) == 0)
                    return input[0];
                else if (input == "A")
                    return input[0];
                else if (input == "Q")
                    return input[0];
                
                Console.WriteLine("Please choose a valid option");

            } while (true);

            
     
        }

        static void ListProducts ()

        {
            //Are there any products?
            //if (_name != null && _name != String.Empty)
            //if (_name != null && _name.Length == 0)
            //if (_name != null && _name != "")
            if (!String.IsNullOrEmpty(_name))
            {
                //Display a product - name [$price]
                //                      <description>

                //String formatting
                //var msg = String.Format("{0} [${1}]", _name, _price);

                //String concatenation
                //var msg = _name + " [$"+ _price + "]";

                //String concat part2
                //var msg = String.Concat(_name, " [$", _price, "]");

                //String interpolation
                string msg = $"{_name} [${_price}]";
                Console.WriteLine(msg);

                //Console.WriteLine(_name);
                //Console.WriteLine(_price);

                if (!String.IsNullOrEmpty(_description))
                    Console.WriteLine(_description);
                      
                Console.WriteLine(_description);
            } else
                Console.WriteLine("No products");

        }

        //Data for a product
        static string _name;
        static decimal _price;
        static string _description;

        static void PlayingWithPrimatives()
        {
            //Primative
            decimal unitPrice = 10.5M;

            //Real declaration
            System.Decimal unitPrice2 = 10.5M;

            //Current time
            System.DateTime now = DateTime.Now;

            System.Collections.ArrayList items;
        }

        static void PlayingWithVariables()
        {
            //Single decls
            int hours = 0;
            //Do not
            //int hours;
            //hours = 0;
            double rate = 10.25;


            //Still not assigned
            //if (false)
            //hours = 0;

            int hours2 = hours;

            //Multiple decls
            string firstName, lastName;

            //string @class;

            //Single assignment
            firstName = "Bob";
            lastName = "Miller";

            //Multiple assignment
            firstName = lastName = "Sue";

            //Math ops
            int x = 0, y = 10;
            int add = x + y;
            int substact = x - y;
            int multiply = x * y;
            int divide = x / y;
            int modulos = x % y;

            //x = x + 10
            x += 10;
            double ceiling = Math.Ceiling(rate);
            double floor = ceiling;



        }
    }
}
