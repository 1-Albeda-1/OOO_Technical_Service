using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using TechnicalService.Context.DB;
using TechnicalService.Context.Models;

namespace OOO_Technical_Service.Forms
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
            toolStripLabelFIO.Text = $"Пользователь: {WorkToEmployee.Employee.LastName} {WorkToEmployee.Employee.FirstName} {WorkToEmployee.Employee.Patronymic}";
            using (var db = new TechnicalSecviceContext())
            {
                var role = db.Roles.FirstOrDefault(x => x.Id == WorkToEmployee.Employee.RoleId);
                if (role != null)
                {
                    toolStripLabelRole.Text = $"Статус: {role.RoleName}";
                }
                else
                {

                    toolStripLabelRole.Text = "Статус: Неавторизованный гость";
                }
            }
            
        }

        private void заявкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StatusRequestForm form = new StatusRequestForm();
            form.ShowDialog();
        }

        private void справкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("");
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void авторизацияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AuthorizationForm form = new AuthorizationForm();
            form.ShowDialog();
            this.Close();
        }

        private void MenuForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
