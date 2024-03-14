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
    public partial class ClientForm : Form
    {
        private int pageSize = 10;
        private int oldCountPage = -1;
        private readonly BindingSource bindingSource = new BindingSource();

        public ClientForm()
        {
            InitializeComponent();
            bindingSource.CurrentItemChanged += Bs_CurrentItemChanged;
            dataGridView1.AutoGenerateColumns = false;
            Print();
            if (WorkToEmployee.Employee.RoleId == 1)
            {
                buttonEdit.Enabled = buttonAdd.Enabled = buttonDelete.Enabled = false;
            }
        }
        private void Print()
        {
            using (var db = new TechnicalSecviceContext())
            {
                var count = db.Clients.Count();
                var countPage = (int)Math.Ceiling((decimal)count / pageSize);

                if (oldCountPage != countPage)
                {
                    oldCountPage = countPage;
                    var current = bindingSource.Position;

                    if (current > countPage)
                    {
                        current = countPage;
                    }

                    bindingSource.DataSource = Enumerable.Range(1, countPage);

                    if (current != -1)
                    {
                        bindingSource.Position = current;
                    }

                    bindingNavigator1.BindingSource = bindingSource;
                }
                toolStripLabelCount.Text = $"Кол-во записей: {count}";
                dataGridView1.DataSource = db.Clients
                    .OrderBy(x => x.FullName)
                    .Skip(bindingSource.Position * pageSize)
                    .Take(pageSize)
                    .ToList();
            }
        }
        private void Bs_CurrentItemChanged(object sender, EventArgs e)
        {
            Print();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            AddEditClientForm form = new AddEditClientForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                using (var db = new TechnicalSecviceContext())
                {
                    db.Clients.Add(form.Client);
                    db.SaveChanges();
                    Print();
                }
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            var clientId = (Client)dataGridView1.SelectedRows[0].DataBoundItem;

            if (clientId == null) return;

            using (var db = new TechnicalSecviceContext())
            {
                var client1 = db.Clients.FirstOrDefault(x => x.Id == clientId.Id);
                AddEditClientForm form = new AddEditClientForm(client1);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    db.SaveChanges();
                    Print();
                }
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            var clientId = (Client)dataGridView1.SelectedRows[0].DataBoundItem;

            if (clientId == null) return;

            using (var db = new TechnicalSecviceContext())
            {
                var client1 = db.Clients.FirstOrDefault(x => x.Id == clientId.Id);
                if (MessageBox.Show($"Удалить клиента {clientId.FullName}?", "Подтвердите!", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    db.Clients.Remove(client1);
                    db.SaveChanges();
                    Print();
                }
            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
