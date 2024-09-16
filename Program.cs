// start main //

using System;
using System.Runtime.Loader;

class CollegeFootballStartupMenu{
    static void Main(string[] arguments){
        string enjoymentLevel = GetEnjoymentLevel();
        string stadium = GetStadiumRecommendation(enjoymentLevel);
        string game = GetGameRecommendation(stadium);
        DisplayStadiumDetails(stadium, game);
    }

    static string GetEnjoymentLevel(){
        Console.WriteLine("What Level Of Enjoyment Do You Want?\n1. Boring\n2. Average\n3. Fun\n4. Epic\n5. Nevermind, I Don't Like Football");
        string enjoymentLevel = Console.ReadLine();
        return enjoymentLevel;
    }

    static void DisplayStadiumDetails(string stadium, string game){
        Console.WriteLine("\nThe Best Game to Go to Would Be at " + stadium + ". \nThe Best Game to Attend is " + game + ".");
    }

    static string GetStadiumRecommendation(string enjoymentLevel){
        if (enjoymentLevel() == "1"){
            return "Neyland Stadium";
        }
        else if (enjoymentLevel() == "2"){
            return "Jordan-Hare Stadium";
        }
        else if (enjoymentLevel() == "3"){
            return "Tiger Stadium";
        }
        else if (enjoymentLevel() == "4"){
            return "Saban Field at Bryant-Denny Stadium";
        }
        else if (enjoymentLevel() == "5"){
            return "Bye!!!";
        }
        else {
            return "Unknown Stadium or Request, Try Again :)";
        }
    }

    static string GetGameRecommendation(string stadium){
        if (stadium == "Neyland Stadium"){
            return "vs. Kent State";
        }
        else if (stadium == "Jordan-Hare Stadium"){
            return "vs. Kentucky";
        }
        else if (stadium == "Tiger Stadium"){
            return "vs. Alabama";
        }
        else if (stadium == "Saban Field at Bryant-Denny Stadium"){
            return "vs. Auburn";
        }
        else {
            return "Sorry, Unknown Game";
        }
    }
}