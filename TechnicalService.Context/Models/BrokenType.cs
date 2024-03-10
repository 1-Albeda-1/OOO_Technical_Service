using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechnicalService.Context.Models
{
    public class BrokenType
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public ICollection<Request> Requests { get; set; }
    }
}
