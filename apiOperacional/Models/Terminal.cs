namespace apiOperacional.Models
{
    public class Terminal
    {
        public int Id { get; set; }
        public string NomeTerminal { get; set; }
        public string Endereco { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public long Cpnj { get; set; }
        public StatusOperacional Status { get; set; }
        public string StatusOperacional
        {
            get
            {
                switch (Status)
                {
                    case Models.StatusOperacional.NORMAL:
                        return "Operação normal";
                    case Models.StatusOperacional.LENTIDAO:
                        return "Operação com lentidão";
                    case Models.StatusOperacional.PARADO:
                        return "Operação parada";
                    default:
                        return "Informação não disponivel";
                }

            }
        }
    }

    public enum StatusOperacional
    {

        NORMAL,
        LENTIDAO,
        PARADO
    }


}