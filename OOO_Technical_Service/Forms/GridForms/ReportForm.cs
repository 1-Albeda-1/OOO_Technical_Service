using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TechnicalService.Context.DB;

namespace OOO_Technical_Service.Forms.GridForms
{
    public partial class ReportForm : Form
    {
        private int pageSize = 5;
        private int oldCountPage = -1;
        private readonly BindingSource bindingSource = new BindingSource();
        public ReportForm()
        {
            InitializeComponent();
            bindingSource.CurrentItemChanged += Bs_CurrentItemChanged;
            dataGridView1.AutoGenerateColumns = false;
            Print();
        }
        private void Print()
        {
            using (var db = new TechnicalSecviceContext())
            {
                var count = db.Clients.Count();
                var countPage = (int)Math.Ceiling((decimal)count / pageSize);

                if (oldCountPage != countPage)
                {
                    oldCountPage = countPage;
                    var current = bindingSource.Position;

                    if (current > countPage)
                    {
                        current = countPage;
                    }

                    bindingSource.DataSource = Enumerable.Range(1, countPage);

                    if (current != -1)
                    {
                        bindingSource.Position = current;
                    }

                    bindingNavigator1.BindingSource = bindingSource;
                }
                toolStripLabelCount.Text = $"Кол-во записей: {count}";
                dataGridView1.DataSource = db.Reports.Include(x => x.Request)
                    .OrderBy(x => x.Reason)
                    .Skip(bindingSource.Position * pageSize)
                    .Take(pageSize)
                    .ToList();
            }
        }
        private void Bs_CurrentItemChanged(object sender, EventArgs e)
        {
            Print();
        }
        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
