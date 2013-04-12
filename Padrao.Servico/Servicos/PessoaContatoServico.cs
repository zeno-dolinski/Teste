using GenericRepository.Library.Interface;
using Padrao.Dominio.Entidades;
using Padrao.Dominio.Interfaces;
using Padrao.Servico.Base.Servicos;
using Padrao.Servico.Interfaces;

namespace Padrao.Servico.Servicos
{
    public class PessoaContatoServico : BaseServico<PessoaContato>, IPessoaContatoServico
    {
        private readonly IPessoaContatoRepositorio pessoaContatoRepositorio;
        private readonly IPessoaRepositorio pessoaRepositorio;
        private readonly IUnitOfWork unitOfWork;

        public PessoaContatoServico(IPessoaContatoRepositorio pessoaContatoRepositorio, IUnitOfWork unitOfWork)
            : base(pessoaContatoRepositorio, unitOfWork)
        {
            this.pessoaContatoRepositorio = pessoaContatoRepositorio;
            this.unitOfWork = unitOfWork;
        }


        #region IPessoaContatoServico Members
        public void AdicionarContatos(PessoaContato pessoaContato)
        {
            pessoaContatoRepositorio.Add(pessoaContato);
            unitOfWork.Commit();
        }

        
        #endregion

    }
}