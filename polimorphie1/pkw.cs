
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class PKW : vehicle {

    public PKW(string name, int platze, int kofferraumVol) :base(name, platze) {
        
    }

    protected int kofferraumVol;

    

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
    public void Kofferaumbeladen()
    {
        Console.WriteLine("Kofferraum kann mit Maximal " + kofferraumVol + "beladen werden");
    }

}