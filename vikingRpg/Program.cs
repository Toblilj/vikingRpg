
namespace vikingRpg;
using System.Net.Security;
using System.Collections.Generic;
using VikingRpg.Core.Locations;
using VikingRpg.Core.Characters;


// public class Town
// {
  
//  public string townName {get; set;} = " "; 


// public Town (string townName)
//     {
//         this.townName=townName;
//     }

// }



class Program
{ 

    //   List<Town> allTowns = new List<Town>(); //den bor här så länge, då det inte är relevant att en town kan alla towns. Utan den får bo här tills jag skapar en spelvärlds fil/class sen. 
  

           
        static void Main()
        {

                var wolin = new Town("Wolin");
                var ribe = new Town("Ribe"); //används ej i nuläget ska läggas till i list sen.


            //anropar jomsviking classen
            var jomsviking=new Jomsviking ("Richard", "Jomsborg", wolin, 100,40);
       



        //anropar character klassen- för Rasmus och även dialogerna för karaktären
        var villageElder = new Character("Rasmus", " Jomsborg", wolin);
        //hämtar dialogen och loppar igenom alla dialoger för karaktären och printar rätt dialog vi söker-idfk how men ja.
    
           var d=CharacterDialouge.For(villageElder);
           foreach(var line in d.Intro.Lines)
        {
            Console.WriteLine(line);
        }
           
            // villageElder.introduceCharacter();
            // villageElder.describeTown(); //anropar med villageElder för villageelder anropar character classen.

           Console.WriteLine($"Du är just nu utanför {villageElder.characterName} hus. ");

             Console.WriteLine("Välj ett alternativen här för att komma vidare");
                Console.WriteLine("Du väljer alternativ genom att skriva det!");
                Console.WriteLine("Vart vill du gå? ");
                Console.WriteLine("Träningsfältet");
                Console.WriteLine("Värdshuset");
                //övergripande while loop för hela if-else
             while(true){
              
            // Console.WriteLine("Vart vill du gå? ");
            var location= Console.ReadLine();
           
            switch (location?.ToLower())
        {
            case "träningsfältet":
                    TrainingField trainingField = new TrainingField();
        
            break;
            
              case "värdshuset":
                Console.WriteLine("Du har nu gått til värdshuset");
             break;
            
            default:
                Console.WriteLine("felaktigt val, vad vill du göra?");
                break;  
            
            
            
            }


        // } else if (location == "Värdshuset")
        // {
        //     Console.WriteLine("Du har nu gått til värdshuset");

        // } else
        // {
        //     Console.WriteLine("felaktigt val, vad vill du göra?");
        // }
        //     }



       
           
        // }
        }

}
}
 