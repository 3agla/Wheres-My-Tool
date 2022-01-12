using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WMT
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class addPage : ContentPage  
    {
        public addPage()
        {
            InitializeComponent();
        }

        private void addTool(object sender, EventArgs e)
        {
            string key = addInput.Text;

            if (MyDicts.MyDict.hToolDict.ContainsKey(key))
            {
                hToolAdded.Text = "Hand Tool " + addHTool.Text + " already exists in library.";
            }
            else
            {
                MyDicts.MyDict.hToolDict.Add(addInput.Text, addHTool.Text);
                hToolAdded.Text = "Hand tool " + addHTool.Text + " has been added to library.";
            }

            if (MyDicts.MyDict.aToolDict.ContainsKey(key))
            {
                aToolAdded.Text = "Applicator Tool " + addATool.Text + " already exists in library.";
            }
            else
            {
                MyDicts.MyDict.aToolDict.Add(addInput.Text, addATool.Text);
                aToolAdded.Text = "Applicator tool " + addATool.Text + " has been added to library.";
            }
            
            addInput.Text = "";
            addHTool.Text = "";
            addATool.Text = "";
        }
    }
}