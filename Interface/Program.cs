using Interface.Interfaces;
using System;

namespace Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            /*   var processor = new PhotoProcessor();
               var filter = new PhotoFilters();
               System.Action<Photo> filterHandler = filter.ApplyBrightness;
               filterHandler += filter.ApplyContrast;
               filterHandler += RemoveRedEye;
               processor.Process("photo.jpg",filterHandler);*/


            var encoder = new VideoEncoder();
            encoder.RegisterNotificationChannel(new MailNotificationChannel());
            encoder.RegisterNotificationChannel(new SmsNotificationChannel());

            encoder.Encode(new Video());
        }

        static void RemoveRedEye(Photo photo)
        {
            Console.WriteLine("Removing Red Eyes");
        }
    }
}
