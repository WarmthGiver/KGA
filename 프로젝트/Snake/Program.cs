using System;

namespace Snake
{
    internal class Program
    {
        const int windowWidth = 65;
        const int windowHeight = 33;

        private static void Main(string[] args)
        {
            Console.SetWindowSize(windowWidth, windowHeight);

            while (true)
            {
                Console.Clear();

                Console.Write("                   ###  #   #  ###  #   # #####                  \n");
                Console.Write("                  #     ##  # #   # #  #  #                      \n");
                Console.Write("#################  ###  # # # ##### ###   ##### #################\n");
                Console.Write("                      # #  ## #   # #  #  #                      \n");
                Console.Write("                   ###  #   # #   # #   # #####                  \n");

                Console.ReadLine();
            }
        }

        private class Snake
        {

        }
    }
}