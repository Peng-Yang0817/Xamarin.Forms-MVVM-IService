using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using Newtonsoft.Json;

namespace MyAppMVVM
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class WebService : ContentPage
    {
        public WebService()
        {
            InitializeComponent();
        }
        public async void CallWebServiceButton_OnClicked(object sender, EventArgs args)
        {
            var httpClient = new HttpClient();
            var response = await httpClient.GetAsync("https://v2.jinrishici.com/token");

            var json = await response.Content.ReadAsStringAsync();

            var token = JsonConvert.DeserializeObject<JinrishiciToken>(json);

            ResultLabel.Text = token.Data;
        }
    }
    public partial class JinrishiciToken
    {
        public string Status { get; set; }

        public string Data { get; set; }
    }
}