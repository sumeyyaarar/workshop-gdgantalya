using System;
using System.Collections.Generic;
using GDGXamarinWorkshop.Model;
using Xamarin.Forms;

namespace GDGXamarinWorkshop.Pages
{
    public partial class BirdsPage : ContentPage
    {
        public BirdsPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            lstBirds.ItemsSource = Data.Birds;
        }

        async void Handle_ItemSelected(object sender, Xamarin.Forms.SelectedItemChangedEventArgs e)
        {
            var detail = e.SelectedItem as Data;
            if (string.IsNullOrEmpty(detail.Image))
            {
                detail.Image = "empty.jpg";
            }
            var page = new DetailPage();
            page.BindingContext = detail;
            await Navigation.PushAsync(page);
        }
    }
}
