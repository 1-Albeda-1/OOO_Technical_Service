using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechnicalService.Context.Models;

namespace TechnicalService.Context.DB
{
    public class TechnicalSecviceContext : DbContext
    {
        public DbSet<BrokenType> BrokenTypes { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Equipment> Equipments { get; set; }
        public DbSet<EquipmentType> EquipmentTypes { get; set; }
        public DbSet<Report> Reports { get; set; }
        public DbSet<Request> Requests { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<SparesCount> SparesCounts { get; set; }
        public DbSet<SparesType> SparesTypes { get; set; }
        public DbSet<Status> Statuses { get; set; }

        public TechnicalSecviceContext() : base("DefaultConnection") { }

    }
}
