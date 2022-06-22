namespace apiBff.Models
{
    public class FrontAgendamentoPendentemModel    
    {
        public string CadastroNomeMotorista { get; set; }
        public byte[] CadastroFotoMotorista { get; set; }
        public List<SituacaoOperacionalModel> SituacaoOperacionalTerminais { get; set; }
        public List<AgendamentoPendenteModel> Agendamentos { get; set; }
    }
}