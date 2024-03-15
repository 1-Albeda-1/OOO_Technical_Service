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
using OOO_Technical_Service.Forms.GridForms;

namespace OOO_Technical_Service.Forms
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
            Authorization();
        }

        private void справкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("");
        }
        private void Authorization()
        {
            toolStripLabelFIO.Text = $"Пользователь: {WorkToEmployee.Employee.FullName}";
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
            if (WorkToEmployee.Employee.RoleId == 3 || WorkToEmployee.Employee.RoleId == 4)
            {
                добавитьРаботникаToolStripMenuItem.Visible = true;
            }
        }
        private void добавитьРаботникаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddEmployeeForm form = new AddEmployeeForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                using (var db = new TechnicalSecviceContext())
                {
                    db.Employees.Add(form.Employee);
                    db.SaveChanges();
                }
            }
        }
        private void заявкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StatusRequestForm form = new StatusRequestForm();
            form.ShowDialog();
        }

        private void клиентыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClientForm form = new ClientForm();
            form.ShowDialog();
        }
        private void оборудованиеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EquipmentForm form = new EquipmentForm();
            form.ShowDialog();
        }
        private void запчастиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SparesCountForm form = new SparesCountForm();
            form.ShowDialog();
        }

        private void авторизацияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AuthorizationForm form = new AuthorizationForm();
            if(form.ShowDialog() == DialogResult.OK)
            {
                Authorization();
            }
        }
        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MenuForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void отчетностьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReportForm form = new ReportForm();
            form.ShowDialog();
        }
    }
}
