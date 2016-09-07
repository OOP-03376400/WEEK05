using System;

class Program
{
    static void Main(string[] args)
    {
        baseclass bc = new baseclass();
        bc.print();
    }
}

class baseclass
{
    virtual public void print()
    {
        Console.WriteLine("base class print()");
    }
}


class derivedclass : baseclass
{
     override public void print()
    {
        Console.WriteLine("derived class print()");
    }

}

class derived2 : derivedclass
{
    override public void print()
    {
        Console.WriteLine("derived2 class print()");
    }

}