
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

abstract public class vehicle {

    public vehicle(string name, int platze) {
        this.name = name;
        this.platze = platze;
    }

    protected string name;

    protected int PS;

    protected int platze;
    

    virtual public void Drive() {
        // TODO implement here
        Console.WriteLine("fährt mit max: " + platze + " Passagieren");
    }

    virtual public void PrintName() {
        // TODO implement here
        Console.WriteLine("Name des Gefaehrts: " + name);
    }

}