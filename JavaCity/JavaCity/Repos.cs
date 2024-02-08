using SQLite;
using System.Collections.Generic;

namespace JavaCity
{
    public class Repos
    {
        SQLiteConnection database;
        public Repos(string databasePath)
        {
            database = new SQLiteConnection(databasePath);
            database.CreateTable<Orderes>();
        }
        public IEnumerable<Orderes> GetItems()
        {
            return database.Table<Orderes>().ToList();
        }
        public Orderes GetItem(int id)
        {
            return database.Get<Orderes>(id);
        }
        public int DeleteItem(int id)
        {
            return database.Delete<Orderes>(id);
        }
        public int SaveItem(Orderes item)
        {
            if (item.Id != 0)
            {
                database.Update(item);
                return item.Id;
            }
            else
            {
                return database.Insert(item);
            }
        }
    }
}
