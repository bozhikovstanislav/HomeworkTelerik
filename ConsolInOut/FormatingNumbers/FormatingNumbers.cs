using System;

    class FormatingNumbers
    {
        static void Main()
        {
            /* Problem 5. Formatting Numbers
                * -- Write a program that reads 3 numbers:
                     integer a (0 <= a <= 500)
                     floating-point b
                     floating-point c
                *The program then prints them in 4 virtual columns on the console. 
                    *Each column should have a width of 10 characters.
                        The number a should be printed in hexadecimal, left aligned
                        Then the number a should be printed in binary form, padded with zeroes
                        The number b should be printed with 2 digits after the decimal point, right aligned
                        The number c should be printed with 3 digits after the decimal point, left aligned.
             */
            Console.WriteLine("Whelcom to the program that Formats a numbers  ");
            Console.WriteLine("\n");

            Console.WriteLine("***********************************************************");

            Console.WriteLine("Enter the First number");

            //Entering the 2 numbers
            string a = Console.ReadLine();
            int numberA;
            bool isNumberA = int.TryParse(a, out numberA);

            Console.WriteLine("Enter the second number");
            string b = Console.ReadLine();
            float numberB;
            bool isNumberB = float.TryParse(b, out numberB);

            Console.WriteLine("Enter the second number");
            string c = Console.ReadLine();
            float numberC;
            bool isNumberC = float.TryParse(c, out numberB);
            //Validationg the numbers
            if (isNumberA && (isNumberB&&isNumberC))
            {
                //Converting and formating 
                int hexaA = Convert.ToInt32(a, 16);
                string binaryA = Convert.ToInt32(a, 2).ToString();
                Console.WriteLine("{0}", hexaA);
                Console.WriteLine("Thank you for using the software have a nice Day :)");
            }
            else
            {
                Console.WriteLine("You put wrong niumber . Pleas put  an integer ");
            }
            Console.ReadLine();

        }
    }

