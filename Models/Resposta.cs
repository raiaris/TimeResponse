using System;
namespace SolucionarApi.Models
{
    public class Resposta
    {
        private double Sum;
        private double Avg;
        private double Max;
        private double Min;
        private long Count;

        public Resposta(double sum,double avg, double max, double min,long count)
        {
            _Sum = sum;
            _Avg = avg;
            _Max = max;
            _Min = min;
            _Count = count;

        }

        public double  _Sum   { get => Sum; set =>Sum  = value; }
        public double  _Avg   { get => Avg; set => Avg = value; }
        public double  _Max   { get => Max; set => Max = value; }
        public double  _Min   { get => Min; set => Min = value; }
        public long  _Count   { get => Count; set => Count = value; }
       



    }
}