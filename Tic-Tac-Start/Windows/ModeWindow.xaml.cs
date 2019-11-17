using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace Tic_Tac_Start
{
    public partial class ModeWindow : Window
    {
        //Variables
        private const string saveExtention = "TicTacMode";
        private string currModePath = "";
        private string typeOfMode;
        private Type[] typesOfParameters;
        private List<RadioButton> radiosMode = new List<RadioButton>();
        private List<Action> actions = new List<Action>();
        private bool isStarting = true;

        private readonly string pluginTutorialPath = System.Windows.Forms.Application.StartupPath + @"\How to create a plugin\" + "Créer un plugin Tic-Tac-Start.pdf";
        private readonly string pluginTutorielVideo = "https://youtu.be/ZcI9U90dVsA";

        //Controls
        private System.Windows.Forms.CheckedListBox CLB_Plugins;
        private System.Windows.Forms.OpenFileDialog OFD;
        private System.Windows.Forms.SaveFileDialog SFD;

        //Constructor
        public ModeWindow()
        {
            InitializeComponent();
            InitializeControls();

            radiosMode.Add(this.RB_Timer);
            radiosMode.Add(this.RB_StopWatch);
            radiosMode.Add(this.RB_ClockTime);

            //Type of parameters (in order) of an "TimerMode" object
            typesOfParameters = new Type[] { typeof(TimeSpan), typeof(List<Action>) };
        }

        private void InitializeControls()
        {
            //CLB_Plugins
            this.CLB_Plugins = new System.Windows.Forms.CheckedListBox()
            {
                CheckOnClick = true
            };
            this.CLB_Plugins.ItemCheck += CLB_Plugins_ItemCheck;
            this.WFH_CLB_Plugins.Child = this.CLB_Plugins;

            //OFD
            this.OFD = new System.Windows.Forms.OpenFileDialog()
            {
                DefaultExt = saveExtention
            };

            //SFD
            this.SFD = new System.Windows.Forms.SaveFileDialog()
            {
                DefaultExt = saveExtention
            };
        }

        //Load
        private void ModeWindow_Load(object sender, RoutedEventArgs e)
        {
            //Show plugins and load save
            ShowPlugins();
            LoadSave(Global.mainWindow.GetMode);

            isStarting = false;
        }

        //Load a configuration
        private void LoadSave(TimerMode _currMode)
        {
            //Mode
            Type _currType = _currMode.GetType();
            typeOfMode = _currType.Name;

            //Chek the radio button corresponding to the mode
            for (int i = 0; i < radiosMode.Count; i++)
            {
                if ("Tic_Tac_Start." + (string)radiosMode[i].Tag == _currType.FullName)
                {
                    radiosMode[i].IsChecked = true;
                    break;
                }
            }

            //Set the time value
            this.NUD_Hour.Value = _currMode.Value.Hours;
            this.NUD_Minute.Value = _currMode.Value.Minutes;
            this.NUD_second.Value = _currMode.Value.Seconds;

            //Plugins
            //Check the activated plugins
            actions = _currMode.actions;
            foreach (Action a in _currMode.actions)
            {
                int _index = this.CLB_Plugins.Items.IndexOf(a.name);
                this.CLB_Plugins.SetItemChecked(_index, true);
            }
        }

        //Get changes (TimerMode object)
        private TimerMode GetChange()
        {
            Type _type = Type.GetType("Tic_Tac_Start." + typeOfMode, true);


            object[] parameters = new object[]
            {
                new TimeSpan((int)this.NUD_Hour.Value, (int)this.NUD_Minute.Value, (int)this.NUD_second.Value),
                actions
            };

            return (TimerMode)_type.GetConstructor(typesOfParameters).Invoke(parameters);
        }

        //Set the new mode and close window
        private void BT_Finich_Click(object sender, RoutedEventArgs e)
        {
            Global.mainWindow.SetMode(GetChange());
            this.Close();
        }

        //Set the type of the selected timer mode
        private void SetTypeOfMode(object sender, RoutedEventArgs e)
        {
            RadioButton _rb = (RadioButton)sender;
            if (_rb.IsChecked == true)
            {
                typeOfMode = (string)_rb.Tag;
            }
        }

        //Open the adding of plugin window
        private void BT_AddPlugin_Click(object sender, RoutedEventArgs e)
        {
            if (new AddPluginWindow().ShowDialog() == true)
            {
                ShowPlugins();
            }
        }

        //Show plugins manager window
        private void BT_PluginsManagers_Click(object sender, RoutedEventArgs e)
        {
            new PluginsManagerWindow().ShowDialog();

            ShowPlugins();
        }

        //Show all plugins into the Checked list box
        private void ShowPlugins()
        {
            this.CLB_Plugins.Items.Clear();

            foreach (Plugin p in Global.plugins)
            {
                this.CLB_Plugins.Items.Add(p.Title);
            }
        }

        //Triggered when any plugin is checked or unchecked
        private void CLB_Plugins_ItemCheck(object sender, System.Windows.Forms.ItemCheckEventArgs e)
        {
            //If the window is starting, exit function
            if (isStarting)
                return;

            //if the plugin is checked...
            if (e.NewValue == System.Windows.Forms.CheckState.Checked)
            {
                //Get action of this plugin (with parameters)
                Action _action = Global.plugins[e.Index].GetAction();

                //If this action isn't null...
                if (_action != null)
                    actions.Add(_action); //...add this action to the actions list
                else
                    e.NewValue = System.Windows.Forms.CheckState.Unchecked; //else uncheck this plugin
            }
            else
            {
                //Search (by name) the action corresponding to the unchecked plugin
                foreach (Action a in actions)
                {
                    if (a.name == this.CLB_Plugins.Items[e.Index].ToString())
                    {
                        actions.Remove(a); //Remove the action from the actions list
                        break;
                    }

                }
            }
        }


        #region Menu

        private void Menu_CanExecute(object sender, System.Windows.Input.CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }

        //New configuration
        private void New_Executed(object sender, System.Windows.Input.ExecutedRoutedEventArgs e)
        {
            this.RB_Timer.IsChecked = true;

            this.NUD_Hour.Value = 0;
            this.NUD_Minute.Value = 0;
            this.NUD_second.Value = 0;
        }

        //Open a configuration save
        private void Open_Executed(object sender, System.Windows.Input.ExecutedRoutedEventArgs e)
        {
            if (this.OFD.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                TimerMode _saveLoaded = TimerMode.OpenSave(this.OFD.FileName);

                if (_saveLoaded != null)
                {
                    isStarting = true;
                    LoadSave(_saveLoaded);
                    isStarting = false;

                    currModePath = this.OFD.FileName;
                }

            }
        }

        //Save As...
        private void SaveAs_Executed(object sender, System.Windows.Input.ExecutedRoutedEventArgs e)
        {
            SaveAs();
        }
       
        //Save configuration
        private void Save_Executed(object sender, System.Windows.Input.ExecutedRoutedEventArgs e)
        {
            if (currModePath == "" || currModePath == null)
                SaveAs();
            else
                TimerMode.SaveMode(currModePath, GetChange());
        }

        //Save As...
        private void SaveAs()
        {
            if (this.SFD.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                TimerMode.SaveMode(this.SFD.FileName, GetChange());
            }
        }

        #endregion

        private void BT_PluginTutorial_Click(object sender, RoutedEventArgs e)
        {
            MyFunctions.ProcessManager.RunPowerShellCommand("Start \"" + pluginTutorialPath + "\"");
            MyFunctions.ProcessManager.RunPowerShellCommand("Start " + pluginTutorielVideo);
        }
    }
}
