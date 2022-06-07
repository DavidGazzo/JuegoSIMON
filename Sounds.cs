using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegoSIMON
{
    class Sounds
    {
        public void InitSound()
        {
            int duracion = 100;
            int freq = 200;

            for (int i = 1; i < 4; i++) Console.Beep(freq * i, duracion);
            Thread.Sleep(400);
            Console.Beep(600, duracion);
            Console.Beep(600, duracion*6);
            Thread.Sleep(300);
        }

        public void InputError()
        {
            int duracion = 200;
            int freq = 50;
            for (int i = 6; i > 1; i--) Console.Beep(freq * i, duracion);
        }
    }
    
}
