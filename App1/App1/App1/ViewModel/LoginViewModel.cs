using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace App1.ViewModel
{
    public class LoginViewModel:BaseViewModel
    {
        #region variables
        string email;
        string password;
        bool isrunning;
        #endregion
      
        #region propiedades

        public string Email
        {
            get { return this.email; }
            set { SetValue(ref this.email, value); }
        }
        public string Password
        {
            get { return this.password; }
            set { SetValue(ref this.password, value); }

        }

        public bool IsRunning
        {
            get { return this.isrunning; }
            set { SetValue(ref this.isrunning, value); }
        }

        #endregion

        #region Comandos

        public ICommand LoginCommand
        {
            get
            {
                return new RelayCommand(Login);
            }
        }

        private async void Login()
        {
            if(String.IsNullOrEmpty(email))
            {
                await App.Current.MainPage.DisplayAlert("Email empty", "Please imput email","accept");
                return;
            }


            if (String.IsNullOrEmpty(password))
            {
                await App.Current.MainPage.DisplayAlert("Password empty", "Please imput Password", "accept");
                return;
            }
        }





        #endregion



    }
}
