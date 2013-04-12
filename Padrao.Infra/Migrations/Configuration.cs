namespace Padrao.Infra.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using System.Collections.Generic;
    using Padrao.Infra.Infraestrutura;
    using Padrao.Dominio.Entidades;

    internal sealed class Configuration : DbMigrationsConfiguration<PadraoContexto>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }

        private Padrao.Infra.Infraestrutura.PadraoContexto _context;

        private void Seed<T>(T entity) where T : class
        {
            _context.Set<T>().Add(entity);
        }

        private void Seed<T>(List<T> entities) where T : class
        {
            foreach (T t in entities)
                _context.Set<T>().Add(t);
        }

        protected override void Seed(PadraoContexto context)
        {
            _context = context;

            
            List<Cliente> cliente = new List<Cliente>();

            Cliente cl1 = new Cliente();
            cliente.Add(new Cliente { Nome = "A Cliente 001", CPF = "111.111.111-11", RG = "11.111.111-1", Sexo = 0, Tipo = 0, DataNascimento = DateTime.Now.AddYears(-10), DataCadastro = DateTime.Now });
            cliente.Add(new Cliente { Nome = "B Cliente 002", CPF = "222.222.222-22", RG = "22.222.222-2", Sexo = 1, Tipo = 0, DataNascimento = DateTime.Now.AddYears(-10), DataCadastro = DateTime.Now });
            cliente.Add(new Cliente { Nome = "C Cliente 003", CPF = "333.333.333-33", RG = "33.333.333-3", Sexo = 1, Tipo = 0, DataNascimento = DateTime.Now.AddYears(-10), DataCadastro = DateTime.Now });

            List<PessoaContato> contatoCliente1 = new List<PessoaContato>();
            contatoCliente1.Add(new PessoaContato { Tipo = 0, Descricao = "cliente01@teste.com.br", DataCadastro = DateTime.Now });
            contatoCliente1.Add(new PessoaContato { Tipo = 0, Descricao = "cliente01@outro.com.br", DataCadastro = DateTime.Now });
            contatoCliente1.Add(new PessoaContato { Tipo = 1, Descricao = "(35) 1111 1111", DataCadastro = DateTime.Now });
            contatoCliente1.Add(new PessoaContato { Tipo = 2, Descricao = "(35) 1111 1111", DataCadastro = DateTime.Now });
            contatoCliente1.Add(new PessoaContato { Tipo = 2, Descricao = "(11) 1111 1111", DataCadastro = DateTime.Now });
            cliente[0].Contato = contatoCliente1;

            List<PessoaContato> contatoCliente2 = new List<PessoaContato>();
            contatoCliente2.Add(new PessoaContato { Tipo = 0, Descricao = "cliente02@teste.com.br", DataCadastro = DateTime.Now });
            contatoCliente2.Add( new PessoaContato { Tipo = 2, Descricao = "(35) 2222 2222", DataCadastro = DateTime.Now });
            cliente[1].Contato = contatoCliente2;
            

            Seed<Cliente>(cliente);

            base.Seed(_context);
        }
    }
}

