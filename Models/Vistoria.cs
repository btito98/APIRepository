using EstudoCRUDAPI.Enums;

namespace EstudoCRUDAPI.Models
{
    public class Vistoria
    {
        public int Id { get; set; }
        public int OS { get; set; }
        public string nomeVistoriador { get; set; }
        public StatusVistoria statusVistoria  { get; set; }
        public ECV ECV { get; set; }
    }
}
