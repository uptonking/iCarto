using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/**********************************************************************************     
     * Created by  Yao  on  5/14/2016 3:29:32 PM     
     * README:定时器demo
     * ============================================================================
     * CHANGELOG：
    ********************************************************************************/
namespace iCarto.Tests.examples
{
    public class WinfromTimer
    {
        static System.Windows.Forms.Timer myTimer = new System.Windows.Forms.Timer();
        static int alarmCounter = 1;
        static bool exitFlag = false;

        // This is the method to run when the timer is raised. 
        private static void TimerEventProcessor(Object myObject,
                                                EventArgs myEventArgs)
        {
            myTimer.Stop();

            // Displays a message box asking whether to continue running the timer. 
            if (MessageBox.Show("Continue running?", "Count is: " + alarmCounter,
               MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                // Restarts the timer and increments the counter.
                alarmCounter += 1;
                myTimer.Enabled = true;
            }
            else
            {
                // Stops the timer.
                exitFlag = true;
            }
        }

        public static int Main()
        {
            /* Adds the event and the event handler for the method that will 
               process the timer event to the timer. */
            myTimer.Tick += new EventHandler(TimerEventProcessor);

            // Sets the timer interval to 5 seconds.
            myTimer.Interval = 2000;
            myTimer.Start();

            // Runs the timer, and raises the event. 
            while (exitFlag == false)
            {
                // Processes all the events in the queue.
                Application.DoEvents();
            }
            return 0;
        }
    }

}