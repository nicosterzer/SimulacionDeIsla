using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP1LAB2_2
{
    public partial class Form1 : Form
    {
        Isla isla;
        public Form1()
        {
            InitializeComponent();

            FormInicio f = new FormInicio();

            if (f.ShowDialog() == DialogResult.OK)
            {
                int ancho = Convert.ToInt32(f.nudAncho.Value);
                int alto = Convert.ToInt32(f.nudLargo.Value);

                dataGridViewIsla.ColumnCount = ancho;
                dataGridViewIsla.RowCount = alto;

                int cantQ = Convert.ToInt32(f.nudQuesos.Value);
                int cantR = Convert.ToInt32(f.nudRatones.Value);

                for (int i = 0; i < dataGridViewIsla.RowCount; i++)
                {
                    for (int j = 0; j < dataGridViewIsla.ColumnCount; j++)
                    {
                        dataGridViewIsla[i, j].Style.BackColor = Color.LightYellow;
                    }
                }

                if (f.rbIsla1.Checked)
                {
                    isla = new Isla(ancho, alto, cantQ, cantR, this);

                    for (int i = 0; i < isla.Quesos; i++)
                    {
                        if (isla[i] is Queso)
                        {
                            dataGridViewIsla[((Queso)isla[i]).GetPosicionX(), ((Queso)isla[i]).GetPosicionY()].Style.BackColor = Color.Yellow;
                        }      
                    }
                    for (int i = 0; i < isla.ContPiezas; i++)
                    {
                        if (isla[i] is Raton)
                        {
                            dataGridViewIsla[((Animal)isla[i]).GetPosicionX(), ((Animal)isla[i]).GetPosicionY()].Style.BackColor = Color.SandyBrown;
                        }
                    }                    
                }
                else
                {
                    int cantG = Convert.ToInt32(f.nudGatos.Value);

                    isla = new Isla2(ancho, alto, cantQ, cantR, cantG, this);

                    for (int i = 0; i < isla.ContPiezas; i++)
                    {
                        if (isla[i] is Queso)
                        {
                            dataGridViewIsla[((Queso)isla[i]).GetPosicionX(), ((Queso)isla[i]).GetPosicionY()].Style.BackColor = Color.Yellow;
                        }
                    }
                    for (int i = 0; i < (isla.ContPiezas); i++)
                    {
                        if (isla[i]is Raton)
                        {
                            dataGridViewIsla[((Animal)isla[i]).GetPosicionX(), ((Animal)isla[i]).GetPosicionY()].Style.BackColor = Color.SandyBrown;
                        }
                        else if (isla[i] is Gato)
                        {
                            dataGridViewIsla[((Animal)isla[i]).GetPosicionX(), ((Animal)isla[i]).GetPosicionY()].Style.BackColor = Color.Gray;
                        }
                    }
                }                                
            }

            dataGridViewIsla.ColumnHeadersVisible = false;
            dataGridViewIsla.RowHeadersVisible = false;

            dataGridViewIsla.Enabled = false;

            for (int i = 0; i < dataGridViewIsla.ColumnCount; i++)
            {
                dataGridViewIsla.Columns[i].Width = 20;
            }
            for (int i = 0; i < dataGridViewIsla.RowCount; i++)
            {
                dataGridViewIsla.Rows[i].Height = 20;
            }

            dataGridViewIsla.Width = dataGridViewIsla.ColumnCount * 20;
            dataGridViewIsla.Height = dataGridViewIsla.RowCount * 20;

            this.Width = Convert.ToInt32(dataGridViewIsla.Width * 2.5) + 10;
            this.Height = Convert.ToInt32(dataGridViewIsla.Height * 2.5);

            this.button1.Location = new Point(dataGridViewIsla.Width + 40, 12);
            this.label1.Location = new Point(dataGridViewIsla.Width + 40, 48);
            this.label2.Location = new Point(dataGridViewIsla.Width + 40, 84);
            this.label3.Location = new Point(dataGridViewIsla.Width + 40, 120);
            
            this.label7.Location = new Point(dataGridViewIsla.Width + 30, 48);
            this.label5.Location = new Point(dataGridViewIsla.Width + 30, 84);
            this.label6.Location = new Point(dataGridViewIsla.Width + 30, 120);

            this.listBox1.Location = new Point(dataGridViewIsla.Width + 40, 156);
            this.listBox2.Location = new Point((dataGridViewIsla.Width + listBox1.Width), 156);

            label1.Text = ("Cantidad de Quesos: " + isla.Quesos);
            label2.Text = ("Cantidad de Ratones: " + isla.Ratones);

            if (isla is Isla2)
            {
                label3.Text = ("Cantidad de Gatos: " + ((Isla2)isla).Gatos);
            }
            else
            {
                label3.Text = ("-");
            }

            listBox1.Height = Convert.ToInt32(dataGridViewIsla.Height);
            listBox1.Width = Convert.ToInt32(dataGridViewIsla.Width /2.5);
            listBox2.Height = Convert.ToInt32(dataGridViewIsla.Height);
            listBox2.Width = Convert.ToInt32(dataGridViewIsla.Width / 2.5);

            f.Dispose();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (isla is Isla && isla.Ratones == 0)
            {
                Form form = new Form();
                ListBox l1 = isla.InformeDeFinDePartida();
                l1.Width = form.Width;
                l1.Height = form.Height;
                form.Controls.Add(l1);
            }
            else if (isla is Isla2 && isla.Ratones == 0 && ((Isla2)isla).Gatos == 0)
            {
                Form form = new Form();
                ListBox l1 = isla.InformeDeFinDePartida();
                l1.Width = form.Width;
                l1.Height = form.Height;
                form.Controls.Add(l1);
                form.Show();
            }


            isla.MoverPiezas();

            for (int i = 0; i < dataGridViewIsla.RowCount; i++)
            {
                for (int j = 0; j < dataGridViewIsla.ColumnCount; j++)
                {
                    dataGridViewIsla[i, j].Style.BackColor = Color.LightYellow;
                }
            }


            for (int i = 0; i < isla.ContPiezas; i++)
            {
                if (isla[i] is Queso)
                {
                    dataGridViewIsla[((Queso)isla[i]).GetPosicionX(), ((Queso)isla[i]).GetPosicionY()].Style.BackColor = Color.Yellow;
                }
            }
            for (int i = 0; i < (isla.ContPiezas); i++)
            {
                if (isla[i] is Animal)
                {
                    dataGridViewIsla[((Animal)isla[i]).GetPosicionX(), ((Animal)isla[i]).GetPosicionY()].Style.BackColor = Color.SandyBrown;
                    if (isla is Isla2)
                    {
                        if (isla[i] is Gato)
                        {
                            dataGridViewIsla[((Animal)isla[i]).GetPosicionX(), ((Animal)isla[i]).GetPosicionY()].Style.BackColor = Color.Gray;
                        }      
                    }                   
                }                       
            }
            label1.Text = ("Cantidad de Quesos: " + isla.Quesos);
            label2.Text = ("Cantidad de Ratones: " + isla.Ratones);
            if (isla is Isla2)
            {
                label3.Text = ("Cantidad de Gatos: " + ((Isla2)isla).Gatos);
            }
            else
            {
                label3.Text = ("-");
            }
        }
    }
}
