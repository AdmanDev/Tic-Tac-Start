using System.Windows;
using System.Windows.Controls;
using MyFunctions;

namespace Tic_Tac_Start
{
    public partial class WindowHeader : UserControl
    {
        //Variables
        private Window w; //The window of this control

        private WPF_ADMANMenu admanMenu;
        private const string featurePage = "https://admansoftware.wordpress.com/2015/08/31/tic-tac-start/";

        //Constructor
        public WindowHeader()
        {
            InitializeComponent();
            admanMenu = new WPF_ADMANMenu(featurePage);
        }

        //On load
        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            w = Window.GetWindow(this);

            if (w != null)
                this.LB_Title.Text = w.Title;
        }

        //Close the window or the application
        private void BT_Close_Click(object sender, RoutedEventArgs e)
        {
            if (w == Global.mainWindow)
                Application.Current.Shutdown();
            else
                w.Close();
        }

        //Move the window
        private void Grid_Header_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            w.DragMove();
        }

        //Show ADMAN Software-FR menu
        private void BT_ADMANSoftware_Click(object sender, RoutedEventArgs e)
        {
            admanMenu.ShowMenu();
        }

        private void BT_Minimize_Click(object sender, RoutedEventArgs e)
        {
            w.WindowState = WindowState.Minimized;
        }
    }
}
