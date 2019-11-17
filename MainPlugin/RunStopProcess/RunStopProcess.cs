namespace MainPlugin.RunStopProcess
{
    public static class RunStopProcess
    {
        //Main function of this plugin (run / stop a process)
        public static void RunStop(string process, bool run)
        {
            if (process == "" || process == null)
                return;

            if (run)
                Util.RunPowerShellCommand("Start \"" + process + "\"", false);
            else
                Util.KillProc(process, true);
        }
    }
}
