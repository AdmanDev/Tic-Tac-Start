using System;
using System.Windows;

namespace MainPlugin.RunStopProcess
{
    public partial class RunStopProcess_ParamsDialog : Window
    {
        public RunStopProcess_ParamsDialog()
        {
            InitializeComponent();
        }

        //Get result (parameters to run / stop a process)
        public object[] GetParameters()
        {
            return new object[] { this.TB_ProcessName.Text, this.RB_RunProcess.IsChecked };
        }

        private void BT_OK_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = true;
        }

        private void BT_ChooseVideo_Click(object sender, RoutedEventArgs e)
        {
            if (Util.OFD.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.TB_ProcessName.Text = Util.OFD.FileName;
                this.RB_RunProcess.IsChecked = true;
            }
        }
    }
}
