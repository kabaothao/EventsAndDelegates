using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsAndDelegates
{
    public class VideoEncoder
    {
        // 1. Define a delegate
        // 2. Define an event based on that delegate
        // 3. Raise the event 

        //public delegate void VideoEncodedEventHandler(object source, VideoEventArgs args);
        //public event VideoEncodedEventHandler VideoEncoded;
        //To raise an event we need a method that is responsible for that.

        //EventHandler
        //EventHandler<TEventArgs> we can use this delegate insead of creating a custom delegate

        public event EventHandler<VideoEventArgs> VideoEncoded;

        //public event EventHandler VideoEncoding;


        // this EventHandler<VideoEventArgs> is the same as public delegate void VideoEncodedEventHandler(object source, VideoEventArgs args);

        public void Encode(Video video)
        {
            Console.WriteLine("Encoding Video..."); //log a message to the console
            Thread.Sleep(3000);

            OnVideoEncoded(video);
        }



        protected virtual void OnVideoEncoded(Video video)
        {
            if (VideoEncoded != null)
                VideoEncoded(this, new VideoEventArgs() { Video = video });
        }
    }
}
