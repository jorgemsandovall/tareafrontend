using System;
using System.Collections.Generic;
using System.Text;

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


        public bool IsRunning
        {
            get { return this.isrunning; }
            set { SetValue(ref this.isrunning, value); }




            #endregion


        }
    }
