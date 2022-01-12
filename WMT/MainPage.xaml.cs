using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;


namespace WMT
{
    public class MyDicts
    {
        public struct MyDict
        {
            public static Dictionary<string, string> hToolDict = new Dictionary<string, string>();
            public static Dictionary<string, string> aToolDict = new Dictionary<string, string>();
        }
    }

    public partial class MainPage : ContentPage
    {
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

            if (key == null)
            {
                return;
            }
            else if (key.ToUpper() == "ADD")
            {
                uInput.Text = "";
                addPage(sender, e);
                key = "";
            }
            else
            {
                foreach (KeyValuePair<string, string> x in MyDicts.MyDict.hToolDict)
                {
                    if (x.Key == key)
                    {
                        handTool = x.Value;
                        break;
                    }
                    else
                    {
                        handTool = "N/A";
                    }
                }

                foreach (KeyValuePair<string, string> x in MyDicts.MyDict.aToolDict)
                {
                    if (x.Key == key)
                    {
                        applicator = x.Value;
                        break;
                    }
                    else
                    {
                        applicator = "N/A";
                    }
                }
            }

            hTool.Text = handTool;
            aTool.Text = applicator;
            dispLbl.Text = key;
            uInput.Text = "";
        }

        public async void addPage(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new addPage());
        }
    }
}
