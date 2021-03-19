using ExchangeRatesApp.Helper;
using ExchangeRatesApp.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ExchangeRatesApp.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SettingsPage : ContentPage
    {
        public bool[] WillShow = new bool[26];
        public SettingsPage(bool[] WillShowGet)
        {
            InitializeComponent();
            WillShow = WillShowGet;
            GetExchangeRatesInfo();          
        }

        private async void GetExchangeRatesInfo()
        {
            var url = $"https://www.nbrb.by/api/exrates/rates?periodicity=0";

            var result = await ApiCaller.Get(url);

            if (result.Successful)
            {
                try
                {
                    Rate[] ExchangeInfo = JsonConvert.DeserializeObject<Rate[]>(result.Response);

                    AddExchangeInfo(ExchangeInfo);
                }
                catch (Exception ex)
                {
                    await DisplayAlert("Exchange Rates Info", ex.Message, "OK");
                }
            }

        }

        private void AddExchangeInfo(Rate[] ExchangeInfo)
        {
            curAbbrv.Text = ExchangeInfo[0].Cur_Abbreviation;
            curScale.Text = ExchangeInfo[0].Cur_Scale.ToString();
            curName.Text = ExchangeInfo[0].Cur_Name;

            curAbbrv1.Text = ExchangeInfo[1].Cur_Abbreviation;
            curScale1.Text = ExchangeInfo[1].Cur_Scale.ToString();
            curName1.Text = ExchangeInfo[1].Cur_Name;

            curAbbrv2.Text = ExchangeInfo[2].Cur_Abbreviation;
            curScale2.Text = ExchangeInfo[2].Cur_Scale.ToString();
            curName2.Text = ExchangeInfo[2].Cur_Name;

            curAbbrv3.Text = ExchangeInfo[3].Cur_Abbreviation;
            curScale3.Text = ExchangeInfo[3].Cur_Scale.ToString();
            curName3.Text = ExchangeInfo[3].Cur_Name;

            curAbbrv4.Text = ExchangeInfo[4].Cur_Abbreviation;
            curScale4.Text = ExchangeInfo[4].Cur_Scale.ToString();
            curName4.Text = ExchangeInfo[4].Cur_Name;

            curAbbrv5.Text = ExchangeInfo[5].Cur_Abbreviation;
            curScale5.Text = ExchangeInfo[5].Cur_Scale.ToString();
            curName5.Text = ExchangeInfo[5].Cur_Name;

            curAbbrv6.Text = ExchangeInfo[6].Cur_Abbreviation;
            curScale6.Text = ExchangeInfo[6].Cur_Scale.ToString();
            curName6.Text = ExchangeInfo[6].Cur_Name;

            curAbbrv7.Text = ExchangeInfo[7].Cur_Abbreviation;
            curScale7.Text = ExchangeInfo[7].Cur_Scale.ToString();
            curName7.Text = ExchangeInfo[7].Cur_Name;

            curAbbrv8.Text = ExchangeInfo[8].Cur_Abbreviation;
            curScale8.Text = ExchangeInfo[8].Cur_Scale.ToString();
            curName8.Text = ExchangeInfo[8].Cur_Name;

            curAbbrv9.Text = ExchangeInfo[9].Cur_Abbreviation;
            curScale9.Text = ExchangeInfo[9].Cur_Scale.ToString();
            curName9.Text = ExchangeInfo[9].Cur_Name;

            curAbbrv10.Text = ExchangeInfo[10].Cur_Abbreviation;
            curScale10.Text = ExchangeInfo[10].Cur_Scale.ToString();
            curName10.Text = ExchangeInfo[10].Cur_Name;

            curAbbrv11.Text = ExchangeInfo[11].Cur_Abbreviation;
            curScale11.Text = ExchangeInfo[11].Cur_Scale.ToString();
            curName11.Text = ExchangeInfo[11].Cur_Name;

            curAbbrv12.Text = ExchangeInfo[12].Cur_Abbreviation;
            curScale12.Text = ExchangeInfo[12].Cur_Scale.ToString();
            curName12.Text = ExchangeInfo[12].Cur_Name;

            curAbbrv13.Text = ExchangeInfo[13].Cur_Abbreviation;
            curScale13.Text = ExchangeInfo[13].Cur_Scale.ToString();
            curName13.Text = ExchangeInfo[13].Cur_Name;

            curAbbrv14.Text = ExchangeInfo[14].Cur_Abbreviation;
            curScale14.Text = ExchangeInfo[14].Cur_Scale.ToString();
            curName14.Text = ExchangeInfo[14].Cur_Name;

            curAbbrv15.Text = ExchangeInfo[15].Cur_Abbreviation;
            curScale15.Text = ExchangeInfo[15].Cur_Scale.ToString();
            curName15.Text = ExchangeInfo[15].Cur_Name;

            curAbbrv16.Text = ExchangeInfo[16].Cur_Abbreviation;
            curScale16.Text = ExchangeInfo[16].Cur_Scale.ToString();
            curName16.Text = ExchangeInfo[16].Cur_Name;

            curAbbrv17.Text = ExchangeInfo[17].Cur_Abbreviation;
            curScale17.Text = ExchangeInfo[17].Cur_Scale.ToString();
            curName17.Text = ExchangeInfo[17].Cur_Name;

            curAbbrv18.Text = ExchangeInfo[18].Cur_Abbreviation;
            curScale18.Text = ExchangeInfo[18].Cur_Scale.ToString();
            curName18.Text = ExchangeInfo[18].Cur_Name;

            curAbbrv19.Text = ExchangeInfo[19].Cur_Abbreviation;
            curScale19.Text = ExchangeInfo[19].Cur_Scale.ToString();
            curName19.Text = ExchangeInfo[19].Cur_Name;

            curAbbrv20.Text = ExchangeInfo[20].Cur_Abbreviation;
            curScale20.Text = ExchangeInfo[20].Cur_Scale.ToString();
            curName20.Text = ExchangeInfo[20].Cur_Name;

            curAbbrv21.Text = ExchangeInfo[21].Cur_Abbreviation;
            curScale21.Text = ExchangeInfo[21].Cur_Scale.ToString();
            curName21.Text = ExchangeInfo[21].Cur_Name;

            curAbbrv22.Text = ExchangeInfo[22].Cur_Abbreviation;
            curScale22.Text = ExchangeInfo[22].Cur_Scale.ToString();
            curName22.Text = ExchangeInfo[22].Cur_Name;

            curAbbrv23.Text = ExchangeInfo[23].Cur_Abbreviation;
            curScale23.Text = ExchangeInfo[23].Cur_Scale.ToString();
            curName23.Text = ExchangeInfo[23].Cur_Name;

            curAbbrv24.Text = ExchangeInfo[24].Cur_Abbreviation;
            curScale24.Text = ExchangeInfo[24].Cur_Scale.ToString();
            curName24.Text = ExchangeInfo[24].Cur_Name;

            curAbbrv25.Text = ExchangeInfo[25].Cur_Abbreviation;
            curScale25.Text = ExchangeInfo[25].Cur_Scale.ToString();
            curName25.Text = ExchangeInfo[25].Cur_Name;
        }
        private async void Checked_click(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }

        private void Sw_fir(object sender, ToggledEventArgs e)
        {
            if (sw1.IsToggled == true)
            {
                WillShow[0] = true;
            }
            else
                WillShow[0] = false;
        }

        private void Sw_sec(object sender, ToggledEventArgs e)
        {
            if (sw2.IsToggled == true)
            {
                WillShow[1] = true;
            }
            else
                WillShow[1] = false;
        }

        private void Sw_thr(object sender, ToggledEventArgs e)
        {
            if (sw3.IsToggled == true)
            {
                WillShow[2] = true;
            }
            else
                WillShow[2] = false;
        }

        private void Sw_four(object sender, ToggledEventArgs e)
        {
            if (sw4.IsToggled == true)
            {
                WillShow[3] = true;
            }
            else
                WillShow[3] = false;
        }

        private void Sw_five(object sender, ToggledEventArgs e)
        {
            if (sw5.IsToggled == true)
            {
                WillShow[4] = true;
            }
            else
                WillShow[4] = false;
        }

        private void Sw_six(object sender, ToggledEventArgs e)
        {
            if (sw6.IsToggled == true)
            {
                WillShow[5] = true;
            }
            else
                WillShow[5] = false;
        }

        private void Sw_sev(object sender, ToggledEventArgs e)
        {
            if (sw7.IsToggled == true)
            {
                WillShow[6] = true;
            }
            else
                WillShow[6] = false;
        }

        private void Sw_eight(object sender, ToggledEventArgs e)
        {
            if (sw8.IsToggled == true)
            {
                WillShow[7] = true;
            }
            else
                WillShow[7] = false;
        }

        private void Sw_nine(object sender, ToggledEventArgs e)
        {
            if (sw9.IsToggled == true)
            {
                WillShow[8] = true;
            }
            else
                WillShow[8] = false;
        }

        private void Sw_ten(object sender, ToggledEventArgs e)
        {
            if (sw10.IsToggled == true)
            {
                WillShow[9] = true;
            }
            else
                WillShow[9] = false;
        }

        private void Sw_elev(object sender, ToggledEventArgs e)
        {
            if (sw11.IsToggled == true)
            {
                WillShow[10] = true;
            }
            else
                WillShow[10] = false;
        }

        private void Sw_twelve(object sender, ToggledEventArgs e)
        {
            if (sw12.IsToggled == true)
            {
                WillShow[11] = true;
            }
            else
                WillShow[11] = false;
        }

        private void Sw_thirteen(object sender, ToggledEventArgs e)
        {
            if (sw13.IsToggled == true)
            {
                WillShow[12] = true;
            }
            else
                WillShow[12] = false;
        }

        private void Sw_fourteen(object sender, ToggledEventArgs e)
        {
            if (sw14.IsToggled == true)
            {
                WillShow[13] = true;
            }
            else
                WillShow[13] = false;
        }

        private void Sw_fiveteen(object sender, ToggledEventArgs e)
        {
            if (sw15.IsToggled == true)
            {
                WillShow[14] = true;
            }
            else
                WillShow[14] = false;
        }

        private void Sw_sixteen(object sender, ToggledEventArgs e)
        {
            if (sw16.IsToggled == true)
            {
                WillShow[15] = true;
            }
            else
                WillShow[15] = false;
        }

        private void Sw_sevteen(object sender, ToggledEventArgs e)
        {
            if (sw17.IsToggled == true)
            {
                WillShow[16] = true;
            }
            else
                WillShow[16] = false;
        }

        private void Sw_eighteen(object sender, ToggledEventArgs e)
        {
            if (sw18.IsToggled == true)
            {
                WillShow[17] = true;
            }
            else
                WillShow[17] = false;
        }

        private void Sw_nineteen(object sender, ToggledEventArgs e)
        {
            if (sw19.IsToggled == true)
            {
                WillShow[18] = true;
            }
            else
                WillShow[18] = false;
        }

        private void Sw_twenty(object sender, ToggledEventArgs e)
        {
            if (sw20.IsToggled == true)
            {
                WillShow[19] = true;
            }
            else
                WillShow[19] = false;
        }

        private void Sw_twentyone(object sender, ToggledEventArgs e)
        {
            if (sw21.IsToggled == true)
            {
                WillShow[20] = true;
            }
            else
                WillShow[20] = false;
        }

        private void Sw_twentytwo(object sender, ToggledEventArgs e)
        {
            if (sw22.IsToggled == true)
            {
                WillShow[21] = true;
            }
            else
                WillShow[21] = false;
        }

        private void Sw_twentythr(object sender, ToggledEventArgs e)
        {
            if (sw23.IsToggled == true)
            {
                WillShow[22] = true;
            }
            else
                WillShow[22] = false;
        }

        private void Sw_twentyfour(object sender, ToggledEventArgs e)
        {
            if (sw24.IsToggled == true)
            {
                WillShow[23] = true;
            }
            else
                WillShow[23] = false;
        }

        private void Sw_twentyfive(object sender, ToggledEventArgs e)
        {
            if (sw25.IsToggled == true)
            {
                WillShow[24] = true;
            }
            else
                WillShow[24] = false;
        }

        private void Sw_twentysix(object sender, ToggledEventArgs e)
        {
            if (sw26.IsToggled == true)
            {
                WillShow[25] = true;
            }
            else
                WillShow[25] = false;
        }
    }
}