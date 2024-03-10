using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechnicalService.Context.Models
{
    public class SparesCount
    {
        public int Id { get; set; }
        public string Count { get; set; }
        public int SparesTypeId { get; set; }
        public virtual SparesType SparesType { get; set; }
        public ICollection<Report> Reports { get; set; }
        public SparesCount()
        {
            Reports = new HashSet<Report>();
        }

    }
}
