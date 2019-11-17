using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Tic_Tac_Start
{
    [Serializable]
    public class AppSettings
    {
        //Variables
        public List<Plugin> plugins;

        //Constructors
        public AppSettings()
        {
            //Set variables
            plugins = new List<Plugin>();
        }

        public AppSettings(string _language, List<Plugin> _plugins)
        {
            //Set variables
            plugins = _plugins;
        }

        //Save settings
        public static void Save(string _path, AppSettings _settings)
        {
            FileStream fs = File.Create(_path);
            new BinaryFormatter().Serialize(fs, _settings);

            fs.Close();
        }

        public static AppSettings OpenSettings(string _path)
        {
            AppSettings _result = new AppSettings();

            if (File.Exists(_path))
            {
                FileStream fs = File.OpenRead(_path);
                BinaryFormatter sz = new BinaryFormatter();
                _result = (AppSettings)sz.Deserialize(fs);

                fs.Close();
            }

            //Initialize each plugins
            foreach (Plugin p in _result.plugins)
            {
                p.Initialize();
            }

            return _result;

        }
    }
}
