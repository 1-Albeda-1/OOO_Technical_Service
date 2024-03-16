using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TechnicalService.Context.Models;
using System.Data.Entity;
using TechnicalService.Context.DB;

namespace OOO_Technical_Service.Forms
{
    public partial class StatusRequestForm : Form
    {
        private int readyRequest = 0;
        public StatusRequestForm()
        {
            InitializeComponent();
            comboBoxStatus.DisplayMember = nameof(Status.Title);
            comboBoxStatus.ValueMember = nameof(Status.Id);
        }


        private void StatusRequestForm_Load(object sender, EventArgs e)
        {
            using (var db = new TechnicalSecviceContext())
            {

                comboBoxStatus.Items.Clear();
                comboBoxStatus.Items.AddRange(db.Statuses.OrderBy(x => x.Title).ToArray());
                comboBoxStatus.Items.Insert(0, new Status()
                {
                    Id = -1,
                    Title = "Все стаутсы",
                });

                comboBoxStatus.SelectedIndex = 0;

                var requests = db.Requests.Include(x => x.Employees).Include(x => x.Comments).Include(x => x.Equipment).ToList();
                readyRequest = 0;

                foreach (var request in requests)
                {
                    var requestUserControl = new RequestUserControl(request);
                    requestUserControl.Parent = flowLayoutPanel1;
                    if(request.Status.ToString() == "Выполнено")
                    {
                        readyRequest++;     
                    }          
                }
            }
            labelReadyRequest.Text = readyRequest.ToString();
        }
        private void Filter()
        {
            if (comboBoxStatus.SelectedItem == null) return;
            var selectedStatusId = ((Status)comboBoxStatus.SelectedItem).Id;
            foreach (var item in flowLayoutPanel1.Controls)
            {
                var visible = true;
                if (item is RequestUserControl requestUserControl)
                {
                    if (selectedStatusId != -1 &&
                        requestUserControl.Request.Status.Id != selectedStatusId)
                    {
                        visible = false;
                    }

                    if (!(string.IsNullOrEmpty(textBoxSearch.Text) 
                        || requestUserControl.Request.Equipment.Title.ToLower().Contains(textBoxSearch.Text.ToLower())))
                    {
                        visible = false;
                    }

                    requestUserControl.Visible = visible;
                }
            }
        }
        
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            AddRequestForm form = new AddRequestForm();

            if (form.ShowDialog() == DialogResult.OK)
            {
                using (var db = new TechnicalSecviceContext())
                {
                    var ids = form.GetCheckedTypes();
                    form.Request.Employees = db.Employees.Where(x => ids.Contains(x.Id)).ToList();
                    db.Requests.Add(form.Request);
                    db.SaveChanges();
                }
                var requestUserControl = new RequestUserControl(form.Request);
                requestUserControl.Parent = flowLayoutPanel1;
            }
            
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            Filter();
        }

        private void comboBoxStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            Filter();
        }
    }
}
