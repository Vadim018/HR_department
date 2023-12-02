using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OM2
{
    internal class PositionServiceBLL
    {
        DBItemDAL<Position> dbPosition;

        DBItemDAL<Department> dbDepartment;

        public PositionServiceBLL(DBItemDAL<Position> dbPosition, DBItemDAL<Department> dbDepartment)
        {
            this.dbPosition = dbPosition;
            this.dbDepartment = dbDepartment;
        }

        public List<PositionDepartmentVM> GetPositionsDepartmens()
        {

            List<PositionDepartmentVM> positions = new List<PositionDepartmentVM>();

            foreach (Position p in dbPosition.Items)
            {
                positions.Add(new PositionDepartmentVM(p.PositionName, p.RelatedDepartment.DepartmentName));
            }
            return positions;
        }

        public List<Position> GetPositionsByDepartmentName(string departmentName)
        {
            List<Position> positions = new List<Position>();

            foreach (Department d in dbDepartment.Items)
            {
                if (d.DepartmentName == departmentName)
                {
                    positions.AddRange(d.Positions);
                }
            }
            return positions;
        }
    }
}