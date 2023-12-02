using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OM2
{
    internal class PositionServicePL
    {
        PositionServiceBLL positionServiceBLL;

        public PositionServicePL(PositionServiceBLL positionServiceBLL)
        {
            this.positionServiceBLL = positionServiceBLL;
        }

        public void GetPositionsDepartmens()
        {

            List<PositionDepartmentVM> positions = positionServiceBLL.GetPositionsDepartmens();

            foreach (PositionDepartmentVM p in positions)
            {
                Console.WriteLine(p);
            }
        }

        public void GetPositionsByDepartmentName()
        {
            //Console.OutputEncoding = Encoding.UTF8;

            Console.Write("Введіть ім'я: ");
            string name = Console.ReadLine();

            List<Position> positions = positionServiceBLL.GetPositionsByDepartmentName(name);

            foreach (Position position in positions)
            {
                Console.WriteLine(position);
            }
        }
    }
}