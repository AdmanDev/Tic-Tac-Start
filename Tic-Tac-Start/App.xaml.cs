using System;
using System.Windows;

namespace Tic_Tac_Start
{
    public partial class App : Application
    {
        private void Application_Startup(object sender, StartupEventArgs e)
        {
            Global.OnApplicationStart();

            Global.mainWindow = new MainWindow();
            Global.mainWindow.Show();
        }
    }
}
