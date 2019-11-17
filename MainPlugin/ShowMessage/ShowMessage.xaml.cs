using System;
using System.Windows;

namespace MainPlugin.ShowMessage
{
    public partial class ShowMessage : Window
    {
        public ShowMessage()
        {
            InitializeComponent();
        }

        //Show a message (it is the main function of this plugin)
        public static void ShowMess(string _message)
        {
            ShowMessage f = new ShowMessage();
            f.LB_Message.Content = _message;
            f.Show();
        }
    }
}
