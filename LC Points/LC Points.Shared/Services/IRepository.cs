using System.Collections.ObjectModel;

namespace LC_Points.Services
{
    public interface IRepository<T>
    {
        ObservableCollection<T> Collection { get; }

        void Add(T entity);

        void Remove(T entity);

        void Clear();

        int Count { get; }
    }
}
