using AB.CursoMvc.Application.Interfaces;
using AB.CursoMvc.Application.ViewModels;
using System;
using System.Collections.Generic;

namespace AB.CursoMvc.Application.Services
{
    public class ClienteAppService : IClienteAppService
    {
        public ClienteEnderecoViewModel Adicionar(ClienteEnderecoViewModel clienteEnderecoViewModel)
        {
            throw new NotImplementedException();
        }

        public ClienteViewModel Atualizar(ClienteViewModel clienteViewModel)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ClienteViewModel> ObterAtivos()
        {
            throw new NotImplementedException();
        }

        public ClienteViewModel ObterPorCpf(string cpf)
        {
            throw new NotImplementedException();
        }

        public ClienteViewModel ObterPorEmail(string email)
        {
            throw new NotImplementedException();
        }

        public ClienteViewModel ObterPorId(Guid id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ClienteViewModel> ObterTodos()
        {
            throw new NotImplementedException();
        }

        public void Remover(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
