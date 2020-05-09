using Mobile.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Mobile
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

        }

        public bool ShouldReload { get; set; } = true;
        protected override void OnAppearing()
        {
            base.OnAppearing();

            if (ShouldReload)
            {
                CarouselViewMonkeys.ItemsSource = Monkey.GetMonkeys();
                ShouldReload = false;
            }
        }

        private void CarouselViewMonkeys_CurrentItemChanged(object sender, CurrentItemChangedEventArgs e)
        {
            if (CarouselViewMonkeys.CurrentItem is Monkey item)
            {
                item.Focused = true;

                (CarouselViewMonkeys.ItemsSource as List<Monkey>)
               ?.ForEach((monkey) =>
               {
                   if (monkey.Id != item.Id)
                       monkey.Focused = false;
               });
            }




        }
    }


}
