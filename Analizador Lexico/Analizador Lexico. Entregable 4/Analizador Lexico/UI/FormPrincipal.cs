using AnalizadorLexico.Engine;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;


namespace AnalizadorLexico.UI
{
    public partial class FormPrincipal : Form
    {
        private Engine.AnalizadorLexico motorLexico;
        private bool isFormatting = false;

        public FormPrincipal()
        {
            InitializeComponent();
            InicializarGrids();
            ConfigurarColoresErrores();
            txtCodigo.TextChanged += txtCodigo_TextChanged;
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            InicializarGrids();
        }

        private void InicializarGrids()
        {
            dgvTokens.Columns.Clear();
            dgvTokens.Columns.Add("Linea", "Linea");
            dgvTokens.Columns.Add("Columna", "Columna");
            dgvTokens.Columns.Add("Tipo", "Tipo");
            dgvTokens.Columns.Add("Lexema", "Lexema");

            dgvErrores.Columns.Clear();
            dgvErrores.Columns.Add("Linea", "Linea");
            dgvErrores.Columns.Add("Columna", "Columna");
            dgvErrores.Columns.Add("Descripcion", "Descripcion");
            dgvErrores.Columns.Add("Texto", "Texto");

            dgvSimbolos.Columns.Clear();
            dgvSimbolos.Columns.Add("Id", "Id");
            dgvSimbolos.Columns.Add("Nombre", "Nombre");
            dgvSimbolos.Columns.Add("TipoToken", "Tipo");
            dgvSimbolos.Columns.Add("Linea", "Linea");
            dgvSimbolos.Columns.Add("Columna", "Columna");
        }
        private string EnumerarLineasCodigo(string codigoOriginal)
        {
            if (string.IsNullOrEmpty(codigoOriginal))
                return string.Empty;

            string[] lineas = codigoOriginal.Split(new[] { "\r\n", "\n", "\r" }, StringSplitOptions.None);
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < lineas.Length; i++)
            {
                sb.AppendLine($"{i + 1}. {lineas[i]}");
            }

