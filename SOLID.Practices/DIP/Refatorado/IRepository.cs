﻿using System.Linq;

namespace SOLID.Practices.DIP.Refatorado
{
    public interface IRepository
    {
        IQueryable<T> Query<T>();
        T Save<T>(T entity);
    }
}