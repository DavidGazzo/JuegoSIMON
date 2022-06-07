namespace JuegoSIMON
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            
            Botones btn = new Botones();
            Sounds sounds = new Sounds();
            InputPlayer inputPlayer = new InputPlayer();
            Random encender = new Random();             // Enciende Boton aleatoriamente            

            int speed = 300;        // Duración del boton encendido
            int btnRandom = 0;      // Botón que se enciende su valor lo entrega "encender"
            int contador = 0;       // Contador de intentos
            bool acierto = false;   // Si true continua aumentando la secuencia. False error de ingreso del jugador
            bool continuar = false; // Continuar jugando = true, no continuar = false

            // Presentacion Juego
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(inputPlayer.PresentationPoster("          DIGI-SIMON         "));
            sounds.InitSound();
            FunctionBtns(btn, 0, speed);
            FunctionBtns(btn, 1, speed);
            FunctionBtns(btn, 2, speed);
            FunctionBtns(btn, 3, speed);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.SetCursorPosition(0, 12);
            string mensajeLargo = "luego ingrese igual secuencia";
            Console.Write(inputPlayer.LegendPlus(mensajeLargo.Length,"begin"));
            Console.Write(inputPlayer.LegendPlus(mensajeLargo.Length,"Mire y escuche atentamente,  "));
            Console.Write(inputPlayer.LegendPlus(mensajeLargo.Length, mensajeLargo));
            Console.Write(inputPlayer.LegendPlus(mensajeLargo.Length,"(Solo números del 1 al 4)    "));
            Console.Write(inputPlayer.LegendPlus(mensajeLargo.Length, "finish"));
            Console.WriteLine("Presione una tecla para comenzar...");
            Console.ReadKey();
            Console.ResetColor();
            
            //--------------------------------------
            do
            {
                List<int> secuencia = new List<int>();
                Console.Clear();
                Console.WriteLine(inputPlayer.PresentationPoster("    DIGI-SIMON    "));
                do
                {
                    btnRandom = encender.Next(0, 4);            // Agrega a la secuencia un boton
                    secuencia.Add(btnRandom);                   // Guarda toda la secuencia que se va generando
                    for (int i = 0; i < secuencia.Count; i++)   // Imprime nuevo boton
                    {                    
                        FunctionBtns(btn, secuencia[i], speed); // Parametros secuencia[i]= nro boton, speed = Velocidad de funcionamiento
                    }                
                    contador++;                     // Cuenta largo de la secuencia
                    Console.ResetColor();
                    Console.SetCursorPosition(0, 12);   // 
                    Console.WriteLine("Ingrese su secuencia...");                    
                    acierto = inputPlayer.SecuenciaInputJugador(secuencia); // Compara la secuencia con lo que ingresa el jugador
                    Console.SetCursorPosition(0, 12);   // 
                    Console.WriteLine("                              ");    // Borra textos "Ingrese su secuencia"...                                                                            
                    Console.WriteLine("                              ");    // ...y secuencia ingresada
                    if (contador==5) contador = contador;
                } while (acierto);

                if (!acierto)
                {
                    sounds.InputError();  // Si se ingresa con error una secuencia
                    Console.WriteLine($"UUuuuhhh! Perdiste. Lograste ingresar \"{contador}\" secuencias.");
                    Console.Write("¿Quieres jugar nuevamente? S/N ");
                    continuar = inputPlayer.OnlyYesNo(Console.ReadLine());
                }
            
            } while (continuar);
        }

        static void FunctionBtns(Botones btn, int botonActivo, int speed)   // Generacion de cada boton, grafico, sonido, posicion
        {
            
            switch (botonActivo)
            {
                case 0:
                    BtnRed(btn, 1);
                    NumDriver(btn,1,true);
                    Sound(800,200);
                    Thread.Sleep(speed);
                    NumDriver(btn, 1, false);
                    BtnRed(btn, 0);                    
                    Thread.Sleep(10);
                    break;
                case 1:
                    BtnGreen(btn, 1);
                    NumDriver(btn, 2, true);
                    Sound(1200, 200);
                    Thread.Sleep(speed);
                    NumDriver(btn, 2, false);
                    BtnGreen(btn, 0);
                    Thread.Sleep(10);
                    break;
                case 2:
                    BtnBlue(btn, 1);
                    NumDriver(btn, 3, true);
                    Sound(400,200);
                    Thread.Sleep(speed);
                    NumDriver(btn, 3, false);
                    BtnBlue(btn, 0);
                    Thread.Sleep(10);
                    break;
                case 3:
                    BtnYellow(btn, 1);
                    NumDriver(btn, 4, true);
                    Sound(1600, 200);
                    Thread.Sleep(speed);
                    NumDriver(btn, 4, false);
                    BtnYellow(btn, 0);
                    Thread.Sleep(10);
                    break;
            }
        }
        
        static void BtnRed(Botones btn, int intens)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            for (int z = 0; z < 4; z++) Console.WriteLine(btn.Boton(intens, 0, z));          
        }

        static void BtnGreen(Botones btn, int intens)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            for (int z = 0; z < 4; z++) Console.WriteLine(btn.Boton(intens, 10, z));
        }

        static void BtnBlue(Botones btn, int intens)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            for (int z = 0; z < 4; z++) Console.WriteLine(btn.Boton(intens, 20, z));
        }

        static void BtnYellow(Botones btn, int intens)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            for (int z = 0; z < 4; z++) Console.WriteLine(btn.Boton(intens, 30, z));
        }

        static void Sound(int freq, int duration)
        {
            Console.Beep(freq,duration);
        }

        static void NumDriver(Botones btn, int nro, bool ver)
        {
            switch (nro)
            {
                case 1:
                    if (ver)
                    {
                        for (int z = 0; z < 3; z++) Console.WriteLine(btn.NumberBottom(1,4, z+4, z));
                    }
                    else
                    {
                        for (int z = 0; z < 3; z++) Console.WriteLine(btn.DeletNumber(4, z + 4));
                    }
                    
                    break;
                case 2:
                    if (ver)
                    {
                        for (int z = 0; z < 3; z++) Console.WriteLine(btn.NumberBottom(2, 14, z + 4,z));
                    }
                    else
                    {
                        for (int z = 0; z < 3; z++) Console.WriteLine(btn.DeletNumber(14, z + 4));
                    }
                    break;
                case 3:
                    if (ver)
                    {
                        for (int z = 0; z < 3; z++) Console.WriteLine(btn.NumberBottom(3, 24, z + 4, z));
                    }
                    else
                    {
                        for (int z = 0; z < 3; z++) Console.WriteLine(btn.DeletNumber(24, z + 4));
                    }
                    break;
                case 4:
                    if (ver)
                    {
                        for (int z = 0; z < 3; z++) Console.WriteLine(btn.NumberBottom(4, 34, z + 4, z));
                    }
                    else
                    {
                        for (int z = 0; z < 3; z++) Console.WriteLine(btn.DeletNumber(34, z + 4));
                    }
                    break;
                
            }
        }        

        static void NivelMaximo()
        {
            //for (int i = 0; i < 5; i++)
            //{
            //    for (int j = 0; j < contador; j++)
            //    {
            //        //cargar encender en la lista o en una variable
            //        FunctionBtns(btn, encender.Next(0, 4), speed);//0,speed);

            //    }

            //    Console.ReadKey();
            //    contador++;
            //}
        }
    }
}