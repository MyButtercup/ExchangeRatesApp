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
        }

        private static DateTime TodayDate = GetDateInRightFormat(DateTime.Now);
        private static DateTime TomorrowDate = GetDateInRightFormat(TodayDate.AddDays(1));
        private static DateTime YesterdayDate = GetDateInRightFormat(TodayDate.AddDays(-1));

        private async void GetExchangeRatesInfo()
        {
            var url = $"https://www.nbrb.by/api/exrates/rates?ondate={TomorrowDate}&periodicity=0";
        }

        private static DateTime GetDateInRightFormat(DateTime dt)
        {
            string date = dt.ToString("s");
            DateTime RightDate = DateTime.Parse(date);
            return RightDate;
        }
    }
}
