using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Navigation
{
    public partial class Movie : ContentPage
    {
        public Movie()
        {
            InitializeComponent();
        }
		void button_action(object sender, System.EventArgs e)
		{
            Navigation.PopToRootAsync();
		}
    }
}
