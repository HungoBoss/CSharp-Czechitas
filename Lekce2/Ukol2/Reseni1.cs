/* Zadání:
 * Napiste funkci, ktera umi detekovat, ze se jedna o palindrom (zatim jen u slov) a pak z pole vypiste jen palindromy.
 */
 
 string[] slova = new string[] { "kajak", "program", "rotor", "Czechitas", "madam", "Jarda", "radar", "nepotopen" };
 
 // Pro to, aby slovo mohlo být palindrom musí vlastně být jednotlivá písmena zrcadlově symetrická. Písmeno na indexu 0 musí
 // být shodné s písmenem na indexu Length - 1, písmeno na indexu 1 musí být shodné s písmenem na indexu Length - 1 - 1 nebo
 // jinými slovy Length - 1 - i. Můžeme proto projít řetězec za pomocí cyklu for a kontrolovat, zda si písmena na patřičných
 // indexech skutečně odpovídají.
 
 List<string> palindrom = new List<string>();               // Vytvořím si nový seznam, který bude držet všechny palindromy
 
 foreach (string slovo in slova)                            // Procházím všechna slova
 {
    bool jePalindrom = true;                                // Proměnná udávající, zda je slovo palindrom či nikoli
    for (int i = 0; i < slovo.Length; i++)                  // Projdu jednotlivá písmena ve slově
    {
        if (slovo[i] != slovo[slovo.Length-1-i])            // Kontrolují, zda si znaky zrcadlově odpovídají
        {
            jePalindrom = false;                            // Pokud ne, nejedná se o palindrom
            break;                                          // A vyskakuji z cyklu
        }
    }
    
    if (jePalindrom)
    {
        palindrom.Add(slovo);                               // Pokud je slovo palindrom, přidám ho do seznamu
    }
 }
 
