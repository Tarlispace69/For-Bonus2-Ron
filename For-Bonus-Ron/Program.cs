using System;

namespace For_Bonus_Ron
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1, j = 0, end = 0;
            bool inverted = true;

            Console.Write("How long to make the triangle? ");
            end = int.Parse(Console.ReadLine());
            Console.WriteLine("Do you want to invert the traingle?\n0-no\n1-yes");
            inverted = Convert.ToBoolean(int.Parse(Console.ReadLine()));

            // changing start and end points if the triangle is inverted
            if (inverted)
            {
                i = -1 * end;
                end = 0;
            }

            // printing each line
            for (; i <= end; i++)
            {
                // printing each digit
                for (j=1; j <= Math.Abs(i); j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
