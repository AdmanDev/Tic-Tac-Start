using System;
using System.Windows;

namespace Tic_Tac_Start
{
    public partial class AddPluginWindow : Window
    {
        //Variables
        private bool editMode;
        private Plugin pluginToEdit;

        //Controls
        private System.Windows.Forms.OpenFileDialog OFD;

        //Constructor
        public AddPluginWindow()
        {
            InitializeComponent();
            InitializeControls();

            editMode = false;
        }

        public AddPluginWindow(Plugin _pluginToEdit)
        {
            InitializeComponent();
            InitializeControls();

            editMode = true;
            pluginToEdit = _pluginToEdit;

            this.TB_DllPath.Text = _pluginToEdit.DllLocation;
            this.TB_ActionName.Text = _pluginToEdit.FrenchTitle;
            this.TB_ActionName_English.Text = _pluginToEdit.EnglishTitle;
            this.TB_MethodClass.Text = _pluginToEdit.MethodClass;
            this.TB_MethodName.Text = _pluginToEdit.MethodName;
            this.TB_ParamsDialog.Text = _pluginToEdit.ParametersWindow;

            this.BT_AddPlugin.Content = "OK";
        }

        private void InitializeControls()
        {
            //OFD
            this.OFD = new System.Windows.Forms.OpenFileDialog()
            {
                AddExtension = true,
                CheckFileExists = true,
                CheckPathExists = true,
                DefaultExt = "dll",
                Filter = "|*.dll",
                Title = "Séléctionnez le .dll de votre plugin..."
            };
        }

        //Choose a DLL (plugin)
        private void BT_ChooseDLL_Click(object sender, RoutedEventArgs e)
        {
            if (this.OFD.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.TB_DllPath.Text = this.OFD.FileName;

                //Warning if the dll exists already in the DLLs folder
                if (System.IO.File.Exists(Plugin.dllS_Path + this.OFD.SafeFileName))
                    MessageBox.Show("Close the software then copy and paste the new version of your dll into the following directory : " + Environment.NewLine + Plugin.dllS_Path, "Tic-Tac-Start", MessageBoxButton.OK, MessageBoxImage.Exclamation);

            }
        }

        //Add a new plugin
        private void BT_AddPlugin_Click(object sender, RoutedEventArgs e)
        {
            //Get plugin informations
            string _dll = this.TB_DllPath.Text;
            string _frenchName = this.TB_ActionName.Text;
            string _englishName = this.TB_ActionName_English.Text;
            string _class = this.TB_MethodClass.Text;
            string _method = this.TB_MethodName.Text;
            string _paramsDialog = this.TB_ParamsDialog.Text;

            if (_dll == "" || _frenchName == "" || _class == "" || _method == "" || _paramsDialog == "")
                return;

            //Create a new instance of "Plugin" with these infomations
            Plugin _newPlugin = new Plugin(_frenchName, _englishName, _dll, _class, _method, _paramsDialog);

            //If the plugin has not error...
            if (!_newPlugin.HasPluginError())
            {
                //Add to plugins list
                if (editMode)
                {
                    int index = Global.plugins.IndexOf(pluginToEdit);
                    Global.plugins[index] = _newPlugin;
                }
                else
                {
                    Global.plugins.Add(_newPlugin);
                }

                //Save change
                Global.Save();
                this.DialogResult = true;
            }
        }

    }
}
