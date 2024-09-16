// start main //

using System;

// Hey I found the using System and class CollegeFootballStartup online to simplify the start and fix some issues
class CollegeFootballStartupMenu{
    static void Main(string[] arguments){
        string enjoymentLevel = GetEnjoymentLevel();
        if (enjoymentLevel == "5") {
            Console.WriteLine("Bye!!!");
            return;
        }

        string stadium = GetStadiumRecommendation(enjoymentLevel);
        string game = GetGameRecommendation(stadium);
        DisplayStadiumDetails(stadium, game);
    }
    
// End Main //
    static string GetEnjoymentLevel(){
        System.Console.WriteLine("What Level Of Enjoyment Do You Want?\n1. Boring\n2. Average\n3. Fun\n4. Epic\n5. Nevermind, I Don't Like Football");
        string enjoymentLevel;
        do {
            enjoymentLevel = Console.ReadLine() ?? ""; //Had to look this up because of repeated null errors
            if (enjoymentLevel != "1" && enjoymentLevel !="2" && enjoymentLevel != "3" && enjoymentLevel != "4" && enjoymentLevel != "5"){
                Console.WriteLine("Invalid Input, Please Enter A Number From 1 To 5 To Continue ...");
            }
        } 
        
        while (enjoymentLevel != "1" && enjoymentLevel != "2" && enjoymentLevel != "3" && enjoymentLevel != "4" && enjoymentLevel != "5");
        
        return enjoymentLevel;
    }

    static void DisplayStadiumDetails(string stadium, string game){
        System.Console.WriteLine("\nThe Best Game to Go to Would Be at " + stadium + ". \nThe Best Game to Attend is " + game + ".");
    }

    static string GetStadiumRecommendation(string enjoymentLevel){
        switch (enjoymentLevel) {
            case "1":
                return "Neyland Stadium";
            case "2":
                return "Jordan-Hare Stadium";
            case "3":
                return "Tiger Stadium";
            case "4":
                return "Saban Field at Bryant-Denny Stadium";
            default:
                return "Unknown Stadium or Request, Try Again :)";
        }
    }

    static string GetGameRecommendation(string stadium){
        switch (stadium) {
            case "Neyland Stadium":
                return "vs. Kent State";
            case "Jordan-Hare Stadium":
                return "vs. Kentucky";
            case "Tiger Stadium":
                return "vs. Alabama";
            case "Saban Field at Bryant-Denny Stadium":
                return "vs. Auburn";
            default:
                return "Sorry, Unknown Game :(";
        }
    }
}