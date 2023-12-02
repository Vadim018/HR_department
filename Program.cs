/*

-------------------------------------------------------------------------------
Завдання ОМ2
-------------------------------------------------------------------------------
    Створити трирівневу інформаційну систему з підтримки діяльності відділу кадрів.

    Існують декілька відділів. В кожному відділі є декілька посад.

    Інформаційна система повинна:
    * вивести всі посади (кожна посада зі своїм відділом);
    * по введеній назві відділу надавати назви всіх посад цього відділу.
-------------------------------------------------------------------------------

*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OM2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            DBItemDAL<Position> dbPosition = new DBItemDAL<Position>();

            Position position1 = new Position("P1");
            Position position2 = new Position("P2");
            Position position3 = new Position("P3");
            Position position4 = new Position("P4");

            DBItemDAL<Department> dbDepartment = new DBItemDAL<Department>();

            Department department1 = new Department("D1");
            Department department2 = new Department("D2");

            position1.RelatedDepartment = department1;
            position2.RelatedDepartment = department1;
            position3.RelatedDepartment = department2;
            position4.RelatedDepartment = department2;

            department1.Positions.Add(position1);
            department1.Positions.Add(position2);
            department2.Positions.Add(position3);
            department2.Positions.Add(position4);

            dbPosition.Add(position1);
            dbPosition.Add(position2);
            dbPosition.Add(position3);
            dbPosition.Add(position4);

            dbDepartment.Add(department1);
            dbDepartment.Add(department2);

            PositionServiceBLL positionServiceBLL = new PositionServiceBLL(dbPosition, dbDepartment);

            PositionServicePL positionServicePL = new PositionServicePL(positionServiceBLL);

            PositionServiceMenu positionServiceMenu = new PositionServiceMenu(positionServicePL);

            MainMenu mainMenu = new MainMenu(positionServiceMenu);

            mainMenu.Run();
        }
    }
}