using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegoSIMON
{    
    class InputPlayer
    {    
        public bool SecuenciaInputJugador(List<int> secuenciaRandom)
        {            
            bool acierto = false;
            int nroIngr=-1;
            for (int i = 0; i < secuenciaRandom.Count; i++)
            {
                ConsoleKeyInfo tecla = Console.ReadKey(false);
                if (tecla.KeyChar == 49) nroIngr =0;
                if (tecla.KeyChar == 50) nroIngr = 1;
                if (tecla.KeyChar == 51) nroIngr = 2;
                if (tecla.KeyChar == 52) nroIngr = 3;

                if (nroIngr == secuenciaRandom[i])
                {
                    acierto = true;
                }
                else
                {
                    acierto = false;
                    break;
                }
            }
            return acierto;
        }

        public string PresentationPoster(string legend)
        {
            // Genera cartel adaptandose al texto recibido
            int longer = legend.Length;
            string tittle = "";
            string space = " ";
            string horizBar = new string('─', longer + 8);
            string vertBar = "│";
            string supIzq = "┌";
            string supDer = "┐";
            string infIzq = "└";
            string infDer = "┘";
            string margenSpace = new string(' ', 4);
            string prefix = vertBar + margenSpace;
            string suffix = margenSpace + vertBar;

            tittle = supIzq + horizBar + supDer + "\n";
            tittle += prefix + legend + suffix + "\n";
            tittle += infIzq + horizBar + infDer + "\n";

            return tittle;
        }   //  End PresentationPoster

        public string LegendPlus(int longer, string legend)
        {
            // Genera cartel adaptandose al texto recibido
            //int longer = legend.Length;

            string tittle = "";
            string space = " ";
            string horizBar = new string('─', longer + 8);
            string vertBar = "│";
            string supIzq = "┌";
            string supDer = "┐";
            string infIzq = "└";
            string infDer = "┘";
            string margenSpace = new string(' ', 4);
            string prefix = vertBar + margenSpace;
            string suffix = margenSpace + vertBar;

            if (legend=="begin")
            {
                tittle = supIzq + horizBar + supDer + "\n";
            }
            else if (legend == "finish")
            {
                tittle += infIzq + horizBar + infDer + "\n";
            }
            else
            {
                tittle += prefix + legend + suffix + "\n";
            }
            return tittle;
        }   //  End PresentationPoster

        public bool ctrlNumber(string fact)
        {
            bool inNumber = Int32.TryParse(fact, out _);
            return inNumber;
        }   // End CtrlNumber

        public bool OnlyYesNo(string response)
        {
            bool responseYes = false;
            CtrlString(response);

            if (response.ToUpper() == "S")
            {
                responseYes = true;          // La respuesta es SI
            }
            else if (response.ToUpper() == "N")
            {
                responseYes = false;          // La respuesta es NO

            }
            return responseYes;
        }   // End OnlyYesNo

        public bool CtrlString(string response)
        {
            bool isstring = false;
            for (int i = 0; i < response.Length; i++)
            {
                isstring = char.IsLetter(response[i]);
            }
            return isstring;
        }   // End CtrlString

        public int Centrar(string palabra)
        {
            // largo palabra 19, mitad 9

            int posicionInicio = 0;
            int centroPalabra = palabra.Length / 2;
            // Cartel 27 columnas, mitad 13
            posicionInicio = 27 - (palabra.Length * 2 + 1);

            return posicionInicio;
        }

    }

}
