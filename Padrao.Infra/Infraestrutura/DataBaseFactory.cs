using System.Data.Entity;
using GenericRepository.Library.Interface;

namespace Padrao.Infra.Infraestrutura
{
    public class DataBaseFactory : IDataBaseFactory
    {
        private PadraoContexto _contexto;

        public DbContext Get()
        {
            return _contexto ?? (_contexto = new PadraoContexto());
        }
    }
}

