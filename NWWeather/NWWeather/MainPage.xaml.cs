using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using System.Collections.ObjectModel;
using System.Net.Http;
using Newtonsoft.Json;


// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace NWWeather
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        ObservableCollection<NorthwindData> _results;
        public MainPage()
        {
            this.InitializeComponent();
            _results = new ObservableCollection<NorthwindData>();
            lvResults.ItemsSource = _results;
        }

        private async void Page_Loaded(object sender, RoutedEventArgs e)
        {
            _results.Clear();
            using (var client = new HttpClient())
            {
                //Now
                var NowResponse =
                      await client.GetStringAsync("https://finalprojectcomp494.azurewebsites.net/api/weather/1");
                var NowInformation = JsonConvert.DeserializeObject<NorthwindNowData>(NowResponse);
                //*********TO DO IMAGE HERE???? MAYBE??? IS IT REQUIRED?
                CurrentTemp.Text = NowInformation.tempF.ToString()+" *F";
                CurrentTitle.Text = NowInformation.weather;
                CurrentWind.Text = "Winds: " + NowInformation.windDir + " at " + NowInformation.windMph.ToString()+" mph";
                CurrentHumidity.Text = "Relative Humidity: " + NowInformation.relativeHumidity;
                CurrentUpdated.Text = NowInformation.observationTime;
                

                //Predictions
                var Response =
                      await client.GetStringAsync("https://finalprojectcomp494.azurewebsites.net/api/weather/");
                 var ReturnList = JsonConvert.DeserializeObject<List<NorthwindData>>(Response);
                 foreach (var item in ReturnList)
                 { _results.Add(item); }
            }
        }
    }
}
