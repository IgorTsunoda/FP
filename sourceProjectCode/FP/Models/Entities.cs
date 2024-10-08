namespace FP.Models
{
    public class Entities
    {
        public int IdEntitie { get; set; }
        public string EntitieName { get; set; }
        public int Cnpj { get; set; }
        public int Cpf { get; set; }
        public string Pix { get; set; }
        public DateTime LstUpdateDate { get; set; }
        public char d_e_l_e_t_ { get; set; }

        public Entities()
        {
        }
    }
}
