
namespace vikingRpg;
using System.Net.Security;
using System.Collections.Generic;



public class Town
{
  
 public string townName {get; set;} = " "; 


public Town (string townName)
    {
        this.townName=townName;
    }

}



class Program
{ 

      List<Town> allTowns = new List<Town>(); //den bor här så länge, då det inte är relevant att en town kan alla towns. Utan den får bo här tills jag skapar en spelvärlds fil/class sen. 
  

           
        static void Main()
        {

                var wolin = new Town("Wolin");
                var ribe = new Town("Ribe"); //används ej i nuläget ska läggas till i list sen.


            //anropar jomsviking classen
            var jomsviking=new Jomsviking ("Richard", "Jomsborg", wolin, 100,40);
       



        //anropar character klassen- för Rasmus.
        var villageElder = new Character("Rasmus", " Jomsborg", wolin);
            villageElder.introduceCharacter();
            villageElder.describeTown(); //anropar med villageElder för villageelder anropar character classen.

           Console.WriteLine($"Du är just nu utanför {villageElder.characterName} hus. ");

             Console.WriteLine("Välj ett alternativen här för att komma vidare");
                Console.WriteLine("Du väljer alternativ genom att skriva det!");
                Console.WriteLine("Vart vill du gå? ");
                Console.WriteLine("Träningsfältet");
                Console.WriteLine("Värdshuset");
                //övergripande while loop för hela if-else
             while(true){
              
            Console.WriteLine("Vart vill du gå? ");
            var location= Console.ReadLine();
           
            // detta vill jag flytta till en metod eller class sen, som anropas i en mindre loop eller switch case som referar till dom olika if grejerna för att 
            if(location =="Träningsfältet")
        {
            Console.WriteLine("du har gått till träningsfältet");
            Console.WriteLine("Vad vill du göra här du kan göra dessa alternativ");
            Console.WriteLine("1: träna mot en motståndare");
            Console.WriteLine("2: titta på en fight");
            Console.WriteLine("3: vart vill du gå istället?");
           bool stillTraining=true;
           while(stillTraining){ //while loop för den inre tränings if-elsen.
            var training=Console.ReadLine();
            if (training == "1")
            {
                Console.WriteLine("Du ser en stor och mäktig krigare som vinner strid efter strid, han tittar mot dig!");
                
                 jomsviking.BattleCry();

                Console.WriteLine("Vill du acceptera utmaningen? (Accept/Decline)");
                var challengeDecision = Console.ReadLine();   

                if (challengeDecision == "Accept")
                {
                    Console.WriteLine("Du har accepterat duelen, må gudarna vara på din sida!");
        
                    // Vad händer om spelaren accepterar? (kanske: anropa striden du planerar bygga?)
                }
                else
                {
                    Console.WriteLine($"Ahh! Du är en fegis som inte vågar ha din ära testad av mig! {jomsviking.characterName}");
                }

            } else if  (training == "2")
            {
                Console.WriteLine("Du tittar på när dom andra slåss");
            } else if (training == "3")
            {
              Console.WriteLine("återvänder till meny");
              stillTraining=false;
            }
           }


        } else if (location == "Värdshuset")
        {
            Console.WriteLine("Du har nu gått til värdshuset");

        } else
        {
            Console.WriteLine("felaktigt val, vad vill du göra?");
        }
            }



       
           
        }

}
 