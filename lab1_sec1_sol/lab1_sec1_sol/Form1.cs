using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace lab1_sec1_sol
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int Tam,N,i,ID,pos_mejor;
        float aux,prom,acum,prom_mejor;

            float[] IP;
            float[] IIP;
            float[] SIST;
            float[] NF;


            int[] Carnet;
            string[] Nombre;
            string[] Apellidos;

        void promedio_mejor()
        {
            //acumulando
            for (i = 0; i <= N; i++)
            {
                acum += NF[i];
            }
            prom = acum / N;
            for (i = 0; i <= N; i++)
            {
                if (NF[i] > prom_mejor)
                {
                    prom_mejor = NF[i];
                    pos_mejor = i;
                }
            }
            MessageBox.Show("El promedio de asignatura es: " + Convert.ToString(prom) +" Y el estudiante con la mejor nota es: "+Nombre[pos_mejor]+"Con un promedio de: "+prom_mejor);
        }
        public void imprimir()
        {
            for (i = 0; i < N; i++)
            {
                lbimprimir.Items.Add(NF[i]);
                //lbimprimir.Items.Add("\n");
            }
        }
   

        void limpiar()
        {
            txtapellidos.Clear();
            txtcarnet.Clear();
            txtnombre.Clear();
            txtparcial1.Clear();
            txtparcial2.Clear();
            txtsistematicos.Clear();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbmetodo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnordenar_Click_1(object sender, EventArgs e)
        {
            lbimprimir.Items.Clear();
            i = 0;
            bool Band = false;
            while (i < N - 1 && Band == false)
            {
                Band = true;
                for (int J = 0; J < N - 1; J++)
                {
                    if (NF[J] > NF[J + 1])
                    {
                        aux = NF[J];
                        NF[J] = NF[J + 1];
                        NF[J + 1] = aux;
                        Band = false;
                    }
                    imprimir();
                }
                i = i + 1;
            }
        }

        private void btnimprimir_Click_1(object sender, EventArgs e)
        {
            lbimprimir.Items.Clear();
            lbimprimir.Items.Add("Carnet"+"\t"+"Nombres"+"\t"+"Apellidos"+"\t"+"IP"+"\t"+"IIP"+"\t"+"Sistematicos"+"\t"+"NF"+"\n");
            for (i = 0; i < N; i++)
            {
                lbimprimir.Items.Add(Carnet[i] + "\t" + Nombre[i] + "\t" + Apellidos[i] + "\t" + IP[i] + "\t" + IIP[i] + "\t" + SIST[i] + "\t" + NF[i]);
            }
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            if (N<=Tam-1)
            {
                Carnet[N] = int.Parse(txtcarnet.Text);
                Nombre[N] = txtnombre.Text;
                Apellidos[N] = txtapellidos.Text;
                IP[N] =float.Parse(txtparcial1.Text);
                IIP[N] = float.Parse(txtparcial2.Text);
                SIST[N] = float.Parse(txtsistematicos.Text);
                //Determinacion de nota final
                NF[N] = IP[N]+ IIP[N] + SIST[N];
                N++;
                MessageBox.Show("Datos ingresados con exito");
            }
            else
            {
                MessageBox.Show("No hay espacio");
            }
            limpiar();
        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            i = 0;
            ID = int.Parse(txtcarnet.Text);
            while (i < N && ID != Carnet[i])
            {
                i++;
            }
            if (i > N)
            {
                MessageBox.Show(ID + " No esta Registrado");
            }
            else
            {
                Carnet[i] = int.Parse(txtcarnet.Text);
                Nombre[i] = txtnombre.Text;
                Apellidos[i] = txtapellidos.Text;
                IP[i] = float.Parse(txtparcial1.Text);
                IIP[i] = float.Parse(txtparcial2.Text);
                SIST[i] = float.Parse(txtsistematicos.Text);
                //Recalculo de la nota final
                NF[i] = IP[N] + IIP[N] + SIST[N];
                MessageBox.Show("La persona con Carnet= "+ID+"Se ha actualizado");
            }
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            i = 0;
            ID = int.Parse(txtcarnet.Text);
            while (i < N && ID != Carnet[i])
            {
                i++;
            }
            if (i >= N)
            {
                MessageBox.Show(ID+" No esta registrado");
            }
            else
            {
                txtcarnet.Text = Carnet[i].ToString();
                txtnombre.Text = Nombre[i];
                txtapellidos.Text = Apellidos[i];
                txtparcial1.Text = IP[i].ToString();
                txtparcial2.Text = IIP[i].ToString();
                txtsistematicos.Text = SIST[i].ToString();
            }
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            i = 0;
            ID = int.Parse(txtcarnet.Text);
            while (i < N && ID!=Carnet[i])
            {
                i++;
            }
            if (i > N)
            {
                MessageBox.Show(ID+" No esta Registrado");
            }
            else
            {
                for (int k = 0; k < N - 1; k++)
                {
                    Carnet[k] = Carnet[k + 1];
                    Nombre[k] = Nombre[k + 1];
                    Apellidos[k] = Apellidos[k + 1];
                    IP[k] = IP[k + 1];
                    IIP[k] = IIP[k + 1];
                    SIST[k] = SIST[k + 1];
                    NF[k] = NF[k + 1];
                }
                N=N-1;
                MessageBox.Show("La persona  con Id= "+ ID + "Se ha Eliminado");
            }

        }

        private void btnimprimir_Click(object sender, EventArgs e)
        {
            lbimprimir.Items.Clear();
            for (i = 0; i < N; i++)
            {
                lbimprimir.Items.Add(Carnet[i] + "\t" + Nombre[i] + "\t" + Apellidos[i] + "\t" + IP[i] + "\t" + IIP[i] + "\t" + SIST[i] + "\t" + NF[i]);
            }
        }

        private void btnestablecer_Click(object sender, EventArgs e)
        {
            Tam = int.Parse(txtcant.Text);
            Carnet = new int[Tam];
            Nombre = new string[Tam];
            Apellidos = new string[Tam];
            IP = new float[Tam];
            IIP = new float[Tam];
            SIST = new float[Tam];
            NF = new float[Tam];
            N = 0;
            txtcant.Clear();
            MessageBox.Show("Tamaño establecido");
        }
    }
}
