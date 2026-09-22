using System;
using System.Collections.Generic;
using System.Text;

namespace Entregable3
{
    public class AnalizadorLexico
    {
        private string codigoFuente;
        private int posicion;
        private int lineaActual;
        private int columnaActual;

        public List<Token> TokensReconocidos { get; private set; }
        public List<ErrorLexico> ErroresDetectados { get; private set; }
        public TablaDeSimbolos TablaSimbolos { get; private set; }

        public AnalizadorLexico(string codigoFuente)
        {
            this.codigoFuente = codigoFuente ?? string.Empty;
            posicion = 0;
            lineaActual = 1;
            columnaActual = 1;

            TokensReconocidos = new List<Token>();
            ErroresDetectados = new List<ErrorLexico>();
            TablaSimbolos = new TablaDeSimbolos();
        }

        public void Escanear()
        {
            posicion = 0;
            lineaActual = 1;
            columnaActual = 1;
            TokensReconocidos.Clear();
            ErroresDetectados.Clear();
            TablaSimbolos.Limpiar();

            while (posicion < codigoFuente.Length)
            {
                char caracterActual = codigoFuente[posicion];

                if (char.IsWhiteSpace(caracterActual))
                {
                    if (caracterActual == '\n') { lineaActual++; columnaActual = 1; }
                    else { columnaActual++; }
                    posicion++;
                    continue;
                }

                if (char.IsLetter(caracterActual) || caracterActual == '_')
                {
                    LeerIdentificadorOPalabraReservada();
                }

                else if (char.IsDigit(caracterActual))
                {
                    LeerNumero();
                }

                else if (caracterActual == '"' || caracterActual == '\'')
                {
                    LeerCadenaOCaracter(caracterActual);
                }

                else if (caracterActual == '/')
                {
                    if (VerificarSiguiente('/')) { LeerComentarioLinea(); }
                    else if (VerificarSiguiente('*')) { LeerComentarioBloque(); }
                    else { LeerOperadorOSimbolo(); }
                }

                else if (EsSimboloValido(caracterActual))
                {
                    LeerOperadorOSimbolo();
                }

                else
                {
                    AgregarError(caracterActual.ToString(), "ERR_CAR: Carácter inválido");
                    posicion++;
                    columnaActual++;
                }
            }
        }

        private void LeerIdentificadorOPalabraReservada()
        {
            int inicioLinea = lineaActual;
            int inicioColumna = columnaActual;
            StringBuilder sb = new StringBuilder();

            while (posicion < codigoFuente.Length &&
                  (char.IsLetterOrDigit(codigoFuente[posicion]) || codigoFuente[posicion] == '_'))
            {
                sb.Append(codigoFuente[posicion]);
                posicion++;
                columnaActual++;
            }

            string lexema = sb.ToString();

            if (TablaSimbolos.EsPalabraReservada(lexema))
            {
                AgregarToken(lexema, "TK_PALABRA_RESERVADA", inicioLinea, inicioColumna);
            }
            else
            {
                AgregarToken(lexema, "TK_IDENTIFICADOR", inicioLinea, inicioColumna);
                TablaSimbolos.AgregarOActualizar(lexema, "TK_IDENTIFICADOR", null, inicioLinea, inicioColumna, "local");
            }
        }

        private void LeerNumero()
        {
            int inicioLinea = lineaActual;
            int inicioColumna = columnaActual;
            StringBuilder sb = new StringBuilder();
            bool esReal = false;
            bool errorNum = false;

            while (posicion < codigoFuente.Length &&
                  (char.IsDigit(codigoFuente[posicion]) || codigoFuente[posicion] == '.'))
            {
                if (codigoFuente[posicion] == '.')
                {
                    if (esReal) { errorNum = true; }
                    esReal = true;
                }
                sb.Append(codigoFuente[posicion]);
                posicion++;
                columnaActual++;
            }

            string lexema = sb.ToString();

            if (lexema.EndsWith(".") || errorNum)
            {
                AgregarError(lexema, "ERR_NUM: Número incorrecto");
            }
            else if (esReal)
            {
                AgregarToken(lexema, "TK_NUM_DECIMAL", inicioLinea, inicioColumna);
            }
            else
            {
                AgregarToken(lexema, "TK_NUM_ENTERO", inicioLinea, inicioColumna);
            }
        }

