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
    public partial class AddEditClientForm : Form
    {
        public Client Client { get; set; }
        public AddEditClientForm()
        {
            InitializeComponent();
            Client = new Client();

        }
        public AddEditClientForm(Client client) : this()
        {
            this.Text = "Изменить клиента";
            Client = client;
            textBoxFullName.Text = Client.FullName;
            maskedTextBoxPhone.Text = Client.Phone;
            textBoxEmail.Text = Client.Email;
        }
        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBoxFullName.Text) && !string.IsNullOrWhiteSpace(maskedTextBoxPhone.Text) && !string.IsNullOrWhiteSpace(textBoxEmail.Text))
            {
                Client.FullName = textBoxFullName.Text;
                Client.Phone = maskedTextBoxPhone.Text;
                Client.Email = textBoxEmail.Text;
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
