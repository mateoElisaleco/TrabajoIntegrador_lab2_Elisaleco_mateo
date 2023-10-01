namespace Entidades
{
    public partial class numeracion
    {
        public enum ESistema { Decimal, Binario };
        private ESistema sistema;
        private double valorNumerico;

        private ESistema Sistema
        {
            get { return sistema; }

        }

        private string Valor
        {
            get { return valorNumerico.ToString(); }

        }
        private double BinarioADecimal(string valor)
        {
            double retorno = 0;


            return retorno;
        }

        public string ConvertirA(ESistema sistema)
        {
            string retorno = "";


            return retorno;
        }

        private string DecimalABinario(int valor)
        {
            string retorno = "";


            return retorno;
        }

        private int DecimalABinario(string valor)
        {
            int retorno = 0;


            return retorno;
        }

        private bool EsBinario(string valor)
        {
            bool retorno = false;


            return retorno; 

        }

        private void InicializarValores(string valor, ESistema sistema)
        {


        }
        public void Numeracion(double valor,ESistema sistema)
        {



        }
        public void Numeracion(string valor, ESistema sistema)
        {



        }


    }
}