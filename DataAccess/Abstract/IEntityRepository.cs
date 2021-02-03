using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstract
{   //where T: class diyince bu referans tip olması gerekiyor demek istedik yani int, book falan olmaz demek istedik. 
    //Sonrasında da IEntity yada ona implente olan bir referans tip olması gerekir demek istedik ama IEntity'nin kendisini istemiyoruz aslında
    // new () : new'lenebilir bir nesne olmalı. IEntity newlenemyeceği için o kullanılamayacak
    public interface IEntityRepository<T> where T:class,IEntity,new()
    {
        List<T> GetAll(Expression<Func<T,bool>> filter=null);
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
