using OOO_Technical_Service.Forms.AddForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TechnicalService.Context.DB;
using TechnicalService.Context.Models;

namespace OOO_Technical_Service.Forms.GridForms
{
    public partial class EquipmentForm : Form
    {
        private int pageSize = 5;
        private int oldCountPage = -1;
        private readonly BindingSource bindingSource = new BindingSource();
        public EquipmentForm()
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
                var count = db.Equipments.Count();
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
                dataGridView1.DataSource = db.Equipments.Include(x => x.EquipmentType)
                .OrderBy(x => x.Title)
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
            AddEditEquipmentForm form = new AddEditEquipmentForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                using (var db = new TechnicalSecviceContext())
                {
                    db.Equipments.Add(form.Equipment);
                    db.SaveChanges();
                    Print();
                }
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            var equipmentId = (Equipment)dataGridView1.SelectedRows[0].DataBoundItem;

            if (equipmentId == null) return;

            using (var db = new TechnicalSecviceContext())
            {
                var equipment1 = db.Equipments.FirstOrDefault(x => x.Id == equipmentId.Id);
                AddEditEquipmentForm form = new AddEditEquipmentForm(equipment1);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    db.SaveChanges();
                    Print();
                }
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            var equipmentId = (Equipment)dataGridView1.SelectedRows[0].DataBoundItem;

            if (equipmentId == null) return;

            using (var db = new TechnicalSecviceContext())
            {
                var equipment1 = db.Equipments.FirstOrDefault(x => x.Id == equipmentId.Id);
                if (MessageBox.Show($"Удалить оборудование {equipmentId.Title}?", "Подтвердите!", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    db.Equipments.Remove(equipment1);
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
