using CalculadoraGerente;

namespace Aplicando_Principios_SOLID1
{

    class Program
    {
        static void Main(string[] args)
        {
            GerenciadorDesconto gerDesc
            ;
            Console.WriteLine("Valor da compra 1000 e fidelidade 10 anos (5%)\n");

            gerDesc = new GerenciadorDesconto(new CalculaDescontoFidelidade(), new ClienteComum());
            var resultado = gerDesc.AplicarDesconto(1000, 10);
            Console.WriteLine($"Cliente tipo 2, 10 anos fidelidade,  = {resultado}");

            gerDesc = new GerenciadorDesconto(new CalculaDescontoFidelidade(), new ClienteEspecial());
            var resultado1 = gerDesc.AplicarDesconto(1000, 10);
            Console.WriteLine($"Cliente tipo 3 o valor do desconto é de : {resultado1}");

            gerDesc = new GerenciadorDesconto(new CalculaDescontoFidelidade(), new ClienteVIP());
            var resultado2 = gerDesc.AplicarDesconto(1000, 10);
            Console.WriteLine($"Cliente tipo 4 o valor do desconto é de : {resultado2}\n");

            Console.WriteLine("Valor da compra 1000 e fidelidade 4 anos (4%)\n");
            gerDesc = new GerenciadorDesconto(new CalculaDescontoFidelidade(), new ClienteComum());
            var resultado3 = gerDesc.AplicarDesconto(1000, 4);
            Console.WriteLine($"Cliente tipo 2, 10 anos fidelidade,  = {resultado3}");

            gerDesc = new GerenciadorDesconto(new CalculaDescontoFidelidade(), new ClienteEspecial());
            var resultado4 = gerDesc.AplicarDesconto(1000, 4);
            Console.WriteLine($"Para Cliente tipo 3 o valor do desconto é de : {resultado4}");

            gerDesc = new GerenciadorDesconto(new CalculaDescontoFidelidade(), new ClienteVIP());
            var resultado5 = gerDesc.AplicarDesconto(1000, 4);
            Console.WriteLine($"Para Cliente tipo 4 o valor do desconto é de : {resultado5}");

            Console.ReadLine();
        }
    }



}
