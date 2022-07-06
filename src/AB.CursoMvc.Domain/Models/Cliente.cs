using System;
using System.Collections.Generic;

namespace AB.CursoMvc.Domain.Models
{
    public class Cliente : Entity
    {
        public Cliente()
        {
            Enderecos = new List<Endereco>();
        }
        public string Name { get; set; }
        public string CPF { get; set; }
        public string Email { get; set; }
        public DateTime DataNascimento { get; set; }
        public DateTime DataCadastro { get; set; }
        public bool Ativo { get; set; }
        public bool Excluido { get; set; }
        public virtual ICollection<Endereco> Enderecos { get; set; }


        public void Excluir()
        {
            Excluido = true;
            Ativo = false;
        }
    }
}
