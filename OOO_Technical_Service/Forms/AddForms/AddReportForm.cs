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

namespace OOO_Technical_Service.Forms.AddForms
{
    public partial class AddReportForm : Form
    {
        private int idRequest;
        public Report Report { get; set; }
        public AddReportForm()
        {
            InitializeComponent();
            Report = new Report();
        }
        public AddReportForm(int requestId): this()
        {
            idRequest = requestId;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(richTextBoxReason.Text))
            {
                Report.RequestId = idRequest;
                Report.CompletionDate = DateTimeOffset.Now;
                Report.Price = numericUpDownPrice.Value;
                Report.Reason = richTextBoxReason.Text;
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
