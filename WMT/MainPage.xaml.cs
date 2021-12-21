using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace WMT
{
    public partial class MainPage : ContentPage
    {
        public Dictionary<string, string> hToolDict = new Dictionary<string, string>() { {"1234", "Test" } };
        public Dictionary<string, string> aToolDict = new Dictionary<string, string>() { { "1234", "Test" } };

        public MainPage()
        {
            InitializeComponent();
        }

        private async void infoPage(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new infoPage());
        }

        public void toolLookUp(object sender, EventArgs e)
        {
            string key = uInput.Text;
            string handTool = ""; 
            string applicator = "";

            foreach(KeyValuePair<string, string> x in hToolDict)
            {
                if (x.Key == key){
                    handTool = x.Value;
                }
                else
                {
                    handTool = "N/A";
                }
            }

            foreach (KeyValuePair<string, string> x in aToolDict)
            {
                if (x.Key == key)
                {
                    applicator = x.Value;
                }
                else
                {
                    applicator = "N/A";
                }
            }

            hTool.Text = handTool;
            aTool.Text = applicator;
        }
    }
}
