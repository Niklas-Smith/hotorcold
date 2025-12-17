using System.Runtime.InteropServices;
using System.Text.Json;

namespace hotorcold
{
    
  // Skapar en class GameAttempts
public class GameAttempts
    {
        

 // skapar en varible som av filen hotorcold.json
 private string jsonSave = @"hotorcold.json";

private List<Attempts> hotorcold = new List<Attempts>();

public GameAttempts()
        {
            if(File.Exists(jsonSave) == true)
            {
                string json = File.ReadAllText(jsonSave);
                hotorcold = JsonSerializer.Deserialize<List<Attempts>>(json)!;
                

            }


        }
public Attempts newAttemp(int addattemp)
        {
            
 Attempts obj = new Attempts();
 obj.Tries= addattemp;
 hotorcold.Add(obj);
 marshal();
 return obj;

        }
public int removeAttemp(int index)
        {
            hotorcold.RemoveAt(index);
           marshal();
        return index;

        }
        public List<Attempts> getAttemp()
        {
            return hotorcold;


        }

        private void marshal()
        {
            
         var json = JsonSerializer.Serialize(hotorcold);
         File.WriteAllText(jsonSave, json);

        }





    }






}