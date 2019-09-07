// Author: Spencer Stewart
// Date: 9/7/2019
// Project: ObserverPattern

/* Description:
 * 
 * Class to define the BasketballScore details.
 * 
 */

namespace ObserverPattern
{
    class BasketballScore : Scores
    {
        // Class to create Basketball Score from the base score in Scores
        public BasketballScore(int score) : base(score)
        {

        }
    }
}
