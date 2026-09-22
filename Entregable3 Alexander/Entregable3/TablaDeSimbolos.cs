using System;
using System.Collections.Generic;
using System.Linq;

namespace Entregable3
{
    public class TablaDeSimbolos
    {
        private List<SimboloTabla> listaSimbolos;
        private string[] palabrasReservadas;
        private int contadorId;

        public TablaDeSimbolos()
        {
            listaSimbolos = new List<SimboloTabla>();
            contadorId = 1;

            palabrasReservadas = new string[]
            {
                "using", "namespace", "class", "public", "private", "protected",
                "static", "void", "int", "double", "float", "string", "bool",
                "if", "else", "while", "for", "foreach", "do", "switch", "case",
                "default", "break", "continue", "return", "new",
                "true", "false", "null", "char"
            };
        }

        public bool EsPalabraReservada(string lexema)
        {
            for (int i = 0; i < palabrasReservadas.Length; i++)
            {
                if (palabrasReservadas[i] == lexema)
                    return true;
            }
            return false;
        }

        public void AgregarOActualizar(string nombre, string tipoToken, string tipoDato, int linea, int columna, string ambito)
        {
            if (EsPalabraReservada(nombre)) return;

            if (listaSimbolos.Any(s => s.Nombre == nombre)) return;

            SimboloTabla nuevoSimbolo = new SimboloTabla(contadorId++, nombre, tipoToken, tipoDato, linea, columna, ambito);
            listaSimbolos.Add(nuevoSimbolo);
        }

        public List<SimboloTabla> ObtenerSimbolos()
        {
            return listaSimbolos;
        }

        public void Limpiar()
        {
            listaSimbolos.Clear();
            contadorId = 1;
        }
    }
}
