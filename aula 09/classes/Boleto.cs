using System;
namespace aula_09classes
{
    public class Boleto : Pagamento
    {
        private string codigoDeBarras;

        private DateTime dataDoPagamento;

        public void Registrar(){

            Console.WriteLine("Registrado");
        }

        public override string Desconto(int valor)
        {
            return "";
        }
    }
}