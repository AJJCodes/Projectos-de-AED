using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RA5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int N, aux, k, i, izq, der, inta, j;


        private void txtnumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                int Num = int.Parse(txtnumero.Text);
                lbnumeros.Items.Add(Num);
                IEtiqueta.Text = Convert.ToString(lbnumeros.Items.Count + " elementos insertado");
                txtnumero.Text = "";
                txtnumero.Focus();
            }
        }

        private void cbmetodos_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtOrden.Clear();
            if (cbmetodos.SelectedIndex == 0)
            {
                Sacudida();
            }
            if (cbmetodos.SelectedIndex == 1)
            {
                InsercionDirecta();
            }
            if (cbmetodos.SelectedIndex==2)
            {
                InsercionDecreciente();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbmetodos.Items.Add("Shaker sort/Sacudida");
            cbmetodos.Items.Add("Insercion Directa");
            cbmetodos.Items.Add("Shell/Insercion_Incrementos_Decrecientes");
            cbmetodos.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        int[] Numeros;

        void imprimir()
        {
            for (j = 0; j < N; j++)
            {
                txtOrden.Text = txtOrden.Text + (Numeros[j] + " ");
            }
            txtOrden.Text = txtOrden.Text + "\r\n";
        }

        public void Sacudida()
        {
            N = 0;
            foreach(int Elemento in lbnumeros.Items)
            {
                Array.Resize(ref Numeros, N + 1);
                Numeros[N] = Elemento;
                N++;
            }
            izq = 1;
            der = N - 1;
            k = N - 1;

            while (der >= izq)
            {
                for (i = der; i >= izq; i--)
                {
                    if (Numeros[i - 1] > Numeros[i])
                    {
                        aux = Numeros[i-1];
                        Numeros[i - 1] = Numeros[i];
                        Numeros[i] = aux;
                        k = i;
                    }
                    imprimir();
                }
                izq = k + 1;
                for (i = izq; i <= der; i++)
                {
                    if (Numeros[i - 1] > Numeros[i])
                    {
                        aux = Numeros[i - 1];
                        Numeros[i - 1] = Numeros[i];
                        Numeros[i] = aux;
                        k = i;
                    }
                    imprimir();
                }
                der = k - 1;
            }
        }

        void InsercionDirecta()
        {
            N = 0;
            foreach(int Elemento in lbnumeros.Items)
            {
                Array.Resize(ref Numeros, N + 1);
                Numeros[N] = Elemento;
                N++;
            }

            for (i = 1; i < N; i++)
            {
                aux = Numeros[i];
                k = i - 1;
                while ((k >= 0) && (aux < Numeros[k]))
                {
                    Numeros[k + 1] = Numeros[k];
                    k = k - 1;
                    imprimir();
                }
                Numeros[k + 1] = aux;
                imprimir();
            }
            imprimir();
        }

        void InsercionDecreciente()
        {
            N = 0;
            foreach(int Elemento in lbnumeros.Items)
            {
                Array.Resize(ref Numeros, N+1);
                Numeros[N] = Elemento;
                N++;
            }
            bool band;
            inta = N;
            while (inta>0)
            {
                inta = inta / 2;
                band = true;
                while (band)
                {
                    band = false;
                    i = 0;
                    while ((i + inta) <= N - 1) {
                        if (Numeros[i]>Numeros[i+inta])
                        {
                            aux = Numeros[i];
                            Numeros[i] = Numeros[i + inta];
                            Numeros[i + inta] = aux;
                            band = true;
                        }
                        i = i + 1;
                    }
                    imprimir();
                }
            }
        }
        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            lbnumeros.Items.Clear();
        }
    }
}
