using System;
using System.Windows;

namespace MainPlugin.ShutDown_Restart_PC
{
    public partial class ShutDown_Restart_PC_ParamsDialog : Window
    {
        //Constructor
        public ShutDown_Restart_PC_ParamsDialog()
        {
            InitializeComponent();
        }

        //Get result (parameters to shut down / restart computer)
        public object[] GetParameters()
        {
            return new object[] { this.RB_ShutDown.IsChecked };
        }

        //Validate parameters
        private void BT_OK_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = true;
        }
    }
}
