using System;
using static System.Console;

// projekt hot or cold c# av Niklas Smith, nism2400

namespace hotorcold
{
class Program
{
    static void Main(string[]args ) {


  while (true)
  {
      // rensar 
      Clear();
      // gör att cursor är dold.
    CursorVisible = false;
  
      WriteLine("Hot Or Cold");
   // Ger de här alternativen när programet startar
   WriteLine("1. Spela hot Or cold");
 WriteLine("2. Se resultat");
 WriteLine("X. Avslute spel");
 
// Gör att man kan välja med knapp ett av alternative 1,2 eller x
 int keyPress = (int)ReadKey(true).Key;

switch(keyPress)
{
 case '1':





 break; 
case '2':

break; 
case 88:

// Gör så man kan avsluta spelet med x
 Environment.Exit(0);
break;

  }








  }





}


}
}