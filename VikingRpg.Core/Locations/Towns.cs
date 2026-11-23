public class Town
{
  
 public string townName {get; set;} = " "; 


public Town (string townName)
    {
        this.townName=townName;
    }



  List<Town> allTowns = new List<Town>(); //den bor här så länge, då det inte är relevant att en town kan alla towns. Utan den får bo här tills jag skapar en spelvärlds fil/class sen. 

}