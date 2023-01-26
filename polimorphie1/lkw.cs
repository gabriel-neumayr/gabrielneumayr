
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class LKW : vehicle
{

    public LKW(string name, int platze) : base(name, platze)
    {
      

    }

    private int anhaengerVol;

    public void beladen(string name)
    {
        // TODO implement here
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