using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OM2
{
    internal class PositionDepartmentVM
    {

        public string PositionName { get; set; }

        public string DepartmentName { get; set; }

        public PositionDepartmentVM(string positionName, string departmentName)
        {
            PositionName = positionName;
            DepartmentName = departmentName;
        }

        public override string ToString()
        {
            return String.Format(PositionName + " " + DepartmentName);
        }
    }
}