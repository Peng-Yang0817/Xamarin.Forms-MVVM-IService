using MyAppMVVM.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace MyAppMVVM.Services
{
    public class FavoriteStorage : IFavoriteStorage
    {
        private SQLiteAsyncConnection connection;
        public async Task CreateDatabaseAsync()
        {
            // 取得當前平台APP的特殊區域存儲路徑，有一個叫db.db的檔案
            var databasePath = Path.Combine(
                Environment.GetFolderPath(
                    Environment.SpecialFolder.LocalApplicationData
                ), "db.db"
            );

            // 創立連接
            connection = new SQLiteAsyncConnection(databasePath);

            // 刪除數據庫
            await connection.DropTableAsync<Favorite>();

            // 建立數據庫
            await connection.CreateTableAsync<Favorite>();
        }

        public async Task InserDatabaseAsync(Favorite favorite)
        {
            await connection.InsertAsync(favorite);
        }

        public async Task<IList<Favorite>> ReadDataAsync()
        {
            return await connection.Table<Favorite>().ToListAsync();
        }
    }
}
