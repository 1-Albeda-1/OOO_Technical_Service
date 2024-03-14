using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace TechnicalService.Context.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public int RoleId { get; set; }
        public virtual Role Role { get; set; }
        public ICollection<Comment> Comments { get; set; }
        public ICollection<Request> Requests { get; set; }
        public Employee() 
        {
            Requests = new HashSet<Request>();
        }
        public override string ToString()
        {
            return FullName;
        }
    }
}
