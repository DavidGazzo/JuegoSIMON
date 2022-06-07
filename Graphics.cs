using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegoSIMON
{
    class Botones
    {
        public string Boton(int intensidad, int posX ,int posY)
        {            
            string boton = "";
            Console.SetCursorPosition(posX, posY+4);

            if (intensidad == 0)
            {                
                string strChar = new string('░', 8);
                boton += $"{strChar}\n";
            }
            else if (intensidad == 1)
            {                
                string strChar = new string('█', 8);
                boton += $"{strChar}\n";
            }
            return boton;
        }


        public string NumberBottom(int num, int posX, int posY,int z)
        {
            Console.SetCursorPosition(posX, posY+4);
            string grapNum = "";
            switch (num)
            {
                case 1:
                    if (z==0)
                    {
                        grapNum = "╗\n";
                    }
                    else if (z == 1)
                    {
                        grapNum += "║\n";
                    }
                    else
                    {
                        grapNum += "╩\n";
                    }                    
                    break;
                case 2:
                    if (z == 0)
                    {
                        grapNum = "══╗\n";
                    }
                    else if (z == 1)
                    {
                        grapNum += "╔═╝\n";
                    }
                    else
                    {
                        grapNum += "╚══\n";
                    }                    
                    break;
                case 3:
                    if (z == 0)
                    {
                        grapNum = "══╗\n";
                    }
                    else if (z == 1)
                    {
                        grapNum += "══╣\n";
                    }
                    else
                    {
                        grapNum += "══╝\n";
                    }                    
                    break;
                case 4:
                    if (z == 0)
                    {
                        grapNum = "║ ║\n";
                    }
                    else if (z == 1)
                    {
                        grapNum += "╚═╣\n";
                    }
                    else
                    {
                        grapNum += "  ║\n";
                    }                    
                    break;
            }
            return grapNum;
        }

        public string DeletNumber(int posX, int posY)
        {
            Console.SetCursorPosition(posX, posY+4);
            string grapNum = "   \n";            
            return grapNum;
        }

        
    }
    
}
