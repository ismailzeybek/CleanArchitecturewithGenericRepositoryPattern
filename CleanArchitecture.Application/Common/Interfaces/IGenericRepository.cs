using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using CleanArchitecture.Domain.Entities;

namespace CleanArchitecture.Application.Common.Interfaces
{

    public interface IGenericRepository<T>: IGenericCommandRepository<T>, 
        IGenericQueryRepository<T> where T :BaseEntity
    {

    }
    public interface IGenericCommandRepository<T> where T : class
    {
        //Add
        //    Update
        //    Delete

        Task Add(T entity);
        void Update(T entity);
        void Delete(int id);
    }

    public interface IGenericQueryRepository<T> where T : class
    {
        IEnumerable<T> GetAll();
        T GetById(int id);
        IEnumerable<T> Get(Expression<Func<T,bool>> expression);

        //    GetAll
        //    GetById
        //    Get

    }
}
