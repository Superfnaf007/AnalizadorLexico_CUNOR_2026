public class SimboloTabla
{
    public int Id { get; set; }
    public string Nombre { get; set; }
    public string TipoToken { get; set; }
    public string TipoDato { get; set; }
    public string Valor { get; set; }
    public int Linea { get; set; }
    public int Columna { get; set; }
    public string Ambito { get; set; }
    public bool Inicializado { get; set; }

    public SimboloTabla(int id, string nombre, string tipoToken, string tipoDato, int linea, int columna, string ambito)
    {
        Id = id;
        Nombre = nombre;
        TipoToken = tipoToken;
        TipoDato = tipoDato;
        Valor = null;
        Linea = linea;
        Columna = columna;
        Ambito = ambito;
        Inicializado = false;
    }
}
