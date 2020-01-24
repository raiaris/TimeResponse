using System;
namespace SolucionarApi.Models
{
    public class Body
    {
        private double duration;
        private long timestamp;
        public Body()
        {
        }

        public double    _duration   { get => duration; set => duration = value; }
        public long _timestamp { get => timestamp; set => timestamp = value; }
        
    }
}