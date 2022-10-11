using System;
using System.Collections.Generic;

// Abstraktní třída domácího mazlíčka
public abstract class DomaciMazlicek
{
	// Každý DomaciMazlicek má své jméno
	public string Jmeno { get; private set; }
	
	// Konstruktor bázové třídy
	public DomaciMazlicek(string jmeno)
	{
		this.Jmeno = jmeno;
	}
	
	// Metoda NakrmSe() je virtuální, má proto defaultní implementaci, ale
	// třídy, které dědí z DomaciMazlicek si jí mohou pomocí klíčového slova
	// override přepsat
	public virtual void NakrmSe()
	{
		Console.WriteLine(Jmeno + " nakrmen neidentifikovanym jidlem.");
	}
}


// Třída Pejsek, která dědí ze třídy DomaciMazlicek
public class Pejsek : DomaciMazlicek
{
	// Konstruktor Pejska, pomocí base se předává parametr
	// konstruktoru bázové třídy (DomaciMazlicek)
	public Pejsek(string jmeno) : base(jmeno)
	{
		// Prázdný konstruktor Pejska
	}
	
	// Pejsci si implementují vlastní podobu funkce NakrmSe
	// Používají k tomu klíčové slovo override
	public override void NakrmSe()
	{
		Console.WriteLine(Jmeno + " nakrmen granulemi.");
	}
	
	// Pejsci umí aportovat
	public void Aportuj()
	{
		Console.WriteLine("Umim aportovat.");
	}
}

// Třída Kočka, která dědí ze třídy DomaciMazlicek
public class Kocka : DomaciMazlicek
{
	// Konstruktor Kocky, pomocí base se předává parametr
	// konstruktoru bázové třídy (DomaciMazlicek)
	public Kocka(string jmeno) : base(jmeno)
	{
		// Prázdný konstruktor Kocky
	}
	
	// Kočky si implementují vlastní podobu funkce NakrmSe
	// Používají k tomu klíčové slovo override
	public override void NakrmSe()
	{
		Console.WriteLine(Jmeno + " nakrmen mlékem.");
	}
	
	// Kočky umí zamňoukat
	public void Zamnoukej()
	{
		Console.WriteLine("Mňoukám");
	}
}


public class Program
{
	public static void Main()
	{
		// Vytvořím seznam domácích mazlíčků
		List<DomaciMazlicek> mazlicci = new List<DomaciMazlicek>();
		
		// První pejsek se bude jmenovat třeba Azor
		Pejsek azor = new Pejsek("Azor");
		Console.WriteLine("Moje jmeno je: " + azor.Jmeno);
		azor.Aportuj();
		
		// Přidám ho do seznamu
		mazlicci.Add(azor);
		
		// První kočka se bude jmenovat třeba Sušenka
		Kocka susenka = new Kocka("Susenka");
		Console.WriteLine("Moje jmeno je: " + susenka.Jmeno);
		susenka.Zamnoukej();
		
		// Přidám jí do seznamu
		mazlicci.Add(susenka);
		
		// Druhá kočka se jmenuje Amy a přidám jí do seznamu
		Kocka amy = new Kocka("Amy");
		mazlicci.Add(amy);
		
		Console.WriteLine(new string('=', 20));
		
		// Projdu všechny mazlíčky
		foreach (var domaciMazlicek in mazlicci)
		{
			// Vypíši jméno každého mazlíčka a nechám ho se nakrmit
			Console.WriteLine("Moje jmeno je: " + domaciMazlicek.Jmeno);
			domaciMazlicek.NakrmSe();
			
			// Pokud je domácí mazlíček pejsek, tak bude aportovat,
			// pokud je kočka, tak může zamňoukat
			if (domaciMazlicek is Pejsek)
			{
				(domaciMazlicek as Pejsek).Aportuj();
			}
			else if (domaciMazlicek is Kocka)
			{
				(domaciMazlicek as Kocka).Zamnoukej();
			}
		}	
	}
}
