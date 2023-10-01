
namespace Entidades
{
    public partial class operacion
    {
        private numeracion primerOperando ;
        private numeracion segundoOperando ;

        private numeracion PrimerOperando
        {
            get{return primerOperando;}
            set { primerOperando = value;}
        }
        private numeracion SegundoOperando
        {
            get { return segundoOperando; }
            set { segundoOperando = value; }
        }
        public void Operacion(numeracion primerOperando, numeracion segundoOperando)
        {



        }
        public numeracion Operar(char operador)
        {
            ;



           return retorno;
        }

    }
}