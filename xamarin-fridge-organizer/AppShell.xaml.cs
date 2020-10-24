using System;
using System.Collections.Generic;
using xamarin_fridge_organizer.ViewModels;
using xamarin_fridge_organizer.Views;
using Xamarin.Forms;

namespace xamarin_fridge_organizer
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
        }

    }
}
