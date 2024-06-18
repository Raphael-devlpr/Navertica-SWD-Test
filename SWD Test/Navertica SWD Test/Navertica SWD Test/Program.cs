using System;

class Program
{
    static void Main()
    {
        for (int i = 1; i <= 100; i++)
        {
            string output = "";

            if (i % 3 == 0)
            {
                output += "NAV";
            }

            if (i % 5 == 0)
            {
                output += "ERTICA";
            }

            if (output == "")
            {
                output = i.ToString();
            }

            Console.WriteLine(output);
        }
    }
}
