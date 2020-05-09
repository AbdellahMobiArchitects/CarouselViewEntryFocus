using Mobile.Models;
using System;
using System.Collections.Generic;
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
        public CarouselContent()
        {
            InitializeComponent();
        }

        private Monkey model;
        protected override void OnBindingContextChanged()
        {
            base.OnBindingContextChanged();

            if (model != null)
                model.PropertyChanged -= OnModelPropertyChanged;

            model = BindingContext as Monkey;

            if (model != null)
                model.PropertyChanged += OnModelPropertyChanged;
        }

        private void OnModelPropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            if (e.PropertyName == nameof(Monkey.Id))
                EntryMoneky.Focus();
        }
    }
}