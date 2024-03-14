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

namespace OOO_Technical_Service.Forms.AddForms
{
    public partial class AddEditSparesForm : Form
    {
        public SparesCount Spares { get; set; }
        public AddEditSparesForm()
        {
            InitializeComponent();
            Spares = new SparesCount();
            Initialize();
        }
        private void Initialize()
        {
            using (var db = new TechnicalSecviceContext())
            {
                comboBoxType.Items.AddRange(db.SparesTypes.AsNoTracking().ToArray());
                comboBoxType.SelectedIndex = 0;
            }
        }
        public AddEditSparesForm(SparesCount spares) : this()
        {
            this.Text = "Изменить запчасть";
            Spares = spares;
            numericUpDownCount.Text = Spares.Count;
            comboBoxType.SelectedItem = comboBoxType.Items.Cast<SparesType>()
                .FirstOrDefault(x => x.Id == Spares.Id);
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            Spares.Count = numericUpDownCount.Text;
            Spares.SparesTypeId = ((SparesType)comboBoxType.SelectedItem).Id;
            DialogResult = DialogResult.OK;
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
