using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyAppMVVM
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Preference : ContentPage
    {
        public Preference()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 在這個方法中，程式首先讀取了 PreferenceEntry 的文字內容
        /// 接著使用 Xamarin.Essentials 套件提供的 Preferences 類別來儲存使用者的偏好設定。
        /// 其中，Set 方法需要兩個參數：一個是用來識別這個偏好設定的鍵 (Key)，另一個是要儲存的值 (Value)。
        /// 在這裡，鍵設為 "Key"，而要儲存的值則是從 PreferenceEntry 讀取的文字內容 saveValue。
        /// </summary>
        public void PreferenceSaveButton_Clicked(object sender, EventArgs args)
        {
            string saveValue = PreferenceEntry.Text;
            Xamarin.Essentials.Preferences.Set("Key", saveValue);
        }

        public void PreferenceReadButton_Clicked(object sender, EventArgs args)
        {
            PreferenceResultLabel.Text = 
                Xamarin.Essentials.Preferences.Get("Key","No Value");
        }
    }
}