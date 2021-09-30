namespace tabuleiro
{
    abstract class Peca
    {
        public Posicao posicao { get; set; }
        public Cor cor { get; protected set; }
        public int quantidadeMovimentos {get; set;}
        public Tabuleiro tabuleiro { get; protected set; }

        public Peca(Tabuleiro tabuleiro, Cor cor)
        {
            this.posicao = null;
            this.tabuleiro = tabuleiro;
            this.cor = cor;
            this.quantidadeMovimentos = 0;
        }

        public void incrementarMovimento()
        {
            quantidadeMovimentos++;
        }

        public abstract bool[,] movimentosPossiveis();
        

    }
}
