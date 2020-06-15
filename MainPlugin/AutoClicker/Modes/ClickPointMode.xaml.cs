using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace MainPlugin.AutoClicker.Modes
{
    public partial class ClickPointMode : UserControl, IClickMode
    {
        //Variables
        private Point screenPoint;

        //Constructor
        public ClickPointMode()
        {
            InitializeComponent();
        }

        public ModeParameters GetParameters()
        {
            List<Point> pointsList = new List<Point>()
            {
                screenPoint
            };
            int interval = Convert.ToInt32(this.NUD_Interval.Value);
            int reppeat = Convert.ToInt32(this.NUD_Repeats.Value);

            return new ModeParameters(pointsList, interval, reppeat);
        }

        private void BT_SelectPoint_Click(object sender, RoutedEventArgs e)
        {
            SelectPoint_Window spw = new SelectPoint_Window();
            if (spw.ShowDialog() == true)
            {
                screenPoint = spw.SelectedPoint;
                this.BT_SelectPoint.Content = "Point : " + screenPoint.ToString();
            }
        }
    }
}
