using System;
using System.Collections.Generic;
using System.Text;

using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;

namespace MyAppMVVM.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
        /// <summary>
        /// 結果，系統內的真實值
        /// </summary>
        private string _result;

        public string Result
        {
            get => _result;
            set => Set(nameof(Result), ref _result, value);
        }

        /// <summary>
        /// Hellow命令
        /// </summary>
        private RelayCommand _helloCommand;

        public RelayCommand HelloCommand
        {
            get
            {
                if (_helloCommand == null)
                {
                    _helloCommand = new RelayCommand(() =>
                    {
                        Result = "Hello Word!";
                    });
                }
                return _helloCommand;
            }
        }
    }
}
