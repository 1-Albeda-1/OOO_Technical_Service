using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechnicalService.Context.Models;

namespace OOO_Technical_Service
{
    internal static class WorkToEmployee
    {
        private static Employee employee;
        public static Employee Employee
        {
            get
            {
                if (employee == null)
                {
                    employee = new Employee()
                    { 
                        Id = -1,
                        FullName = "Неавторизованный гость",
                        RoleId = 1,
                    };
                }
                return employee;
            }
            set { employee = value; }
        }
    }
}
