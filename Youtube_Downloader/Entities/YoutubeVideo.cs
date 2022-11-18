using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Youtube_Downloader.Entities;
using YoutubeExplode;
using YoutubeExplode.Videos.Streams;

namespace Youtube_Downloader.Entities
{
    internal class YoutubeVideo
    {
        public string Link { get; private set; }
        //public string Title { get; private set; }
        //public string Author { get; private set; }
        //public TimeSpan? Duration { get; private set; }

        public YoutubeVideo()
        {
            Link = "";
        }

        public YoutubeVideo(string link)
        {
            Link = link;
        }

        public async void GetVideoInformation(Label lblTitle, Label lblAuthor, Label lblDuration)
        {
            YoutubeClient youtube = new YoutubeClient();

            var video = await youtube.Videos.GetAsync(Link);

            lblTitle.Text = video.Title.ToString();
            lblAuthor.Text = video.Author.ChannelTitle.ToString();
            lblDuration.Text = video.Duration.ToString();
        }

        public async void DownloadVideo(string pathToSave, EnumVideoFormat videoFormat)
        {
            YoutubeClient youtube = new YoutubeClient();

            var streamManifest = await youtube.Videos.Streams.GetManifestAsync(Link); // Checo os streams disponiveis no video

            if(videoFormat == EnumVideoFormat.MP4) // Verifico o formato selecionado
            {
                var streamInfo = streamManifest.GetMuxedStreams().GetWithHighestVideoQuality(); // Pego audio e video
                var stream = await youtube.Videos.Streams.GetAsync(streamInfo); // Pego a leitura do video
                await youtube.Videos.Streams.DownloadAsync(streamInfo, pathToSave);
            }
        }

        public bool CheckValidVideo(string link)
        {
            var youtube = new YoutubeClient();

            try
            {
                var video = youtube.Videos.GetAsync(link);
            }
            catch(Exception ex)
            {
                return false;
            }

            return true;
        }


    }
}
