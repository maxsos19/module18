using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoutubeExplode;
using YoutubeExplode.Videos;
using YoutubeExplode.Exceptions;
using System.IO;

namespace AnApplicationForDownloadingVideosFromYouTube
{
    class AcceptsLink
    {
        public async Task InfoCommand(YoutubeClient youtubeClient, string videoUrk)
        {
            try
            {
                var video = await youtubeClient.Videos.GetAsync("https://youtu.be/GMeF4DJaSxs?si=5pg_aaNv_kgRB0Nq");
                Console.WriteLine($"Title: {video.Title}");
                Console.WriteLine($"Description: {video.Description}");
            }
            catch (YoutubeExplodeException e)
            {
                Console.WriteLine($"Error: {e.Message}");
            }
        }
    }
}
