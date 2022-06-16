using Realms;
using SpicyWorkoutPlaner.Core.Models;
using System.Text;

namespace SpicyWorkoutPlaner.Core.Services
{
    public class Repository
    {
        protected RealmConfiguration configuration;

        public Repository()
        {
            configuration = new RealmConfiguration(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "spicydata"))
            {
                EncryptionKey = Encoding.UTF8.GetBytes("5OZy0mX7BM00IoNhrChw3MZY5jPUWoJpjGDIq3gu5szYlahfkiH2gOZFf6cl5tZl")
            }; 
        }

        public void Insert(RealmObject entity)
        {
            var realm = Realm.GetInstance(configuration);

            if (realm == null)
                throw new NullReferenceException("database can't be null");

            realm.Write(() =>
            {
                realm.Add(entity, false);
            });
        }

        public void Update(RealmObject entity)
        {
            var realm = Realm.GetInstance(configuration);

            if (realm == null)
                throw new NullReferenceException("database can't be null");

            realm.Write(() =>
            {
                realm.Add(entity, true);
            });
        }

        public void SoftDelete(RealmObject entity)
        {
            var realm = Realm.GetInstance(configuration);

            if (realm == null)
                throw new NullReferenceException("database can't be null");

            if (entity is IDataBaseCore)
            {
                (entity as IDataBaseCore)!.DeletedAt = DateTime.Now;

                realm.Write(() =>
                {
                    realm.Add(entity, true);
                });
            }
        }
    }
}
