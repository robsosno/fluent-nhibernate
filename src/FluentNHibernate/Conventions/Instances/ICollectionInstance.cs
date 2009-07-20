using System;
using System.Reflection;
using FluentNHibernate.Conventions.Inspections;
using NHibernate.Persister.Entity;

namespace FluentNHibernate.Conventions.Instances
{
    public interface ICollectionInstance : ICollectionInspector
    {
        new IKeyInstance Key { get; }
        new IRelationshipInstance Relationship { get; }
        void Table(string tableName);
        void Name(string name);
        void Schema(string schema);
        void LazyLoad();
        void BatchSize(int batchSize);

        ICollectionInstance Not { get; }
        new IAccessInstance Access { get; }
        new ICacheInstance Cache { get; }
        new ICollectionCascadeInstance Cascade { get; }
        new IFetchInstance Fetch { get; }
        new IOptimisticLockInstance OptimisticLock { get; }
        new IOuterJoinInstance OuterJoin { get; }
        void Check(string constraint);
        void CollectionType<T>();
        void CollectionType(string type);
        void CollectionType(Type type);
        void Generic();
        void Inverse();
        void Persister<T>() where T : IEntityPersister;
        void Where(string whereClause);
    }
}