using OOO_Technical_Service.Forms.AddForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TechnicalService.Context.DB;
using TechnicalService.Context.Models;

namespace OOO_Technical_Service.Forms.GridForms
{
    public partial class SparesCountForm : Form
    {
        private int pageSize = 5;
        private int oldCountPage = -1;
        private readonly BindingSource bindingSource = new BindingSource();
        public SparesCountForm()
        {
            InitializeComponent();
            bindingSource.CurrentItemChanged += Bs_CurrentItemChanged;
            dataGridView1.AutoGenerateColumns = false;
            Print();
            if (WorkToEmployee.Employee.RoleId == 1)
            {
                buttonEdit.Enabled = buttonAdd.Enabled = false;
            }
        }
        private void Print()
        {
            using (var db = new TechnicalSecviceContext())
            {
                var count = db.SparesCounts.Count();
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
                dataGridView1.DataSource = db.SparesCounts.Include(x => x.SparesType)
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
            AddEditSparesForm form = new AddEditSparesForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                using (var db = new TechnicalSecviceContext())
                {
                    db.SparesCounts.Add(form.Spares);
                    db.SaveChanges();
                    Print();
                }
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            var sparesId = (SparesCount)dataGridView1.SelectedRows[0].DataBoundItem;

            if (sparesId == null) return;

            using (var db = new TechnicalSecviceContext())
            {
                var spares1 = db.SparesCounts.FirstOrDefault(x => x.Id == sparesId.Id);
                AddEditSparesForm form = new AddEditSparesForm(spares1);
                if (form.ShowDialog() == DialogResult.OK)
                {
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
