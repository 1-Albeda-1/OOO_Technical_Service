using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechnicalService.Context.Models
{
    public class EquipmentType
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public ICollection<Equipment> Equipments { get; set; }
    }
}
