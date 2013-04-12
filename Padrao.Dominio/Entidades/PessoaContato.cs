using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Padrao.Dominio.Entidades
{
    public class PessoaContato
    {

        public int PessoaContatoId { get; set; }
        public byte Tipo { get; set; }
        public string Descricao { get; set; }
        public DateTime DataCadastro { get; set; }
        
        public enumTipoContato enmTipoContato
        {
            get { return (enumTipoContato)Tipo; }
            set { Tipo = (byte)value; }
        }

        public PessoaContato()
        { }

        public PessoaContato(int PessoaContatoId, byte Tipo, string Descricao, DateTime DataCadastro)
        {
            this.PessoaContatoId = PessoaContatoId;
            this.Tipo = Tipo;
            this.Descricao = Descricao;
            this.DataCadastro = DataCadastro;
        }
    }

    public enum enumTipoContato
    {
        email = 0,
        fone = 1,
        cel = 2,
        fax = 3
    }
}
