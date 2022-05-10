using System.Linq.Expressions;

namespace SpicyWorkoutPlaner.Core.Services
{
    public interface IRepository
    {
        void Insert<T>(T entity);

        void Update<T>(T entity);

        T? FindById<T>(Expression<Func<T, bool>> filter) where T : new();

        List<T> FindAll<T>(Expression<Func<T, bool>> filter) where T : new();

        void SoftDelete<T>(T entity);
    }
}
