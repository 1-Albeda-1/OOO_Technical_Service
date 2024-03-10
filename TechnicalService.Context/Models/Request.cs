using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechnicalService.Context.Models
{
    public class Request
    {
        public int Id { get; set; }
        public DateTimeOffset RequestDate { get; set; }
        public int EquipmentId { get; set; }
        public virtual Equipment Equipment { get; set; }
        public int BrokenTypeId { get; set; }
        public virtual BrokenType BrokenType { get; set; }
        public int ClientId { get; set; }
        public virtual Client Client { get; set; }
        public int StatusId { get; set; }
        public virtual Status Status { get; set; }
        public string Description { get; set; }
        public string Priority { get; set; }
        public ICollection<Employee> Employees { get; set; }
        public ICollection<Comment> Comments { get; set; }
        public ICollection<Report> Reports { get; set; }
        public Request()
        {
            Employees = new HashSet<Employee>();
            Comments = new HashSet<Comment>();
        }
    }
}
