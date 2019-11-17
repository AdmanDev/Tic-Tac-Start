using System;
using System.Windows;
using System.Windows.Forms;

namespace Tic_Tac_Start
{
    public partial class MainWindow : Window
    {
        //Variables
        private TimerMode timerMode;
        private TimerMode initialeTimerMode;
        private bool timerIsWorking;

        //Controls
        private Timer TM_WindowsTime;
        private Timer MainTimer;
        private NotifyIcon NT_StopDiscreteMode;

        //Properties
        public TimerMode GetMode { get => timerMode; }

        //Constructor
        public MainWindow()
        {
            InitializeComponent();
            IntitalizeControls();

            //Set the default mode
            SetMode(new DefaultTimerMode(new TimeSpan(), new System.Collections.Generic.List<Action>()));
            timerIsWorking = false;
        }

        private void IntitalizeControls()
        {
            //TM_WindowsTime
            this.TM_WindowsTime = new Timer() { Interval = 1000, Enabled = true };
            this.TM_WindowsTime.Tick += TM_WindowsTime_Tick;

            //MainTimer
            this.MainTimer = new Timer() { Interval = 1000, Enabled = false };
            this.MainTimer.Tick += MainTimer_Tick;

            //NT_StopDiscreteMode
            this.NT_StopDiscreteMode = new NotifyIcon()
            {
                Visible = true,
                Icon = Properties.Resources.Logo_ICON
            };
            this.NT_StopDiscreteMode.DoubleClick += NT_StopDiscreteMode_DoubleClick;
        }

        //Display the Windows time (each 1 second)
        private void TM_WindowsTime_Tick(object sender, EventArgs e)
        {
            this.LB_WindowTime.Content = DateTime.Now.ToLongTimeString();
        }

        //Start or stop the timer
        private void BT_StartStop_Click(object sender, RoutedEventArgs e)
        {
            if (timerIsWorking)
            {
                //Stop timer
                this.MainTimer.Stop();
                this.BT_StartStop.Content = "Start";
                this.BT_Reset.IsEnabled = true;
            }
            else
            {
                //Start timer
                this.MainTimer.Enabled = true;
                this.MainTimer.Start();
                this.BT_StartStop.Content = "Stop";
                this.BT_Reset.IsEnabled = false;
            }

            timerIsWorking = !timerIsWorking;
        }

        //Main timer tick function (triggered each 1 second)
        private void MainTimer_Tick(object sender, EventArgs e)
        {
            //Update current timer time
            timerMode.UpdateTimer();
            DisplayCurrentTime();

            //Prevent negative time
            if (timerMode.CurrentTime.Equals(new TimeSpan(0, 0, 0)))
            {
                //Stop timer and reset
                BT_StartStop_Click(sender, null);
                BT_Reset_Click(sender, null);
            }
        }

        //Display timer time
        private void DisplayCurrentTime()
        {
            this.LB_HoursDisplayer.Content = timerMode.CurrentTime.Hours.ToString();
            this.LB_MinutesDisplayer.Content = timerMode.CurrentTime.Minutes.ToString();
            this.LB_SecondsDisplayer.Content = timerMode.CurrentTime.Seconds.ToString();
        }

        //Reset the timer
        private void BT_Reset_Click(object sender, RoutedEventArgs e)
        {
            SetMode(initialeTimerMode);
        }

        //Set the timer mode
        public void SetMode(TimerMode _mode)
        {
            initialeTimerMode = Global.Clone<TimerMode>(_mode);
            timerMode = Global.Clone<TimerMode>(_mode);
            DisplayCurrentTime();
        }

        //Open the mode window
        private void BT_Mode_Click(object sender, RoutedEventArgs e)
        {
            new ModeWindow().Show();
        }

        #region Menu

        //Top most
        private void CBB_TopMost_CheckedChanged(bool newValue)
        {
            this.Topmost = newValue;
        }

        //Activate the "discrete mode"
        private void CBB_DiscreteMode_Click(object sender, RoutedEventArgs e)
        {
            this.Visibility = Visibility.Hidden;
            this.ShowInTaskbar = false;

            this.NT_StopDiscreteMode.ShowBalloonTip(10, "Tic-Tac-Start", "Le logiciel travail en arrière-plan.", ToolTipIcon.Info);
        }

        #endregion

        //Stop the "discrete mode"
        private void NT_StopDiscreteMode_DoubleClick(object sender, EventArgs e)
        {
            this.Visibility = Visibility.Visible;
            this.ShowInTaskbar = true;
        }

    }
}
