using System;
using System.IO;
using System.Linq;
using AnalizadorLexico.Models;
using System.Collections.Generic;

namespace AnalizadorLexico.Engine
{
    public class TablaDeSimbolos
    {
        private SimboloTabla[] arregloSimbolos;
        private int contadorSimbolos;
        private Dictionary<string, string> palabrasReservadas;

        public TablaDeSimbolos()
        {
            arregloSimbolos = new SimboloTabla[1000];
            contadorSimbolos = 0;

            palabrasReservadas = new Dictionary<string, string>();

            CargarPalabrasReservadas();  
        }

        private void CargarPalabrasReservadas() 
        {
            string ruta = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Diccionario.txt");

            if (File.Exists(ruta))
            {
                string[] palabras = File.ReadAllLines(ruta);

                foreach (string palabra in palabras) 
                {
                    string palabraLimpia = palabra.Trim();

                    if (palabraLimpia != "") 
                    {
                        palabrasReservadas[palabraLimpia] = "PALABRA_RESERVADA";
                    
                    } 
                }
            }
        }

        public bool EsPalabraReservada(string lexema)
        {
            return palabrasReservadas.ContainsKey(lexema);    
        }

        public void AgregarOActualizar(string nombre, string tipoToken, int linea, int columna)
        {
            if (EsPalabraReservada(nombre))
            {
                return;
            }

            for (int i = 0; i < contadorSimbolos; i++)
            {
                if (arregloSimbolos[i].Nombre == nombre)
                {
                    return; 
                }
            }

           
            int nuevoId = contadorSimbolos + 1;
            SimboloTabla nuevoSimbolo = new SimboloTabla(nuevoId, nombre, tipoToken, linea, columna);
            arregloSimbolos[contadorSimbolos] = nuevoSimbolo;
            contadorSimbolos++;
        }

        public SimboloTabla[] ObtenerSimbolos()
        {
            SimboloTabla[] resultado = new SimboloTabla[contadorSimbolos];
            Array.Copy(arregloSimbolos, resultado, contadorSimbolos);
            return resultado;
        }

        public void Limpiar()
        {
            contadorSimbolos = 0;
            arregloSimbolos = new SimboloTabla[1000];
        }
    }
}
