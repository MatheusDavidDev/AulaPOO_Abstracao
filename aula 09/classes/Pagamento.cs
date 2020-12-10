using System;
namespace aula_09classes
{
    public abstract class Pagamento
    {
        //Atributos
        private DateTime data;

        protected float valor;


        //Metodos

        public string Cancelar(){
            return "";
        }

        //Obrigatorio por ser abistrato
         public abstract string Desconto(int valor);

    }  
}