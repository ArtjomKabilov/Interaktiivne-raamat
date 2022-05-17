using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Interaktiivne_raamat
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage
    {
        public MainPage()
        {
            InitializeComponent();
            profileImage.Source = ImageSource.FromFile("");
            aboutList.ItemsSource = GetMenuList();
            var homaPage = typeof(Views.AboutPage);
            Detail = new NavigationPage((Page)Activator.CreateInstance(homaPage));
        }
        public List<MasterMenuItems> GetMenuList()
        {
            var list = new List<MasterMenuItems>();
            list.Add(new MasterMenuItems()
            {
                Text = "Ema",
                Detail = "+372856485",
                ImagePath = "telefon.png",
                TargetPage = typeof(Views.Mother)
            });
            list.Add(new MasterMenuItems()
            {
                Text = "Isa",
                Detail = "+372685485",
                ImagePath = "telefon.png",
                TargetPage = typeof(Views.LoginPage)
            });
            list.Add(new MasterMenuItems()
            {
                Text = "Vanaisa",
                Detail = "+37265874125",
                ImagePath = "telefon.png",
                TargetPage = typeof(Views.LoginPage)
            });
            list.Add(new MasterMenuItems()
            {
                Text = "Vanaema",
                Detail = "+3729878754",
                ImagePath = "telefon.png",
                TargetPage = typeof(Views.LoginPage)
            });
            list.Add(new MasterMenuItems()
            {
                Text = "ArtemS",
                Detail = "+369575245",
                ImagePath = "telefon.png",
                TargetPage = typeof(Views.LoginPage)
            });
            list.Add(new MasterMenuItems()
            {
                Text = "ElexG",
                Detail = "+3725615852",
                ImagePath = "telefon.png",
                TargetPage = typeof(Views.LoginPage)
            });
            list.Add(new MasterMenuItems()
            {
                Text = "Õde",
                Detail = "+3723654263",
                ImagePath = "telefon.png",
                TargetPage = typeof(Views.LoginPage)
            });
            list.Add(new MasterMenuItems()
            {
                Text = "Onu",
                Detail = "+3721452145",
                ImagePath = "telefon.png",
                TargetPage = typeof(Views.LoginPage)
            });
            list.Add(new MasterMenuItems()
            {
                Text = "NikitaP",
                Detail = "+3726543216",
                ImagePath = "telefon.png",
                TargetPage = typeof(Views.LoginPage)
            });
            return list;
        } 
        private void aboutList_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var selectedMenuItem = (MasterMenuItems)e.SelectedItem;
            Type selectedPage = selectedMenuItem.TargetPage;
            Detail = new NavigationPage((Page)Activator.CreateInstance(selectedPage));
            IsPresented = false;
        }
    }
}