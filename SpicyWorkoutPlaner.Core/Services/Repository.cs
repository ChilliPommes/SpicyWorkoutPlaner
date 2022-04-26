using SpicyWorkoutPlaner.Core.Models;
using System.Linq.Expressions;

namespace SpicyWorkoutPlaner.Core.Services
{
    public class Repository : IRepository
    {
        public void Insert<T>(T entity)
        {
            var database = DataBaseConnection.Instance.Connection;

            if (database == null)
                throw new NullReferenceException("database can't be null");

            database.Insert(entity);
        }

        public void Update<T>(T entity)
        {
            var database = DataBaseConnection.Instance.Connection;

            if (database == null)
                throw new NullReferenceException("database can't be null");

            database.Update(entity);
        }

        public T? FindById<T>(Expression<Func<T, bool>> filter)where T : new()
        {
            var database = DataBaseConnection.Instance.Connection;

            if (database == null)
                throw new NullReferenceException("database can't be null");

            return database.Table<T>().Where(filter).FirstOrDefault();
        }

        public void SoftDelete<T>(T entity)
        {
            var database = DataBaseConnection.Instance.Connection;

            if (database == null)
                throw new NullReferenceException("database can't be null");

            if (entity is DataBaseCore dbCore)
            {
                dbCore.DeletedAt = DateTime.Now;

                database.Update(entity);
            }
        }
    }
}
