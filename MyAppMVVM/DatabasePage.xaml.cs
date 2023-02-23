using SQLite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using MyAppMVVM.Models;

namespace MyAppMVVM
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DataBase : ContentPage
    {
        private SQLiteAsyncConnection connection;
        public DataBase()
        {
            InitializeComponent();
        }
        /*
        public async void CreateDatabaeButton_Clicked(object sender, EventArgs args)
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

        public async void InsertDataButton_Clicked(object sender, EventArgs args)
        {
            var favorite = new Favorite { IsFavorite = true };
            await connection.InsertAsync(favorite);
        }

        public async void ReadDataButton_Clicked(object sender, EventArgs args)
        {
            ResultListView.ItemsSource =
            await connection.Table<Favorite>().ToListAsync();
        }
        */
    }
}