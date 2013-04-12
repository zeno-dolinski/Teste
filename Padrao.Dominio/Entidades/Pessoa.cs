using System;
using System.ComponentModel;
using System.Collections.Generic;

namespace Padrao.Dominio.Entidades
{
    public abstract class Pessoa
    {
        public int PessoaId { get; set; }
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public byte Sexo { get; set; }
        public string CPF { get; set; }
        public string RG { get; set; }
        public DateTime? DataCadastro { get; set; }
        public byte Tipo { get; set; }

        public virtual ICollection<PessoaContato> Contato { get; set; }

        public enumSexo enmSexo
        {
            get { return (enumSexo)Sexo; }
            set { Sexo = (byte)value; }
        }

        public enumTipoPessoa enmTipoPessoa
        {
            get { return (enumTipoPessoa)Tipo; }
            set { Tipo = (byte)value; }
        }

        public Pessoa()
        { }

        public void AddPessoa(int PessoaId, string Nome, DateTime DataNascimento, DateTime? DataCadastro, byte Sexo, string CPF, string RG, byte Tipo)
        {
            this.PessoaId = PessoaId;
            this.Nome = Nome;
            this.DataNascimento = DataNascimento;
            this.DataCadastro = DataCadastro;
            this.Sexo = Sexo;
            this.CPF = CPF;
            this.RG = RG;
            this.Tipo = Tipo;
        }
    }

    public enum enumSexo : byte
    {
        [Description("Masculino")]
        Masculino = 0,
        [Description("Feminino")]
        Feminino = 1
    }

    public enum enumTipoPessoa : byte
    {
        [Description("Física")]
        Fisica = 0,
        [Description("Jurídica")]
        Juridica = 1
    }
}
