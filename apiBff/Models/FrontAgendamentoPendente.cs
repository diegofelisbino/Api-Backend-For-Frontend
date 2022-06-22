namespace apiBff.Models
{
    public class FrontAgendamentoPendente
    {
        public string CadastroNomeMotorista { get; set; }
        public byte[] CadastroFotoMotorista { get; set; }
        public List<SituacaoOperacional> SituacaoOperacionalTerminais { get; set; }
        public List<AgendamentoPendente> Agendamentos { get; set; }
    }

    public class SituacaoOperacional
    {
        public string SituacaoNomeTerminal { get; set; }
        public string SituacaoStatusOperacional { get; set; }
    }

    public class AgendamentoPendente
    {
        public string AgendamentoMotivacao { get; set; }
        public DateTime AgendamentoDataPlanejada { get; set; }
        public string AgendamentoPlacaCavalo { get; set; }
        public string AgendamentoPlacaReboque { get; set; }
    }
}