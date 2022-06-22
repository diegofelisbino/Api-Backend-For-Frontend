using apiCadastro.Models;
using Bogus;

namespace apiCadastro.Services
{
    public class CadastroServices
    {
        public static List<Motorista> ListaDeMotoristasFake()
    {
        //byte[] image = System.IO.File.ReadAllBytes(@"C:\Projetos\BFF\apiCadastro\Images");

        var motoristaFaker = new Faker<Motorista>("pt_BR")
        .RuleFor(m => m.Id, f => f.IndexFaker)
        .RuleFor(m => m.Nome, f => f.Person.FullName)
        .RuleFor(m => m.Cnh, f => f.Random.Long(000000000001, 999999999999).ToString())
        .RuleFor(m => m.CnhValidade, f => f.Date.Future(5))
        .RuleFor(m => m.Cpf, f => f.Random.Long(00000000001, 99999999999).ToString())
        .RuleFor(m => m.Celular, f => f.Person.Phone)
        .RuleFor(m => m.Email, f => f.Person.Email)
        //.RuleFor(m => m.Foto, image)
        .Generate(10);

        return motoristaFaker;
    }
    }
}