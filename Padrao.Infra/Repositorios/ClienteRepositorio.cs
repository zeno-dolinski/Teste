using GenericRepository.Library.Implementation;
using GenericRepository.Library.Interface;
using Padrao.Dominio.Interfaces;
using Padrao.Dominio.Entidades;

namespace Padrao.Infra.Repositorios
{
    public class ClienteRepositorio : BaseRepository<Cliente>, IClienteRepositorio
    {
        private readonly IUnitOfWork unitOfWork;

        public ClienteRepositorio(IDataBaseFactory dataBaseFactory, IUnitOfWork unitOfWork)
            : base(dataBaseFactory)
        {
            this.unitOfWork = unitOfWork;
        }

    }
}