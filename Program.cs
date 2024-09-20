public class Point
{
    public double x;
    public double y;

    public Point(double x, double y)
    {
        this.x = x;
        this.y = y;
    }
}

public class Triangle
{
    public Point p1;
    public Point p2;
    public Point p3;

    public Triangle(Point p1, Point p2, Point p3)
    {
        this.p1 = p1;
        this.p2 = p2;
        this.p3 = p3;
    }

    static double area(Point p1, Point p2, Point p3)
    {
        return Math.Abs((p1.x * (p2.y - p3.y) + p2.x * (p3.y - p1.y) + p3.x * (p1.y - p2.y)) / 2.0);
    }

    public bool IsInside(Point p)
    {
        double A = area(p1, p2, p3);
        double A1 = area(p, p2, p3);
        double A2 = area(p1, p, p3);
        double A3 = area(p1, p2, p);
        return (A == A1 + A2 + A3);
    }

}

public static class Program
{
    public static void Main()
    {
        Triangle triangle = new Triangle(new Point(-5.92, 3.03), new Point(-5.28, 3.01), new Point(2.08, -2.49));
        Triangle triangle2 = new (new Point(0.64, 5.35), new Point(0.92, 4.89), new Point(-8.9, 1.03));  
        Console.WriteLine(DoesIntersect(triangle, triangle2));
    }
    public static bool DoesIntersect(Triangle triangle, Triangle triangle2){
        if(triangle.IsInside(triangle2.p1)){return true;}
        else if(triangle.IsInside(triangle2.p2)){return true;}
        else if(triangle.IsInside(triangle2.p3)){return true;}
        else if(triangle2.IsInside(triangle.p1)){return true;}
        else if(triangle2.IsInside(triangle.p2)){return true;}
        else if(triangle2.IsInside(triangle.p3)){return true;}
        return false;
    }
}
