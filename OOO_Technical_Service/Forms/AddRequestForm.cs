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
    public partial class AddRequestForm : Form
    {
        public Request Request { get; set; }
        public AddRequestForm()
        {
            InitializeComponent();
            comboBoxStatus.DisplayMember = nameof(Status.Title);
            comboBoxBrokeType.DisplayMember = nameof(Status.Title);
            comboBoxClient.DisplayMember = nameof(Status.Title);
            comboBoxPriority.DisplayMember = nameof(Status.Title);
            checkedListBoxEmployees.DisplayMember = nameof(Employee.LastName);
            Request = new Request();
        }
        public List<int> GetCheckedTypes()
            => checkedListBoxEmployees.CheckedItems.Cast<Employee>().Select(x => x.Id).ToList();
    }
}
