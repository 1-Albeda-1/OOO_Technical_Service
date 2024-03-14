using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using TechnicalService.Context.DB;
using TechnicalService.Context.Models;

namespace OOO_Technical_Service.Forms.AddForms
{
    public partial class AddEditEquipmentForm : Form
    {
        public Equipment Equipment { get; set; }
        public AddEditEquipmentForm()
        {
            InitializeComponent();
            Equipment = new Equipment();
            Initialize();
        }
        private void Initialize()
        {
            using (var db = new TechnicalSecviceContext())
            {
                comboBoxType.Items.AddRange(db.EquipmentTypes.AsNoTracking().ToArray());
                comboBoxType.SelectedIndex = 0;
            }
        }

        public AddEditEquipmentForm(Equipment equipment) : this()
        {
            this.Text = "Изменить оборудование";
            Equipment = equipment;
            textBoxTitle.Text = Equipment.Title;
            textBoxSerialNumber.Text = Equipment.SerialNumber;
            comboBoxType.SelectedItem = comboBoxType.Items.Cast<EquipmentType>()
                .FirstOrDefault(x => x.Id == Equipment.Id);
        }
        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBoxTitle.Text) && !string.IsNullOrWhiteSpace(textBoxSerialNumber.Text))
            {
                Equipment.Title = textBoxTitle.Text;
                Equipment.SerialNumber = textBoxSerialNumber.Text;
                Equipment.EquipmentTypeId = ((EquipmentType)comboBoxType.SelectedItem).Id;
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
