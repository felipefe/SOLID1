namespace CalculadoraGerente
{

    public enum StatusContaCliente : int
    {
        NaoRegistrado = 1,
        Comum = 2,
        Especial = 3,
        VIP = 4,
    }

    public static class Constantes
    {
        public const int DESCONTO_MAXIMO_FIDELIDADE = 5;
        public const decimal DESCONTO_CLIENTE_COMUM = 0.1m;
        public const decimal DESCONTO_CLIENTE_ESPECIAL = 0.7m;
        public const decimal DESCONTO_CLIENTE_VIP = 0.5m;
    }


    public class GerenciadorDesconto
    {

        public decimal AplicarDesconto(decimal precoProduto, StatusContaCliente statusContaCliente, int tempoClienteEmAnos)
        {
            decimal precoCalculado = 0;
            decimal descontoFidelidade = (tempoClienteEmAnos > Constantes.DESCONTO_MAXIMO_FIDELIDADE) ? (decimal)Constantes.DESCONTO_MAXIMO_FIDELIDADE / 100 : (decimal)tempoClienteEmAnos / 100;

            switch (statusContaCliente)
            {
                case StatusContaCliente.NaoRegistrado:
                    precoCalculado = precoProduto;
                    break;
                case StatusContaCliente.Comum:
                    precoCalculado = CalcularDescontoPadrao(precoProduto, descontoFidelidade, tempoClienteEmAnos, Constantes.DESCONTO_CLIENTE_COMUM);
                    break;
                case StatusContaCliente.Especial:
                    var acrescimoPreco = CalcularAcrescimoPreco(Constantes.DESCONTO_CLIENTE_ESPECIAL, precoProduto);
                    precoCalculado = acrescimoPreco - descontoFidelidade * acrescimoPreco;
                    break;
                case StatusContaCliente.VIP:
                    precoCalculado = CalcularDescontoPadrao(precoProduto, descontoFidelidade, tempoClienteEmAnos, Constantes.DESCONTO_CLIENTE_VIP);
                    break;
                default:
                    throw new ApplicationException("Status não previsto");
            }

            return precoCalculado;
        }


        public decimal CalcularAcrescimoPreco(decimal acrescimo, decimal precoProduto) => (acrescimo * precoProduto);
        public decimal CalcularDescontoPadrao(decimal precoProduto, decimal descontoFidelidade, int tempoClienteEmAno, decimal margem)
        {
            var acrescimo = CalcularAcrescimoPreco(margem, precoProduto);
            return (precoProduto - acrescimo) - descontoFidelidade * (precoProduto - acrescimo);
        }

    }

}