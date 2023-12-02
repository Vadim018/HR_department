using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace OM2   
{
    internal class Position : IID
    {
        public int Id { get; set; }

        public string PositionName { get; set; }

        public Department RelatedDepartment { get; set; }

        public Position(string positionName)
        {
            PositionName = positionName;
        }

        public override string ToString()
        {
            return String.Format(Id + " " + PositionName + " " + RelatedDepartment.DepartmentName);
        }
    }
}