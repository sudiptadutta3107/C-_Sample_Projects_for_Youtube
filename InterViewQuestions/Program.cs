using System;
using System.Collections.Generic;
using System.Linq;

class AcDbEntity
{
    public int Color { get; set; }
    public string Layer { get; set; }

    public void Draw() { }
}

class AcDbPoint : AcDbEntity
{
    
    public double x { get; set; }
    public double y { get; set; }
    public double z { get; set; }

    public void Draw() { }
}

class AcDbLine : AcDbEntity
{
    public double Length { get; set; }
    public double Angle { get; set; }

    public void Draw() { }
}

class AcDbCircle : AcDbEntity
{

    public double Circumference { get; set; }
    public double Area { get; set; }

    public void Draw() { }
}

class Program
{
        static void Main()
        {
        //AcDbLine acDbLine = new AcDbLine();
        //acDbLine.Length = 10;

        //AcDbCircle acDbCircle = new AcDbCircle();
        //acDbCircle.Area = 10;

        //acDbLine.Color = 5;

        try
        {
            int x = int.Parse("panch");
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }

            
        }
}

