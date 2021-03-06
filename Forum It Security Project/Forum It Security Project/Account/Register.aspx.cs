﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Forum_It_Security_Project.Account
{
    public partial class Register : System.Web.UI.Page
    {
        private const string ValidationGroup = "RegisterValidation";
        protected void Page_Load(object sender, EventArgs e)
        {
            RegisterUser.ContinueDestinationPageUrl = Request.QueryString["ReturnUrl"];
        }

        protected void RegisterUser_CreatedUser(object sender, EventArgs e)
        {
            FormsAuthentication.SetAuthCookie(RegisterUser.UserName, false /* createPersistentCookie */);

            string continueUrl = RegisterUser.ContinueDestinationPageUrl;
            if (String.IsNullOrEmpty(continueUrl))
            {
                continueUrl = "~/";
            }
            Response.Redirect(continueUrl);
        }

        protected void RegisterButton_OnClick(object sender, EventArgs e)
        {
            string userName = Username.Text;
            string password = Password.Text;
            string confirmPassword = ConfirmPassword.Text;


            if (password == confirmPassword)
            {
                try
                {
                    // TODO:: conect to the service
                }
                catch (Exception)
                {
                    throw;
                }
            }
            else
            {
                //THROW NEW ARGUMETN EX.
            }

        }
    }
}
