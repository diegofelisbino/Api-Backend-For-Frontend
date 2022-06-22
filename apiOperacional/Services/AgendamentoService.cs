using apiOperacional.Models;
using Bogus;

namespace apiOperacional.Services
{
    public class AgendamentoService
    {
        public static List<Agendamento> ListaDeAgendamentosFake()
        {
            var motivacoes = new List<string>();
            motivacoes.Add("Importação");
            motivacoes.Add("Exportação");

            var agendamentoFaker = new Faker<Agendamento>("pt_BR")
            .RuleFor(a => a.Id, f => f.IndexFaker)
            .RuleFor(a => a.Motivacao, f => f.Random.ListItem<String>(motivacoes))
            .RuleFor(a => a.PlacaCavalo, f => f.Random.String2(3).ToUpper()+ "-"+ f.Random.String2(4,"0123456789"))
            .RuleFor(a => a.PlacaReboque, f => f.Random.String2(3).ToUpper()+ "-"+ f.Random.String2(4,"0123456789"))
            .RuleFor(a => a.DataEntrada, f => f.Date.Future(1))
            .RuleFor(a => a.Status, f => f.Random.Enum<StatusAgendamento>())
            .RuleFor(a => a.Local, f => Services.TerminalService.ListaDeTerminaisFake().FirstOrDefault())
            .RuleFor(a => a.NumeroCarga, f => f.Commerce.Product())
            .RuleFor(a => a.Importador, f => f.Company.CompanyName())
            .RuleFor(a => a.Transportadora, f => f.Company.CompanyName())
            .RuleFor(a => a.Motorista, f => f.Person.FullName)
            .Generate(4);

            return agendamentoFaker;
        }
    }
}