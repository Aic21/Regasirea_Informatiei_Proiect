using Microsoft.EntityFrameworkCore;
using Regasirea_Informatiei_Lab.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Regasirea_Informatiei_Lab.DAL.Interfaces;
using Regasirea_Informatiei_Lab.Models;

namespace Regasirea_Informatiei_Lab.DAL.Repositories
{
	public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class
	{
		private bool disposedValue;
		private readonly DBContext context;

		public GenericRepository(DBContext _context)
		{
			context = _context;
		}

		public async Task Delete(TEntity entity)
		{
			if (context.Entry(entity).State == EntityState.Detached)
			{
				context.Set<TEntity>().Attach(entity);
			}
			context.Set<TEntity>().Remove(entity);
			await context.SaveChangesAsync();
		}

		public async Task DeleteById(int id)
		{
			var entity = await context.Set<TEntity>().FindAsync(id);
			context.Set<TEntity>().Remove(entity);
			await context.SaveChangesAsync();
		}

		public IEnumerable<TEntity> GetAll()
		{
			return context.Set<TEntity>().AsTracking();
		}

		public IEnumerable<TEntity> GetAll(params Expression<Func<TEntity, object>>[] properties)
		{
			if (properties == null)
				throw new ArgumentNullException(nameof(properties));

			//var entity = context as IQueryable<TEntity>; // _dbSet = dbContext.Set<TEntity>()
			var entity = context.Set<TEntity>();

			foreach (var prop in properties)
			{
				entity.Include(prop);
			}

			return entity.AsTracking();
		}

		public async Task<TEntity> GetById(int id)
		{
			return await context.Set<TEntity>().FindAsync(id);
		}

		public List<TEntity> GetByCondition(Expression<Func<TEntity, bool>> where)
		{
			var entity = context.Set<TEntity>().Where(where).ToList();

			return entity;
		}

		public async Task<TEntity> GetById(string id)
		{
			return await context.Set<TEntity>().FindAsync(id);
		}

		public async Task Insert(TEntity entity)
		{
			await context.Set<TEntity>().AddAsync(entity);
			await context.SaveChangesAsync();
		}

		public async Task Update(TEntity entity)
		{
			context.Set<TEntity>().Update(entity);
			await context.SaveChangesAsync();
		}

		protected virtual void Dispose(bool disposing)
		{
			if (!disposedValue)
			{
				if (disposing)
				{
					// TODO: dispose managed state (managed objects)
					if (context != null)
					{
						context.Dispose();
					}
				}

				// TODO: free unmanaged resources (unmanaged objects) and override finalizer
				// TODO: set large fields to null
				disposedValue = true;
			}
		}

		// // TODO: override finalizer only if 'Dispose(bool disposing)' has code to free unmanaged resources
		~GenericRepository()
		{
			Dispose(disposing: false);
		}

		public void Dispose()
		{
			// Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
			Dispose(disposing: true);
			GC.SuppressFinalize(this);
		}
	}
}
