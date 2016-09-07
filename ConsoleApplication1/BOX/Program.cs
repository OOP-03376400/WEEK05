using System;
class Program
{
    static void Main(string[] args)
    {
        Box a = new Box(2, 5, 8);
        Console.WriteLine("Surface Area = {0}", a.SurfaceArea());
        Console.WriteLine("Volune of box = {0}", a.Volume());

    }
}
class Box
{
    private int x;
    private int y;
    private int z;

    public Box(int x, int y, int z)
    {
        this.x = x;
        this.y = y;
        this.z = z;
    }
    public int SurfaceArea()
    {
        return (x * y * 2)   // บน + ล่าง
            + (y * z * 2)    // หน้า + หลัง
            + x * z * 2;     // ซ้าย + ขวา
    }
    public int Volume()
    {
        return (x * y * z);     
    }
}
