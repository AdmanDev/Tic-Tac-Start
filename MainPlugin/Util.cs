using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Management.Automation;
using System.Management.Automation.Runspaces;
using System.IO;
using System.Windows.Forms;

namespace MainPlugin
{
    public static class Util
    {
        //Properties
        public static OpenFileDialog OFD { get; } = new OpenFileDialog()
        {
            Title = "Sélectionnez un fichier..."
        };

        //Stop a Window process
        public static void KillProc(string name, bool force)
        {
            System.Diagnostics.Process[] prc = System.Diagnostics.Process.GetProcessesByName(name);

            foreach (System.Diagnostics.Process p in prc)
            {
                if(force)
                {
                    p.Kill();
                    p.Close();
                }
                else
                {
                    p.CloseMainWindow();
                    p.Close();
                }
            }
        }

        //Run a PowerShell command
        public static List<object> RunPowerShellCommand(string script, bool stronglyString)
        {
            List<Object> list = new List<object>();
            Collection<PSObject> collection2;
            //  PSObject obj;
            Pipeline pipeline;
            Runspace runspace = RunspaceFactory.CreateRunspace();
            runspace.Open();
            pipeline = runspace.CreatePipeline();
            pipeline.Commands.AddScript(script);

            if (stronglyString)
                pipeline.Commands.Add("Out-String");
            collection2 = pipeline.Invoke();
            if (stronglyString)
            {
                System.Text.StringBuilder builder = new System.Text.StringBuilder();
                foreach (PSObject obj in collection2)
                {
                    if (builder.Length > 0)
                    {
                        builder.Append(obj.ToString());
                    }
                    else
                    {
                        builder.AppendLine(obj.ToString());
                    }
                }
                list = new List<object>(System.Linq.Enumerable.Cast<object>(builder.ToString().Split(Environment.NewLine.ToCharArray())));
            }
            else
            {
                foreach (PSObject obj in collection2)
                {
                    list.Add(obj.ImmediateBaseObject);
                }
            }

            return list;
        }

    }
}
