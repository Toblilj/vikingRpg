namespace vikingRpg;
   

   public enum QuestStage { Start }
   
   
public class CharacterDialouge{


   public static CharacterDialogues For(Character c, QuestStage stage = QuestStage.Start)
    {
        
    switch (c.characterName)
    {
        case "Rasmus":
            return Rasmus;
        case "Richard":
            return Richard;
        default:
            return new CharacterDialogues();
    }
    
    }
public static readonly CharacterDialogues Rasmus = new()
{
  Intro=new(){Lines=new []{ "Hello my name is Rasmus voice of a thousand storms, and i belong to Jomsborg welcome to the world!" , 
  "and this is the town of Wolin is a big village and it is where the army of Jarl Aaron resides. We are the mighty army of Jomsborg"}}
 };
//vill jag bygga på dialogerna här för t.e.x ett quest eller liknande så skapar jag en nu istället för intro=new() dvs du ersätter intro med det "facket" du vill ha du skapar nya fack längre ned.
    public static readonly CharacterDialogues Richard = new()
{
  Intro=new(){Lines=new []{"Jag är Richard Jomsviking, den mäktigaste krigaren på detta fält!" , "Jag utmanar dig på en duel!"     }},
    BattleCry=new (){Lines=new[]{"bla bla"}}
};

   
    }





//Lista med repliker
public class Conversation
{
    public string[] Lines { get; init; } = { "..." };
}


//här skapar vi dom nya facken för dialoger så om du vill lägga till en ny dialog till viken karaktär som helst så är det här du gör det.
    public class CharacterDialogues
{
    public Conversation Intro { get; init; } = new();
    public Conversation Quest1 { get; init; } = new();
    public Conversation BattleCry { get; init; } = new();
}

