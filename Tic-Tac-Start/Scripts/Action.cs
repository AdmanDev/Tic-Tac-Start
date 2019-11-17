using System;
using System.Reflection;

namespace Tic_Tac_Start
{
    [Serializable]
    public class Action
    {
        //Variables
        [NonSerialized] private MethodInfo method;
        private object[] parameters;
        public string name;

        //Constructors
        public Action()
        {
            
        }

        public Action(MethodInfo _method, string _name, params object[] _parameters)
        {
            //Set action infos
            method = _method;
            name = _name;
            parameters = _parameters;
        }

        //Execute the main method of the plugin
        public object ExecutePlugin()
        {
            return method.Invoke(null, parameters);
        }

        //Get the main method with plugin name
        public void Initialize()
        {
            foreach (Plugin plug in Global.plugins)
            {
                if(plug.Title == name)
                {
                    method = plug.mainMethod;
                }
            }
        }

    }
}
