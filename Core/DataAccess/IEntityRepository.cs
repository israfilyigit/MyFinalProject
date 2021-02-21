using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Core.DataAccess

{
    public interface IEntityRepository<T> where T:class, IEntity, new() // generic constraint generik kısıtlama // class referans tip olabilir demek
    {                                                                 // new() newlenebilir olmalı
        List<T> GetAll(Expression<Func<T, bool>> filter = null);  // tüm datayı filtre uygulayarak veya uygulamayarak elde etmek
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity); 
        void Delete(T entity);
    }
}
