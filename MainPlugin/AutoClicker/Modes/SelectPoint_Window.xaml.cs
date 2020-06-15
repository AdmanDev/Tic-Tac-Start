using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace MainPlugin.AutoClicker.Modes
{
    public partial class SelectPoint_Window : Window
    {
        //Enum
        public enum SelectPointMode { OnePoint, Multiple, Visualisation }

        //Properties
        public Point SelectedPoint { get; private set; }
        public List<Point> SelectedPoints { get; private set; }
        public SelectPointMode Mode { get; private set; }

        //Constructors
        public SelectPoint_Window()
        {
            InitializeComponent();

            Mode = SelectPointMode.OnePoint;
        }

        public SelectPoint_Window(List<Point> points, SelectPointMode _mode = SelectPointMode.Visualisation)
        {
            InitializeComponent();

            Mode = _mode;
            SelectedPoints = points;

            ShowPoints(points);
        }

        private void ShowPoints(List<Point> points)
        {
            foreach (Point p in points)
            {
                Label label = GenerateLabel(p.ToString());
                this.MyCanvas.Children.Add(label);

                Canvas.SetLeft(label, p.X);
                Canvas.SetTop(label, p.Y);
            }
        }

        private Label GenerateLabel(string text)
        {
            return new Label()
            {
                Content = text,
                Padding = new Thickness(10, 5, 10, 5),
                FontSize = 14d,
                FontWeight = FontWeights.ExtraBold
            };
        }

        private void Window_MouseMove(object sender, MouseEventArgs e)
        {
            SelectedPoint = e.GetPosition(this);
            this.LB_Point.Content = SelectedPoint.ToString();

            Canvas.SetLeft(this.LB_Point, SelectedPoint.X);
            Canvas.SetTop(this.LB_Point, SelectedPoint.Y);
        }

        private void MyCanvas_MouseUp(object sender, MouseButtonEventArgs e)
        {
            this.DialogResult = true;
        }
    }
}
