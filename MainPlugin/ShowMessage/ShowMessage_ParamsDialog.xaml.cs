using System;
using System.Windows;

namespace MainPlugin.ShowMessage
{
    public partial class ShowMessage_ParamsDialog : Window
    {
        public ShowMessage_ParamsDialog()
        {
            InitializeComponent();
        }

        //Get result (parameters to show a message)
        public object[] GetParameters()
        {
            return new object[] { this.TB_Message.Text };
        }

        //Enable this action
        private void BT_OK_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = true;
        }
    }
}
