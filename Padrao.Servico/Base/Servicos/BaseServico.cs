using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Padrao.Servico.Base.Interfaces;
using GenericRepository.Library.Interface;
using System.Linq.Expressions;

namespace Padrao.Servico.Base.Servicos
{
    public class BaseServico<T> : IBaseServico<T> where T : class
    {
        private readonly IBaseRepository<T> baseRepository;
        private readonly IUnitOfWork unitOfWork;

        public BaseServico(IBaseRepository<T> baseRepository, IUnitOfWork unitOfWork)
        {
            this.baseRepository = baseRepository;
            this.unitOfWork = unitOfWork;
        }

        public void Add(T entity)
        {
            baseRepository.Add(entity);
            unitOfWork.Commit();
        }

        public void Update(T entity)
        {
            baseRepository.Update(entity);
            unitOfWork.Commit();
        }

        public void Delete(T entity)
        {
            baseRepository.Delete(entity);
            unitOfWork.Commit();
        }

        public T GetById(long Id)
        {
            return baseRepository.GetById(Id);
        }

        public T GetById(string Id)
        {
            return baseRepository.GetById(Id);
        }

        public IEnumerable<T> GetAll()
        {
            return baseRepository.GetAll();
        }
    }
}
