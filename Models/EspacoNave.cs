using System.Collections.Generic;

namespace SpaceshipManager.Models
{
    public class EspacoNave
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Modelo { get; set; }
        public int Passageiros { get; set; }
        public float Carga { get; set; }
        public string Classe { get; set; }

        public virtual List<HistoricoViagem> ListaHistoricoViagem { get; set; }

        public virtual List<EspacoNavePiloto> ListaEspacoNavePiloto { get; set; }
    }
}
