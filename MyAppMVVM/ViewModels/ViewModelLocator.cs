using System;
using System.Collections.Generic;
using System.Text;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Ioc;
using MyAppMVVM.Services;

namespace MyAppMVVM.ViewModels
{
    public class ViewModelLocator : ViewModelBase
    {
        /// <summary>
        /// 註冊剛剛建立好的MainPageViewModel
        /// 也就等於再SimpleIoc內註冊一個類
        /// </summary>
        public ViewModelLocator()
        {
            SimpleIoc.Default.Register<MainPageViewModel>();
            SimpleIoc.Default.Register<DatabasePageViewModel>();
            SimpleIoc.Default.Register<IFavoriteStorage, FavoriteStorage>();
        }

        /// <summary>
        /// View 找我，調用我有註冊的MainPageViewModel這個屬性
        /// 我就會透過SimpleIoc來幫妳返回ViewModel實例
        /// </summary>
        public MainPageViewModel MainPageViewModel =>
            SimpleIoc.Default.GetInstance<MainPageViewModel>();

        public DatabasePageViewModel DatabasePageViewModel =>
           SimpleIoc.Default.GetInstance<DatabasePageViewModel>();
    }
}
