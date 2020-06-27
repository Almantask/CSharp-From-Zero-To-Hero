using System.Collections.Generic;
using BootCamp.Chapter.Ref.Repository.Interfaces;

namespace BootCamp.Chapter.Ref.Repository.InMemory.Repositories
{
    public class Repository<TEntity, TModel> : IRepository<TModel, uint> where TModel : class, IEntity
    where TEntity: class, IEntity
    {
        protected List<TEntity> Context;

        protected Repository() { }

        public void Create(TModel model)
        {
            var entity = Mapping.Mapper.Map<TEntity>(model);
            Context.Add(entity);
        }

        public void Delete(uint key)
        {
            Context.RemoveAll(e => e.Id == key);
        }

        public IEnumerable<TModel> Get()
        {
            return Mapping.Mapper.Map<IEnumerable<TEntity>, IEnumerable<TModel>>(Context);
        }

        public TModel Get(uint id)
        {
            var entity = Context.Find(e => e.Id == id);
            var models = Mapping.Mapper.Map<TModel>(entity);

            return models;
        }

        public void Update(TModel model)
        {
            var entity = Context.Find(e => e.Id == model.Id);
            Mapping.Mapper.Map<TModel, TEntity>(model, entity);
        }
    }
}
