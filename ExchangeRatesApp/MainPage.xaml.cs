using ExchangeRatesApp.Helper;
using ExchangeRatesApp.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ExchangeRatesApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            GetExchangeRatesInfo();
        }

        private static string TodayDate = GetDateInRightFormat(DateTime.Today.Date);
        private static string TomorrowDate = GetDateInRightFormat(DateTime.Today.Date.AddDays(1));
        private static string YesterdayDate = GetDateInRightFormat(DateTime.Today.Date.AddDays(-1));

        private async void GetExchangeRatesInfo()
        {
            var url = $"https://www.nbrb.by/api/exrates/rates?periodicity=0";
            Today_Date.Text = TodayDate.ToString();
            Tomorrow_Date.Text = TomorrowDate.ToString();
           //var url = $"https://www.nbrb.by/api/exrates/rates?ondate={TodayDate}&periodicity=0";

            var result = await ApiCaller.Get(url);

            if (result.Successful)
            {
                try
                {
                    Rate[] ExchangeInfo = JsonConvert.DeserializeObject<Rate[]>(result.Response);
                    int i = 1;

                    int[] Cur_Id = new int[26];
                    //for(int j = 0; j < ExchangeInfo.Length; j++)
                    //{
                    //Cur_Id[i] = ExchangeInfo[i].Cur_ID;
                    //curAbbrv1.Text = ExchangeInfo[0].Cur_Abbreviation;
                    //curScale1.Text = ExchangeInfo[0].Cur_Scale.ToString();
                    //curName1.Text = ExchangeInfo[0].Cur_Name;
                    //tomorrow_rate1.Text = ExchangeInfo[0].Cur_OfficialRate.ToString();

                    //curAbbrv1.Text = ExchangeInfo[1].Cur_Abbreviation;
                    //curScale1.Text = ExchangeInfo[1].Cur_Scale.ToString();
                    //curName1.Text = ExchangeInfo[1].Cur_Name;
                    //tomorrow_rate1.Text = ExchangeInfo[1].Cur_OfficialRate.ToString();

                    //curAbbrv25.Text = ExchangeInfo[24].Cur_Abbreviation;
                    //curScale25.Text = ExchangeInfo[24].Cur_Scale.ToString();
                    //curName25.Text = ExchangeInfo[24].Cur_Name;
                    //tomorrow_rate25.Text = ExchangeInfo[24].Cur_OfficialRate.ToString();
                    curAbbrv1.Text = ExchangeInfo[0].Cur_Abbreviation;
                    curScale1.Text = ExchangeInfo[0].Cur_Scale.ToString();
                    curName1.Text = ExchangeInfo[0].Cur_Name;
                    tomorrow_rate1.Text = ExchangeInfo[0].Cur_OfficialRate.ToString();

                    curAbbrv2.Text = ExchangeInfo[1].Cur_Abbreviation;
                    curScale2.Text = ExchangeInfo[1].Cur_Scale.ToString();
                    curName2.Text = ExchangeInfo[1].Cur_Name;
                    tomorrow_rate2.Text = ExchangeInfo[1].Cur_OfficialRate.ToString();

                    curAbbrv3.Text = ExchangeInfo[2].Cur_Abbreviation;
                    curScale3.Text = ExchangeInfo[2].Cur_Scale.ToString();
                    curName3.Text = ExchangeInfo[2].Cur_Name;
                    tomorrow_rate3.Text = ExchangeInfo[2].Cur_OfficialRate.ToString();

                    curAbbrv4.Text = ExchangeInfo[3].Cur_Abbreviation;
                    curScale4.Text = ExchangeInfo[3].Cur_Scale.ToString();
                    curName4.Text = ExchangeInfo[3].Cur_Name;
                    tomorrow_rate4.Text = ExchangeInfo[3].Cur_OfficialRate.ToString();

                    curAbbrv5.Text = ExchangeInfo[4].Cur_Abbreviation;
                    curScale5.Text = ExchangeInfo[4].Cur_Scale.ToString();
                    curName5.Text = ExchangeInfo[4].Cur_Name;
                    tomorrow_rate5.Text = ExchangeInfo[4].Cur_OfficialRate.ToString();

                    curAbbrv6.Text = ExchangeInfo[5].Cur_Abbreviation;
                    curScale6.Text = ExchangeInfo[5].Cur_Scale.ToString();
                    curName6.Text = ExchangeInfo[5].Cur_Name;
                    tomorrow_rate6.Text = ExchangeInfo[5].Cur_OfficialRate.ToString();

                    curAbbrv7.Text = ExchangeInfo[6].Cur_Abbreviation;
                    curScale7.Text = ExchangeInfo[6].Cur_Scale.ToString();
                    curName7.Text = ExchangeInfo[6].Cur_Name;
                    tomorrow_rate7.Text = ExchangeInfo[6].Cur_OfficialRate.ToString();

                    curAbbrv8.Text = ExchangeInfo[7].Cur_Abbreviation;
                    curScale8.Text = ExchangeInfo[7].Cur_Scale.ToString();
                    curName8.Text = ExchangeInfo[7].Cur_Name;
                    tomorrow_rate8.Text = ExchangeInfo[7].Cur_OfficialRate.ToString();

                    curAbbrv9.Text = ExchangeInfo[8].Cur_Abbreviation;
                    curScale9.Text = ExchangeInfo[8].Cur_Scale.ToString();
                    curName9.Text = ExchangeInfo[8].Cur_Name;
                    tomorrow_rate9.Text = ExchangeInfo[8].Cur_OfficialRate.ToString();

                    curAbbrv10.Text = ExchangeInfo[9].Cur_Abbreviation;
                    curScale10.Text = ExchangeInfo[9].Cur_Scale.ToString();
                    curName10.Text = ExchangeInfo[9].Cur_Name;
                    tomorrow_rate10.Text = ExchangeInfo[9].Cur_OfficialRate.ToString();

                    curAbbrv11.Text = ExchangeInfo[10].Cur_Abbreviation;
                    curScale11.Text = ExchangeInfo[10].Cur_Scale.ToString();
                    curName11.Text = ExchangeInfo[10].Cur_Name;
                    tomorrow_rate11.Text = ExchangeInfo[10].Cur_OfficialRate.ToString();

                    curAbbrv12.Text = ExchangeInfo[11].Cur_Abbreviation;
                    curScale12.Text = ExchangeInfo[11].Cur_Scale.ToString();
                    curName12.Text = ExchangeInfo[11].Cur_Name;
                    tomorrow_rate12.Text = ExchangeInfo[11].Cur_OfficialRate.ToString();

                    curAbbrv13.Text = ExchangeInfo[12].Cur_Abbreviation;
                    curScale13.Text = ExchangeInfo[12].Cur_Scale.ToString();
                    curName13.Text = ExchangeInfo[12].Cur_Name;
                    tomorrow_rate13.Text = ExchangeInfo[12].Cur_OfficialRate.ToString();

                    curAbbrv14.Text = ExchangeInfo[13].Cur_Abbreviation;
                    curScale14.Text = ExchangeInfo[13].Cur_Scale.ToString();
                    curName14.Text = ExchangeInfo[13].Cur_Name;
                    tomorrow_rate14.Text = ExchangeInfo[13].Cur_OfficialRate.ToString();

                    curAbbrv15.Text = ExchangeInfo[14].Cur_Abbreviation;
                    curScale15.Text = ExchangeInfo[14].Cur_Scale.ToString();
                    curName15.Text = ExchangeInfo[14].Cur_Name;
                    tomorrow_rate15.Text = ExchangeInfo[14].Cur_OfficialRate.ToString();

                    curAbbrv16.Text = ExchangeInfo[15].Cur_Abbreviation;
                    curScale16.Text = ExchangeInfo[15].Cur_Scale.ToString();
                    curName16.Text = ExchangeInfo[15].Cur_Name;
                    tomorrow_rate16.Text = ExchangeInfo[15].Cur_OfficialRate.ToString();

                    curAbbrv17.Text = ExchangeInfo[16].Cur_Abbreviation;
                    curScale17.Text = ExchangeInfo[16].Cur_Scale.ToString();
                    curName17.Text = ExchangeInfo[16].Cur_Name;
                    tomorrow_rate17.Text = ExchangeInfo[16].Cur_OfficialRate.ToString();

                    curAbbrv18.Text = ExchangeInfo[17].Cur_Abbreviation;
                    curScale18.Text = ExchangeInfo[17].Cur_Scale.ToString();
                    curName18.Text = ExchangeInfo[17].Cur_Name;
                    tomorrow_rate18.Text = ExchangeInfo[17].Cur_OfficialRate.ToString();

                    curAbbrv19.Text = ExchangeInfo[18].Cur_Abbreviation;
                    curScale19.Text = ExchangeInfo[18].Cur_Scale.ToString();
                    curName19.Text = ExchangeInfo[18].Cur_Name;
                    tomorrow_rate19.Text = ExchangeInfo[18].Cur_OfficialRate.ToString();

                    curAbbrv20.Text = ExchangeInfo[19].Cur_Abbreviation;
                    curScale20.Text = ExchangeInfo[19].Cur_Scale.ToString();
                    curName20.Text = ExchangeInfo[19].Cur_Name;
                    tomorrow_rate20.Text = ExchangeInfo[19].Cur_OfficialRate.ToString();

                    curAbbrv21.Text = ExchangeInfo[20].Cur_Abbreviation;
                    curScale21.Text = ExchangeInfo[20].Cur_Scale.ToString();
                    curName21.Text = ExchangeInfo[20].Cur_Name;
                    tomorrow_rate21.Text = ExchangeInfo[20].Cur_OfficialRate.ToString();

                    curAbbrv22.Text = ExchangeInfo[21].Cur_Abbreviation;
                    curScale22.Text = ExchangeInfo[21].Cur_Scale.ToString();
                    curName22.Text = ExchangeInfo[21].Cur_Name;
                    tomorrow_rate22.Text = ExchangeInfo[21].Cur_OfficialRate.ToString();

                    curAbbrv23.Text = ExchangeInfo[22].Cur_Abbreviation;
                    curScale23.Text = ExchangeInfo[22].Cur_Scale.ToString();
                    curName23.Text = ExchangeInfo[22].Cur_Name;
                    tomorrow_rate23.Text = ExchangeInfo[22].Cur_OfficialRate.ToString();

                    curAbbrv24.Text = ExchangeInfo[23].Cur_Abbreviation;
                    curScale24.Text = ExchangeInfo[23].Cur_Scale.ToString();
                    curName24.Text = ExchangeInfo[23].Cur_Name;
                    tomorrow_rate24.Text = ExchangeInfo[23].Cur_OfficialRate.ToString();

                    curAbbrv25.Text = ExchangeInfo[24].Cur_Abbreviation;
                    curScale25.Text = ExchangeInfo[24].Cur_Scale.ToString();
                    curName25.Text = ExchangeInfo[24].Cur_Name;
                    tomorrow_rate25.Text = ExchangeInfo[24].Cur_OfficialRate.ToString();

                    curAbbrv26.Text = ExchangeInfo[25].Cur_Abbreviation;
                        curScale26.Text = ExchangeInfo[25].Cur_Scale.ToString();
                        curName26.Text = ExchangeInfo[25].Cur_Name;
                        tomorrow_rate26.Text = ExchangeInfo[25].Cur_OfficialRate.ToString();

                    //var dt = new DateTime().ToUniversalTime().AddSeconds(weatherInfo.dt);
                    //dateTxt.Text = dt.ToString("dddd, MMM dd").ToUpper();

                    //GetForecast();
                    //GetBackground();
                }
                catch (Exception ex)
                {
                    await DisplayAlert("Weather Info", ex.Message, "OK");
                }
            }
            else
            {
                var url_1 = $"https://www.nbrb.by/api/exrates/rates?ondate={TodayDate}&periodicity=0";
                var ExchangeInfo = JsonConvert.DeserializeObject<List<Rate>>(result.Response);
            }

        }
        private static void AddGridRow(Grid grid, int newrow, float cur_tod, float cur_tom)
        {
            //grid.Children.Add(new StackLayout { 
            //new Label{ 
            //}
            //});
            grid.Children.Add(new Label{
               Text = cur_tod.ToString(),
               TextColor = Color.Black,
               FontSize = 24,
               HorizontalTextAlignment = TextAlignment.End,
            }, newrow, 2);
            grid.Children.Add(new Label
            {
                Text = cur_tom.ToString(),
                TextColor = Color.Black,
                FontSize = 24,
                HorizontalTextAlignment = TextAlignment.End,
            }, newrow, 2);

        }
        private static string GetDateInRightFormat(DateTime dt)
        {
            string date = dt.ToString("s");

            //DateTime RightDate = DateTime.Parse(date);
            //return RightDate;
            return date;
        }

        private async void Settings_Open(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Pages.SettingsPage());
        }
    }
}
