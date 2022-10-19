using System;
using System.Collections.Generic;

interface IUmiPocitatObsah
{
	double SpocitejObsah();	
}

interface IUmiPocitatObvod
{
	double SpocitejObvod();
}

public class Obdelnik : IUmiPocitatObsah, IUmiPocitatObvod
{
	public double A { get; set; }
	public double B { get; set; }
	
	public Obdelnik(double a, double b)
	{
		A = a;
		B = b;
	}
	
	public double SpocitejObsah() 
	{
		return A * B;
	}
	
	public double SpocitejObvod()
	{
		return 2 * (A + B);
	}
}

public class Kruh : IUmiPocitatObsah, IUmiPocitatObvod
{
	public double R { get; set; }
	
	public Kruh(double r)
	{
		R = r;
	}
	
	public double SpocitejObsah()
	{
		return 3.14 * R * R;
	}
	
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
		
		List<Obdelnik> obdelniky = new List<Obdelnik>() {
			new Obdelnik(5, 3),	
			new Obdelnik(2, 4),
			new Obdelnik(2, 5)
		};
		
		List<Kruh> kruhy = new List<Kruh>()	{
			new Kruh(5),
			new Kruh(3),
			new Kruh(1)
		};
		
		Console.WriteLine("Obdelniky");
		foreach (var obdelnik in obdelniky)
		{
			Console.WriteLine("Obsah: " + obdelnik.SpocitejObsah());
			Console.WriteLine("Obvod: " + obdelnik.SpocitejObvod());
		}
		
		Console.WriteLine("\nKruhy");
		foreach (var kruh in kruhy)
		{
			Console.WriteLine("Obsah: " + kruh.SpocitejObsah());
			Console.WriteLine("Obvod: " + kruh.SpocitejObvod());
		}
	}
}
