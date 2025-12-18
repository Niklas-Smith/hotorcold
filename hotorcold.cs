using System.Runtime.InteropServices;
using System.Text.Json;

namespace hotorcold
{
    
  // Skapar en class GameAttempts
public class GameAttempts
    {
        

 // skapar en varible som av filen hotorcold.json
 private string jsonSave = @"hotorcold.json";


     // skapar en list med Attempts.
private List<Attempts> hotorcold = new List<Attempts>();

public GameAttempts()
        {

              // kollar om jsonSave finns om det gör det läs in vad som finns i list Attempts som sedans görs om från json format.
            if(File.Exists(jsonSave) == true)
            {
                string json = File.ReadAllText(jsonSave);
                hotorcold = JsonSerializer.Deserialize<List<Attempts>>(json)!;
                

            }


        }

        // metod för att kunna använda get, set från class Attempts. tries = addattemp som man sedan spara till json filen med marshal
public Attempts newAttemp(int addattemp)
        {
            
 Attempts obj = new Attempts();
 obj.Tries= addattemp;
 hotorcold.Add(obj);
 marshal();
 return obj;

        }
        
        
    // Metod för att ta bort tries och spara till marrrshal
        public int removeAttemp(int index)
        {
            hotorcold.RemoveAt(index);
           marshal();
        return index;

        }

            // Metod för att hämta in vad som sparat i json filen
        public List<Attempts> getAttemp()
        {
            return hotorcold;


        }
  // Metod för att kunna spara till json filen.
        private void marshal()
        {
            
         var json = JsonSerializer.Serialize(hotorcold);
         File.WriteAllText(jsonSave, json);

        }





    }






}