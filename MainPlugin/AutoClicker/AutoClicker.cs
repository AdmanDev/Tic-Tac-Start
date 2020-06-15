using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Forms;
using MyFunctions;

namespace MainPlugin.AutoClicker
{
    public static class AutoClicker
    {
        //Variables
        private static Timer timer;
        private static int fullProgramFinished;
        private static int currPointIndex;

        private static List<Point> pointsToClick;
        private static int numberOfRepeats;

        //Triggered by Tic-Tac-Start
        public static void Click(List<Point> _pointsToClick, int _clickInterval, int _numberOfRepeats)
        {
            pointsToClick = _pointsToClick;
            numberOfRepeats = _numberOfRepeats;

            fullProgramFinished = 0;
            currPointIndex = 0;

            timer = new Timer() { Interval = _clickInterval };
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private static void Timer_Tick(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(pointsToClick[currPointIndex].X);
            int y = Convert.ToInt32(pointsToClick[currPointIndex].Y);
            MouseManager.Click(x, y);

            currPointIndex += 1;
            if(currPointIndex >= pointsToClick.Count)
            {
                fullProgramFinished += 1;
                currPointIndex = 0;
                if(fullProgramFinished >= numberOfRepeats /*&& numberOfRepeats != 0*/)
                {
                    timer.Stop();
                }
            }
        }

    }
}
