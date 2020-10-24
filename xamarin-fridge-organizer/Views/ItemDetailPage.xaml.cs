using System.ComponentModel;
using Xamarin.Forms;
using xamarin_fridge_organizer.ViewModels;

namespace xamarin_fridge_organizer.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}