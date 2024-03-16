using OOO_Technical_Service.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TechnicalService.Context.DB;
using TechnicalService.Context.Models;
using OOO_Technical_Service.Forms.AddForms;
using OOO_Technical_Service.Forms.GridForms;

namespace OOO_Technical_Service
{
    public partial class RequestUserControl : UserControl
    {
        public Request request { get; set; }
        public RequestUserControl(Request request)
        {
            InitializeComponent();
            this.request = request;
            dataGridView1.AutoGenerateColumns = false;
            InitRequest(request); 
        }
        public Request Request => request;
        private void InitRequest(Request request)
        {
            
            using (var db = new TechnicalSecviceContext())
            {
                var request1 = db.Requests.Include(x => x.BrokenType).Include(x => x.Client).Include(x => x.Equipment).Include(x => x.Status).FirstOrDefault(x => x.Id == request.Id);
                
                if(request1 != null)
                {
                    labelNumber.Text = request1.Id.ToString();
                    labelBrokenType.Text = request1.BrokenType.Title;
                    labelClient.Text = request1.Client.FullName;
                    richTextBoxDescription.Text = request1.Description;
                    labelEquipment.Text = request1.Equipment.Title;
                    labelPriority.Text = request1.Priority;
                    labelSatus.Text = request1.Status.Title;
                    var date = request1.RequestDate.ToString("dd-MM-yyyy");
                    labelDate.Text = date;
                }

                if (request1.Status.Title == "Выполнено")
                {
                    this.BackColor = Color.DarkGray;      
                }
                var comment = db.Requests.Include(x => x.Comments).FirstOrDefault(x => x.Id == request.Id).Comments.Select(x => x.Id);
                dataGridView1.DataSource = db.Comments.Include(x => x.Employee).Where(x => comment.Contains(x.Id)).ToList();
            }

            if (WorkToEmployee.Employee.RoleId == 1)
            {
                buttonEdit.Enabled = buttonAddComment.Enabled = false;
            }        
        }

        private void buttonAddComment_Click(object sender, EventArgs e)
        {
            AddCommentForm form = new AddCommentForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                using (var db = new TechnicalSecviceContext())
                {
                    var request1 = db.Requests.FirstOrDefault(x => x.Id == request.Id);         
                    db.Comments.Add(form.Comment);
                    if(request1 != null)
                    {
                        request1.Comments.Add(form.Comment);
                    }
                    db.SaveChanges();
                    InitRequest(request1);
                }
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            using (var db = new TechnicalSecviceContext())
            {
                var request1 = db.Requests.FirstOrDefault(x => x.Id == request.Id);
                EditRequestForm form = new EditRequestForm(request1);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    var ids = form.GetCheckedTypes();
                    request1.Employees.Clear();
                    request1.Employees = db.Employees.Where(x => ids.Contains(x.Id)).ToList();
                    db.SaveChanges();
                    InitRequest(request1);

                    if(request1.Status.Title == "Выполнено")
                    {
                        this.BackColor = Color.DarkGray;
                        if (MessageBox.Show($"Заявка номер {request1.Id} выполнена! Требуется составить отчет о проделанной работе.", "Подтвердите!", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                        {
                            AddReportForm addReportForm = new AddReportForm(request1.Id);
                            if(addReportForm.ShowDialog() == DialogResult.OK)
                            {
                                db.Reports.Add(addReportForm.Report);
                                db.SaveChanges();
                            }
                        }
                    }
                }
            }
        }

    }
}
