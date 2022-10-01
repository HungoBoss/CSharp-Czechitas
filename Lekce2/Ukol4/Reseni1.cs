/* Zadání:
 * Ukol - rozsifrujte tuto zpravu - text byl zasifrovan tak, ze jsme kazde pismeno posunuli o jedno doprava: 'a' -> 'b'. 
 * pozn. jedna se o reseni jedne z ucastnic kurzu (mirne upraveno)
 */
 
string sifra = "Wzcpsob!qsbdf!.!hsbuvmvkj!b!ktfn!ob!Ufcf!qztoz";          // Vstupní šifra

string novyText = "";                                                     // Výstupní řetězec

foreach (char znak in sifra)                                              // Projdu jednotlivé znaky ve vstupním řetězci
{
    // Převedu procházený znak na jeho číselnou podobu a odečtu od ní jedničku
    // Jedničku odečítám proto, abych získal znak, který předchází znaku, se kterým pracuji
    int prevodNaSpravnyKod = System.Convert.ToInt32(znak) - 1;
    
    // Získaný číselný kód převedu zpět na odpovídají znak
    char prevodNaPismeno = System.Convert.ToChar(prevodNaSpravnyKod);
    
    // Přidám tento znak do výstupního řetězce
    novyText += prevodNaPismeno;
}

// A vypíši na konzoli
Console.WriteLine(novyText);
 
