using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Metadata.Edm;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechnicalService.Context.Models
{
    public class Report
    {
        public int Id { get; set; }
        public int RequestId { get; set; }
        public virtual Request Request { get; set; }
        public DateTimeOffset CompletionDate { get; set; }
        public decimal Price { get; set; }
        public string Reason { get; set; }

        public ICollection<SparesCount> SparesCounts { get; set; }
        public Report()
        {
            SparesCounts = new HashSet<SparesCount>();
        }
    }
}
