using System;

namespace EventandDelegateExample
{
    class Program
    {
        static void Main(string[] args)
        {
           var video=new Video() { Title = "Video 1" };
            var videoEncoder = new VideoEncoder();
            

            MessageService ms = new MessageService();
            videoEncoder.VideoEncoded += ms.onVideoEncoded;

            videoEncoder.Encode(video);
        }
    }

    public class MessageService
    {
        public void onVideoEncoded(object sender,EventArgs e)
        {
            Console.WriteLine("Message sending....");
        }
    }
}
