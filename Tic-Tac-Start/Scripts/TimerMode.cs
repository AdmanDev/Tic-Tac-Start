using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Tic_Tac_Start
{
    [Serializable]
    public abstract class TimerMode
    {
        //Variables
        protected TimeSpan currTime;
        protected TimeSpan actionsTime;
        public List<Action> actions;

        //Properties
        public TimeSpan CurrentTime { get { return currTime; } }
        public TimeSpan ActionsTime { get { return actionsTime; } }
        public TimeSpan Value { get; protected set; }

        //Abstract functions
        public abstract TimeSpan UpdateTimer(); //Determines how the timer is updated each seconds

        //Executes all actions...
        public  void StartActions()
        {
            //...if it's action time
            if (actionsTime.Equals(currTime))
            {
                foreach (Action a in actions)
                {
                    a.ExecutePlugin();
                }
            }
        }

        //Save this configuration
        public static void SaveMode(string _path, TimerMode _mode)
        {
            FileStream fs = File.Create(_path);
            new BinaryFormatter().Serialize(fs, _mode);

            fs.Close();
        }

        //Open a save
        public static TimerMode OpenSave(string _path)
        {
            TimerMode _result = null;

            if (File.Exists(_path))
            {
                FileStream fs = File.OpenRead(_path);
                BinaryFormatter sz = new BinaryFormatter();
                _result = (TimerMode)sz.Deserialize(fs);

                fs.Close();
            }

            return _result;
        }

    }

    [Serializable]
    public class DefaultTimerMode : TimerMode
    {
        //Constructors
        public DefaultTimerMode()
        {
        }

        public DefaultTimerMode(TimeSpan _actionsTime, List<Action> _actions)
        {
            currTime = new TimeSpan(0, 0, 0);
            actionsTime = Value = _actionsTime;
            actions = _actions;
        }

        //Update current time
        public override TimeSpan UpdateTimer()
        {
            currTime = currTime.Add(new TimeSpan(0, 0, 1));
            StartActions();
            return currTime;
        }
    }

    [Serializable]
    public class StopWatchTimerMode : TimerMode
    {
        //Constructors
        public StopWatchTimerMode()
        {
        }

        public StopWatchTimerMode(TimeSpan _actionTime, List<Action> _actions)
        {
            currTime = Value = _actionTime;
            actions = _actions;
        }

        //Update current time
        public override TimeSpan UpdateTimer()
        {
            currTime = currTime.Add(new TimeSpan(0, 0, -1));
            StartActions();
            return currTime;
        }
    }

    [Serializable]
    public class AlarmClockTimerMode : TimerMode
    {
        //Constructors
        public AlarmClockTimerMode()
        {
        }

        public AlarmClockTimerMode(TimeSpan _actionTime, List<Action> _actions)
        {
            actionsTime = Value = _actionTime;
            actions = _actions;
        }

        //Update current time
        public override TimeSpan UpdateTimer()
        {
            DateTime _time = DateTime.Now;
            currTime = new TimeSpan(_time.Hour, _time.Minute, _time.Second);
            StartActions();
            return currTime;
        }
    }
}
