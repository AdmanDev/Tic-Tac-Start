using MainPlugin.AutoClicker.Modes;
using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace MainPlugin.AutoClicker
{
    public partial class AutoClicker_ParamsDialog : Window
    {
        //Variables
        private IClickMode clickMode;

        //Constructor
        public AutoClicker_ParamsDialog()
        {
            InitializeComponent();

            clickMode = new ClickPointMode();
            this.GB_ModeParams.Content = clickMode;
        }

        public object[] GetParameters()
        {
            ModeParameters parames = clickMode.GetParameters();
            return new object[] { parames.pointsToClick, parames.ClickInterval, parames.NumberOfRepeats };
        }

        private void BT_OK_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = true;
        }

        private void RB_Mode_Checked(object sender, RoutedEventArgs e)
        {
            if(this.GB_ModeParams == null)
            {
                return;
            }

            RadioButton rb = (RadioButton)sender;
            string modeString = rb.Tag.ToString();

            switch (modeString)
            {
                case "ClicksProgram":
                    this.GB_ModeParams.Content = clickMode = new ClicksProgramMode();
                    break;

                default:
                    this.GB_ModeParams.Content = clickMode = new ClickPointMode();
                    break;
            }
            
        }
    }
}
