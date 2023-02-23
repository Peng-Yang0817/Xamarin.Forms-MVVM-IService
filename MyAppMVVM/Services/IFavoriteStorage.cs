using System;
using System.Collections.Generic;
using System.Text;
using MyAppMVVM.Models;
using System.Threading.Tasks;

namespace MyAppMVVM.Services
{
    public interface IFavoriteStorage
    {
        Task CreateDatabaseAsync();

        Task InserDatabaseAsync(Favorite favorite);

        Task<IList<Favorite>> ReadDataAsync();
    }
}