            return sb.ToString();
        }
        private void btnAbrir_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string ruta = openFileDialog1.FileName;
                try
                {
                    if (!System.IO.File.Exists(ruta))
                    {
                        MessageBox.Show("El archivo seleccionado no existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    string contenido = System.IO.File.ReadAllText(ruta);

                    if (string.IsNullOrWhiteSpace(contenido))
                    {
                        MessageBox.Show("El archivo está vacío.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                    txtCodigo.Text = contenido;

                    AplicarResaltadoSintaxis();
                }
                catch (UnauthorizedAccessException)
                {
                    MessageBox.Show("No tiene permisos para abrir este archivo.", "Acceso denegado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al leer el archivo: " + ex.Message, "Error de Lectura", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnEscanear_Click(object sender, EventArgs e)
        {
            Stopwatch cronometro = new Stopwatch();

            try
            {
                string codigoOriginal = txtCodigo.Text ?? string.Empty;

                if (string.IsNullOrWhiteSpace(codigoOriginal))
                {
                    MessageBox.Show("No hay código para analizar. Por favor, ingrese o cargue un archivo con código.", "Código no detectado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtCodigo.Focus();
                    return;
                }

                // 1. Generamos el código con los números de línea
                string codigoNumerado = EnumerarLineasCodigo(codigoOriginal);

                // 2. ¡ESTO ES LO QUE FALTABA! Actualizamos el TextBox para que se vea visualmente en pantalla
                txtCodigo.Text = codigoNumerado;

                cronometro.Start();
                // 3. Pasamos el código numerado al motor léxico
                motorLexico = new Engine.AnalizadorLexico(codigoNumerado);
                motorLexico.Escanear();

                dgvTokens.Rows.Clear();
                var tokens = motorLexico.ObtenerTokens();
                foreach (var t in tokens)
                {
                    dgvTokens.Rows.Add(t.Linea, t.Columna, t.Tipo, t.Lexema);
                }

                dgvErrores.Rows.Clear();
                var errores = motorLexico.ObtenerErrores();
                foreach (var err in errores)
                {
                    dgvErrores.Rows.Add(err.Linea, err.Columna, err.Descripcion, err.CaracterOTexto);
                }

                dgvSimbolos.Rows.Clear();
                var simbolos = motorLexico.TablaSimbolos.ObtenerSimbolos();
                foreach (var s in simbolos)
                {
                    dgvSimbolos.Rows.Add(s.Id, s.Nombre, s.TipoToken, s.PrimeraLinea, s.PrimeraColumna);
                }

                cronometro.Stop();
                ActualizarEstadisticas(cronometro.ElapsedMilliseconds);

                MessageBox.Show("Análisis léxico completado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                cronometro.Stop();
                MessageBox.Show("Ocurrió un error inesperado en el análisis:\n\n" + ex.Message, "Error durante el Análisis", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
            AplicarResaltadoSintaxis();
        }

        private void AplicarResaltadoSintaxis()
        {
            if (isFormatting || string.IsNullOrEmpty(txtCodigo.Text)) return;

            isFormatting = true;

            int seleccionInicio = txtCodigo.SelectionStart;
            int seleccionLongitud = txtCodigo.SelectionLength;

            try
            {
                txtCodigo.SelectAll();
                txtCodigo.SelectionColor = Color.Black;

                string texto = txtCodigo.Text;


                string palabrasClave = @"\b(if|else|while|for|return|int|float|string|void|bool|class|import|public|private)\b";
                ColorearPatron(texto, palabrasClave, Color.Blue);

                string comentarios = @"//.*|/\*[\s\S]*?\*/";
                ColorearPatron(texto, comentarios, Color.Green);

                string cadenas = @"""[^""\\]*(?:\\.[^""\\]*)*""";
                ColorearPatron(texto, cadenas, Color.Brown);

                string numeros = @"\b\d+(\.\d+)?\b";
                ColorearPatron(texto, numeros, Color.DarkOrange);
            }
            finally
            {
                txtCodigo.Select(seleccionInicio, seleccionLongitud);
                txtCodigo.SelectionColor = Color.Black;
                isFormatting = false;
            }
        }
        private void ColorearPatron(string texto, string patron, Color color)
        {
            foreach (Match match in Regex.Matches(texto, patron))
            {
                txtCodigo.Select(match.Index, match.Length);
                txtCodigo.SelectionColor = color;
            }
        }
        private void FormPrincipal_Load_1(object sender, EventArgs e)
        {

        }

        private void ConfigurarColoresErrores()
        {
            dgvErrores.EnableHeadersVisualStyles = false;

            dgvErrores.DefaultCellStyle.BackColor = Color.MistyRose;
            dgvErrores.DefaultCellStyle.ForeColor = Color.DarkRed;

            dgvErrores.DefaultCellStyle.SelectionBackColor = Color.IndianRed;
            dgvErrores.DefaultCellStyle.SelectionForeColor = Color.White;

            dgvErrores.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkRed;
            dgvErrores.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            dgvErrores.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            dgvErrores.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }

        private void ActualizarEstadisticas(long tiempoMilisegundos)
        {

            int totalTokens = dgvTokens.Rows.Cast<DataGridViewRow>().Count(fila => !fila.IsNewRow);

            int totalErrores = dgvErrores.Rows.Cast<DataGridViewRow>().Count(fila => !fila.IsNewRow);

            string codigo = txtCodigo.Text;

            int totalLineas = string.IsNullOrEmpty(codigo)? 0: codigo.Split(new[] { "\r\n", "\n", "\r" },StringSplitOptions.None).Length;

            lblTotalTokens.Text = "Total de tokens: " + totalTokens;

            lblTotalLineas.Text = "Total de líneas: " + totalLineas;

            lblTotalErrores.Text = "Total de errores: " + totalErrores;

            lblTiempoAnalisis.Text ="Tiempo de análisis: " + tiempoMilisegundos + " ms";
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
           
            if (dgvTokens.Rows.Cast<DataGridViewRow>().All(fila => fila.IsNewRow))
            {
                MessageBox.Show("Primero debes realizar un análisis.", "Sin resultados", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

        
            sfdExportar.Filter ="Archivo CSV (*.csv)|*.csv|" +"Archivo de texto (*.txt)|*.txt";
            sfdExportar.FileName = "Resultados_Analisis";

            if (sfdExportar.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            try
            {
                bool esCsv = sfdExportar.FilterIndex == 1;

                using (StreamWriter escritor = new StreamWriter(sfdExportar.FileName,false,new UTF8Encoding(true)))
                {
                    if (esCsv)
                    {
                        escritor.WriteLine("RESULTADOS DEL ANALISIS LEXICO");
                        escritor.WriteLine();

                        ExportarTabla(escritor,"TOKENS",dgvTokens,true);
                        ExportarTabla(escritor,"ERRORES LEXICOS",dgvErrores,true);
                        ExportarTabla(escritor,"TABLA DE SIMBOLOS",dgvSimbolos,true);
                    }
                    else
                    {
                        escritor.WriteLine("RESULTADOS DEL ANALISIS LEXICO");
                        escritor.WriteLine();

                        ExportarTabla(escritor,"TOKENS",dgvTokens,false);
                        ExportarTabla(escritor,"ERRORES LEXICOS",dgvErrores,false);
                        ExportarTabla(escritor,"TABLA DE SIMBOLOS",dgvSimbolos,false);

                        escritor.WriteLine();
                        escritor.WriteLine("ESTADISTICAS");
                        escritor.WriteLine(lblTotalTokens.Text);
                        escritor.WriteLine(lblTotalLineas.Text);
                        escritor.WriteLine(lblTotalErrores.Text);
                        escritor.WriteLine(lblTiempoAnalisis.Text);
                    }
                }

                MessageBox.Show("Los resultados se exportaron correctamente.","Exportación completada",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("No fue posible exportar los resultados: " + ex.Message,"Error de exportación",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void ExportarTabla(StreamWriter escritor,string titulo,DataGridView tabla,bool esCsv)
        {
            escritor.WriteLine(titulo);

            if (esCsv)
            {
                var encabezados = tabla.Columns.Cast<DataGridViewColumn>().Select(columna => EscaparCsv(columna.HeaderText));
                escritor.WriteLine(string.Join(",", encabezados));

                foreach (DataGridViewRow fila in tabla.Rows)
                {
                    if (fila.IsNewRow)continue;

                    var valores = fila.Cells.Cast<DataGridViewCell>().Select(celda =>EscaparCsv(celda.Value?.ToString() ?? "")); 
                    escritor.WriteLine(string.Join(",", valores));
                }
            }
            else
            {
                string[] encabezados = tabla.Columns.Cast<DataGridViewColumn>().Select(columna => columna.HeaderText).ToArray();
                escritor.WriteLine(string.Join("\t", encabezados));

                foreach (DataGridViewRow fila in tabla.Rows)
                {
                    if (fila.IsNewRow)continue;

                    string[] valores = fila.Cells.Cast<DataGridViewCell>().Select(celda => celda.Value?.ToString() ?? "").ToArray();
                    escritor.WriteLine(string.Join("\t", valores));
                }
            }

            escritor.WriteLine();
        }

        private string EscaparCsv(string valor)
        {
            return "\"" + valor.Replace("\"", "\"\"") + "\"";
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("¿Está seguro de que desea salir del programa?","Confirmar salida",MessageBoxButtons.YesNo,MessageBoxIcon.Question);

            if (respuesta == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
