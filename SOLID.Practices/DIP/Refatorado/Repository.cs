using System.Linq;

namespace SOLID.Practices.DIP.Refatorado
{
    public class Repository
    {
        public IQueryable<T> Query<T>() { return default(IQueryable<T>); }
        public T Save<T>(T entity) { return default(T); }
    }
}
