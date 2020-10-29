namespace xamarin_fridge_organizer.Shared.Sqlite
{
    using SQLite;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using xamarin_fridge_organizer.Interfaces.Models;
    using xamarin_fridge_organizer.Models;

    public sealed class FridgeOrganizerDatebase
    {
        static readonly Lazy<SQLiteAsyncConnection> lazyInitializer = new Lazy<SQLiteAsyncConnection>(() =>
        {
            return new SQLiteAsyncConnection(Constants.DatabasePath, Constants.Flags);
        });

        static SQLiteAsyncConnection Database => lazyInitializer.Value;
        static bool initialized = false;

        public FridgeOrganizerDatebase()
        {
            InitializeAsync().SafeFireAndForget(false);
        }

        async Task InitializeAsync()
        {
            if (!initialized)
            {
                if (!Database.TableMappings.Any(m => m.MappedType.Name == typeof(FridgeItem).Name))
                {
                    await Database.CreateTablesAsync(CreateFlags.None, typeof(FridgeItem)).ConfigureAwait(false);
                }

                if (!Database.TableMappings.Any(m => m.MappedType.Name == typeof(Category).Name))
                {
                    await Database.CreateTablesAsync(CreateFlags.None, typeof(Category)).ConfigureAwait(false);
                }
                initialized = true;
            }
        }

        #region FridgeItem
        public Task<List<T>> GetItemsAsync<T>() where T: IItem, new()
        {
            return Database.Table<T>().ToListAsync();
        }

        //public Task<List<FridgeItem>> GetExpiredItems()
        //{
        //    // SQL queries are also possible
        //    return Database.QueryAsync<FridgeItem>("SELECT * FROM [FridgeItem] WHERE [Expiry] IS NOT NULL AND [Expiry] < date('now')");
        //}

        public Task<T> GetItemAsync<T>(Guid id) where T : IItem, new()
        {
            return Database.Table<T>().Where(i => i.Id == id).FirstOrDefaultAsync();
        }

        public Task<int> SaveItemAsync<T>(T item) where T : IItem, new()
        {
            if (Guid.Empty != item.Id)
            {
                return Database.UpdateAsync(item);
            }
            else
            {
                return Database.InsertAsync(item);
            }
        }

        public Task<int> DeleteItemAsync<T>(T item) where T : IItem, new()
        {
            return Database.DeleteAsync(item);
        }

        #endregion

   }
}
