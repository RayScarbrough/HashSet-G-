using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
      
        HashSet<string> teamA = new HashSet<string> { "Chris", "James", "Mark", "Ethan", "Brad" };

        
        HashSet<string> teamB = new HashSet<string> { "Alex", "Luke", "Nathan", "Oliver", "Peter" };

      
        HashSet<string> teamC = new HashSet<string> { "Chris", "Luke", "Sam", "Dylan", "Max" };

        
        Console.WriteLine("Combined Team (A + B):");
        teamA.UnionWith(teamB);
        foreach (var player in teamA)
        {
            Console.WriteLine(player);
        }

        
        HashSet<string> commonPlayers = new HashSet<string>(teamA);
        commonPlayers.IntersectWith(teamC);
        Console.WriteLine("\nPlayers in both the combined Team (A + B) and Team C:");
        foreach (var player in commonPlayers)
        {
            Console.WriteLine(player);
        }
    }
}
