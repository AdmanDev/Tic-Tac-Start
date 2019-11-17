using System;
using System.IO;
using System.Collections.Generic;                                                                                                                                                            
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace Tic_Tac_Start
{
    public static class Global
    {
        /******************************************VARIABLES************************************/
        public static MainWindow mainWindow;
        public static System.Globalization.CultureInfo cultureInfo;
        public static AppSettings appSettings;
        public static List<Plugin> plugins = new List<Plugin>();

        private static string appSettings_Path = System.Windows.Forms.Application.StartupPath + @"\AppSettings.bin";


        /******************************************FUNCTIONS************************************/

        //When this application is starting...
        public static void OnApplicationStart()
        {
            MyFunctions.UpdateManager.CheckUpdate();
            appSettings = AppSettings.OpenSettings(appSettings_Path);
            plugins = appSettings.plugins;
        }


        //Clone an object
        public static T Clone<T>(T source)
        {
            if (!typeof(T).IsSerializable)
            {
                throw new ArgumentException("The type must be serializable.", "source");
            }

            // Don't serialize a null object, simply return the default for that object
            if (Object.ReferenceEquals(source, null))
            {
                return default(T);
            }

            IFormatter formatter = new BinaryFormatter();
            Stream stream = new MemoryStream();
            using (stream)
            {
                formatter.Serialize(stream, source);
                stream.Seek(0, SeekOrigin.Begin);
                T tobj = (T)formatter.Deserialize(stream);

                if (source is TimerMode)
                {
                    //Initialize each actions
                    foreach (Action act in (tobj as TimerMode).actions)
                    {
                        act.Initialize();
                    } 
                }
                    

                return tobj;
            }
        }

        //Save settings
        public static void Save()
        {
            AppSettings.Save(appSettings_Path, appSettings);
            Properties.Settings.Default.Save();
        }
    }
}
