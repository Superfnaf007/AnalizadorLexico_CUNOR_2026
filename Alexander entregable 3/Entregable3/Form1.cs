using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Entregable3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAnalizar_Click(object sender, EventArgs e)
        {
            // 1. Limpiar resultados anteriores para una nueva ejecución
            lstTokens.Items.Clear();
            lstErrores.Items.Clear();

            // 2. Obtener el código fuente ingresado en la interfaz
            string codigoFuente = txtCodigoFuente.Text;

            // 3. Instanciar el analizador léxico pasándole el código fuente
            AnalizadorLexico analizador = new AnalizadorLexico(codigoFuente);

            // 4. Ejecutar el proceso de escaneo
            analizador.Escanear();

            // 5. Mostrar los tokens reconocidos en el ListBox correspondiente
            foreach (var token in analizador.TokensReconocidos)
            {
                lstTokens.Items.Add(token.ToString());
            }

            // 6. Mostrar los errores léxicos detectados (si los hay)
            foreach (var error in analizador.ErroresDetectados)
            {
                lstErrores.Items.Add(error.ToString());
            }
        }
    }
}
