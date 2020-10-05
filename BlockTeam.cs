using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Block_de_Notas_MicrosisTeam_;

namespace CapaPresentacion.Extras
{
    public partial class BlockTeam : Form
    {
        //string Fechas = DateTime.Now.Hour.ToString("hh:mm:ss");
        public BlockTeam()

        {
            InitializeComponent();
           
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void nuevo_Click(object sender, EventArgs e)
        {
            try {

            OpenFileDialog open = new OpenFileDialog();
            StreamReader lectura = null;
            open.Filter = "archivo de texto (.txt)|*.txt|Todos los archivos (*.*)|*.*";
            open.Title = "Abrir archivo";
            open.ShowDialog();
            open.OpenFile();
            string rutaArchivo = open.FileName;
            lectura = File.OpenText(rutaArchivo);
            richTextBox1.Text = lectura.ReadToEnd();
        }
            catch(Exception ex)
            {
                //notiError.confirmacion("ALGO SALIO MAL", ex.Message);
            }
        }

        private void guardarComo_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog guardarcom = new SaveFileDialog();
                StreamWriter nombreArchivo = null;

                guardarcom.Filter = "archivo de texto (.txt)|*.txt|Todos los archivos (*.*)|*.*";
                guardarcom.Title = "Guardar como...";
                guardarcom.ShowDialog();
                string ruta = guardarcom.FileName;
                nombreArchivo = File.AppendText(ruta);
                nombreArchivo.Write(richTextBox1.Text);
                nombreArchivo.Flush();
              
            }
            catch(Exception ex)
            {
                //    notiError.confirmacion("ALGO SALIO MAL",ex.Message);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ade_Click(object sender, EventArgs e)
        {
            richTextBox1.Redo();
        }

        private void salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void desacerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Undo();
        }

        private void cortarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void copiarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void pegarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void seleccionarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
        }

        private void horaYFechaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DateTime fecha = DateTime.Now;
            richTextBox1.Text = fecha.ToString();
        }

        private void fuentesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fuente = new FontDialog();
            fuente.Font = richTextBox1.Font;
            if (fuente.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.Font = fuente.Font;
            }
        }

        private void colorDeFondoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog colorFondo = new ColorDialog();
            if (colorFondo.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.BackColor = colorFondo.Color;
            }
        }

        private void colorDeFuenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog colorFuente = new ColorDialog();
            if (colorFuente.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.ForeColor = colorFuente.Color;
            }
        }

        private void acercaDelBlockDeNotasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            block f = new block();
            f.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void zoomToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void guardar_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog()==DialogResult.OK)
            {
                richTextBox1.SaveFile(saveFileDialog1.FileName, RichTextBoxStreamType.RichText);
    }
        }

        private void BlockTeam_Load(object sender, EventArgs e)
        {
            gunaAnimateWindow1.Start();
            timer1.Start();

        }

        private void acercarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this.richTextBox1.Font = Font.Size.ToString("");
            //this.richTextBox1.Font = 


        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(richTextBox1.Text);
        }

        private void gunaSeparator1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void toolStripSplitButton1_ButtonClick(object sender, EventArgs e)
        {

        }

        private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripStatusLabel4_Click(object sender, EventArgs e)
        {

        }

        private void instagramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.instagram.com/microsisteam_oficial/");
        }

        private void twiterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://twitter.com/microsisteam");
        }

        private void youtubeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel2.Text = DateTime.Now.ToString("hh:mm:ss");
            toolStripStatusLabel4.Text = DateTime.Now.ToLongDateString();
        }

        private void Imprimir_Click(object sender, EventArgs e)
        {
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(richTextBox1.Text,new Font("Segoe UI",14,FontStyle.Regular),Brushes.Black,new PointF(120,120));
        }

        private void aCercarToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void barraHorariaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(statusStrip1.Visible == true)
            {
                statusStrip1.Visible = false;
            }
            else
            {
                statusStrip1.Visible = true;
            }
        }

        private void ayudaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
           System.di.Process.Start("Hello word");
        }
    }
}
