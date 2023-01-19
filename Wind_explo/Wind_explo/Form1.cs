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

namespace Wind_explo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            txtdirectorios.Enabled = false;
        }
        List<Pila> Lista = new List<Pila>();
        string Buscador;
        //Pila
        Stack<string> Stackers = new Stack<string>();
        //pila en reversa
        Stack<string> rev = new Stack<string>();
        string Dires;
        string Temp;

        void buscar()
        {
            Buscador = txtbuscar.Text;
            Lista.Find(x => x.Directorio == Buscador);

        }

        private void btninstrucciones_Click(object sender, EventArgs e)
        {
            MessageBox.Show("1) ingresar dato por dato en el texbox\nejemplo: a) Ingreso de disco : C:/\nb)Usuario: Anthony/\netc");
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            lbqueue.Items.Add(txtDir.Text + "\n");
            //Añadimos cosas al stack
            Stackers.Push(txtDir.Text);
            txtDir.Clear();
        }

        private void btnHacer_Click(object sender, EventArgs e)
        {
            txtdirectorios.Clear();
            //Contamos la cantidad de cosas ingresadas
            /*
            foreach (var x in lbqueue.Items)
            {
                cosas++;
                txtdirectorios.Text = txtdirectorios.Text+x;
            }
            */
            /*Hacemos el stack en reversa*/
            while(Stackers.Count != 0)
            {
                rev.Push(Stackers.Pop());
            }
            foreach(string item in rev)
            {
                txtdirectorios.Text = txtdirectorios.Text + item;
            }
            //Limpiamos el string de los \n
            string limpio= txtdirectorios.Text.Replace("\n", "").Replace("\r", "");


            Dires = limpio;
            //Si no existe lo creamos
            bool myCondition = true;
            if(MessageBox.Show("¿Seguro que desea crear este Directorio?\n"+Dires, "Ventana de Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question, myCondition ? MessageBoxDefaultButton.Button2 : MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                try
                {
                    if (!Directory.Exists(@Dires))
                    {
                        //Creamos el directorio si no existe
                        Directory.CreateDirectory(@Dires);
                        Lista.Add(new Pila
                        {
                            /*
                            Disco = lbqueue.Items[0].ToString(),
                            Usuario = lbqueue.Items[1].ToString(),
                            Folder = lbqueue.Items[2].ToString(),
                            otro_folder = lbqueue.Items[3].ToString(),*/
                            Directorio = Convert.ToString(txtdirectorios.Text)
                        });
                        /*MessageBox.Show(Convert.ToString(cosas));*/
                        dtgdirectorios.DataSource = null;
                        dtgdirectorios.DataSource = Lista;
                        lbqueue.Items.Clear();
                        MessageBox.Show("Directorio Creado");
                    }
                    else
                    {
                        if (Directory.Exists(@Dires))
                        {
                            MessageBox.Show("El directorio ya existe");
                            lbqueue.Items.Clear();
                            txtdirectorios.Clear();
                        }
                    }
                }
                catch
                {
                    MessageBox.Show("El Directorio No se pudo crear");
                    lbqueue.Items.Clear();
                }
            }
            Stackers.Clear();
            rev.Clear();
        }

        private void txtDir_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                lbqueue.Items.Add(txtDir.Text + "\n");
                txtDir.Clear();
            }
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(@txtbuscar.Text))
            {
                MessageBox.Show("existe el directorio");
                foreach(var mae in Lista)
                {
                    if(txtbuscar.Text == mae.Directorio)
                    {
                        Temp = mae.Directorio;
                    }
                }
                MessageBox.Show("El directorio Existe y es : \n "+Temp);
            }
            else
            {
                MessageBox.Show("Ese Directorio No existe");
            }
        }

        private void txtbuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if (Directory.Exists(@txtbuscar.Text))
                {
                    MessageBox.Show("existe el directorio");
                    foreach (var mae in Lista)
                    {
                        if (txtbuscar.Text == mae.Directorio)
                        {
                            Temp = mae.Directorio;
                        }
                    }
                    MessageBox.Show("El directorio Existe y es : \n " + Temp);
                }
                else
                {
                    MessageBox.Show("Ese Directorio No existe");
                }
            }
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            //Eliminamos todo
            foreach(var x in Lista)
            {
                Dires = x.Directorio;
                Directory.Delete(Dires);
            }
            this.Close();
        }

        private void Form1_Deactivate(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Eliminamos todo
            //No funciona
            foreach (var x in Lista)
            {
                Dires = Convert.ToString(x.Directorio);
                Directory.Delete(@Dires);
            }
        }
    }
}
