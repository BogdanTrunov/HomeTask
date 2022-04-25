using System;


namespace HomeTask
{
    
    class Program
    {
        static int symbol = 10;
        static void Main(string[] args)
        {
            for (int i = 1; i <= symbol; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("#");
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            for (int i = 1; i <= symbol; i++)
            {
                for (int j = 1; j <= 11 - i; j++)
                {
                    Console.Write("#");
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            for (int i = 1; i <= symbol; i++)
            {
                for (int j = 0; j < 10-i; j++)
                {
                    Console.Write(" ");
                }

                for (int k = 1; k <= i; k++)
                {
                    Console.Write("#");
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            for (int i = 1; i <= symbol; i++)
            {
                for (int j = 0; j < i-1; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 0; k < symbol - (i-1); k++)
                {
                    Console.Write("#");
                }
                Console.WriteLine();
            }
        }

    }
}
