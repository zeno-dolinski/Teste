using System;

namespace Padrao.Dominio.Entidades
{
    public class Cliente : Pessoa
    {
        public Cliente() { }

        public Cliente(int PessoaId, string Nome, DateTime DataNascimento, DateTime? DataCadastro, byte Sexo, string CPF, string RG, byte Tipo)
        {
            base.AddPessoa(PessoaId, Nome, DataNascimento, DataCadastro, Sexo, CPF, RG, Tipo);
        }
    }
}
