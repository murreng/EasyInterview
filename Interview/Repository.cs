using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview
{
    public class Repository<T, I> : IRepository<T, I> where T : IStoreable<I>
    {
        private IList<T> repo;

        public IEnumerable<T> GetAll()
        {
            return repo;
        }

        public T Get(I id)
        {
            Storable<I> storeId = new Storable<I>{Id = id};
            return repo.FirstOrDefault(w => new Storable<I> { Id = w.Id} == storeId);
        }

        public void Delete(I id)
        {
            repo.RemoveAt(repo.IndexOf(Get(id)));
        }

        public void Save(T item)
        {
            repo.Add(item);
        }
    }
}
