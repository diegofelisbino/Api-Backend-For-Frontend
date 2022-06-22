namespace apiBff.Dtos
{
    public class TerminalDto
    {
        public int Id { get; set; }
        public string NomeTerminal { get; set; }
        public string Endereco { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public long Cpnj { get; set; }
        public string StatusOperacional { get; set; } 
    }    
}