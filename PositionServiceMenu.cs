using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OM2
{
    internal class PositionServiceMenu
    {

        PositionServicePL positionServicePL;

        public PositionServiceMenu(PositionServicePL positionServicePL)
        {
            this.positionServicePL = positionServicePL;
        }

        public void Run()
        {
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("1) Вивести всі посади");
                Console.WriteLine("2) По введеній назві відділу надавати назви всіх посад");
                Console.WriteLine("3) Вихід");

                int menuNumber = Convert.ToInt32(Console.ReadLine());

                switch (menuNumber)
                {
                    case 1:
                        positionServicePL.GetPositionsDepartmens();
                        break;
                    case 2:
                        positionServicePL.GetPositionsByDepartmentName();
                        break;
                    case 3:
                        flag = false;
                        break;
                    default:
                        Console.WriteLine("CHOOSE ONE OF THE POINTS BELOW");
                        break;
                }
            }
        }
    }
}