namespace MainPlugin.ShutDown_Restart_PC
{
    public static class ShutDown_Restart_PC
    {
        //Main function of this plugin (ShutDown / Restart computer)
        public static void ShutDown_Restart(bool shutDown)
        {
            if (shutDown)
                Util.RunPowerShellCommand("shutdown -s -t 0", false); //Shut down computer
            else
                Util.RunPowerShellCommand("shutdown -r -t 0", false); //Restart computer
        }
    }
}
