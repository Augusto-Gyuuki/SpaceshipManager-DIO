using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpaceshipManager.Models
{
    public class HistoricoViagem
    {
        public int Id { get; set; }
        public int IdPiloto { get; set; }
        public int IdEspacoNave { get; set; }
        public DateTime? DataSaida { get; set; }
        public DateTime? DataChegada { get; set; }

        public virtual Piloto Piloto { get; set; }
        public virtual EspacoNave EspacoNave { get; set; }
    }
}
