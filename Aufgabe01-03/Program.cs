namespace M320.Cylinder;

class Program
{
    public static void LektionEins()
    {
        // Zylinder
        Cylinder c1 = new Cylinder();

        // Radius
        c1.Radius = 5.25;
        // Höhe
        c1.Height = 20.5;

        // Durchmesser
        double diameter1 = c1.GetDiameter();
        // Grundfläche
        double baseArea1 = c1.GetBaseArea();
        // Volumen
        double volume1 = c1.GetVolume();

        // Umfang
        double circumference1 = c1.GetCircumference();
        // Mantelfläche
        double lateralArea1 = c1.GetLateralArea();
        // Oberfläche
        double surfaceArea1 = c1.GetSurfaceArea();

        Console.WriteLine("Cylinder 01:");
        Console.WriteLine("radius = " + c1.GetRadius());
        Console.WriteLine("height = " + c1.GetHeight());
        Console.WriteLine("base area = " + baseArea1);
        Console.WriteLine("diameter = " + diameter1);
        Console.WriteLine("base area = " + baseArea1);
        Console.WriteLine("volume = " + volume1);
        Console.WriteLine("circumference = " + circumference1);
        Console.WriteLine("lateral area = " + lateralArea1);
        Console.WriteLine("surface area = " + surfaceArea1);
        Console.WriteLine();

        //--------------------------------------------- 

        Cylinder z2 = new Cylinder(15.0, 15.5); 
        double volume2 = z2.GetVolume();
        double surfaceArea2 = z2.GetSurfaceArea();

        Console.WriteLine("Cylinder 02:");
        Console.WriteLine("volume = " + volume2);
        Console.WriteLine("surface area = " + surfaceArea2);
        Console.WriteLine();

        //---------------------------------------------

        double surfaceArea3 = Cylinder.GetSurfaceArea(25.25, 20.0); 

        Console.WriteLine("Cylinder 03:");
        Console.WriteLine("surface area = " + surfaceArea3);
        Console.WriteLine();
        
        //---------------------------------------------

        Cuboid myCuboid = new Cuboid(3, 4, 5);
        Console.WriteLine($"Bodenfläche: {myCuboid.GetBaseArea()}, Volumen: {myCuboid.GetVolume()}, Oberfläche: {myCuboid.GetSurfaceArea()}, Diagonale: {Math.Round(myCuboid.GetDiagonal(), 2)}");

        Cylinder myCylinder = new Cylinder(5, 10);
        
        Cuboid boundingBox = myCylinder.GetBoundingCuboid();
        Console.WriteLine($"Zylinder passt exakt in Quader L:{boundingBox.Length}, B:{boundingBox.Width}, H:{boundingBox.Height}");

        Cuboid testCuboid = new Cuboid(8, 8, 12); 
        
        if (myCylinder.FitsInside(testCuboid))
        {
            Console.WriteLine("True");
        }
        else
        {
            Cuboid fittingCuboid = myCylinder.GetInscribedCuboid();
            Console.WriteLine($"False L:{Math.Round(fittingCuboid.Length, 2)}, B:{Math.Round(fittingCuboid.Width, 2)}, H:{Math.Round(fittingCuboid.Height, 2)}");
        }
        
        Console.ReadLine();
    }
}