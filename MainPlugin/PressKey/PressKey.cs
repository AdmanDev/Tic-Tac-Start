using System;

namespace MainPlugin.PressKey
{
    public static class PressKey
    {
        public static void Press(string keys)
        {
            System.Windows.Forms.SendKeys.SendWait(keys);
        }
    }
}
