﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WashablesSystem.Classes;

namespace WashablesSystem
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void cLoginButton_Click(object sender, EventArgs e)
        {
            UserClass user = new UserClass(ctxtbxUserName.Text, ctxtbxPass.Text);
            bool userValid = user.loginUser();

            if (userValid == true)
            {
                new Main().Show();
                this.Hide();
            }
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
