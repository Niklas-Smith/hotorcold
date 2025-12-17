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



    }






}