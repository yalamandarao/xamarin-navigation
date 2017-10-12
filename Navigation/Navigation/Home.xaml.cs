using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Navigation
{
    public partial class Home : ContentPage
    {
        public Home()
        {
            Title = "Home";
            InitializeComponent();
        }
		void button_action(object sender, System.EventArgs e)
		{
            Navigation.PushAsync(new Video());
		}
    }
}
