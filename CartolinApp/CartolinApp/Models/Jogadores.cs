namespace CartolinApp.Models
{
    public class Jogadores
    {
        public string Nome { get; set; }
        public string Apelido { get; set; }
        public string Foto { get; set; }
        public int Atleta_id { get; set; }
        public int Rodada_id { get; set; }
        public int Clube_id { get; set; }
        public int Posicao_id { get; set; }
        public int Status_id { get; set; }
        public int Pontos_num { get; set; }
        public int Preco_num { get; set; }
        public int Variacao_num { get; set; }
        public int Media_num { get; set; }
        public int Jogos_num { get; set; }
        public object Scout { get; set; }
    }
}
