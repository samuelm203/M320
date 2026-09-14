namespace M320.Cylinder;

public class Cylinder
{
    private double _radius; 
    private double _height; 
    
    public double Radius
    {
        get { return _radius; }
        set { _radius = value; }
    }
    
    public double Height
    {
        get { return _height; }
        set { _height = value; }
    }

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
    
    public Cuboid GetBoundingCuboid()
    {
        double side = Radius * 2;
        return new Cuboid(side, side, Height);
    }

    public Cuboid GetInscribedCuboid()
    {
        double side = Radius * Math.Sqrt(2);
        return new Cuboid(side, side, Height);
    }

    public bool FitsInside(Cuboid cuboid)
    {
        double cuboidBaseDiagonal = Math.Sqrt(cuboid.Length * cuboid.Length + cuboid.Width * cuboid.Width);
        double cylinderDiameter = 2 * Radius;

        return (cuboid.Height <= Height) && (cuboidBaseDiagonal <= cylinderDiameter);
    }
}