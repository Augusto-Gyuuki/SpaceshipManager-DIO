namespace SpaceshipManager.Models
{
    public class EspacoNavePiloto
    {
        public int IdPiloto { get; set; }
        public int IdEspacoNave { get; set; }

        public virtual Piloto Piloto { get; set; }
        public virtual EspacoNave EspacoNave { get; set; }
    }
}