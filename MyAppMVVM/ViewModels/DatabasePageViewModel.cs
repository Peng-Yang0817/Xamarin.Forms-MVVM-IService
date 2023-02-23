using System;
using System.Collections.Generic;
using System.Text;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using MyAppMVVM.Services;
using MyAppMVVM.Models;
using MvvmHelpers;

namespace MyAppMVVM.ViewModels
{
    public class DatabasePageViewModel : ViewModelBase
    {
        private IFavoriteStorage _favoriteStorage;

        public DatabasePageViewModel(IFavoriteStorage favoriteStorage)
        {
            _favoriteStorage = favoriteStorage;
        }

        public RelayCommand _createDatabaseCommand;
        public RelayCommand CreateDatabaseCommand =>
            _createDatabaseCommand ?? (_createDatabaseCommand =
                new RelayCommand(async () => await _favoriteStorage.CreateDatabaseAsync()));


        public RelayCommand _insertDataCommand;
        public RelayCommand InsertDataCommand =>
            _insertDataCommand ?? (_insertDataCommand =
                new RelayCommand(async () =>
                    await _favoriteStorage.InserDatabaseAsync(
                        new Favorite { IsFavorite = true })));


        public RelayCommand _readDataCommand;
        public RelayCommand ReadDataCommand =>
            _readDataCommand ?? (_readDataCommand =
                new RelayCommand(async () =>
                {
                    var results = await _favoriteStorage.ReadDataAsync();
                    Favorites.AddRange(results);
                }));

        /// <summary>
        /// 有這寫法才能在前端顯示ListView
        /// </summary>
        public ObservableRangeCollection<Favorite> Favorites { get; } =
            new ObservableRangeCollection<Favorite>();
    }
}
