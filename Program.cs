using CalculadoraGerente;

namespace Aplicando_Principios_SOLID1
{

    class Program
    {
        static void Main(string[] args)
        {
            GerenciadorDesconto gerDesc = new GerenciadorDesconto();
            Console.WriteLine("Valor da compra 1000 e fidelidade 10 anos (5%)\n");

            var resultado = gerDesc.AplicarDesconto(1000, StatusContaCliente.Comum, 10);
            Console.WriteLine($"Cliente tipo 2, 10 anos fidelidade,  = {resultado}");

            var resultado1 = gerDesc.AplicarDesconto(1000, StatusContaCliente.Especial, 10);
            Console.WriteLine($"Cliente tipo 3 o valor do desconto é de : {resultado1}");

            var resultado2 = gerDesc.AplicarDesconto(1000, StatusContaCliente.VIP, 10);
            Console.WriteLine($"Cliente tipo 4 o valor do desconto é de : {resultado2}\n");

            Console.WriteLine("Valor da compra 1000 e fidelidade 4 anos (4%)\n");
            var resultado3 = gerDesc.AplicarDesconto(1000, StatusContaCliente.Comum, 4);
            Console.WriteLine($"Cliente tipo 2, 10 anos fidelidade,  = {resultado3}");

            var resultado4 = gerDesc.AplicarDesconto(1000, StatusContaCliente.Especial, 4);
            Console.WriteLine($"Para Cliente tipo 3 o valor do desconto é de : {resultado4}");

            var resultado5 = gerDesc.AplicarDesconto(1000, StatusContaCliente.VIP, 4);
            Console.WriteLine($"Para Cliente tipo 4 o valor do desconto é de : {resultado5}");

            Console.ReadLine();
        }
    }


  
}
