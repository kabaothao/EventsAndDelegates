using System;

namespace EventsAndDelegates // Note: actual namespace depends on the project name.
{
    public class Program
    {
        static void Main(string[] args)
        {

            var video = new Video() { Title = "Video 1" };//first we instantiate the video here
            var videoencoder = new VideoEncoder();

            videoEncoder.Encode(video); //then we instantiate the video encoder and finally we call the encode method, passing the video object.
        }
    }
}