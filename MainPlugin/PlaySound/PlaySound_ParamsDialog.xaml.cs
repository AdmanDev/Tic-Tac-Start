using System;
using System.Windows;
using System.Windows.Forms;

namespace MainPlugin.PlaySound
{
    public partial class PlaySound_ParamsDialog : Window
    {
        //Constructor
        public PlaySound_ParamsDialog()
        {
            InitializeComponent();
        }

        //Get result (parameters to play a sound)
        public object[] GetParameters()
        {
            return new object[] { this.TB_SoundLocation.Text, this.CB_Loop.IsChecked };
        }

        //Choose a sound file
        private void BT_ChooseSound_Click(object sender, RoutedEventArgs e)
        {
            if (Util.OFD.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.TB_SoundLocation.Text = Util.OFD.FileName;
            }
        }

        private void BT_OK_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = true;
        }
    }
}
