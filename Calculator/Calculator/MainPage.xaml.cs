using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Calculator
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            screenLabel.Text = (sender as Button).Text;
        }

        private void Button_Clicked_Erase(object sender, EventArgs e)
        {
            screenLabel.Text = null;
        }
    }
}
