using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Forms;

namespace MainPlugin.AutoClicker.Modes
{
    public partial class ClicksProgramMode : System.Windows.Controls.UserControl, IClickMode
    {
        //Variables
        private readonly SaveFileDialog sfd;
        private readonly OpenFileDialog ofd;

        private List<Point> clicksPonts;

        //Constructor
        public ClicksProgramMode()
        {
            InitializeComponent();

            sfd = new SaveFileDialog()
            {
                FileName = "My clicks program",
                DefaultExt = "bin",
                Filter = "|*.bin",
                Title = "Enregistrer un programme de clicks..."
            };

            ofd = new OpenFileDialog()
            {
                FileName = "My clicks program",
                DefaultExt = "bin",
                Filter = "|*.bin",
                Title = "Ouvrir un programme de clicks..."
            };

            clicksPonts = new List<Point>();
        }

        public ModeParameters GetParameters()
        {
            int intervall = Convert.ToInt32(this.NUD_Interval.Value);
            int repeats = Convert.ToInt32(this.NUD_Repeat.Value);

            return new ModeParameters(clicksPonts, intervall, repeats);
        }

        private void ShowPoints(List<Point> points)
        {
            foreach (Point p in points)
            {
                this.LV_Points.Items.Add(p.ToString());
            }
        }

        private void BT_AddPoints_Click(object sender, RoutedEventArgs e)
        {
            SelectPoint_Window spw = new SelectPoint_Window();
            if (spw.ShowDialog() == true)
            {
                clicksPonts.Add(spw.SelectedPoint);
                this.LV_Points.Items.Add(spw.SelectedPoint.ToString());
            }
        }

        private void BT_RemovePoint_Click(object sender, RoutedEventArgs e)
        {
            if (this.LV_Points.SelectedItem != null)
            {
                int pointIndex = this.LV_Points.SelectedIndex;
                this.LV_Points.Items.RemoveAt(pointIndex);
                clicksPonts.RemoveAt(pointIndex);
            }
        }

        private void BT_VisualisePoint_Click(object sender, RoutedEventArgs e)
        {
            if(this.LV_Points.SelectedItem != null)
            {
                List<Point> points = new List<Point>()
                {
                    clicksPonts[this.LV_Points.SelectedIndex]
                };

                SelectPoint_Window spw = new SelectPoint_Window(points, SelectPoint_Window.SelectPointMode.Visualisation);
                spw.ShowDialog();
            }
            else
            {
                SelectPoint_Window spw = new SelectPoint_Window(clicksPonts, SelectPoint_Window.SelectPointMode.Visualisation);
                spw.ShowDialog();
            }
        }

        private void BT_SaveProgram_Click(object sender, RoutedEventArgs e)
        {
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                ModeParameters mp = GetParameters();
                Dictionary<string, object> datas = new Dictionary<string, object>();
                datas.Add("Points", mp.pointsToClick);
                datas.Add("Interval", mp.ClickInterval);
                datas.Add("Repeats", mp.NumberOfRepeats);

                MyFunctions.FileManager.Serialize(sfd.FileName, datas);
            }
        }

        private void BT_OpenProgram_Click(object sender, RoutedEventArgs e)
        {
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                Dictionary<string, object> datas = MyFunctions.FileManager.Deserialize<Dictionary<string, object>>(ofd.FileName);

                this.NUD_Interval.Value = (int)datas["Interval"];
                this.NUD_Repeat.Value = (int)datas["Repeats"];
                clicksPonts = (List<Point>)datas["Points"];

                ShowPoints(clicksPonts);
            }
        }
    }
}
