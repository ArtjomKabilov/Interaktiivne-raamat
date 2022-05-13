using Interaktiivne_raamat.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace Interaktiivne_raamat.Views
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