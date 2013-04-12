using System.Collections.Generic;

namespace Padrao.Servico.Base.Interfaces
{
    public interface IBaseServico<T> where T : class
    {
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        T GetById(long Id);
        T GetById(string Id);
        IEnumerable<T> GetAll();
    }
}
