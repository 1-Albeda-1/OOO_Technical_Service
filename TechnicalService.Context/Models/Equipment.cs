using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechnicalService.Context.Models
{
    public class Equipment
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string SerialNumber { get; set; }
        public int EquipmentTypeId { get; set; }
        public virtual EquipmentType EquipmentType { get; set; }
        public ICollection<Request> Requests { get; set; }
    }
}
