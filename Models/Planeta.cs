using System.Collections.Generic;

namespace SpaceshipManager.Models
{
    public class Planeta
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public float Rotacao { get; set; }
        public float Orbita { get; set; }
        public float Diametro { get; set; }
        public string Clima { get; set; }
        public int Populacao { get; set; }

        public virtual List<Piloto> ListaPilotos { get; set; }
    }
}
