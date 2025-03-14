﻿using OOO_Technical_Service.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TechnicalService.Context.DB;
using TechnicalService.Context.Models;

namespace OOO_Technical_Service
{
    public partial class AuthorizationForm : Form
    {
        public AuthorizationForm()
        {
            InitializeComponent();
            textBoxPassword.UseSystemPasswordChar = true;
        }

        private void buttonEnter_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBoxLogin.Text) && !string.IsNullOrWhiteSpace(textBoxPassword.Text))
            {
                using (var db = new TechnicalSecviceContext())
                {
                    var user = db.Employees.FirstOrDefault(x => x.Login == textBoxLogin.Text && x.Password == textBoxPassword.Text);

                    if (user == null)
                    {
                        MessageBox.Show("Неправильное имя пользователя или пароль!");
                        textBoxPassword.Clear();
                    }
                    else
                    {
                        WorkToEmployee.Employee = user;
                        this.DialogResult = DialogResult.OK;
                    }
                }
            }
            else
                MessageBox.Show("Заполните все поля перед входом!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void buttonEnterGuest_Click(object sender, EventArgs e)
        {
            WorkToEmployee.Employee = new Employee
            {
                FullName = "Неавторизованный гость",
                RoleId = 1
            };
            this.DialogResult = DialogResult.OK;
        }

        private void checkBoxPassView_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxPassView.Checked)
            {
                textBoxPassword.UseSystemPasswordChar = false;
            }
            else
            {
                textBoxPassword.UseSystemPasswordChar = true;
            }
        }
    }
}
