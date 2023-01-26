using System;



class card
{
	protected string name;
	protected string wohnort;
	protected int alter;
	public string iban;
	public int pin;
	public float kontostand;
	public card(string name, string wohnort , int alte, string iban, int pin, float kontostand)
    {
		this.name = name;
		this.wohnort= wohnort;
		this.alter = alte;
		this.iban = iban;
		this.pin = pin; 
		this.kontostand = kontostand;
    }


	public void Kontostand_ablesen(float kontostand)
    {
		Console.WriteLine("Ihr Kontostand ist : ");
		Console.WriteLine(kontostand);
    }
}
