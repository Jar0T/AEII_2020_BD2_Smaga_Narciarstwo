﻿using E_SkiLift.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace E_SkiLift.Windows
{
    /// <summary>
    /// Logika interakcji dla klasy AddUserUserControl.xaml
    /// </summary>
    public partial class AddUserUserControl : UserControl
    {
        public AddUserUserControl()
        {
            InitializeComponent();
        }

        private void addUserButton_Click(object sender, RoutedEventArgs e)
        {
            Admin.AddUser((UserType) int.Parse(AddUserType.Text), AddUserName.Text, AddUserLogin.Text, AddUserPassword.Text);
            MessageBox.Show("Added new user.");
            AddUserName.Text = "";
            AddUserLogin.Text = "";
            AddUserPassword.Text = "";
            AddUserType.Text = "";
        }
    }
}
