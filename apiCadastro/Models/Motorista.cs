


namespace apiCadastro.Models
{
    public class Motorista
    {
        public int Id { get; set; }
        public string Nome { get; set; }       
        
        public string Cnh { get; set; }
        public DateTime CnhValidade { get; set; }
        public string Cpf { get; set; }
        public string Celular { get; set; }
        public string Email { get; set; }
        public byte[] Foto { get; set; }
        
    }
}