using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter.Demos
{
    interface IDataStore<TEntity, TModel, TId> 
        where TEntity : IEntity<TId>
        where TModel : class
    { }

    interface IEntity<TId>
    {
        TId Id { get; }
    }

    class GenericOnGenericConstraints
    {
    }
}
