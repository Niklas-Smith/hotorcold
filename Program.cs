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

Random randomNumber = new();
int rightNumber = randomNumber.Next(1, 100);
int i = 0;


while(i < 10)
 {   
Write("Guess number bettwen 1 and 100:  ");
string? input = ReadLine();


if(int.TryParse(input, out int attemp) && attemp>=1 && attemp <=100)  {

i++;
                
  int DiffrentBettwenAttempAndAnsver = Math.Abs(attemp - rightNumber);

   if (attemp == rightNumber)
 {
                  
 WriteLine($"You Win it was right number {rightNumber} and it took {i} tries");
 
 return ;
 
 }

 else if (DiffrentBettwenAttempAndAnsver <= 5) 
 {
  WriteLine("Verry hot at most 5 number from right number");


}

  else if(DiffrentBettwenAttempAndAnsver <=15)
  {
      
  WriteLine("hot at most 15 number from right number");

  }
                  
  else if(DiffrentBettwenAttempAndAnsver <=35)
  {
      
  WriteLine("Cold at most 35 number from right number");

  }

       else if(DiffrentBettwenAttempAndAnsver <=50)
  {
      
  WriteLine("Verry Cold at most 50 number from right number");

  }     

  else
    {
          WriteLine("Not even Close");        
          
  }
 


  }
 
}    




  


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