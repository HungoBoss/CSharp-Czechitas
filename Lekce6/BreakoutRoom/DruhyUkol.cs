using System;
using System.Collections.Generic;

// Rozhraní IUmiPocitatObsah
interface IUmiPocitatObsah
{
	// Třídy, které implementují rozhraní IUmiPocitat musí implementovat
	// i tuto metodu.
	double SpocitejObsah();
}

// Rozhraní IUmiPocitatObvod
interface IUmiPocitatObvod
{
	// Třídy, které implementují rozhraní IUmiPocitatObvod musí implementovat
	// i tuto metodu.
	double SpocitejObvod();
}

// Třída Obdélník, která implementuje rozhraní IUmiPocitatObsah a IUmiPocitatObvod
public class Obdelnik : IUmiPocitatObsah, IUmiPocitatObvod
{
	// Vlastnosti obdélníku
	public double A { get; set; }
	public double B { get; set; }
	
	// Konstruktor třídy Obdelnik
	public Obdelnik(double a, double b)
	{
		A = a;
		B = b;
	}
	
	// Implementovaná metoda SpocitejObsah
	public double SpocitejObsah() 
	{
		return A * B;
	}
	
	// Implementovaná metoda SpocitejObvod
	public double SpocitejObvod()
	{
		return 2 * (A + B);
	}
}

// Třída Kruh, která implementuje rozhraní IUmiPocitatObsah a IUmiPocitatObvod
public class Kruh : IUmiPocitatObsah, IUmiPocitatObvod
{
	// Vlastnosti kruhu
	public double R { get; set; }
	
	// Konstruktor třídy Kruh
	public Kruh(double r)
	{
		R = r;
	}
	
	// Implementovaná metoda SpocitejObsah
	public double SpocitejObsah()
	{
		return 3.14 * R * R;
	}
	
	// Implementovaná metoda SpocitejObvod
	public double SpocitejObvod()
	{
		return 2 * 3.14 * R;
	}
}

public class Program
{
	public static void Main()
	{
		// Zadání:
		// napiste dva ruzne interfacy: IUmiPocitatObsah, IUmiPocitatObvod
		// implementujte tridy obdelnik a kruh, ktere oba interfacy pouzivaji
		// vlozte jejich instance do seznamu a zavolejte na nich prislusne metody na vypocet obsahu a obvodu
		
		// Seznam obdélníků
		List<Obdelnik> obdelniky = new List<Obdelnik>() {
			new Obdelnik(5, 3),	
			new Obdelnik(2, 4),
			new Obdelnik(2, 5)
		};
		
		// Seznam kruhů
		List<Kruh> kruhy = new List<Kruh>()	{
			new Kruh(5),
			new Kruh(3),
			new Kruh(1)
		};
		
		// Procházíme každý obdélník a vypisujeme jeho obsah a obvod
		Console.WriteLine("Obdelniky");
		foreach (var obdelnik in obdelniky)
		{
			Console.WriteLine("Obsah: " + obdelnik.SpocitejObsah());
			Console.WriteLine("Obvod: " + obdelnik.SpocitejObvod());
		}
		
		// Procházíme každý kruh a vypisujeme jeho obsah a obvod
		Console.WriteLine("\nKruhy");
		foreach (var kruh in kruhy)
		{
			Console.WriteLine("Obsah: " + kruh.SpocitejObsah());
			Console.WriteLine("Obvod: " + kruh.SpocitejObvod());
		}
	}
}
