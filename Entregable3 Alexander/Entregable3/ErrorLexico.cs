using System;

public class ErrorLexico
{
    public string CaracterTexto { get; set; } // El fragmento o carácter que causó el error (ej. "@", "3.14.15")
    public string Descripcion { get; set; }   // Descripción detallada del error (ej. "Carácter no permitido")
    public int Linea { get; set; }            // Línea donde ocurrió el error
    public int Columna { get; set; }          // Columna donde ocurrió el error

    // Constructor para inicializar el error léxico
    public ErrorLexico(string caracter, string descripcion, int linea, int columna)
    {
        CaracterTexto = caracter;
        Descripcion = descripcion;
        Linea = linea;
        Columna = columna;
    }

    // Método para imprimir el error de forma clara
    public override string ToString()
    {
        return $"Error Léxico: {Descripcion} ('{CaracterTexto}') en Línea {Linea}, Columna {Columna}";
    }
}
