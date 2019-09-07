// Author: Spencer Stewart
// Date: 9/6/2019
// Project: ObserverPattern

/* Description:
 * 
 * Create a viewer. An individual watching the game. 
 * 
 */

using System;

namespace ObserverPattern
{
    class Viewer : IViewer
    {
        // Name for the Viewer.
        private string ViewerName;

        // Create a basketball score to hold the score for the viewer.
        private Scores theScore = new BasketballScore(0);
        
        // Instantiate the class with the name of the viewer.
        public Viewer(string name)
        {
            ViewerName = name;
        }

        // Update score for the viewer and tell us that update.
        public void Update(Scores score)
        {
            //Console.WriteLine("Notified {0} of {1}'s " + " price change to {2:C} per pound.", ViewerName, score.GetType().Name, score.theScore);
            Console.WriteLine("Notified " + ViewerName + " of Basketball Score update. Score changed to " + score.theScore);
            // Console.WriteLine("This line First");

            // If current score doesn't match new score, change current score to the new score.
            if (score.theScore != theScore.theScore)
            {
                Console.WriteLine(ViewerName + " sees the " + score.GetType().Name + " updated to " + score.theScore + "!\n");
            }
        }
    }
}
