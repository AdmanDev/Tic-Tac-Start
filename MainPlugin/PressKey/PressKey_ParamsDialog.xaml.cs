using System;
using System.Windows;

namespace MainPlugin.PressKey
{
    public partial class PressKey_ParamsDialog : Window
    {
        public PressKey_ParamsDialog()
        {
            InitializeComponent();
        }

        public object[] GetParameters()
        {
            return new object[] { this.TB.Text };
        }

        private void BT_Validate_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = true;
        }

        private void BT_Help_Click(object sender, RoutedEventArgs e)
        {
            string url = "https://docs.microsoft.com/fr-fr/dotnet/api/system.windows.forms.sendkeys.send?redirectedfrom=MSDN&view=netcore-3.1#remarques";
            MyFunctions.ProcessManager.RunPowerShellCommand("Start \"" + url + "\"");
        }
    }
}
