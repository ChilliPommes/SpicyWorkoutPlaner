using MongoDB.Bson;
using Realms;

namespace SpicyWorkoutPlaner.Core.Models
{
    public interface IDataBaseCore
    {
        [PrimaryKey]
        public ObjectId Id { get; set; }

        public DateTimeOffset CreatedAt { get; set; }

        public DateTimeOffset? UpdatedAt { get; set; }

        public DateTimeOffset? DeletedAt { get; set; }
    }
}
