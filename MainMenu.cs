using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OM2
{
    internal class MainMenu
    {
        PositionServiceMenu positionServiceMenu;
        public MainMenu(PositionServiceMenu positionServiceMenu)
        {
            this.positionServiceMenu = positionServiceMenu;
        }
        public void Run()
        {
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("1) Меню");
                Console.WriteLine("2) Вихід");

                int menuNumber = Convert.ToInt32(Console.ReadLine());

                switch (menuNumber)
                {
                    case 1:
                        positionServiceMenu.Run();
                        break;
                    case 2:
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