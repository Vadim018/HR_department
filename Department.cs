using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace OM2
{
    internal class Department : IID
    {
        public int Id { get; set; }

        public string DepartmentName { get; set; }

        public List<Position> Positions { get; set; } = new List<Position>();

        public Department(string departmentName)
        {
            DepartmentName = departmentName;
        }
    }
}