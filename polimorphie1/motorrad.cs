
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Motorrad : vehicle
{

    public Motorrad(string name, int platze, int maxNeigung) : base(name, platze)
    {
        this.maxNeigung = maxNeigung;
    }

    protected int maxNeigung;

    public void wely()
    {
        // TODO implement here
        Console.WriteLine(name + " macht einen Wely mit einer Maximalen neigungn von " + maxNeigung + " °"); 
    }
    public override void PrintName()
    {
        // TODO implement here
        Console.WriteLine("Name des Gefaehrts: " + this.name);
    }

    public override void Drive()
    {
        // TODO implement here
        Console.WriteLine(this.name + " fährt mit max: " + platze + " Passagieren");
    }

}