using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DiplomApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TabbedPage1 : TabbedPage
    {

        public TabbedPage1()
        {
            InitializeComponent();

            MessagingCenter.Subscribe<object, string>(this, "EmailEntered", (sender, arg) =>
            {
                 email = arg;
            });
       
    }

        public string email { get; private set; }

        private void Butt1_Clicked(object sender, EventArgs e)
        {
            switch1.BackgroundColor = Color.Green;
            switch1.Text = "Объект на охране";
        }
        private void Butt2_Clicked(object sender, EventArgs e)
        {
            switch1.BackgroundColor = Color.Red;
            switch1.Text = "Снят с охраны";
        }
    }
}