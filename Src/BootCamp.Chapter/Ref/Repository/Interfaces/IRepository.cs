using System.Collections.Generic;

namespace BootCamp.Chapter.Ref.Repository.Interfaces
{
    public interface IRepository<TModel, in TId> where TModel : class
    {
        void Create(TModel model);
        void Update(TModel model);
        void Delete(TId key);
        IEnumerable<TModel> Get();
        TModel Get(TId id);
    }
}
