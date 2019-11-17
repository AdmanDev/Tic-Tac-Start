using System;
using System.Reflection;
using System.IO;
using System.Windows.Forms;

namespace Tic_Tac_Start
{
    [Serializable]
    public class Plugin
    {
        //Variables
        private string frenchName, englishName;
        private string dllPath;
        private string classe;
        private string methodName;
        private string parametersDialog;
        private string nameSpace;

        [NonSerialized] private Assembly pluginAssembly;
        [NonSerialized] private Type type;
        [NonSerialized] public MethodInfo mainMethod;
        [NonSerialized] private Type parametersDialogType;
        [NonSerialized] private string error;
        [NonSerialized] public static string dllS_Path = Application.StartupPath + @"\DLLs\";

        [NonSerialized] private MyFunctions.TranslateWords translate;

        //Properties
        public string Title { get { return translate.GetWord("title"); } }
        public string DllLocation { get { return dllPath; } }
        public string FrenchTitle { get { return frenchName; } }
        public string EnglishTitle { get { return englishName; } }
        public string MethodClass { get { return classe; } }
        public string MethodName { get { return methodName; } }
        public string ParametersWindow { get { return parametersDialog; } }
        public string Namespace { get { return nameSpace; } }

        //Constructors
        public Plugin()
        {
        }

        public Plugin(string _frenchName, string _englishName, string _dllPath, string _class, string _methodName, string _paramDialog)
        {
            if (_frenchName == "" || _frenchName == null)
                _frenchName = _englishName;
            if (_englishName == "" || _englishName == null)
                _englishName = _frenchName;

            //Set plugin informations
            frenchName = _frenchName;
            englishName = _englishName;
            classe = _class;
            methodName = _methodName;
            parametersDialog = _paramDialog;
            nameSpace = Path.GetFileNameWithoutExtension(_dllPath);

            //Create DLLs directories if exitsn't
            if (!Directory.Exists(dllS_Path))
                Directory.CreateDirectory(dllS_Path);

            //Copy the dll into DLLs folder
            dllPath = dllS_Path + Path.GetFileName(_dllPath);
            if (!File.Exists(dllPath))
            {
                File.Copy(_dllPath, dllPath, true);
            }

            //Load dll assembly (plugin)
            Initialize();

        }

        //Get plugin action
        public Action GetAction()
        {
            //Show a message and return if the plugin has an error
            if(error != "OK")
            {
                MessageBox.Show(error, "Tic-Tac-Start", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }

            //Show the parameters window of this plugin
            object _paramWindow;
            DialogResult result = DialogResult.None;

            //Crearz params window and show it
            _paramWindow = parametersDialogType.GetConstructor(new Type[0]).Invoke(null);
            if(_paramWindow is Form)
            {
                result = ((Form)_paramWindow).ShowDialog();
            }
            else if(_paramWindow is System.Windows.Window)
            {
                if (((System.Windows.Window)_paramWindow).ShowDialog() == true)
                {
                    result = DialogResult.OK;
                }
            }
            else
            {
                _paramWindow = null;
            }

            //If user has validated...
            if (result == DialogResult.OK)
            {
                //Get parameters and return the action
                object[] _params = (object[])parametersDialogType.GetMethod("GetParameters").Invoke(_paramWindow, null);
                return new Action(mainMethod, this.Title, _params);
            }

            return null;
        }

        //Determines if the plugin has error
        public bool HasPluginError()
        {
            //Assembly or the parameters window class name error
            if (pluginAssembly.GetType(nameSpace + "." + parametersDialog) == null)
            {
                error = "The '" + nameSpace + "' namespace or the '" + parametersDialog + "' parameters window class can not be found !";
                return true;
            }

            //error : the plugin contains not the "GetParameters" method
            if (pluginAssembly.GetType(nameSpace + "." + parametersDialog).GetMethod("GetParameters") == null)
            {
                error = "The 'GetParameters' method can not be found in your '" + parametersDialog + "' class !";
                return true;
            }

            //error : main class name
            if (pluginAssembly.GetType(nameSpace + "." + classe) == null)
            {
                error = "The '" + nameSpace + "' namespace or the '" + classe + "' class can not be found !";
                return true;
            }

            //error : the main method can not be found
            if (pluginAssembly.GetType(nameSpace + "." + classe).GetMethod(methodName) == null)
            {
                error = "The '" + methodName + "' method can not be found !";
                return true;
            }

            error = "OK"; //No error
            return false;
        }

        //Load assembly (plugin)
        public void Initialize()
        {
            //Set plugin language
            translate = new MyFunctions.TranslateWords();
            translate.AddWord("title", frenchName, englishName);

            //GetPath
            dllPath = dllS_Path + nameSpace + ".dll";

            //Load plugin
            pluginAssembly = Assembly.LoadFile(dllPath);

            //Determine if plugin has any error
            if (HasPluginError())
            {
                MessageBox.Show(error, "Tic-Tac-Start", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //Get main class type, main method and the type of parameters window
            type = pluginAssembly.GetType(nameSpace + "." + classe);
            mainMethod = type.GetMethod(methodName);
            parametersDialogType = pluginAssembly.GetType(nameSpace + "." + parametersDialog);

        }

    }
}
