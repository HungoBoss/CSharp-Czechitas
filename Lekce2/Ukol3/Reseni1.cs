/* Zadání:
 * Ukol - opravte v tomto textu omylem zapnuty Caps Lock
 */
 
 string capsLock = "jAK mICROSCOFT wORD POZNA ZAPNUTY cAPSLOCK";
 
 // Pravděpodobně nejintuitivnějším řešením by bylo projít řetězec po znacích a zkontrolovat, zda je každý procházený
 // symbol velké či malé písmeno a podle toho přiřadit odpovídající malé či velké písmeno do výsledného řetězce.
 // Ukážeme si řešení pomocí LINQ, které jsme ještě neprobírali, ale právě pro tyto účely by se velmi hodilo.
 // LINQ či spíše klasifikátory můžete znát z jiných jazyků jako lambda funkce či anonymní funkce.
 
char[] capsLock = stringToChange.Select(x => char.IsUpper(x) ? char.ToLower(x) : char.ToUpper(x)).ToArray();
Console.WriteLine(new string(capsLock));

// Vysvětlení:
// Pokud to zkusím trošku popsat, tak si každý prvek stringToChange postupně projdeme a budeme jej referencovat jakožto x. 
// Pro každé x zkontrolujeme, zda je to velké písmeno. Pokud ano, přiřadíme do výsledku hodnotu x převedenou na malé písmeno. 
// Pokud ne, přiřadíme do výsledku hodnotu x převedenou na velké písmeno. Protože LINQ vrací výsledky jako kolekci IEnumerable
// (datová struktura, kterou lze procházet), tak si jí změníme přes .ToArray() na pole znaků.
