using System;
using System.Collections.Generic;

// Vytvářím abstraktní bázovou třídu Zviratko
public abstract class Zviratko
{
	public string Jmeno {get; set;}				// Každé zvířátko bude mít svoje jméno
	
	// Konstruktor zvířátek
	public Zviratko(string jmeno)
	{
		Jmeno = jmeno;
	}
	
	// Abstraktní metoda VydavejZvuk()
	// Potomci této bázové třídy si budou muset implementovat vlastní podobu vydávání zvuku
	public abstract void VydavejZvuk();
}

// Třída psů, kteří jsou potomci třídy Zviratko
public class Pes : Zviratko
{
	// Konstruktor třídy Pes, pomocí base posílám parametr jmeno do konstruktoru bázové
	// třídy
	public Pes(string jmeno) : base(jmeno)
	{
		// Konstruktor psa
	}
	
	// Třída Pes si implementuje vlastní způsob vydávání zvuku
	public override void VydavejZvuk()
	{
		Console.WriteLine("Haf haf!");
	}
}

// Třída koček, které jsou potomci třídy Zviratko
public class Kocka : Zviratko
{
	// Konstruktor třídy Kocka, pomocí base posílám parametr jmeno do konstruktoru bázové
	// třídy
	public Kocka(string jmeno) : base(jmeno)
	{
		// Konstruktor kočky
	}
	
	// Třída Kocka si implementuje vlastní způsob vydávání zvuku
	public override void VydavejZvuk()
	{
		Console.WriteLine("Mňau mňau!");
	}
}

// Třída ovcí, které jsou potomci třídy Zviratko
public class Ovce : Zviratko
{
	// Konstruktor třídy Ovce, pomocí base posílám parametr jmeno do konstruktoru bázové
	// třídy
	public Ovce(string jmeno) : base(jmeno)
	{
		// Konstruktor ovce
	}
	
	// Třída Ovce si implementuje vlastní způsob vydávání zvuku
	public override void VydavejZvuk()
	{
		Console.WriteLine("Béé!");
	}
}

public class Program
{
	public static void Main()
	{
		// Zadání
		// navrhnete vhodnou strukturu trid, ktera umozni v programu (v Mainu) vytvorit seznam zviratek v zoo koutku (List), 
		// ktery pak muzeme jednoduse projit cyklem (foreach) a zadat kazdemu z nich prikaz VydavejZvuk
		// pritom kazde zviratko bude vydavat jiny zvuk (vypise na konzoli Haf, haf nebo Mnau, mnau)
		// v ramci cyklu nechci resit, jake konkretni zviratko to je
		// vytvorte alespon 3 ruzna zviratka
		// hint: budete potrebovat vhodnou bazovou tridu a virtual/abstract a override
		
		List<Zviratko> zoo = new List<Zviratko>();			// Vytvoříme si list zvířátek
		
		Pes azor = new Pes("Azor");							// Vytvořím psa Azora
		Kocka micka = new Kocka("Micka");					// Vytvořím kočku Micku
		Ovce shaun = new Ovce("Shaun");						// Vytvořím ovci Shaun
		
		// Přidám jednotlivá zvířata do seznamu zoo
		zoo.Add(azor);
		zoo.Add(micka);
		zoo.Add(shaun);
		
		// Projdu jednotlivá zvířata a nechám je vydat jejich zvuky
		foreach (var zvire in zoo)
		{
			zvire.VydavejZvuk();
		}
	}
}
