using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EXAMENSG
{
    
    public partial class Form1 : Form
    {
        Matriz x1, x2, x3;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            x1 = new Matriz();
            x2 = new Matriz();
            x3 = new Matriz();
        }

        //CARGAR X1

        private void cargarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            x1.CargarRandom(int.Parse(textBox1.Text), int.Parse(textBox2.Text), int.Parse(textBox3.Text), int.Parse(textBox4.Text));
        }

        //DESCARGAR X1
        private void descargarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox5.Text = x1.Descargar();
        }

        //CARGAR X2
        private void cargarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //x2.CargarRandom(int.Parse(textBox1.Text), int.Parse(textBox2.Text), int.Parse(textBox3.Text), int.Parse(textBox4.Text));

        }

        //DESCARGAR X2
        private void descargarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //textBox6.Text = x2.Descargar();
        }

        //DESCARGAR X3
        private void descargarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            //textBox6.Text = x3.Descargar();
        }

        //EXAMEN LLAMADAS

        //LLAMADA PREGUNTA 1 (MayorFrecuenciaRango)

        private void pregunta1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int fi = int.Parse(textBox1.Text);
            int ff = int.Parse(textBox2.Text);
            int ci = int.Parse(textBox3.Text);
            int cf = int.Parse(textBox4.Text);

            int ele = 0;   // variables locales que se llenarán por ref
            int frec = 0;

            x1.Ejercicio1(fi, ff, ci, cf, ref ele, ref frec);

            textBox6.Text = "ele = " + ele + "   frec = " + frec;
        }

        //LLAMADA PREGUNTA 2
        private void pregunta2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            x1.EjercicioDiferentesP1();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
        }
    }
}
