using AB.CursoMvc.Domain.Models;
using System.Collections.Generic;


namespace AB.CursoMvc.Domain.Interfaces
{
    public interface IClienteRepository : IRepository<Cliente>
    {
        Cliente ObterPorCpf(string cpf);
        Cliente ObterPorEmail(string email);
        IEnumerable<Cliente> ObterAtivos();
    }
}
