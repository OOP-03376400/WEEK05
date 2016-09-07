using System;

class Program
{
    static void Main(string[] args)
    {
        student bird = new student("Bird", 2.5f, 3.0f);


    }
}

public class student
{
    private string name;
    private float gps;
    private float gpa;

    public student(string name) : this(name, 0, 0)
    {
    }

    public student(string name, float gps) : this(name, gps, 0)
    {
    }
    public student(string name, float gps, float gpa)
    {
        this.name = name;
        this.gps = gps;
        this.gpa = gpa;
    }

}