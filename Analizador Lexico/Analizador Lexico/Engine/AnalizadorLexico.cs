using System;
using AnalizadorLexico.Models;

namespace AnalizadorLexico.Engine
{
    public class AnalizadorLexico
    {
        private string codigoFuente;
        private int posicion;
        private int lineaActual;
        private int columnaActual;

        private Token[] tokens;
        private int contadorTokens;

        private ErrorLexico[] errores;
        private int contadorErrores;

        public TablaDeSimbolos TablaSimbolos { get; private set; }

        public AnalizadorLexico(string codigoFuente)
        {
            this.codigoFuente = codigoFuente ?? string.Empty;
            posicion = 0;
            lineaActual = 1;
            columnaActual = 1;

            tokens = new Token[2000];
            contadorTokens = 0;

            errores = new ErrorLexico[500];
            contadorErrores = 0;

            TablaSimbolos = new TablaDeSimbolos();
        }

        public Token[] ObtenerTokens()
        {
            Token[] resultado = new Token[contadorTokens];
            Array.Copy(tokens, resultado, contadorTokens);
            return resultado;
        }

        public ErrorLexico[] ObtenerErrores()
        {
            ErrorLexico[] resultado = new ErrorLexico[contadorErrores];
            Array.Copy(errores, resultado, contadorErrores);
            return resultado;
        }


        public void Escanear()
        {
            posicion = 0;
            lineaActual = 1;
            columnaActual = 1;
            contadorTokens = 0;
            contadorErrores = 0;
            TablaSimbolos.Limpiar();

            while (posicion < codigoFuente.Length)
            {
                char caracterActual = codigoFuente[posicion];

                if (caracterActual == '\n')
                {
                    lineaActual++;
                    columnaActual = 1;
                    posicion++;
                }
                else if (caracterActual == '\r')
                {
                    posicion++;
                }
                else
                {
                    columnaActual++;
                    posicion++;
                }
            }
        }
    }
}
