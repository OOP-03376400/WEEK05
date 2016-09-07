using System;

class Program
{
    static void Main(string[] args)
    {
        Shape s = new Shape();
        Rectangle r = new Rectangle(3, 4);
        Console.WriteLine(r.Area);
    }
}

class Shape
{
    protected int width;
    protected int height;
    public void setWidth(int w) { this.width = w; }
    public void setHeight(int h) { this.height = h; }
}

class Rectangle : Shape
{
    public int Area 
    {
        get { return (width * height); }
    }
    public Rectangle(int width, int height)
    {
        setWidth(width);
        setHeight(height);
    }

}