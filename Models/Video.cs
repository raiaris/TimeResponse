using System;
namespace SolucionarApi.Models
{
    public class Video
    {
     
        private string Link;
        private double Duration;
       

        public Video()
        {
        }

        public string _Link { get => Link; set => Link = value; }
        public double _Duration { get => Duration; set => Duration = value; }

    }
}