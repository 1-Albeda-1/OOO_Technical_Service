using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TechnicalService.Context.Models;

namespace OOO_Technical_Service.Forms
{
    public partial class EditRequestForm : Form
    {
        public Request Request { get; set; }
        public EditRequestForm()
        {
            InitializeComponent();
            comboBoxStatus.DisplayMember = nameof(Status.Title);
            checkedListBoxEmployees.DisplayMember = nameof(Employee.LastName);
            Request = new Request();
        }
        public List<int> GetCheckedTypes()
            => checkedListBoxEmployees.CheckedItems.Cast<Employee>().Select(x => x.Id).ToList();

        public EditRequestForm(Request request) : this()
        {
            Request = request;
            richTextBoxDescription.Text = Request.Description;

            var ids = Request.Employees.Select(x => x.Id).ToList();
            for (int i = 0; i < checkedListBoxEmployees.Items.Count; i++)
            {
                if (ids.Contains(((Employee)checkedListBoxEmployees.Items[i]).Id))
                {
                    checkedListBoxEmployees.SetItemChecked(i, true);
                }
            }

            comboBoxStatus.SelectedItem = comboBoxStatus.Items.Cast<Status>()
                .FirstOrDefault(x => x.Id == Request.Id);
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(richTextBoxDescription.Text))
            {
                Request.Description = richTextBoxDescription.Text;
                Request.StatusId = ((Status)comboBoxStatus.SelectedItem).Id;
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
