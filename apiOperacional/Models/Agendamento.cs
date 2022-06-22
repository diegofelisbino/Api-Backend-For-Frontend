namespace apiOperacional.Models
{
    public class Agendamento
    {
        public int Id { get; set; }
        public string Motivacao { get; set; }
        public string PlacaCavalo { get; set; }
        public string PlacaReboque { get; set; }
        public DateTime DataEntrada { get; set; }
        public StatusAgendamento Status { get; set; }
        public Terminal Local { get; set; }
        public string NumeroCarga { get; set; }
        public string Importador { get; set; }
        public string Transportadora { get; set; }
        public string Motorista { get; set; }
        
        
    }
}