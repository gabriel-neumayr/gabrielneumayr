using System;



public class CZahl
{
	
	private int zahl;
	
	
	public void Spell()
    {
		
		int zahl1 = this.zahl % 100;
		Console.WriteLine(zahl1);
		int zahl2 = this.zahl % 10;
		Console.WriteLine(zahl2);

        switch (this.zahl)
        {
			case >= 900:
				Console.WriteLine("Neunhundert");
				break;
			case >= 800:
				Console.WriteLine("Achthundert");
				break;
			case >= 700:
				Console.WriteLine("Siebenhundert");
                break;
			case >= 600:
				Console.WriteLine("Sechshundert");
                break;
			case >= 500:
				Console.WriteLine("Fümfhundert");
                break;
			case >= 400:
				Console.WriteLine("Vierhundert");
                break;
			case >= 300:
				Console.WriteLine("Dreihundert");
                break;
			case >= 200:
				Console.WriteLine("Zweihundert");
                break;
			case >= 100:
				Console.WriteLine("Hundert");
				break;
        }

        switch (zahl2)
        {
			
			case >= 9:
				Console.WriteLine("Neun und ");
				break;
			case >= 8:
				Console.WriteLine("Acht und ");
				break;
			case >= 7:
				Console.WriteLine("Sieben und ");
				break;
			case >= 6:
				Console.WriteLine("Sechs und ");
				break;
			case >= 5:
				Console.WriteLine("Fünf und ");
				break;

        }

        switch (zahl1)
        {

			case >= 90:
				Console.WriteLine("Neunzig");
				break;
			case >= 80:
				Console.WriteLine("Achtzig");
                break;
			case >= 70:
				Console.WriteLine("Siebzig");
				break;
			case >= 60:
				Console.WriteLine("Sechzig" );
				break;
			case >= 50:
				Console.WriteLine("Fünfzig");
				break;
			case >= 40:
				Console.WriteLine("Fierzig");
				break;
			case >= 30:
				Console.WriteLine("Dreisig");
				break;
			case >= 20:
				Console.WriteLine("Zwanzig");
				break;
			
			case >= 12:
				Console.WriteLine("Zwölf");
				break;
			case >= 11:
				Console.WriteLine("Elv");
				break;
			case >= 10:
				Console.WriteLine("Zehn");
				break;

        }
	
	}

	public CZahl()
	{
		this.zahl = Convert.ToInt32(Console.ReadLine());
		
	
	}
}


