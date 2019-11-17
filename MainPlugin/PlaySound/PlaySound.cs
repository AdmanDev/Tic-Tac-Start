using System.Media;

namespace MainPlugin.PlaySound
{
    public static class PlaySound
    {
        //Variables
        private static WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer();

        //The main function of this plugin (Play sound)
        public static void Play(string _soundPath, bool _loop)
        {
            if (string.IsNullOrEmpty(_soundPath))
                return;

            wplayer.URL = _soundPath;
            wplayer.settings.setMode("loop", _loop);
            wplayer.controls.play();
   
            //SoundPlayer sound = new SoundPlayer(_soundPath);

            //if (_loop)
            //    sound.PlayLooping();
            //else
            //    sound.Play();
        }
    }
}