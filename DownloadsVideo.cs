using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoutubeExplode;
using YoutubeExplode.Videos;
using YoutubeExplode.Exceptions;
using System.IO;
using YoutubeExplode.Converter;

namespace AnApplicationForDownloadingVideosFromYouTube
{
    internal class DownloadsVideo
    {
        public async Task DownloadCommand(YoutubeClient youtubeClient, string videoUrl)
        {
            try
            {
                string outputFilePath = Path.Combine(Environment.CurrentDirectory, "video.mp4");
                var video = await youtubeClient.Videos.GetAsync(videoUrl);
                await youtubeClient.Videos.DownloadAsync(videoUrl, outputFilePath, builder => builder.SetPreset(ConversionPreset.UltraFast));
                Console.WriteLine("Video downloaded successfully.");
            }
            catch (YoutubeExplodeException e)
            {
                Console.WriteLine($"Error: {e.Message}");
            }
        }
    }
}
