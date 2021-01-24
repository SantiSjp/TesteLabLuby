namespace _3DesafioPOO.MaquinaVendas
{
    public class Produto
    {
        public Produto()
        {

        }

        public Produto(int id, string nome, double valor, int quantidade)
        {
            Id = id;
            Nome = nome;
            Valor = valor;
            Quantidade = quantidade;
        }

        public int Id { get; set; }
        public string Nome { get; set; }
        public double Valor { get; set; }
        public int Quantidade { get; set; }
        public object Where { get; internal set; }
    }
}
