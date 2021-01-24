namespace _3DesafioPOO.MaquinaVendas
{
    public class Produto
    {
        public Produto(string nome, double valor, int quantidade)
        {
            Nome = nome;
            Valor = valor;
            Quantidade = quantidade;
        }

        public string Nome { get; set; }
        public double Valor { get; set; }
        public int Quantidade { get; set; }
    }
}
