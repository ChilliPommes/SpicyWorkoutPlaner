using SQLite;

namespace SpicyWorkoutPlaner.Core.Services
{
    public sealed class DataBaseConnection
    {
        private static DataBaseConnection instance;

        public static DataBaseConnection Instance => instance ??= new DataBaseConnection();


        private SQLiteConnection? connection;

        public DataBaseConnection() => connection = new SQLiteConnection(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "spicydata.db"), SQLiteOpenFlags.ReadWrite | SQLiteOpenFlags.Create);

        public SQLiteConnection? Connection => connection;
    }
}
