using AngleSharp.Common;
using Youtube_Downloader.Entities;

namespace Youtube_Downloader
{
    public partial class FrmPrincipal : Form
    {
        YoutubeVideo youtubeVideo = new YoutubeVideo();

        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void TxtLink_TextChanged(object sender, EventArgs e)
        {
            if (youtubeVideo.CheckValidVideo(TxtLink.Text))
            {
                youtubeVideo = new YoutubeVideo(TxtLink.Text);

                youtubeVideo.GetVideoInformation(LblVideoTitle, LblAuthorTxt, LblDurationOut, TxtDescricao);

                //LblVideoTitle.Text = youtubeVideo.Title;
                //LblDurationOut.Text = youtubeVideo.Duration.ToString();
            }
        }

        private void TxtLink_Leave(object sender, EventArgs e)
        {

        }

        private void BtnDownload_Click(object sender, EventArgs e)
        {
            int selected = CbxFormats.SelectedIndex;

            EnumVideoFormat videoFormat = selected == 0 ? EnumVideoFormat.MP4 : EnumVideoFormat.MP3;

            if (videoFormat == EnumVideoFormat.MP4)
            {
                SaveFileDialog saveDialog = new SaveFileDialog();
                saveDialog.Filter = "MP4 Files | *.mp4";
                saveDialog.DefaultExt = "mp4";
                saveDialog.Title = "Select path to save";
                string path = "";
                if(saveDialog.ShowDialog() == DialogResult.OK)
                {
                    path = saveDialog.FileName;
                }
                else
                {
                    return;
                }

                youtubeVideo.DownloadVideo(path, videoFormat);
            }
            else
            {
                SaveFileDialog saveDialog = new SaveFileDialog();
                saveDialog.Filter = "MP3 Files | *.mp3";
                saveDialog.DefaultExt = "mp3";
                saveDialog.Title = "Select path to save";
                string path = "";
                if (saveDialog.ShowDialog() == DialogResult.OK)
                {
                    path = saveDialog.FileName;
                }
                else
                {
                    return;
                }

                youtubeVideo.DownloadVideo(path, videoFormat);
            }
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            CbxFormats.SelectedIndex = 0;
            frmMenu1.formLoaded();
        }
    }
}