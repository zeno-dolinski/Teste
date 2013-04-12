using GenericRepository.Library.Interface;

namespace Padrao.Infra.Infraestrutura
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly IDataBaseFactory databaseFactory;
        private PadraoContexto dataContext;

        public UnitOfWork(IDataBaseFactory databaseFactory)
        {
            this.databaseFactory = databaseFactory;
        }

        protected PadraoContexto DataContext
        {
            get { return dataContext ?? (dataContext = (PadraoContexto)databaseFactory.Get()); }
        }

        public void Commit()
        {
            DataContext.Commit();
        }
    }
}
