using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab2_sol_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Variables globales
        int N=0,Tam,i,Pos,x;

        //Funcion para limpiar
        void limpiar()
        {
            txtnombre.Clear();
            txtapellido.Clear();
            txtcalificacion.Clear();
            txtcarne.Clear();
            txtnombrepro.Clear();
        }

        public struct Proyectos
        {
            public int Carnet;
            public string Nombre;
            public string Apellidos;
            //Datos refereidos al proyecto
            public string pronom;
            public float Cal;
            public DateTime Fechaentre;
        }

        Proyectos[] Proys;

        private void btnestablecer_Click(object sender, EventArgs e)
        {
            Tam = int.Parse(txtcant.Text);
            Proys=new Proyectos[Tam];
            MessageBox.Show("Tamaño Establecido");
            txtcant.Clear();
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            int x;
            x = int.Parse(txtcarne.Text);
            Busca(x);
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            x = int.Parse(txtcarne.Text);
            Eliminar(x);
        }

        private void btnimprimir_Click(object sender, EventArgs e)
        {
            lbimprimir.Items.Clear();
            lbimprimir.Items.Add("Carnet" + "\t" + "Nombres" + "\t" + "Apellidos"+"\t"+"Nombre de proyecto"+"\t"+"Fecha de entrega"+"\t"+"\t"+"Calificacion");
            for (i=0;i<N;i++) {
                lbimprimir.Items.Add(Proys[i].Carnet+"\t"+ Proys[i].Nombre+"\t"+Proys[i].Apellidos+"\t"+Proys[i].pronom+"\t"+Proys[i].Fechaentre+"\t"+Proys[i].Cal);
            }
        }
        //Aux1 carnet
        //Aux2 Nombre
        //Aux3 Apellidos
        //Aux4 Nombre de proyecto
        //Aux5 Fecha de entrega
        //Aux6 Calificacion
        int aux1;
        string aux2;
        string aux3;
        string aux4;
        DateTime aux5;
        float aux6;
        
        public Proyectos[] meter(Proyectos[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = i + 1; j > 0; j--)
                {
                    if (arr[j - 1].Fechaentre > arr[j].Fechaentre)
                    {
                        //Proceso de mover Carnet
                        aux1 = arr[j - 1].Carnet;
                        arr[j - 1].Carnet = arr[j].Carnet;
                        arr[j].Carnet = aux1;
                        //Proceso de mover nombre
                        aux2 = arr[j - 1].Nombre;
                        arr[j - 1].Nombre = arr[j].Nombre;
                        arr[j].Nombre = aux2;
                        //Proceso de mover apellidos
                        aux3 = arr[j - 1].Apellidos;
                        arr[j - 1].Apellidos = arr[j].Apellidos;
                        arr[j].Apellidos = aux3;
                        //proceso mover nombre proyecto
                         aux4 = arr[j - 1].pronom;
                        arr[j - 1].pronom = arr[j].pronom;
                        arr[j].pronom = aux4;
                        //Processo mover Fecha de entrega
                        aux5 = arr[j - 1].Fechaentre;
                        arr[j - 1].Fechaentre = arr[j].Fechaentre;
                        arr[j].Fechaentre  = aux5;
                        //Proceso de calificacion
                        aux6 = arr[j - 1].Cal;
                        arr[j - 1].Cal = arr[j].Cal;
                        arr[j].Cal = aux6;

                    }
                }
            }
            return arr;
        }


        public int Busca(int x)
        {
            i = 0;
            while (i < Tam && Proys[i].Carnet!=x)
            {
                i++;
            }

            return Pos;
        }

        void Eliminar(int x)
        {
            if (N > 0)
            {
                Pos = Busca(x);
                if (Pos <= -1)
                {
                    MessageBox.Show(x + " No esta registrado");
                }
                else
                {
                    for (i = Pos; i < N - 1; i++)
                    {
                        //Proceso eliminacion
                        Proys[i].Carnet = Proys[i + 1].Carnet;
                        Proys[i].Nombre = Proys[i + 1].Nombre;
                        Proys[i].Apellidos = Proys[i + 1].Apellidos;
                        Proys[i].pronom = Proys[i + 1].pronom;
                        Proys[i].Fechaentre = Proys[i + 1].Fechaentre;
                        Proys[i].Cal = Proys[i + 1].Cal;
                    }
                    N--;
                    MessageBox.Show("La persona con Id= "+x+" Se ha elimado");
                }
            }
            else
            {
                MessageBox.Show("No hay registro");
            }
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            if (N > Tam)
            {
                MessageBox.Show("Lo sentimos ya no cuentas con espacio");
            }
            else
            {
                x = int.Parse(txtcarne.Text);
                //Metemos datos
                Proys[N].Carnet = int.Parse(txtcarne.Text);
                Proys[N].Nombre = txtnombre.Text;
                Proys[N].Apellidos = txtapellido.Text;
                Proys[N].pronom = txtnombrepro.Text;
                Proys[N].Fechaentre = DateTime.Parse(dtpfechaentre.Text);
                Proys[N].Cal = float.Parse(txtcalificacion.Text);
                if (N > 1)
                {
                    Proys=meter(Proys);
                }
                MessageBox.Show("Proyecto ingresado con exito");
                N++;
            }
            limpiar();
        }
    }
}
