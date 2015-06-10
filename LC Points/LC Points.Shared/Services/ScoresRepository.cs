using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using LC_Points.Model;

namespace LC_Points.Services
{
    sealed class ScoresRepository : IRepository<ScoreModel>, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private readonly ObservableCollection<ScoreModel> _collection = new ObservableCollection<ScoreModel>();
        private int _count;

        public ScoresRepository()
        {
            _collection.CollectionChanged += (sender, args) =>
            {
                this.Count = _collection.Count;
            };
        }

        public ObservableCollection<ScoreModel> Collection
        {
            get { return _collection; }
        }


        public void Add(ScoreModel entity)
        {
            _collection.Add(entity);
        }

        public void Remove(ScoreModel entity)
        {
            _collection.Remove(entity);
        }

        public void Clear()
        {
            _collection.Clear();
        }

        public int Count
        {
            get { return _count; }
            set
            {
                if (_count != value)
                {
                    _count = value;
                    this.NotifyPropertyChanged();
                }
            }
        }

        private void NotifyPropertyChanged([CallerMemberName] string propertyName = null)
        {
            if (this.PropertyChanged != null)
            {
                this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
