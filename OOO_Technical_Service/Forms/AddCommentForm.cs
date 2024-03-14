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
    public partial class AddCommentForm : Form
    {
        public Comment Comment { get; set; }
        public AddCommentForm()
        {
            InitializeComponent();
            Comment = new Comment();
            labelFIO.Text = WorkToEmployee.Employee.FullName.ToString();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(richTextBoxComment.Text))
            {
                using (var db = new TechnicalSecviceContext())
                {
                    var employeeId = db.Employees.FirstOrDefault(x => x.FullName == labelFIO.Text);
                    Comment.EmployeeId = employeeId.Id;
                }
                Comment.CommentText = richTextBoxComment.Text;
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
