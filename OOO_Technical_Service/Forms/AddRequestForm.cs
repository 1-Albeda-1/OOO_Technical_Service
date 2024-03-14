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
    public partial class AddRequestForm : Form
    {
        public Request Request { get; set; }
        public AddRequestForm()
        {
            InitializeComponent();
            comboBoxStatus.DisplayMember = nameof(Status.Title);
            comboBoxBrokeType.DisplayMember = nameof(BrokenType.Title);
            comboBoxEquipment.DisplayMember = nameof(Equipment.Title);
            comboBoxClient.DisplayMember = nameof(Client.FullName);
            checkedListBoxEmployees.DisplayMember = nameof(Employee.FullName);
            Request = new Request();
            Initialize();
            if(WorkToEmployee.Employee.RoleId == 4)
            {
                checkedListBoxEmployees.Enabled = true;
            }
        }

        private void Initialize()
        {
            using (var db = new TechnicalSecviceContext())
            {
                comboBoxBrokeType.Items.AddRange(db.BrokenTypes.AsNoTracking().ToArray());
                comboBoxBrokeType.SelectedIndex = 0;
                comboBoxClient.Items.AddRange(db.Clients.AsNoTracking().ToArray());
                comboBoxClient.SelectedIndex = 0;
                comboBoxEquipment.Items.AddRange(db.Equipments.AsNoTracking().ToArray());
                comboBoxEquipment.SelectedIndex = 0;
                comboBoxStatus.Items.AddRange(db.Statuses.AsNoTracking().ToArray());
                comboBoxStatus.SelectedIndex = 0;
                checkedListBoxEmployees.Items.AddRange(db.Employees.AsNoTracking().ToArray());
            }
        }

        public List<int> GetCheckedTypes()
            => checkedListBoxEmployees.CheckedItems.Cast<Employee>().Select(x => x.Id).ToList();

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(richTextBoxDescription.Text))
            {
                Request.EquipmentId = ((Equipment)comboBoxEquipment.SelectedItem).Id;
                Request.BrokenTypeId = ((BrokenType)comboBoxBrokeType.SelectedItem).Id;
                Request.ClientId = ((Client)comboBoxClient.SelectedItem).Id;
                Request.StatusId = ((Status)comboBoxStatus.SelectedItem).Id;
                Request.Priority = comboBoxPriority.Text;
                Request.Description = richTextBoxDescription.Text;
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
