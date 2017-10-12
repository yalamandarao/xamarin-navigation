using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Navigation
{
    public partial class Video : ContentPage
    {
        public Video()
        {
            InitializeComponent();
        }
		void button_action(object sender, System.EventArgs e)
		{
            Navigation.PushAsync(new Movie());
		}
    }
}
