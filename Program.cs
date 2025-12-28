using System;
using static System.Console;

// projekt hot or cold c# av Niklas Smith, nism2400
// kurskod dt071g i kursen Programmering i C#.NET 

namespace hotorcold
{
class Program
{
    static void Main(string[]args ) {


   GameAttempts howmanyattemps = new GameAttempts();
      
// while loop 
  while (true)
  {
      // rensar 
     Clear();
      // gör att cursor är dold.
    CursorVisible = false;
  
      WriteLine("Hot Or Cold / higer or lower");
   // Ger de här alternativen när programet startar
   WriteLine("1. Välj spel");
 WriteLine("2. Ta bort resultat");
 WriteLine("X. Avslute spel");
 
// forech loop för att skriva ut alla tries som är sparade i json
              int  x = 0;
                foreach (Attempts tries in howmanyattemps.getAttemp())  
                {
                    WriteLine("[" + x++ + "] Du använde: " + tries.Tries + " försök");

                }


// Gör att man kan välja med knapp ett av alternative 1,2 eller x
 int keyPress = (int)ReadKey(true).Key;
switch(keyPress)
{
 case '1':


 WriteLine("1. Spela hot Or cold");
  WriteLine("2. Spela higer or lower");
int keypress2 = (int)ReadKey(true).Key;
switch(keypress2)
{
 case '1':

// skapar så man har en varible för ett tal mellan 1 occh 100
Random randomNumber = new();
int rightNumber = randomNumber.Next(1, 101);

// börja i på 0 (för att kolla på hur många gånger man gissat)
int i = 0;


// så läng while loop är under 10 så forstätt att fråga Guess number bettwen 1 and 100: 
while(i < 10  )
 {   
Write("Guess number bettwen 1 and 100:  ");

// gör ReadLine() till en varible.
string? input = ReadLine();


if(int.TryParse(input, out int attemp) && attemp>=1 && attemp <=100)  {

// ökar försök med 1 hella tiden
i++;
                
// Kollar skilladen mellan din gissning number och rätt number (som är random)
  int DiffrentBettwenAttempAndAnsver = Math.Abs(attemp - rightNumber);
// om din gissning är lika med rätt number så gör detta  
   if (attemp == rightNumber)
 {
                  
 

 // Spara till json filen hur många försök du behövede för gissa rätt
 howmanyattemps.newAttemp(i);
 WriteLine($"You Win it was right number {rightNumber} and it took {i} tries");
 WriteLine("Press a key to go back to meny");
 // gör så om gissa rätt number så vänta till keypress för gå vidare till meny.
 ReadKey();
break;
 
 }

// om skillnade mellan din gissning och rätt number är <=5 så gör detta
 else if (DiffrentBettwenAttempAndAnsver <= 5) 
 {
  WriteLine("Verry hot at most 5 number from right number");


}
// om skillnade mellan din gissning och rätt number är <=15 så gör detta
  else if(DiffrentBettwenAttempAndAnsver <=15)
  {
      
  WriteLine("hot at most 15 number from right number");

  }
      // om skillnade mellan din gissning och rätt number är <=35 så gör detta       
  else if(DiffrentBettwenAttempAndAnsver <=35)
  {
      
  WriteLine("Cold at most 35 number from right number");

  }
// om skillnade mellan din gissning och rätt number är <=50 så gör detta
       else if(DiffrentBettwenAttempAndAnsver <=50)
  {
      
  WriteLine("Verry Cold at most 50 number from right number");

  }     
// om skillnade mellan din gissning och rätt number är >50 så gör detta
  else
    {
          WriteLine("Not even Close");        
          
  }
 


  }
 
}    

  break;
case '2':

  // skapar så man har en varible för ett tal mellan 1 och 1000
Random randomNumber2 = new();
int rightNumber2 = randomNumber2.Next(1, 1001);
// börja y på 0 (för att kolla på hur många gånger man gissat)
int y = 0;
while(y < 15)
 {   
Write("Guess number bettwen 1 and 1000:  ");

// gör ReadLine() till en varible.
string? input2 = ReadLine(); 
if(int.TryParse(input2, out int attemp2) && attemp2>=1 && attemp2 <=1000)
 {
                    
// ökar försök med 1 hella tiden
y++;

//  om din gissning är lika med rätt number så gör detta  
   if (attemp2 == rightNumber2)
 {
                  
 WriteLine($"You Win it was right number {rightNumber2} and it took {y} tries");

 // Spara till json filen hur många försök du behövede för gissa rätt
 howmanyattemps.newAttemp(y);
 WriteLine("Press a key to go back to meny");
 // gör så om gissa rätt number vänta för keypress för gå vidare till meny
 ReadKey();
break;
 
 }
// Om ditt nummber är störe än rätt nummer gör detta.
 else if (attemp2 > rightNumber2) 
 {
  WriteLine("The number is lower");


}

// Om ditt nummber är mindre än rätt nummer gör detta.
 else if (attemp2 < rightNumber2) 
 {
  WriteLine("The number is higer");


}


}


}

break;



}



  


 break;
case '2':

  // gör att curser syns.
   CursorVisible = true;
  Write("vilket index vill du tar bort: ");
  string? index = ReadLine();
   // gör att man kan ta bort resultat beroende på index
                        if (!String.IsNullOrEmpty(index))
                            try
                      {
                   howmanyattemps.removeAttemp(Convert.ToInt32(index));


               }
                 catch (Exception)
                            {
                                WriteLine("index finns inte");
                                WriteLine("tryck knapp för fortsätta");
                                 ReadKey();

      }

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