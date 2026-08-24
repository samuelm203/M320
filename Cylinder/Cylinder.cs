namespace M320.Cylinder;

public class Cylinder
{
    public double Radius;
    public double Height;

    public Cylinder()
    {
    }

    public Cylinder(double radius, double height)
    {
        Radius = radius;
        Height = height;
    }

    public double GetRadius()
    {
        return Radius;
    }

    public double GetHeight()
    {
        return Height;
    }

    public double GetDiameter()
    {
        return Radius * 2;
    }
    
    public double GetBaseArea()
    {
        return Math.PI * Radius * Radius;
    }
    
    public double GetVolume()
    {
        return Math.PI * Radius * Radius * Height;
    }

    public double GetCircumference()
    {
        return 2 * Math.PI * Radius;
    }
    
    public void SetRadius(double radius)
    {
        Radius = radius;
    }
    
    public void SetHeight(double height)
    {
        Height = height;
    }
    
    public void SetDiameter(double diameter)
    {
        Radius = diameter / 2;
    }
    
    public static double GetSurfaceArea(double radius, double height)
    {
        return 2 * Math.PI * radius * (radius + height);
    }
    
    public double GetSurfaceArea()
    {
        return 2 * Math.PI * Radius * (Radius + Height);
    }
    
    public double GetLateralArea()
    {
        return 2 * Math.PI * Radius * Height;
    } 
}