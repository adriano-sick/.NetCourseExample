using System;

namespace Entities
{
    public class Chocolate
    {
        public string Id { get; set; }
        public string Tipo { get; set; }
        public float PercentualCacau { get; set; }
        public float PercentualAcucar { get; set; }
        public float PercentualLeite { get; set; }
        public float PercentualManteiga { get; set; }
        public string OrigemCacau { get; set; }
        public int Temperatura { get; set; }
        public bool Temperado { get; set; }
    }
}
