using System.Windows.Forms;

namespace MainPlugin.PlayVideo
{
    public partial class PlayVideo : Form
    {
        public PlayVideo()
        {
            InitializeComponent();
        }

        public static void Play(string videoPath)
        {
            PlayVideo playVideo = new PlayVideo();
            playVideo.WMP_Video.URL = videoPath;
            playVideo.Show();
        }
    }
}
