using laba9;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba9
{
    public class UnitOfWork : IDisposable //механизм для освобождения неуправляемых ресурсов,
    {
        private readonly AppDbContext _context;
        private bool _disposed;//для отслеживания освобождения ресурсов
        private Dictionary<Type, object> _repositories;

        public UnitOfWork(AppDbContext context) //инициализация
        {
            _context = context;
            _repositories = new Dictionary<Type, object>();
            _disposed = false;
        }

        public IRepository<T> Repository<T>() where T : class
            //прверка содержит ли наш словари репозиторий определенного типа  и если нет то создает новые экземпляр и добавляе его в словарь
        {
            if (_repositories.ContainsKey(typeof(T)))
            {
                return (IRepository<T>)_repositories[typeof(T)];
            }

            var repository = new Repository<T>(_context);
            _repositories.Add(typeof(T), repository);
            return repository;
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }

                _disposed = true;
            }
        }
    }
}
