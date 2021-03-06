﻿using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject.Data.RepositoryPattern.Interfaces
{
    public interface IRepository<TEntity>  where TEntity:class
    {
        IQueryable<TEntity> AsQueryable();
        IQueryable<TEntity> Where(Expression<Func<TEntity, bool>> expression);
        TEntity GetById(int id);
        IEnumerable<TEntity> GetAll();
        void Add(TEntity entity);
        void AddRange(IEnumerable<TEntity> entities);
        void Remove(int id);
        void RemoveRange(IEnumerable<TEntity> entities);
        void Update(TEntity entity);

    }
}
