using System;
using System.Windows.Forms;

namespace Editor_De_Texto
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

        private void abrir_Click(object sender, EventArgs e)
        {
            String r;
            openFileDialog1.ShowDialog();
            System.IO.StreamReader archivo = new System.IO.StreamReader(openFileDialog1.FileName);
            r = archivo.ReadLine();
            richTextBox1.Text = r.ToString();
        }

        private void guardar_Click(object sender, EventArgs e)
        {
            saveFileDialog1.FileName = "Sin titulo.Txt";
            var guardar = openFileDialog1.ShowDialog();
            if (guardar == DialogResult.OK)
            {
                using (var guardar_archivo = new System.IO.StreamWriter(saveFileDialog1.FileName))
                {
                    guardar_archivo.WriteLine(richTextBox1.Text);
                }
            }

        }

        private void cerrar_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void atras_Click(object sender, EventArgs e)
        {
            richTextBox1.Undo();
        }

        private void adelante_Click(object sender, EventArgs e)
        {
            richTextBox1.Redo();
        }

        private void copiar_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void cortar_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void pegar_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void seleccionarTodo_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
        }

        private void eliminarTodo_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var cl = colorDialog1.ShowDialog();
            if (cl == DialogResult.OK)
            {
                richTextBox1.ForeColor = colorDialog1.Color;

            }

        }

        private void formatoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmt = fontDialog1.ShowDialog();
            if (frmt == DialogResult.OK)

            {
                richTextBox1.Font = fontDialog1.Font;

            }
        }

        private void seleccionar_tamaño(object sender, EventArgs e)
        {
            if (richTextBox1.SelectedText != "")
            {


            }
        }
    }
}
