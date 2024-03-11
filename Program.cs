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
    internal class Program
    {
        static async Task Main(string[] args)
        {
            var commandParser = new AcceptsLink();
            var youtubeClient = new YoutubeClient();
            var download = new DownloadsVideo();

            Console.WriteLine("Enter the command (info or download) followed by the YouTube video URL:");
            string input = Console.ReadLine();

            string[] inputParts = input.Split(' ');
            string command = inputParts[0];
            string videoUrl = inputParts[1];

            if (command == "info")
            {
                await commandParser.InfoCommand(youtubeClient, videoUrl);
            }
            else if (command == "download")
            {
                await download.DownloadCommand(youtubeClient, videoUrl);
            }
            else
            {
                Console.WriteLine("Invalid command. Please use 'info' or 'download'.");
            }
        }
    }
}
