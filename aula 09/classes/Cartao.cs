namespace aula_09classes
{
    public class Cartao : Pagamento
    {
        //Aributos
        public string bandeira;

        public string numero;

        public string titular;

        public string cvv;

        //metodos
        public string SalvarCartao(){
            
            return "";
        }
        public override string Desconto(int valor)
        {
            return "";
        }
    }
}