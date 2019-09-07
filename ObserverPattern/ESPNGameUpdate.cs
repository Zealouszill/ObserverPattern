// Author: Spencer Stewart
// Date: 9/7/2019
// Project: ObserverPattern

/* Description:
 * 
 * This is a driver program to test our observer pattern.
 * It will create multiple "users" and then run a few simulations
 * of the score changing. The console will out put the new score update.
 * 
 */
using System;

namespace ObserverPattern
{
    class ESPNGameUpdate
    {
        // Main function to run observer pattern simulation
        static void Main(string[] args)
        {
            // Create new basketball score.
            Scores score = new BasketballScore(26);

            // Create set of viewers.
            score.Attach(new Viewer("Bob"));
            score.Attach(new Viewer("Clara"));
            score.Attach(new Viewer("Tyler"));
            score.Attach(new Viewer("Bill"));

            // Simulate score changes.
            score.theScore = 22;
            Console.WriteLine("Team shoots and scores two points!");
            Console.WriteLine("");
            score.theScore = 24;
            Console.WriteLine("Team shoots and scores three points!");
            Console.WriteLine("");
            score.theScore = 27;
            Console.WriteLine("");
        }
    }
}


