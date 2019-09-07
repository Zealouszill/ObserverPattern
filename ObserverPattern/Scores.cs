// Author: Spencer Stewart
// Date: 9/6/2019
// Project: ObserverPattern

/* Description:
 * 
 * This is an abstract class for scores. Multiple types of games can inherit
 * from this class to create their own scoring system.
 * This class will update each user that is subscribed to the update
 * and will automatically update the user's score when a new score is set.
 * 
 */

using System.Collections.Generic;

namespace ObserverPattern
{
    // This is our subject. Score for the ESPN game. Other classes can inherit from
    // this class.
    abstract class Scores
    {
        // Create current score for the game.
        private int currentScore;

        // Create a list to hold all individuals who subscribe to the game's score.
        private List<IViewer> listOfViewers = new List<IViewer>();

        // Instantiate class with given score.
        public Scores(int newScore)
        {
            currentScore = newScore;
        }

        // Attach a new viewer to the list.
        public void Attach(IViewer viewer)
        {
            listOfViewers.Add(viewer);
        }

        // Detach a viwer from our list.
        public void Detach(IViewer viewer)
        {
            listOfViewers.Remove(viewer);
        }

        // Notify all viewers when the score changes.
        public void Notify()
        {
            foreach (IViewer viewers in listOfViewers)
            {
                viewers.Update(this);
            }
        }

        // Create the score. If the score is different update it. If not, leave it.
        public int theScore
        {
            get { return currentScore; }
            set
            {
                if (currentScore != value)
                {
                    currentScore = value;
                    Notify();
                }
            }
        }
    }
}
