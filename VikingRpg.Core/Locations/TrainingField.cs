using vikingRpg;

namespace VikingRpg;
    
    
    
    
    
    
    // detta vill jag flytta till en metod eller class sen, som anropas i en mindre loop eller switch case som referar till dom olika if grejerna för att 
           
         public  class TrainingField{ 
           
           public void TrainingFieldLoop(Jomsviking jomsviking){
         
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
                //hämtar Richard karaktären och loopar igenom hans repliker och printar den vi vill ha,dvs battlecry
                var d=CharacterDialouge.For(jomsviking);
                foreach(var line in d.BattleCry.Lines)
                {
                    Console.WriteLine(line);
                }


                Console.WriteLine("Vill du acceptera utmaningen? (Accept/Decline)");
                var challengeDecision = Console.ReadLine();   

                if (challengeDecision == "Accept")
                {
                    Console.WriteLine("Du har accepterat duelen, må gudarna vara på din sida!");
        
                    // Vad händer om spelaren accepterar? 
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
           
           
        }
}

        
        

        