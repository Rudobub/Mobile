using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace DiplomApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private async void ButtonClicked(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(emailField.Text))
                errorText.Text = "Не указан логин";
            else if (string.IsNullOrEmpty(passField.Text))
                    errorText.Text = "Не указан пароль";
            else
            {
                errorText.Text = "";
                nextButton.Text = "Вход выполнен";
                nextButton.TextColor = Color.Green;
                await Navigation.PushAsync(new TabbedPage1());
            }

            MessagingCenter.Send<object, string>(this,"EmailEntered", emailField.Text);

        }

    }
}
