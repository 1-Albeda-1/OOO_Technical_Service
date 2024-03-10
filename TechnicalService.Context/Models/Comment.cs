using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechnicalService.Context.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public string CommentText { get; set; }
        public int EmployeeId { get; set; }
        public virtual Employee Employee { get; set; }
        public ICollection<Request> Requests { get; set; }
        public Comment()
        {
            Requests = new HashSet<Request>();
        }
    }
}
