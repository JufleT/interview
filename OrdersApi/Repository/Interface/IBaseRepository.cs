﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace OrdersApi.Repository.Interface
{
	public interface IBaseRepository<T> where T : class
	{
		void Create(T item);
		T FindById(long id);
		IQueryable<T> GetAll();
		IQueryable<T> GetAll(Expression<Func<T, bool>> predicate);
		IQueryable<T> Get(Expression<Func<T, bool>> predicate);
		void Remove(T item);
		void Update(T item);
	}
}
