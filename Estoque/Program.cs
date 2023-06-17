namespace Estoque
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Produto p1 = new Produto(1, "tenis", 299.99, 39, 4);

            exibeValoreObjProdutos(p1);

            p1.setId(2);
            p1.setNome("chinelo");
            p1.setPreco(199.99);
            p1.setTamanho(40);
            p1.setQuantidade(6);

            exibeValoreObjProdutos(p1);

        }

        public static void exibeValoreObjProdutos(Produto obj)
        {
            Console.WriteLine(obj);
            Console.WriteLine(obj.getId());
            Console.WriteLine(obj.getNome());
            Console.WriteLine(obj.getPreco());
            Console.WriteLine(obj.getTamanho());
            Console.WriteLine(obj.getQuantidade());
        }
    }

    class Produto
    {
        private long id;
        private string nome;
        private double preco;
        private int tamanho;
        private int quantidade;

        public Produto(long id, string nome, double preco, int tamanho, int quantidade)
        {
            this.id = id;
            this.nome = nome;
            this.preco = preco;
            this.tamanho = tamanho;
            this.quantidade = quantidade;

        }

        public void vender()
        {
            quantidade--;
        }

        public void repor()
        {
            quantidade++;
        }

        public long getId() { return id; }
        public string getNome() { return nome; }
        public double getPreco() { return preco; }
        public int getTamanho() { return tamanho; }
        public int getQuantidade() { return quantidade; }

        public void setId(long id) { this.id = id; }
        public void setNome(string nome) { this.nome = nome; }
        public void setPreco(double preco) { this.preco = preco; }
        public void setTamanho(int tamanho) { this.tamanho = tamanho; }
        public void setQuantidade(int quantidade) { this.quantidade = quantidade; }


    }
}