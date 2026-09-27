using System;
using System.Collections.Generic;

public class AnalizadorLexico
{
    private string codigoFuente;
    private int indice;
    private int linea;
    private int columna;

    public List<Token> TokensReconocidos { get; private set; }
    public List<ErrorLexico> ErroresDetectados { get; private set; }
    public TablaDeSimbolos TablaSimbolos { get; private set; }

    public AnalizadorLexico(string codigo)
    {
        codigoFuente = codigo ?? string.Empty;
        indice = 0;
        linea = 1;
        columna = 1;
        TokensReconocidos = new List<Token>();
        ErroresDetectados = new List<ErrorLexico>();
        TablaSimbolos = new TablaDeSimbolos();
    }

    private char Peek() => indice < codigoFuente.Length ? codigoFuente[indice] : '\0';

    private char Advance()
    {
        char c = codigoFuente[indice++];
        if (c == '\n')
        {
            linea++;
            columna = 1;
        }
        else
        {
            columna++;
        }
        return c;
    }

    public void Escanear()
    {
        while (indice < codigoFuente.Length)
        {
            char actual = Peek();

            // 1. Espacios en blanco y tabulaciones
            if (char.IsWhiteSpace(actual))
            {
                Advance();
                continue;
            }

            // 2. Comentarios (Línea // o Bloque /* ... */)
            if (actual == '/' && indice + 1 < codigoFuente.Length)
            {
                if (codigoFuente[indice + 1] == '/') // Comentario de línea
                {
                    while (Peek() != '\n' && Peek() != '\0') Advance();
                    continue;
                }
                else if (codigoFuente[indice + 1] == '*') // Comentario de bloque
                {
                    int inicioLinea = linea;
                    int inicioCol = columna;
                    Advance(); Advance(); // Consumir /*
                    bool cerrado = false;
                    while (indice < codigoFuente.Length)
                    {
                        if (Peek() == '*' && indice + 1 < codigoFuente.Length && codigoFuente[indice + 1] == '/')
                        {
                            Advance(); Advance(); // Consumir */
                            cerrado = true;
                            break;
                        }
                        Advance();
                    }
                    if (!cerrado)
                    {
                        ErroresDetectados.Add(new ErrorLexico("/*", "Comentario de bloque sin cerrar (ERR_COMENTARIO)", inicioLinea, inicioCol));
                    }
                    continue;
                }
            }

            // 3. Identificadores y Palabras Reservadas
            if (char.IsLetter(actual) || actual == '_')
            {
                int inicioCol = columna;
                int inicioLinea = linea;
                string lexema = "";
                while (char.IsLetterOrDigit(Peek()) || Peek() == '_')
                {
                    lexema += Advance();
                }

                if (TablaSimbolos.EsPalabraReservada(lexema))
                {
                    TokensReconocidos.Add(new Token(lexema, "TK_PALABRA_" + lexema.ToUpper(), inicioLinea, inicioCol));
                }
                else
                {
                    TokensReconocidos.Add(new Token(lexema, "TK_IDENTIFICADOR", inicioLinea, inicioCol));
                    TablaSimbolos.AgregarSimbolo(new SimboloTabla(TablaSimbolos.ObtenerSimbolos().Count + 1, lexema, "TK_IDENTIFICADOR", "indefinido", inicioLinea, inicioCol, "global"));
                }
                continue;
            }

            // 4. Números (Enteros y Decimales / Reales)
            if (char.IsDigit(actual))
            {
                int inicioCol = columna;
                int inicioLinea = linea;
                string lexema = "";
                bool esDecimal = false;

                while (char.IsDigit(Peek()))
                {
                    lexema += Advance();
                }

                // Verificar punto decimal
                if (Peek() == '.' && indice + 1 < codigoFuente.Length && char.IsDigit(codigoFuente[indice + 1]))
                {
                    esDecimal = true;
                    lexema += Advance(); // Consumir el punto
                    while (char.IsDigit(Peek()))
                    {
                        lexema += Advance();
                    }

                    // Regla de error numérico si hay múltiples puntos (ej. 3.14.15)
                    if (Peek() == '.')
                    {
                        while (char.IsLetterOrDigit(Peek()) || Peek() == '.') lexema += Advance();
                        ErroresDetectados.Add(new ErrorLexico(lexema, "Número real mal formado (ERR_NUM)", inicioLinea, inicioCol));
                        continue;
                    }
                }

                string tipoToken = esDecimal ? "TK_NUM_DECIMAL" : "TK_NUM_ENTERO";
                TokensReconocidos.Add(new Token(lexema, tipoToken, inicioLinea, inicioCol));
                continue;
            }

            // 5. Cadenas de caracteres ("...")
            if (actual == '"')
            {
                int inicioCol = columna;
                int inicioLinea = linea;
                string lexema = "";
                lexema += Advance(); // Consumir comilla de apertura
                bool cerrada = false;

                while (indice < codigoFuente.Length)
                {
                    char sig = Peek();
                    if (sig == '\n' || sig == '\0')
                    {
                        break;
                    }
                    lexema += Advance();
                    if (sig == '"')
                    {
                        cerrada = true;
                        break;
                    }
                }

                if (!cerrada)
                {
                    ErroresDetectados.Add(new ErrorLexico(lexema, "Cadena de caracteres no cerrada (ERR_CADENA)", inicioLinea, inicioCol));
                }
                else
                {
                    TokensReconocidos.Add(new Token(lexema, "TK_CADENA", inicioLinea, inicioCol));
                }
                continue;
            }

            // 6. Operadores simples y compuestos
            if ("+-*/%=<>!&|".IndexOf(actual) >= 0)
            {
                int inicioCol = columna;
                int inicioLinea = linea;
                string lexema = Advance().ToString();
                char sig = Peek();

                if ((lexema == "+" && (sig == '+' || sig == '=')) ||
                    (lexema == "-" && (sig == '-' || sig == '=')) ||
                    (lexema == "*" && sig == '=') ||
                    (lexema == "/" && sig == '=') ||
                    (lexema == "=" && sig == '=') ||
                    (lexema == "!" && sig == '=') ||
                    (lexema == "<" && sig == '=') ||
                    (lexema == ">" && sig == '=') ||
                    (lexema == "&" && sig == '&') ||
                    (lexema == "|" && sig == '|'))
                {
                    lexema += Advance();
                }

                TokensReconocidos.Add(new Token(lexema, "TK_OPERADOR", inicioLinea, inicioCol));
                continue;
            }

            // 7. Signos de puntuación
            if ("(){}[],.;:?".IndexOf(actual) >= 0)
            {
                TokensReconocidos.Add(new Token(Advance().ToString(), "TK_PUNTUACION", linea, columna - 1));
                continue;
            }

            // 8. Manejo de Caracteres Inválidos (ERR_CAR)
            {
                int inicioCol = columna;
                int inicioLinea = linea;
                string caracterInvalido = Advance().ToString();
                ErroresDetectados.Add(new ErrorLexico(caracterInvalido, "Carácter no permitido en el lenguaje (ERR_CAR)", inicioLinea, inicioCol));
            }
        }
    }
}