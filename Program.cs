class Program
{
    private static void Main(string[] args)
    {
        ContaBancaria contaEmerson = new ContaBancaria("Emerson", 100);
        ContaBancaria contaEllen = new ContaBancaria("Ellen", 100);

        try
        {
            Console.WriteLine("Saldo antes do saque.");
            Console.WriteLine($"O valor do seu saldo atual é de: {contaEmerson.Consultarsaldo()}\n\n");

            Console.WriteLine("Saldo APOS o saque.");
            contaEmerson.saque(100);
            Console.WriteLine($"O valor do seu saldo atual é de: {contaEmerson.Consultarsaldo()}");
        }
        catch (System.Exception e)
        {
            
            Console.WriteLine($"DEU ERRO \n{e}");
        }

       Console.WriteLine("Pressione ENTER para sair...");
       Console.Read();
    }

    class ContaBancaria
    {
        private string nome;
        private decimal saldo;
        public ContaBancaria(string nome, decimal saldo) 
        {
            if(String.IsNullOrWhiteSpace(nome))
            {
                throw new Exception("Nome inválido!");
            }

            if (saldo < 0)
            {
                throw new Exception("Saldo não pode ser negativo!");
            }

            this.nome = nome;
            this.saldo = saldo;            
        }

        public void deposito(decimal valor)
        {
            if (valor <= 0)
            {
                throw new Exception("O valor a ser depositado não pode ser menor ou igual a zero.");
            }

            saldo += valor;
        }

        public decimal Consultarsaldo()
        {
            
            return saldo;
        }

        public void saque(decimal valor)
        {
            if(valor == 0)
            {
                throw new Exception("O valor a ser sacado NÃO PODE ser igual 0. Por favor informe um valor válido!");
            }

            else if (valor < 0)
            {
                throw new Exception("O valor a ser sacado NÃO PODE negativo. Por favor informe um valor válido!");
            }

            else if (valor > saldo)
            {
                throw new Exception("O valor a ser sacado é maior do que seu saldo!");

            }

            else
            {
                saldo = saldo - valor;
            }
        }
    }

}
