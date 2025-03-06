using System;
using System.ComponentModel.Design;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using ZWCAD;

namespace Practise
{
    internal class Practice
    {
        static ZcadDocument myDoc;
        static ZcadApplication ss;
        static ZcadModelSpace myspace;
        static void DrawLine()
        { 
            ZcadLine myline;
            double[] startpoint = new double[3];
            startpoint[0] = 0; startpoint[1] = 0; startpoint[2] = 0;
            double[] endpoint = new double[3];
            endpoint[0] = 10; endpoint[1] = 200; endpoint[2] = 0;
            myline = myspace.AddLine(startpoint, endpoint);
            myline.Update();
            ss.ZoomExtents();
        }
        static void Main()
        {
            try
            {
                Connect();

                string[] commandNames = new string[5];

                int i = 0;

                string commandName = "";

                do
                {
                    Console.Write("\nCommand: ");
                    commandName = Console.ReadLine();

                    commandNames[i++] = commandName;

                    switch (commandName.ToLower())
                    {
                        case "line":
                            Console.Write("Specify first point: ");
                            DrawLine();
                            break;
                        case "circle":
                            Console.Write("Specify centre point: ");
                            break;
                        case "point":
                            Console.Write("Specify a point: ");
                            break;
                        case "quit":
                            Console.Write("Quiting application... ");
                            break;
                        default:
                            Console.Write("Unknown command \"" + commandName + "\".  Press F1 for help.");
                            break;
                    }
                } while (commandName.ToLower() != "quit");
            }
            catch (Exception ex)
            {
                //Console.WriteLine(ex.Message);

                Console.WriteLine("Start a drawing in ZWCAD and then run the application");
            }

            
        }

        private static void Connect()
        {
            ss = (ZcadApplication)Marshal.GetActiveObject("ZWCAD.Application.2025");
            myDoc = ss.ActiveDocument;
            myspace = myDoc.ModelSpace;
            ss.Visible = true;
        }
    }
}
             