using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Graficachan
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            cbmetodo.Items.Add("Simetrico");
            cbmetodo.Items.Add("Antisimetrico");
            cbmetodo.Items.Add("Reflexiva");
            cbmetodo.Items.Add("Anti-Reflexiva");
            cbmetodo.Items.Add("Transitiva");
            txtconocidos.Enabled = false;
        }

        int cont, vert, contadores = 0, bandera = 0, ultimocont = 0, contadoress = 0, elementos_en_lb = 0;
        string Temp1, nuevalinea= Environment.NewLine;
        List<string> Cosas = new List<string>();
        //lado izquierdo
        List<string> Conjunto1 = new List<string>();
        //lado derecho
        List<string> Conjunto2 = new List<string>();
        //Creamos elementos inversos para eso

        List<string> inverso1 = new List<string>();
        List<string> inverso2 = new List<string>();
        //string[,] matriz=new string[100,100];

        private void btningresar_Click(object sender, EventArgs e)
        {
            lbcosas.Items.Add(txtvertices.Text);
            if (contadores % 2 == 0)
            {
                Conjunto2.Add(txtvertices.Text);
            }
            else
            {
                Conjunto1.Add(txtvertices.Text);
            }
            contadores++;
            if (bandera == 0)
            {
                Temp1 = txtvertices.Text;
                bandera++;
            }
            txtvertices.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtmatriz_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtvertices_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtvertices_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                lbcosas.Items.Add(txtvertices.Text);
                if (contadores % 2 == 0)
                {
                    Conjunto2.Add(txtvertices.Text);
                }
                else
                {
                    Conjunto1.Add(txtvertices.Text);
                }
                contadores++;
                txtvertices.Clear();
            }
        }

        //Funcion reflexiva
        public void reflexiva()
        {
            foreach (string lol1 in Conjunto1)
            {
                foreach(string lol2 in Conjunto2)
                {
                    if (lol1 == lol2)
                    {
                        txtmatriz.Text = txtmatriz.Text + "1\t";
                    }
                    else
                    {
                        txtmatriz.Text = txtmatriz.Text + "0\t";
                    }
                    contadoress++;
                    if (contadoress == vert)
                    {
                        contadoress = 0;
                        break;
                    }
                }
                //Añade una nueva linea despues del vertice
                txtmatriz.Text = txtmatriz.Text + nuevalinea;
                ultimocont++;
                if (ultimocont == vert)
                {
                    ultimocont = 0;
                    break;
                }
            }
        }

        public void anti_reflexiva()
        {
            foreach (string lol1 in Conjunto1)
            {
                foreach (string lol2 in Conjunto2)
                {
                    if (lol1 != lol2)
                    {
                        txtmatriz.Text = txtmatriz.Text + "1\t";
                    }
                    else
                    {
                        txtmatriz.Text = txtmatriz.Text + "0\t";
                    }
                    contadoress++;
                    if (contadoress == vert)
                    {
                        contadoress = 0;
                        break;
                    }
                }
                //Añade una nueva linea despues del vertice
                txtmatriz.Text = txtmatriz.Text + nuevalinea;
                ultimocont++;
                if (ultimocont == vert)
                {
                    ultimocont = 0;
                    break;
                }
            }
        }

        public void simetrica()
        {
            //Ingresamos elementos al arreglo
            elementos_en_lb=lbcosas.Items.Count;
            foreach(string lol1 in Conjunto1)
            {
                inverso1.Add(lol1);
            }

            foreach(string lol1 in Conjunto2)
            {
                inverso2.Add(lol1);
            }

            foreach (string lol1 in Conjunto1)
            {
                foreach(string lol2 in Conjunto2){
                    foreach(string lol3 in inverso1){
                        foreach (string lol4 in inverso2)
                        {
                            if (lol1+lol2==lol3+lol4)
                            {
                                txtmatriz.Text = txtmatriz.Text + "1\t";
                            }
                            else
                            {
                                txtmatriz.Text = txtmatriz.Text + "0\t";
                            }
                            contadoress++;
                            if (contadoress == vert)
                            {
                                contadoress = 0;
                                break;
                            }
                        }

                    }
                }
                //Añade una nueva linea despues del vertice
                txtmatriz.Text = txtmatriz.Text + nuevalinea;
                ultimocont++;
                if (ultimocont == vert)
                {
                    ultimocont = 0;
                    break;
                }
            }

        }

        void anti_simetrica()
        {
            //Ingresamos elementos al arreglo
            elementos_en_lb = lbcosas.Items.Count;
            foreach (string lol1 in Conjunto1)
            {
                inverso1.Add(lol1);
            }

            foreach (string lol1 in Conjunto2)
            {
                inverso2.Add(lol1);
            }

            foreach (string lol1 in Conjunto1)
            {
                foreach (string lol2 in Conjunto2)
                {
                    foreach (string lol3 in inverso1)
                    {
                        foreach (string lol4 in inverso2)
                        {
                            if (lol1 + lol2 != lol3 + lol4)
                            {
                                txtmatriz.Text = txtmatriz.Text + "1\t";
                            }
                            else
                            {
                                txtmatriz.Text = txtmatriz.Text + "0\t";
                            }
                            contadoress++;
                            if (contadoress == vert)
                            {
                                contadoress = 0;
                                break;
                            }
                        }

                    }
                }
                //Añade una nueva linea despues del vertice
                txtmatriz.Text = txtmatriz.Text + nuevalinea;
                ultimocont++;
                if (ultimocont == vert)
                {
                    ultimocont = 0;
                    break;
                }
            }

        }
        private void btncalcular_Click(object sender, EventArgs e)
        {
            cont = 0;
            foreach(var L in lbcosas.Items)
            {
                cont++;
            }
            if (cont%2==0)
            {
                foreach (string sos in Cosas)
                {
                    txtconocidos.Text = txtconocidos.Text + sos + "\t"; 
                }
                txtmatriz.Text = txtmatriz.Text + "\n";
                if (cbmetodo.SelectedIndex == 0)
                {
                    simetrica();
                }
                if (cbmetodo.SelectedIndex == 1)
                {
                    anti_simetrica();
                }
                if (cbmetodo.SelectedIndex == 2)
                {
                    reflexiva();
                }
                if (cbmetodo.SelectedIndex == 3)
                {
                    anti_reflexiva();
                }
            }
            else
            {
                MessageBox.Show("Error Ingrese un dato mas o complete datos ");
            }
        }

        private void btnvertices_Click(object sender, EventArgs e)
        {
            vert = int.Parse(txtverticesa.Text);
            txtverticesa.Clear();
        }
    }

}
