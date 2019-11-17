using System;
using System.Windows;

namespace MainPlugin.PlayVideo
{
    public partial class PlayVideo_ParamsDialog : Window
    {
        public PlayVideo_ParamsDialog()
        {
            InitializeComponent();
        }

        //Get result (parameters to play a video)
        public object[] GetParameters()
        {
            return new object[] { this.TB_VideoLocation.Text };
        }

        //Choose video file
        private void BT_ChooseVideo_Click(object sender, RoutedEventArgs e)
        {
            if (Util.OFD.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.TB_VideoLocation.Text = Util.OFD.FileName;
            }
        }

        private void BT_OK_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = true;
        }
    }
}
