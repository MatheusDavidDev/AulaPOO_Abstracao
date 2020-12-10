using System;
using aula_09classes;

namespace aula_09
{
    class Program
    {
        static void Main(string[] args)
        {
            Boleto boleto = new Boleto();
            
            boleto.Desconto(10);

            Cartao cartao = new Cartao();

            cartao.Desconto(0);

            
            

            
        }
    }
}
