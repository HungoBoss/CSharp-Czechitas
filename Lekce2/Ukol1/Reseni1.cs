/* Zadání:
 * Obraťte pořadí stringu. Výstup vypište do konzole.
 */
 
string palindrom = "Kuna nese nanuk";

// Jedním z možných způsobů je string převést na pole znaků a pak použít zabudované metody Reverse(), 
// která otočí pořadí prvků v poli.

char[] charArray = palindrom.ToCharArray();     // Vytvářím pomocné pole charArray, ukládám do něj palindrom převedený na pole znaků
Array.Reverse(charArray);                       // Převracím pořadí prvků v poli charArray
Console.WriteLine(charArray);                   // Vypisuji výsledek do konzole
