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

namespace OOO_Technical_Service.Forms
{
    public partial class AddEmployeeForm : Form
    {
        public Employee Employee { get; set; }
        public AddEmployeeForm()
        {
            InitializeComponent();
            comboBoxRole.DisplayMember = nameof(Role.RoleName);
            Employee = new Employee();
            Initialize();
        }
        private void Initialize()
        {
            using (var db = new TechnicalSecviceContext())
            {
                comboBoxRole.Items.AddRange(db.Roles.AsNoTracking().ToArray());
                comboBoxRole.SelectedIndex = 0;
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBoxFullName.Text) && !string.IsNullOrWhiteSpace(textBoxLogin.Text) && !string.IsNullOrWhiteSpace(textBoxPassword.Text))
            {
                Employee.FullName = textBoxFullName.Text;
                Employee.Login = textBoxLogin.Text;
                Employee.Password = textBoxPassword.Text;
                Employee.RoleId = ((Role)comboBoxRole.SelectedItem).Id;
                DialogResult = DialogResult.OK;
            }
            else
                MessageBox.Show("Заполните все поля перед сохранением!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
