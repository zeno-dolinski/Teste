using System;
using System.Collections.Generic;
using GenericRepository.Library.Implementation;
using GenericRepository.Library.Interface;
using Padrao.Dominio.Entidades;
using Padrao.Dominio.Interfaces;

namespace Padrao.Infra.Repositorios
{
    public class PessoaRepositorio : BaseRepository<Pessoa>, IPessoaRepositorio
    {
        private readonly IUnitOfWork unitOfWork;

        public PessoaRepositorio(IDataBaseFactory dataBaseFactory, IUnitOfWork unitOfWork)
            : base(dataBaseFactory)
        {
            this.unitOfWork = unitOfWork;
        }

        public void AdicionarContatos(int PessoaId, PessoaContato pessoaContato)
        {
            int i = 0;
            i++;
        }
    }
}