using System;
namespace SolucionarApi.Models
{
    public class Resposta
    {
        public double Sum { get; set; }
        public double Avg { get; set; }
        public double Max { get; set; }
        public double Min { get; set; }
        public long Count { get; set; }

        public Resposta(double sum, double avg, double max, double min, long count)
        {
            Sum = sum;
            Avg = avg;
            Max = max;
            Min = min;
            Count = count;
        }
    }
}