using Mobile.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Mobile
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CarouselContent : ContentView
    {
        private Monkey model;
        public CarouselContent()
        {
            InitializeComponent();
        }

        protected override void OnBindingContextChanged()
        {
            base.OnBindingContextChanged();

            if (model != null)
                model.PropertyChanged -= OnModelPropertyChanged;

            model = BindingContext as Monkey;

            if (model != null)
                model.PropertyChanged += OnModelPropertyChanged;
        }

        private async void OnModelPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            switch (e.PropertyName)
            {
                case nameof(Monkey.Focused):
                    //TODO: wait for animation to end then set entry focus
                    if (model.Focused)
                        EntryMoneky.Focus();
                    break;
                default:
                    break;
            }
        }
    }
}