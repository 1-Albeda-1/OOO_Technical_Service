using OOO_Technical_Service.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TechnicalService.Context.DB;
using TechnicalService.Context.Models;

namespace OOO_Technical_Service
{
    public partial class RequestUserControl : UserControl
    {
        public Request request { get; set; }
        public RequestUserControl(Request request)
        {
            InitializeComponent();
            this.request = request;
            InitRequest(request);
        }
        public Request Request => request;
        private void InitRequest(Request request)
        {
            labelNumber.Text = request.Id.ToString();
            labelBrokenType.Text = request.BrokenType.ToString();
            labelClient.Text = request.Client.ToString();
            labelDate.Text = request.RequestDate.ToString();
            labelDescription.Text = request.Description.ToString();
            labelEquipment.Text = request.Equipment.ToString();
            labelPriority.Text = request.Priority.ToString(); 
            labelSatus.Text = request.Status.ToString();

            if(WorkToEmployee.Employee.RoleId == 1)
            {
                buttonEdit.Enabled = buttonAddComment.Enabled = false;
            }        
        }
        private void buttonAddComment_Click(object sender, EventArgs e)
        {

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
                }
            }
        }
    }
}
