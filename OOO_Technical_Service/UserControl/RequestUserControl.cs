﻿using OOO_Technical_Service.Forms;
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
            PrintComment();
        }
        public Request Request => request;
        private void InitRequest(Request request)
        {
            labelNumber.Text = request.Id.ToString();
            labelBrokenType.Text = request.BrokenType.Title;
            labelClient.Text = request.Client.FullName;
            richTextBoxDescription.Text = request.Description;
            labelEquipment.Text = request.Equipment.Title;
            labelPriority.Text = request.Priority;
            labelSatus.Text = request.Status.Title;
            var date = request.RequestDate.ToString("dd-MM-yyyy");
            labelDate.Text = date;

            if (WorkToEmployee.Employee.RoleId == 1)
            {
                buttonEdit.Enabled = buttonAddComment.Enabled = false;
            }        
        }
        private void PrintComment()
        {
            using (var db = new TechnicalSecviceContext())
            {
                dataGridView1.DataSource = db.Comments.Include(x => x.Employee)
                    .ToList();
            }
        }
        private void buttonAddComment_Click(object sender, EventArgs e)
        {
            AddCommentForm form = new AddCommentForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                using (var db = new TechnicalSecviceContext())
                {
                    db.Comments.Add(form.Comment);
                    db.SaveChanges();
                    PrintComment();
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
                }
            }
        }

    }
}
