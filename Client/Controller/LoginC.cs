using Client.Forme;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client.Controller
{
    class LoginC
    {
        FRMLogin frmLogin;
        internal void Login(TextBox txtUsername, TextBox txtPassword, FRMLogin login)
        {
            Doctor d = new Doctor();
            d.Username = txtUsername.Text;
            d.Password = txtPassword.Text;
            this.frmLogin = login;
            Doctor doc;

            if (txtUsername.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show("Nista uneli korisnicko ime ili sifru.");
                return;
            }
            try
            {
                doc = Communication.Instance.LoginUser(d);
                if (doc == null)
                {
                    MessageBox.Show($"Login unsuccessful!");
                    txtUsername.ResetText();
                    txtPassword.ResetText();
                    return;
                }
                else
                {
                    MessageBox.Show("Login successful!");
                }


            }
            catch (System.IO.IOException)
            {
                MessageBox.Show("Sistem ne moze da prijavi clana.");
                return;
            }
            MainController.Instance.Doctor = doc;
            FRMClient main = new FRMClient();
            login.Visible = false;
            main.ShowDialog();
            login.Visible = true;


        }
    }
}
