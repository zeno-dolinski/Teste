using System.Collections.Generic;
using GenericRepository.Library.Interface;
using Padrao.Dominio.Entidades;
using Padrao.Dominio.Interfaces;
using Padrao.Servico.Base.Servicos;
using Padrao.Servico.Interfaces;

namespace Padrao.Servico.Servicos
{
    public class ClienteServico : BaseServico<Cliente>, IClienteServico
    {
        private readonly IClienteRepositorio clienteRepositorio;
        private readonly IUnitOfWork unitOfWork;

        public ClienteServico(IClienteRepositorio clienteRepositorio, IUnitOfWork unitOfWork)
            : base(clienteRepositorio, unitOfWork)
        {
            this.clienteRepositorio = clienteRepositorio;
            this.unitOfWork = unitOfWork;
        }


        #region IClienteServico Members
        public IEnumerable<Cliente> Listar()
        {
            return clienteRepositorio.GetAll();
        }
        #endregion
    }
}