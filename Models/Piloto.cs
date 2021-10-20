using System.Collections.Generic;

namespace SpaceshipManager.Models
{
    public class Piloto
    {
        public int Id { get; set; }
        public int IdPlaneta { get; set; }
        public string AnoNascimento { get; set; }
        public string Nome { get; set; }


        public virtual Planeta Planeta { get; set; }
        public virtual List<HistoricoViagem> ListaHistoricoViagem { get; set; }
    }
}