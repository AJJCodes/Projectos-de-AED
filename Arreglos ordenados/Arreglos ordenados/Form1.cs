using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arreglos_ordenados
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            btnactualizar.Enabled = false;
        }

        int N = 0, Tam, i, pos, x, x2;
        int[] Edad;
        int[] Id;
        string[] Nombres;
        //Funcion de limpiar
        void limpiar()
        {
            txtid.Clear();
            txtedad.Clear();
            txtnombre.Clear();

        }

        private void btnestablecer_Click(object sender, EventArgs e)
        {
            Tam = int.Parse(txtcant.Text);
            Id = new int[Tam];
            Edad = new int[Tam];
            Nombres = new string[Tam];
            N = 0;
            txtcant.Clear();
            MessageBox.Show("Tamaño establecido");
        }

        private void btnborrar_Click(object sender, EventArgs e)
        {
            x = int.Parse(txtid.Text);
            Eliminar(x);
            limpiar();
        }

        private void btnactualizar_Click(object sender, EventArgs e)
        {
            actualizar();
            btnactualizar.Enabled = false;
        }

        private void btnmostrar_Click(object sender, EventArgs e)
        {
            lbmostrar.Items.Clear();
            for (i = 0; i < N; i++)
            {
                lbmostrar.Items.Add(Id[i] + "\t" + Nombres[i] + "\t" + Edad[i]);
            }
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            if (N > 0)
            {
                x2 = int.Parse(txtid.Text);
                pos = Busca(x2);
                if (pos <= -1)
                {
                    MessageBox.Show(x2 + " No esta registrado");
                }
                else {
                    txtedad.Text = Convert.ToString(Edad[pos]);
                    txtnombre.Text = Nombres[pos];
                    btnactualizar.Enabled = true;
                }

            }
        }


        //Funcion buscar
        public int Busca(int x)
        {
            i = 0;
            while(i < N && Id[i] < x)
            {
                i++;
            }
            if (i >= N || Id[i]>x)
            {
                pos = -i;
            }
            else
            {
                pos = i;
            }
            return pos;
        }
        //Funcion de eliminacion
        void Eliminar(int x)
        {
            if (N > 0)
            {
                pos = Busca(x);
                if (pos <= -1)
                {
                    MessageBox.Show(x + "No esta Registrado");
                }
                else
                {
                    for (i = pos; i < N - 1; i++)
                    {
                        Id[i] = Id[i + 1];
                        Nombres[i] = Nombres[i + 1];
                        Edad[i] = Edad[i + 1];
                    }
                    N = N - 1;
                    MessageBox.Show("La persona con Id="+ x +"Se ha eliminado");
                }
            }
            else
            {
                MessageBox.Show("No hay Registros");
            }
        }
        //Funcion de insertar
        void Insertar(int x)
        {
            if (N > 0)
            {
                if (N <= Tam - 1)
                {
                    pos = Busca(x);
                    if(pos > 0)
                    {
                        MessageBox.Show("El elemento ya existe");
                    }
                    else
                    {
                        pos = pos * -1;
                        for (i = N; i >= pos + 1; i--) {
                            Id[i] = Id[i - 1];
                            Edad[i] = Edad[i - 1];
                            Nombres[i] = Nombres[i - 1];
                        }
                        Id[pos] = int.Parse(txtid.Text);
                        Edad[pos] = int.Parse(txtedad.Text);
                        Nombres[pos] = txtnombre.Text;
                        N = N + 1;
                        MessageBox.Show("Elemento Insertado");
                    }
                }
                else
                {
                    MessageBox.Show("No hay espacio");
                }
            }
            else
            {
                Id[N] = int.Parse(txtid.Text);
                Edad[N] = int.Parse(txtedad.Text);
                Nombres[N] = txtnombre.Text;
                N = N + 1;
                MessageBox.Show("Elemento Insertado");
            }
        }

        void actualizar()
        {
            if (N > 0)
            {
                pos = Busca(x);
                if (pos <= -1)
                {
                    MessageBox.Show(x + "No esta Registrado");
                }
                else
                {
                    Id[pos] = int.Parse(txtid.Text);
                    Nombres[pos] = txtnombre.Text;
                    Edad[pos] = int.Parse(txtedad.Text);
                    MessageBox.Show("Elemento actualizado");
                }

            }
            else
            {
                MessageBox.Show("No hay Registros");
            }
        }
        private void btningresar_Click(object sender, EventArgs e)
        {
            x = int.Parse(txtid.Text);
            Insertar(x);
            limpiar();
        }
    }
}
