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
