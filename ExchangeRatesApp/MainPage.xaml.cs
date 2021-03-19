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
            WillShow = new bool[26] { true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true};
            GetExchangeRatesInfo();
        }

        public MainPage(bool[] WillShowGet)
        {
            WillShow = WillShowGet;
        }

        private static string TodayDate = GetDateInRightFormat(DateTime.Today.Date);
        private static string TomorrowDate = GetDateInRightFormat(DateTime.Today.Date.AddDays(1));
        private static string YesterdayDate = GetDateInRightFormat(DateTime.Today.Date.AddDays(-1));
        public static bool[] WillShow = new bool[26];

        private async void GetExchangeRatesInfo()
        {
            var url = $"https://www.nbrb.by/api/exrates/rates?ondate={TomorrowDate}&periodicity=0";

            var result = await ApiCaller.Get(url);

            //массив для проверки надобности вывода валюты
            int[] Cur_Id = new int[26];

            if (result.Successful)
            {
                try
                {
                    Today_Date.Text = ReturnRightDate(DateTime.Today.Date);
                    Tomorrow_Date.Text = ReturnRightDate(DateTime.Today.AddDays(1).Date);
                    Rate[] ExchangeInfo = JsonConvert.DeserializeObject<Rate[]>(result.Response);


                    AddExchangeInfo(ExchangeInfo);
                    AddTomorrowInfo(ExchangeInfo);
                    var url1 = $"https://www.nbrb.by/api/exrates/rates?ondate={TodayDate}&periodicity=0";
                    var result1 = await ApiCaller.Get(url1);

                    try 
                    {
                        Rate[] ExchangeInfo1 = JsonConvert.DeserializeObject<Rate[]>(result1.Response);
                        AddTodayInfo(ExchangeInfo1);
                    }
                    catch (Exception ex1)
                    {
                        await DisplayAlert("Exchange Rates Info", ex1.Message, "OK");
                    }

                }
                catch (Exception ex)
                {
                    await DisplayAlert("Exchange Rates Info", ex.Message, "OK");
                }
            }
            else
            {
                Today_Date.Text = ReturnRightDate(DateTime.Today.AddDays(-1).Date);
                Tomorrow_Date.Text = ReturnRightDate(DateTime.Today.Date);
                var url_1 = $"https://www.nbrb.by/api/exrates/rates?ondate={TodayDate}&periodicity=0";
                var result2 = await ApiCaller.Get(url_1);
                if (result2.Successful)
                {
                    try
                    {
                        Rate[] ExchangeInfo2 = JsonConvert.DeserializeObject<Rate[]>(result.Response);
                        AddExchangeInfo(ExchangeInfo2);
                        AddTomorrowInfo(ExchangeInfo2);

                        var url_2 = $"https://www.nbrb.by/api/exrates/rates?ondate={TodayDate}&periodicity=0";
                        var result3 = await ApiCaller.Get(url_2);

                        try
                        {
                            Rate[] ExchangeInfo4 = JsonConvert.DeserializeObject<Rate[]>(result3.Response);
                            AddTodayInfo(ExchangeInfo4);
                        }
                        catch (Exception ex1)
                        {
                            await DisplayAlert("Exchange Rates Info", ex1.Message, "OK");
                        }
                    }
                    catch (Exception ex3)
                    {
                        await DisplayAlert("Exchange Rates Info", ex3.Message, "OK");
                    }
                }
                else
                {
                   await DisplayAlert("Exchange Rates Info", "Не удалось получить курсы валют", "OK");
                    Settings.IsEnabled = false;
                }
            }
        }

        private int GetTrueAmount()
        {
            int count = 0;
            for (int i = 0; i < 26; i++)
            {
                if (WillShow[i] == true)
                    count++;
            }
            return count;
        }
        private void AddExchangeInfo(Rate[] ExchangeInfo)
        {

            curAbbrv1.Text = ExchangeInfo[0].Cur_Abbreviation;
            curScale1.Text = ExchangeInfo[0].Cur_Scale.ToString();
            curName1.Text = ExchangeInfo[0].Cur_Name;

            curAbbrv2.Text = ExchangeInfo[1].Cur_Abbreviation;
            curScale2.Text = ExchangeInfo[1].Cur_Scale.ToString();
            curName2.Text = ExchangeInfo[1].Cur_Name;          

            curAbbrv3.Text = ExchangeInfo[2].Cur_Abbreviation;
            curScale3.Text = ExchangeInfo[2].Cur_Scale.ToString();
            curName3.Text = ExchangeInfo[2].Cur_Name;

            curAbbrv4.Text = ExchangeInfo[3].Cur_Abbreviation;
            curScale4.Text = ExchangeInfo[3].Cur_Scale.ToString();
            curName4.Text = ExchangeInfo[3].Cur_Name;           

            curAbbrv5.Text = ExchangeInfo[4].Cur_Abbreviation;
            curScale5.Text = ExchangeInfo[4].Cur_Scale.ToString();
            curName5.Text = ExchangeInfo[4].Cur_Name;

            curAbbrv6.Text = ExchangeInfo[5].Cur_Abbreviation;
            curScale6.Text = ExchangeInfo[5].Cur_Scale.ToString();
            curName6.Text = ExchangeInfo[5].Cur_Name;
            
            curAbbrv7.Text = ExchangeInfo[6].Cur_Abbreviation;
            curScale7.Text = ExchangeInfo[6].Cur_Scale.ToString();
            curName7.Text = ExchangeInfo[6].Cur_Name;
            
            curAbbrv8.Text = ExchangeInfo[7].Cur_Abbreviation;
            curScale8.Text = ExchangeInfo[7].Cur_Scale.ToString();
            curName8.Text = ExchangeInfo[7].Cur_Name;
            
            curAbbrv9.Text = ExchangeInfo[8].Cur_Abbreviation;
            curScale9.Text = ExchangeInfo[8].Cur_Scale.ToString();
            curName9.Text = ExchangeInfo[8].Cur_Name;

            curAbbrv10.Text = ExchangeInfo[9].Cur_Abbreviation;
            curScale10.Text = ExchangeInfo[9].Cur_Scale.ToString();
            curName10.Text = ExchangeInfo[9].Cur_Name;

            curAbbrv11.Text = ExchangeInfo[10].Cur_Abbreviation;
            curScale11.Text = ExchangeInfo[10].Cur_Scale.ToString();
            curName11.Text = ExchangeInfo[10].Cur_Name;
            
            curAbbrv12.Text = ExchangeInfo[11].Cur_Abbreviation;
            curScale12.Text = ExchangeInfo[11].Cur_Scale.ToString();
            curName12.Text = ExchangeInfo[11].Cur_Name;            

            curAbbrv13.Text = ExchangeInfo[12].Cur_Abbreviation;
            curScale13.Text = ExchangeInfo[12].Cur_Scale.ToString();
            curName13.Text = ExchangeInfo[12].Cur_Name;

            curAbbrv14.Text = ExchangeInfo[13].Cur_Abbreviation;
            curScale14.Text = ExchangeInfo[13].Cur_Scale.ToString();
            curName14.Text = ExchangeInfo[13].Cur_Name;

            curAbbrv15.Text = ExchangeInfo[14].Cur_Abbreviation;
            curScale15.Text = ExchangeInfo[14].Cur_Scale.ToString();
            curName15.Text = ExchangeInfo[14].Cur_Name;
            
            curAbbrv16.Text = ExchangeInfo[15].Cur_Abbreviation;
            curScale16.Text = ExchangeInfo[15].Cur_Scale.ToString();
            curName16.Text = ExchangeInfo[15].Cur_Name;
            
            curAbbrv17.Text = ExchangeInfo[16].Cur_Abbreviation;
            curScale17.Text = ExchangeInfo[16].Cur_Scale.ToString();
            curName17.Text = ExchangeInfo[16].Cur_Name;           

            curAbbrv18.Text = ExchangeInfo[17].Cur_Abbreviation;
            curScale18.Text = ExchangeInfo[17].Cur_Scale.ToString();
            curName18.Text = ExchangeInfo[17].Cur_Name;
            
            curAbbrv19.Text = ExchangeInfo[18].Cur_Abbreviation;
            curScale19.Text = ExchangeInfo[18].Cur_Scale.ToString();
            curName19.Text = ExchangeInfo[18].Cur_Name;
            
            curAbbrv20.Text = ExchangeInfo[19].Cur_Abbreviation;
            curScale20.Text = ExchangeInfo[19].Cur_Scale.ToString();
            curName20.Text = ExchangeInfo[19].Cur_Name;
            
            curAbbrv21.Text = ExchangeInfo[20].Cur_Abbreviation;
            curScale21.Text = ExchangeInfo[20].Cur_Scale.ToString();
            curName21.Text = ExchangeInfo[20].Cur_Name;
            
            curAbbrv22.Text = ExchangeInfo[21].Cur_Abbreviation;
            curScale22.Text = ExchangeInfo[21].Cur_Scale.ToString();
            curName22.Text = ExchangeInfo[21].Cur_Name;        

            curAbbrv23.Text = ExchangeInfo[22].Cur_Abbreviation;
            curScale23.Text = ExchangeInfo[22].Cur_Scale.ToString();
            curName23.Text = ExchangeInfo[22].Cur_Name;

            curAbbrv24.Text = ExchangeInfo[23].Cur_Abbreviation;
            curScale24.Text = ExchangeInfo[23].Cur_Scale.ToString();
            curName24.Text = ExchangeInfo[23].Cur_Name;

            curAbbrv25.Text = ExchangeInfo[24].Cur_Abbreviation;
            curScale25.Text = ExchangeInfo[24].Cur_Scale.ToString();
            curName25.Text = ExchangeInfo[24].Cur_Name;          

            curAbbrv26.Text = ExchangeInfo[25].Cur_Abbreviation;
            curScale26.Text = ExchangeInfo[25].Cur_Scale.ToString();
            curName26.Text = ExchangeInfo[25].Cur_Name;           
        }
        private void AddTomorrowInfo(Rate[] ExchangeInfo)
        {
            tomorrow_rate1.Text = ExchangeInfo[0].Cur_OfficialRate.ToString();
            tomorrow_rate2.Text = ExchangeInfo[1].Cur_OfficialRate.ToString();
            tomorrow_rate3.Text = ExchangeInfo[2].Cur_OfficialRate.ToString();
            tomorrow_rate4.Text = ExchangeInfo[3].Cur_OfficialRate.ToString();
            tomorrow_rate5.Text = ExchangeInfo[4].Cur_OfficialRate.ToString();
            tomorrow_rate6.Text = ExchangeInfo[5].Cur_OfficialRate.ToString();
            tomorrow_rate7.Text = ExchangeInfo[6].Cur_OfficialRate.ToString();
            tomorrow_rate8.Text = ExchangeInfo[7].Cur_OfficialRate.ToString();
            tomorrow_rate9.Text = ExchangeInfo[8].Cur_OfficialRate.ToString();
            tomorrow_rate10.Text = ExchangeInfo[9].Cur_OfficialRate.ToString();
            tomorrow_rate11.Text = ExchangeInfo[10].Cur_OfficialRate.ToString();
            tomorrow_rate12.Text = ExchangeInfo[11].Cur_OfficialRate.ToString();
            tomorrow_rate13.Text = ExchangeInfo[12].Cur_OfficialRate.ToString();
            tomorrow_rate14.Text = ExchangeInfo[13].Cur_OfficialRate.ToString();
            tomorrow_rate15.Text = ExchangeInfo[14].Cur_OfficialRate.ToString();
            tomorrow_rate16.Text = ExchangeInfo[15].Cur_OfficialRate.ToString();
            tomorrow_rate17.Text = ExchangeInfo[16].Cur_OfficialRate.ToString();
            tomorrow_rate18.Text = ExchangeInfo[17].Cur_OfficialRate.ToString();
            tomorrow_rate19.Text = ExchangeInfo[18].Cur_OfficialRate.ToString();
            tomorrow_rate20.Text = ExchangeInfo[19].Cur_OfficialRate.ToString();
            tomorrow_rate21.Text = ExchangeInfo[20].Cur_OfficialRate.ToString();
            tomorrow_rate22.Text = ExchangeInfo[21].Cur_OfficialRate.ToString();
            tomorrow_rate23.Text = ExchangeInfo[22].Cur_OfficialRate.ToString();
            tomorrow_rate24.Text = ExchangeInfo[23].Cur_OfficialRate.ToString();
            tomorrow_rate25.Text = ExchangeInfo[24].Cur_OfficialRate.ToString();
            tomorrow_rate26.Text = ExchangeInfo[25].Cur_OfficialRate.ToString();
        }

        private void AddTodayInfo(Rate[] ExchangeInfo)
        {
            today_rate1.Text = ExchangeInfo[0].Cur_OfficialRate.ToString();
            today_rate2.Text = ExchangeInfo[1].Cur_OfficialRate.ToString();
            today_rate3.Text = ExchangeInfo[2].Cur_OfficialRate.ToString();
            today_rate4.Text = ExchangeInfo[3].Cur_OfficialRate.ToString();
            today_rate5.Text = ExchangeInfo[4].Cur_OfficialRate.ToString();
            today_rate6.Text = ExchangeInfo[5].Cur_OfficialRate.ToString();
            today_rate7.Text = ExchangeInfo[6].Cur_OfficialRate.ToString();
            today_rate8.Text = ExchangeInfo[7].Cur_OfficialRate.ToString();
            today_rate9.Text = ExchangeInfo[8].Cur_OfficialRate.ToString();
            today_rate10.Text = ExchangeInfo[9].Cur_OfficialRate.ToString();
            today_rate11.Text = ExchangeInfo[10].Cur_OfficialRate.ToString();
            today_rate12.Text = ExchangeInfo[11].Cur_OfficialRate.ToString();
            today_rate13.Text = ExchangeInfo[12].Cur_OfficialRate.ToString();
            today_rate14.Text = ExchangeInfo[13].Cur_OfficialRate.ToString();
            today_rate15.Text = ExchangeInfo[14].Cur_OfficialRate.ToString();
            today_rate16.Text = ExchangeInfo[15].Cur_OfficialRate.ToString();
            today_rate17.Text = ExchangeInfo[16].Cur_OfficialRate.ToString();
            today_rate18.Text = ExchangeInfo[17].Cur_OfficialRate.ToString();
            today_rate19.Text = ExchangeInfo[18].Cur_OfficialRate.ToString();
            today_rate20.Text = ExchangeInfo[19].Cur_OfficialRate.ToString();
            today_rate21.Text = ExchangeInfo[20].Cur_OfficialRate.ToString();
            today_rate22.Text = ExchangeInfo[21].Cur_OfficialRate.ToString();
            today_rate23.Text = ExchangeInfo[22].Cur_OfficialRate.ToString();
            today_rate24.Text = ExchangeInfo[23].Cur_OfficialRate.ToString();
            today_rate25.Text = ExchangeInfo[24].Cur_OfficialRate.ToString();
            today_rate26.Text = ExchangeInfo[25].Cur_OfficialRate.ToString();
        }
        private static void AddGridRow(Grid grid, int newrow, float cur_tod, float cur_tom)
        {
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
        //формат даты для JSON
        private static string GetDateInRightFormat(DateTime dt) 
        {
            string date1 = dt.ToString("s");
            string date = date1.Substring(0, date1.Length - 9);
            return date;
        }

        //формат даты для отображения
        private static string ReturnRightDate(DateTime dt)
        {
            string RightDate = dt.ToString("dd.MM.yyyy");
            return RightDate;
        }
        private async void Settings_Open(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Pages.SettingsPage(WillShow), true);
        }
    }
}
