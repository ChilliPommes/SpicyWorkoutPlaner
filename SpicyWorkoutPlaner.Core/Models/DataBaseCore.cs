using SQLite;

namespace SpicyWorkoutPlaner.Core.Models
{
    public class DataBaseCore
    {
        [PrimaryKey, AutoIncrement]
        public long Id { get; set; }

        public DateTime? CreatedAt { get; set; }

        public DateTime? UpdatedAt { get; set; }

        public DateTime? DeletedAt { get; set; }
    }
}
