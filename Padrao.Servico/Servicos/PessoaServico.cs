using GenericRepository.Library.Interface;
using Padrao.Dominio.Entidades;
using Padrao.Dominio.Interfaces;
using Padrao.Servico.Base.Servicos;
using Padrao.Servico.Interfaces;

namespace Padrao.Servico.Servicos
{
    public class PessoaServico : BaseServico<Pessoa>, IPessoaServico
    {
        private readonly IPessoaRepositorio pessoaRepositorio;
        private readonly IUnitOfWork unitOfWork;

        public PessoaServico(IPessoaRepositorio pessoaRepositorio, IUnitOfWork unitOfWork)
            : base(pessoaRepositorio, unitOfWork)
        {
            this.pessoaRepositorio = pessoaRepositorio;
            this.unitOfWork = unitOfWork;
        }


        #region IPessoaServico Members
        
        #endregion
    }
}