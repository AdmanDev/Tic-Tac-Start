using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Forms;
using MessageBox = System.Windows.Forms.MessageBox;

namespace Tic_Tac_Start
{
    public partial class PluginsManagerWindow : Window
    {
        //Variables
        private List<Plugin> plugins;
        private List<Plugin> pluginsToRemove;

        //Controls
        private CheckedListBox CLB_Plugins;

        //Constructor
        public PluginsManagerWindow()
        {
            InitializeComponent();
            InitializeControls();

            plugins = Global.plugins;
            ShowPlugins();
        }

        private void InitializeControls()
        {
            //CLB_Plugins
            this.CLB_Plugins = new CheckedListBox()
            {
                CheckOnClick = true
            };
            this.CLB_Plugins.ItemCheck += CLB_Plugins_ItemCheck;
            this.WFH_CLB_Plugins.Child = this.CLB_Plugins;
        }

        //Show plugins in the Chhecked Lis Box
        private void ShowPlugins()
        {
            pluginsToRemove = new List<Plugin>();

            this.CLB_Plugins.Items.Clear();
            foreach (Plugin plug in plugins)
            {
                if (plug.Namespace != "MainPlugin")
                    this.CLB_Plugins.Items.Add(plug.Title);
            }
        }

        //Delete the selected plugins
        private void BT_Delete_Click(object sender, RoutedEventArgs e)
        {
            if (this.CLB_Plugins.CheckedIndices.Count <= 0)
                return;

            //Confirmation
            if (MessageBox.Show("Êtes-vous sûr de vouloir supprimer les plugins séléctionnés ?", "Tic-Tac-Start", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                foreach (Plugin plug in pluginsToRemove)
                {
                    if (!IsMainPlugin(plug))
                        plugins.Remove(plug);
                }

                Global.Save();
                ShowPlugins();
            }
        }

        //Edit a plugin
        private void BT_Edit_Click(object sender, RoutedEventArgs e)
        {
            if (this.CLB_Plugins.CheckedIndices.Count <= 0)
                return;

            Plugin pluginToEdit = plugins[(int)this.CLB_Plugins.CheckedIndices[0]];

            if (IsMainPlugin(pluginToEdit))
                return;

            if (new AddPluginWindow(pluginToEdit).ShowDialog() == true)
                ShowPlugins();
        }

        //Determines if the followed plugin is a main plugin
        private bool IsMainPlugin(Plugin _plugin)
        {
            if (_plugin.Namespace == "MainPlugin")
            {
                MessageBox.Show("Vous ne pouvez pas supprimer ou éditer un plugin de base !" + Environment.NewLine + "\"" + _plugin.Title + "\"", "Tic-Tac-Start", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }

            return false;
        }

        //Get selected plugins
        private void CLB_Plugins_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.NewValue == CheckState.Checked)
            {
                pluginsToRemove.Add(plugins[e.Index]);
            }
            else
            {
                pluginsToRemove.Remove(plugins[e.Index]);
            }
        }

    }
}
