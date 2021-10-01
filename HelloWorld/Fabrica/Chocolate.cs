namespace Fabrica
{
    public class Chocolate
    {
        private string tipo;
        public float PorcentagemDeCacau { 
            get 
            {
                return 100 - PorcentagemDeAcucar;
            }
            private set { }
        }

        public float PorcentagemDeAcucar { get; set; }
        public string Tipo
        {
            get
            {
                return tipo;
            }
            set
            {
                tipo = value;
            }
        }

    }
}