        private void LeerCadenaOCaracter(char delimitador)
        {
            int inicioLinea = lineaActual;
            int inicioColumna = columnaActual;
            StringBuilder sb = new StringBuilder();
            sb.Append(delimitador);
            posicion++;
            columnaActual++;

            bool cerrado = false;
            while (posicion < codigoFuente.Length)
            {
                char actual = codigoFuente[posicion];
                if (actual == '\n' || actual == '\r') break;

                sb.Append(actual);
                if (actual == delimitador)
                {
                    cerrado = true;
                    posicion++;
                    columnaActual++;
                    break;
                }
                posicion++;
                columnaActual++;
            }

            string lexema = sb.ToString();

            if (!cerrado)
            {
                AgregarError(lexema, "ERR_CADENA: Cadena no cerrada");
            }
            else
            {
                string tipo = (delimitador == '"') ? "TK_CADENA" : "TK_CARACTER";
                AgregarToken(lexema, tipo, inicioLinea, inicioColumna);
            }
        }

        private void LeerComentarioLinea()
        {
            int inicioLinea = lineaActual;
            int inicioColumna = columnaActual;
            StringBuilder sb = new StringBuilder();
            sb.Append("//");
            posicion += 2;
            columnaActual += 2;

            while (posicion < codigoFuente.Length && codigoFuente[posicion] != '\n')
            {
                sb.Append(codigoFuente[posicion]);
                posicion++;
                columnaActual++;
            }

            AgregarToken(sb.ToString(), "TK_COMENTARIO_LINEA", inicioLinea, inicioColumna);
        }

        private void LeerComentarioBloque()
        {
            int inicioLinea = lineaActual;
            int inicioColumna = columnaActual;
            StringBuilder sb = new StringBuilder();
            sb.Append("/*");
            posicion += 2;
            columnaActual += 2;

            bool cerrado = false;
            while (posicion < codigoFuente.Length)
            {
                char actual = codigoFuente[posicion];
                sb.Append(actual);

                if (actual == '\n') { lineaActual++; columnaActual = 1; }
                else { columnaActual++; }

                if (actual == '*' && posicion + 1 < codigoFuente.Length && codigoFuente[posicion + 1] == '/')
                {
                    sb.Append('/');
                    posicion += 2;
                    columnaActual++;
                    cerrado = true;
                    break;
                }
                posicion++;
            }

            string lexema = sb.ToString();

            if (!cerrado)
            {
                AgregarError(lexema, "ERR_COMENTARIO: Comentario de bloque sin cerrar");
            }
            else
            {
                AgregarToken(lexema, "TK_COMENTARIO_BLOQUE", inicioLinea, inicioColumna);
            }
        }

        private void LeerOperadorOSimbolo()
        {
            int inicioLinea = lineaActual;
            int inicioColumna = columnaActual;
            char actual = codigoFuente[posicion];
            string lexema = actual.ToString();
            string tipo = "";

            if (posicion + 1 < codigoFuente.Length)
            {
                char siguiente = codigoFuente[posicion + 1];
                string posibleCompuesto = "" + actual + siguiente;

                if (posibleCompuesto == "==" || posibleCompuesto == "!=" || posibleCompuesto == "<=" ||
                    posibleCompuesto == ">=" || posibleCompuesto == "&&" || posibleCompuesto == "||" ||
                    posibleCompuesto == "++" || posibleCompuesto == "--" || posibleCompuesto == "+=" ||
                    posibleCompuesto == "-=" || posibleCompuesto == "*=" || posibleCompuesto == "/=")
                {
                    lexema = posibleCompuesto;
                    posicion++;
                    columnaActual++;
                }
            }

            switch (lexema)
            {
                case "+": case "-": case "*": case "/": case "%": tipo = "TK_OP_ARITMETICO"; break;
                case "=": case "==": case "!=": case "<": case ">": case "<=": case ">=": tipo = "TK_OP_RELACIONAL"; break;
                case "&&": case "||": case "!": tipo = "TK_OP_LOGICO"; break;
                case "++": case "--": tipo = "TK_INCREMENTO_DECREMENTO"; break;
                case "+=": case "-=": case "*=": case "/=": tipo = "TK_OP_ASIGNACION_COMPUESTA"; break;
                case "(": case ")": case "{": case "}": case "[": case "]":
                case ";": case ",": case ".": case ":": case "?": tipo = "TK_SIGNO_PUNTUACION"; break;
                default: tipo = "TK_DESCONOCIDO"; break;
            }

            AgregarToken(lexema, tipo, inicioLinea, inicioColumna);
            posicion++;
            columnaActual++;
        }

        private bool VerificarSiguiente(char c)
        {
            return posicion + 1 < codigoFuente.Length && codigoFuente[posicion + 1] == c;
        }

        private bool EsSimboloValido(char c)
        {
            string simbolos = "(){}[];,. :?+-*/%=<>!&|";
            return simbolos.Contains(c);
        }

        private void AgregarToken(string lexema, string tipo, int linea, int columna)
        {
            TokensReconocidos.Add(new Token(lexema, tipo, linea, columna));
        }

        private void AgregarError(string texto, string descripcion)
        {
            ErroresDetectados.Add(new ErrorLexico(texto, descripcion, lineaActual, columnaActual));
        }
    }
}
