﻿#region

using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Threading;
using System.Threading.Tasks;
using Repository.Pattern.DataContext;
using Repository.Pattern.Infrastructure;

#endregion

namespace Repository.Pattern.Ef6
{
    public interface IFakeDbContext
    {
        Guid InstanceId { get; }
        DbSet<T> Set<T>() where T : class;
        int SaveChanges();
        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
        Task<int> SaveChangesAsync();
        void Dispose();

        void AddFakeDbSet<TEntity, TFakeDbSet>()
            where TEntity : Entity, IObjectState, new()
            where TFakeDbSet : FakeDbSet<TEntity>, IDbSet<TEntity>, new();

        void SyncObjectState(object entity);
    }

    public abstract class FakeDbContext : IDataContext, IFakeDbContext
    {
        private readonly Dictionary<Type, object> _fakeDbSets;

        protected FakeDbContext()
        {
            _fakeDbSets = new Dictionary<Type, object>();
        }

        public Guid InstanceId { get; private set; }

        public DbSet<T> Set<T>() where T : class
        {
            return (DbSet<T>) _fakeDbSets[typeof (T)];
        }

        public int SaveChanges()
        {
            return default(int);
        }

        public Task<int> SaveChangesAsync(CancellationToken cancellationToken)
        {
            return new Task<int>(() => default(int));
        }

        public Task<int> SaveChangesAsync()
        {
            return new Task<int>(() => default(int));
        }

        public void Dispose()
        {
        }

        public void AddFakeDbSet<TEntity, TFakeDbSet>()
            where TEntity : Entity, IObjectState, new()
            where TFakeDbSet : FakeDbSet<TEntity>, IDbSet<TEntity>, new()
        {
            var fakeDbSet = Activator.CreateInstance<TFakeDbSet>();
            _fakeDbSets.Add(typeof (TEntity), fakeDbSet);
        }

        public void SyncObjectState(object entity)
        {
        }
    }
}
