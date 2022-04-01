using System;

namespace EventsAndDelegates // Note: actual namespace depends on the project name.
{
    public static class Program
    {
        static void Main(string[] args)
        {

            var video = new Video() { Title = "Video 1" };//first we instantiate the video here
            var videoEncoder = new VideoEncoder(); //publisher
            var mailService = new MailService(); //subscriber
            var MessageService = new MessageService();


            videoEncoder.VideoEncoded += mailService.OnvideoEncoded; //reference or pointer to mailService.OnVideoEncoded
            videoEncoder.VideoEncoded += MessageService.OnVideoEncoded;
            
            videoEncoder.Encode(video);


        }
    }
}