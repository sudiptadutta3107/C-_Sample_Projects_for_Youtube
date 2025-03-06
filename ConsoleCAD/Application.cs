using System;

namespace ConsoleCAD
{
    internal class Application
    {
        static void Main()
        {
            bool bRunning = true;

            while (bRunning) 
            {
                Console.Write("\nCommand: ");

                string commandName = Console.ReadLine();

                if (commandName.ToLower() == "line")
                {
                    Console.Write("Specify first point: ");
                }
                else if (commandName.ToLower() == "circle")
                {
                    Console.Write("Specify center point: ");
                }
                else if (commandName.ToLower() == "point")
                {
                    Console.Write("Specify a point: ");
                }
                else if (commandName.ToLower() == "exit" || commandName.ToLower() == "quit")
                {
                    bRunning = false;
                    Console.Write("Quiting application... ");
                }
                else 
                {
                    Console.Write("Unknown command \"" +  commandName + "\".  Press F1 for help.");
                }
            }
            
        }
    }
}
