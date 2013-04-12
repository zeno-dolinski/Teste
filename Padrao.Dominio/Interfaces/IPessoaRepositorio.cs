using GenericRepository.Library.Interface;
using Padrao.Dominio.Entidades;

namespace Padrao.Dominio.Interfaces
{
    public interface IPessoaRepositorio : IBaseRepository<Pessoa>
    {
        //void AddContatos(int PessoaId, PessoaContato pessoaContato);
    }
}
