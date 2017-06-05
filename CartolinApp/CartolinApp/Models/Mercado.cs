using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CartolinApp.Models
{
    public class Mercado
    {
        public int Rodada_atual { get; set; }
        public int Status_mercado { get; set; }
        public int Esquema_default_id { get; set; }
        public int Cartoleta_inicial { get; set; }
        public int Max_ligas_free { get; set; }
        public int Max_ligas_pro { get; set; }
        public int Max_ligas_matamata_free { get; set; }
        public int Max_ligas_matamata_pro { get; set; }
        public int Max_ligas_patrocinadas_free { get; set; }
        public int Max_ligas_patrocinadas_pro_num { get; set; }
        public bool Game_over { get; set; }
        public int Temporada { get; set; }
        public bool Reativar { get; set; }
        public int Times_escalados { get; set; }
        public Fechamento Fechamento { get; set; }
        public bool Mercado_pos_rodada { get; set; }
        public string Aviso { get; set; }
    }
}
