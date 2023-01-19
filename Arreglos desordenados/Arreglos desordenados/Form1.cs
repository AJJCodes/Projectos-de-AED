using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arreglos_desordenados
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int N = 0, Tam,i;
        int[] Edad;//edades
        int[] Id;//PRIM key
        string[] Nombres;//Conjunto de los nombres

        //Funcion limpiar
        void limpiar()
        {
            txtedad.Clear();
            txtid.Clear();
            txtnombre.Clear();
        }

        private void btnborrar_Click(object sender, EventArgs e)
        {
            int i= 0;
            int x;
            x = int.Parse(txtid.Text);
            while(i<N && x != Id[i])
            {
                i++;
            }
            if (i > N) {
                MessageBox.Show(x + "No esta esta registrado");
            }
            else
            {
                for (int k = 0; k < N-1; k++)
                {
                    Id[k] = Id[k + 1];
                    Nombres[k] = Nombres[k + 1];
                    Edad[k] = Edad[k + 1];
                }
                N = N - 1;
                MessageBox.Show("La persona con Id="+x+"Se ha eliminado");
            }
        }

        private void btnactualizar_Click(object sender, EventArgs e)
        {
            int i = 0;
            int x;
            x = int.Parse(txtid.Text);
            while (i < N && x != Id[i])
            {
                i++;
            }
            if (i >= N)
            {
                MessageBox.Show(x + "No esta esta registrado");
            }
            else
            {
                Id[i] = int.Parse(txtid.Text);
                Nombres[i] = txtnombre.Text;
                Edad[i] = int.Parse(txtedad.Text);
                MessageBox.Show("La persona con Id=" + x + "Se ha actualizado");
            }
        }

        private void btnmostrar_Click(object sender, EventArgs e)
        {
            lbmostrar.Items.Clear();
            for (i=0;i<N;i++) {
                lbmostrar.Items.Add(Id[i]+"\t"+Nombres[i]+"\t"+Edad[i]);
            }
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            int i = 0;
            int x;
            x = int.Parse(txtid.Text);
            while (i < N && x != Id[i])
            {
                i++;
            }
            if(i >= N)
            {
                MessageBox.Show(x+"No esta Registrado");
            }
            else
            {
                lbmostrar.Items.Clear();
                lbmostrar.Items.Add(Id[i]+"\t"+Nombres[i]+"\t"+Edad[i]);
            }
        }

        private void btningresar_Click(object sender, EventArgs e)
        {
            if (N <= Tam - 1)
            {
                Id[N] = int.Parse(txtid.Text);
                Edad[N] = int.Parse(txtedad.Text);
                Nombres[N] = txtnombre.Text;
                N = N + 1;
            }
            else
            {
                MessageBox.Show("No hay espacio");
            }
            limpiar();
        }
        private void btnestablecer_Click(object sender, EventArgs e)
        {
            Tam = int.Parse(txtcant.Text);
            Id = new int[Tam];
            Edad = new int[Tam];
            Nombres = new string[Tam];
            N = 0;
            MessageBox.Show("Cantidad establecida");
            txtcant.Clear();
        }
    }
}
