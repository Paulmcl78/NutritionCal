using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace NutritionCal.GUI.Forms
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {
           string password = txtPassword.Text;

           byte[] passwordTextBytes = Encoding.UTF8.GetBytes(password);

            SHA512 test = new SHA512Managed();


            byte[] hashedPassword = test.ComputeHash(passwordTextBytes);

            string hashValue = Convert.ToBase64String(hashedPassword);

        }
    }
}
