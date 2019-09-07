// Author: Spencer Stewart
// Date: 9/7/2019
// Project: ObserverPattern

/* Description:
 * 
 * Interface to create the update function for the Viewer class.
 * 
 */

namespace ObserverPattern
{
    interface IViewer
    {
        void Update(Scores score);
    }
}
