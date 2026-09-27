using System;

public class Token
{
    // Propiedades básicas que corresponden a tu tabla de símbolos y reportes
    public string Lexema { get; set; }     // El texto real encontrado (ej. "edad", "10", "int")
    public string Tipo { get; set; }       // La categoría del token (ej. TK_IDENTIFICADOR, TK_NUM_ENTERO)
    public int Linea { get; set; }         // Número de línea donde apareció
    public int Columna { get; set; }       // Posición horizontal (columna) donde inició

    // Constructor para inicializar un token fácilmente
    public Token(string lexema, string tipo, int linea, int columna)
    {
        Lexema = lexema;
        Tipo = tipo;
        Linea = linea;
        Columna = columna;
    }

    // Método para convertir el token a texto legible (útil para imprimirlo en un TextBox o consola)
    public override string ToString()
    {
        return $"[{Tipo}] '{Lexema}' (Línea: {Linea}, Columna: {Columna})";
    }
}
