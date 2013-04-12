using System;
using System.Collections.Generic;
using GenericRepository.Library.Implementation;
using GenericRepository.Library.Interface;
using Padrao.Dominio.Entidades;
using Padrao.Dominio.Interfaces;

namespace Padrao.Infra.Repositorios
{
    public class PessoaContatoRepositorio : BaseRepository<PessoaContato>, IPessoaContatoRepositorio
    {
        private readonly IUnitOfWork unitOfWork;

        public PessoaContatoRepositorio(IDataBaseFactory dataBaseFactory, IUnitOfWork unitOfWork)
            : base(dataBaseFactory)
        {
            this.unitOfWork = unitOfWork;
        }
    }
}