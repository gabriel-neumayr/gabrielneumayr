using System;

public class CGrundForm
{
	public string Name;

	public void SetPunkt(CPunkt p1, CPunkt p2, CPunkt p3, CPunkt p4)
    {
		
		Console.WriteLine("(" + p1.x + "|" + p1.y + ")");
		Console.WriteLine("(" + p2.x + "|" + p2.y + ")");
		Console.WriteLine("(" + p3.x + "|" + p3.y + ")");
		Console.WriteLine("(" + p4.x + "|" + p4.y + ")");



	}

	public void SetPunktRadius(Kreis kreis1,CPunkt p1kreis)
    {
		Console.WriteLine("Der Kreis hat die Bezeichnung: " + kreis1.Name);
		Console.WriteLine("(" + p1kreis.x + "|" + p1kreis.y + ")");
		Console.WriteLine("Der Radius beträgt: " + kreis1.radius);
	}
	public CGrundForm(string Name)
	{
		
	}

	

}

public class Kreis : CGrundForm
{
	
	

	public int radius;

	public Kreis(string Name) : base(Name)
	{
		Name = "Kreis";


	}
}

public class Viereck : CGrundForm
{


	public Viereck(string Name) : base(Name)
    {
		Name = "Viereck";
		
    }
}

public struct CPunkt 
{

	public int x;
	public int y;

	public CPunkt(int x, int y)
    {
        this.x = x;
        this.y = y;
    }
}
