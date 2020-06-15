using System;
using System.Collections.Generic;
using System.Windows;

namespace MainPlugin.AutoClicker.Modes
{
    [Serializable]
    public class ModeParameters
    {
        //Variables
        public List<Point> pointsToClick;
        private int clickInterval;
        private int numberOfRepeats;

        //Properies
        internal Point this[int i]
        {
            get => pointsToClick[i];
        }
        public int PointsCount { get => pointsToClick.Count; }
        public int ClickInterval { get => clickInterval; private set => clickInterval = value; }
        public int NumberOfRepeats { get => numberOfRepeats; private set => numberOfRepeats = value; }

        //Constructor
        public  ModeParameters(List<Point> points, int intervalBetweenClicks, int repeats)
        {
            pointsToClick = points;
            ClickInterval = intervalBetweenClicks;
            NumberOfRepeats = repeats;
        }

        public ModeParameters()
        {

        }
    }
}
