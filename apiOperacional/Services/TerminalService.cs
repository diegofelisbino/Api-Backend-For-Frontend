using apiOperacional.Models;
using Bogus;

namespace apiOperacional.Services
{
    public class TerminalService
    {
        public static List<Terminal> ListaDeTerminaisFake()
        {
            var terminalFaker = new Faker<Terminal>("pt_BR")
            .RuleFor(t => t.Id, f => f.IndexFaker)
            .RuleFor(t => t.NomeTerminal, f => f.Person.Company.Name)
            .RuleFor(t => t.Endereco, f => f.Address.StreetName())
            .RuleFor(t => t.Cidade, f => f.Address.City())
            .RuleFor(t => t.Estado, f => f.Address.State())
            .RuleFor(t => t.Status, f => f.Random.Enum<StatusOperacional>())
            .RuleFor(t => t.Cpnj, f => f.Random.Long(0000000000001, 9999999999999))
            .Generate(4);

            return terminalFaker;
        }
    }
}