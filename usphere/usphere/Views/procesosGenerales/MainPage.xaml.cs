using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace usphere.Views.procesosGenerales
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : ContentPage
    {
        public IList<Member> Members { get; private set; }

        public MainPage()
        {
            InitializeComponent();

            Members = new List<Member>();
            Members.Add(new Member { Id = 0, Name = "Carlos Diéguez", Status = "Founder", antiquity = 1, Homeland = "Spain" });
            Members.Add(new Member { Id = 0, Name = "Manuel Antonio Martin Mon", Status = "Founder", antiquity = 1, Homeland = "Spain" });
            Members.Add(new Member { Id = 0, Name = "Isaac Dios", Status = "Vice", antiquity = 1, Homeland = "Spain" });
            Members.Add(new Member { Id = 0, Name = "Daniel Blanco", Status = "Vice", antiquity = 1, Homeland = "Spain" });

            BindingContext = this;
        }

        private void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            Member selectedItem = e.SelectedItem as Member;
        }

        private void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            Member tappedItem = e.Item as Member;
        }
    }
}