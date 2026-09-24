namespace vikingRpg;


public class Character
{
  public  string characterName {get; set;}=" ";
    public string faction {get; set;}= " ";
    Town HomeTown {get; set;} //character hometown- referens till min property i min town class.
  protected  int characterHealth {get; set;} 
    protected int characterStrength {get; set;} 
    
//här vill jag ha min kosntruktor där jag sätter min karaktär baserat på informationen ifrån variablerna, hur får jag informationen ifrån dessa variabler? 
//                                                      sätter Town som string/int/ variabel  här. don't ask me why just do.
public Character (string characterName, string faction, Town homeTown) {
    
//sätter värderna ifrån min main till mina variabler- gör det här för renare kod och dry.
        this.characterName= characterName;
        this.faction=faction;
        this.HomeTown = homeTown;
        // this.characterHealth=characterHealth;
        // this.characterStrength=characterStrength;


    }

    public void  introduceCharacter ()
    {
    
            
           //hanterar vad som ska hända  
       Console.WriteLine($"Hello my name is {characterName}, and i belong to {faction} welcome to the world!");
       
    }

 public void describeTown()
    {


        Console.WriteLine($"and this is the town of {HomeTown.townName}  is a big village and it is where the army of Jarl {characterName} resides. We are the mighty army of {faction}");

        }


}

public class Jomsviking : Character
{


    public Jomsviking(string characterName, string faction, Town homeTown, int health, int strength) 
        : base(characterName, faction, homeTown)
    {
        this.characterHealth = health;
        this.characterStrength = strength;
    }

    public void BattleCry()
    {
        Console.WriteLine("Jag är Richard Jomsviking, den mäktigaste krigaren på detta fält!");
        Console.WriteLine("Jag utmanar dig på en duel!");
    }



}