
namespace Wind_explo
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnIngresar = new System.Windows.Forms.Button();
            this.txtDir = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbqueue = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnHacer = new System.Windows.Forms.Button();
            this.btninstrucciones = new System.Windows.Forms.Button();
            this.dtgdirectorios = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtdirectorios = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtbuscar = new System.Windows.Forms.TextBox();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.btnsalir = new System.Windows.Forms.Button();
            this.Panelsidemenu = new System.Windows.Forms.Panel();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgdirectorios)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.Panelsidemenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnIngresar
            // 
            this.btnIngresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresar.Location = new System.Drawing.Point(6, 242);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnIngresar.Size = new System.Drawing.Size(274, 45);
            this.btnIngresar.TabIndex = 0;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // txtDir
            // 
            this.txtDir.Location = new System.Drawing.Point(286, 35);
            this.txtDir.Name = "txtDir";
            this.txtDir.Size = new System.Drawing.Size(333, 20);
            this.txtDir.TabIndex = 1;
            this.txtDir.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDir_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(286, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Directorio";
            // 
            // lbqueue
            // 
            this.lbqueue.FormattingEnabled = true;
            this.lbqueue.Location = new System.Drawing.Point(291, 105);
            this.lbqueue.Name = "lbqueue";
            this.lbqueue.Size = new System.Drawing.Size(454, 199);
            this.lbqueue.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(286, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(247, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "Queue de directorio";
            // 
            // btnHacer
            // 
            this.btnHacer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHacer.Location = new System.Drawing.Point(6, 293);
            this.btnHacer.Name = "btnHacer";
            this.btnHacer.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnHacer.Size = new System.Drawing.Size(274, 45);
            this.btnHacer.TabIndex = 5;
            this.btnHacer.Text = "Hacer Directorio";
            this.btnHacer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHacer.UseVisualStyleBackColor = true;
            this.btnHacer.Click += new System.EventHandler(this.btnHacer_Click);
            // 
            // btninstrucciones
            // 
            this.btninstrucciones.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btninstrucciones.FlatAppearance.BorderSize = 0;
            this.btninstrucciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btninstrucciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btninstrucciones.ForeColor = System.Drawing.Color.Gainsboro;
            this.btninstrucciones.Location = new System.Drawing.Point(6, 191);
            this.btninstrucciones.Name = "btninstrucciones";
            this.btninstrucciones.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btninstrucciones.Size = new System.Drawing.Size(274, 45);
            this.btninstrucciones.TabIndex = 6;
            this.btninstrucciones.Text = "instrucciones";
            this.btninstrucciones.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btninstrucciones.UseVisualStyleBackColor = true;
            this.btninstrucciones.Click += new System.EventHandler(this.btninstrucciones_Click);
            // 
            // dtgdirectorios
            // 
            this.dtgdirectorios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgdirectorios.Location = new System.Drawing.Point(291, 310);
            this.dtgdirectorios.Name = "dtgdirectorios";
            this.dtgdirectorios.Size = new System.Drawing.Size(890, 280);
            this.dtgdirectorios.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtdirectorios);
            this.groupBox1.Location = new System.Drawing.Point(751, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(430, 63);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "URL";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Directorio";
            // 
            // txtdirectorios
            // 
            this.txtdirectorios.Location = new System.Drawing.Point(6, 37);
            this.txtdirectorios.Name = "txtdirectorios";
            this.txtdirectorios.Size = new System.Drawing.Size(418, 20);
            this.txtdirectorios.TabIndex = 9;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtbuscar);
            this.groupBox2.Location = new System.Drawing.Point(751, 89);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(430, 215);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Buscar";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "Buscador";
            // 
            // txtbuscar
            // 
            this.txtbuscar.Location = new System.Drawing.Point(6, 36);
            this.txtbuscar.Name = "txtbuscar";
            this.txtbuscar.Size = new System.Drawing.Size(322, 20);
            this.txtbuscar.TabIndex = 11;
            this.txtbuscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbuscar_KeyPress);
            // 
            // btnbuscar
            // 
            this.btnbuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbuscar.Location = new System.Drawing.Point(6, 344);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnbuscar.Size = new System.Drawing.Size(274, 45);
            this.btnbuscar.TabIndex = 10;
            this.btnbuscar.Text = "Buscar";
            this.btnbuscar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnbuscar.UseVisualStyleBackColor = true;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // btnsalir
            // 
            this.btnsalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsalir.Location = new System.Drawing.Point(6, 395);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnsalir.Size = new System.Drawing.Size(274, 45);
            this.btnsalir.TabIndex = 11;
            this.btnsalir.Text = "Salir";
            this.btnsalir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // Panelsidemenu
            // 
            this.Panelsidemenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(106)))), ((int)(((byte)(231)))));
            this.Panelsidemenu.Controls.Add(this.panelLogo);
            this.Panelsidemenu.Controls.Add(this.btnsalir);
            this.Panelsidemenu.Controls.Add(this.btninstrucciones);
            this.Panelsidemenu.Controls.Add(this.btnbuscar);
            this.Panelsidemenu.Controls.Add(this.btnIngresar);
            this.Panelsidemenu.Controls.Add(this.btnHacer);
            this.Panelsidemenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.Panelsidemenu.Location = new System.Drawing.Point(0, 0);
            this.Panelsidemenu.Name = "Panelsidemenu";
            this.Panelsidemenu.Size = new System.Drawing.Size(280, 741);
            this.Panelsidemenu.TabIndex = 12;
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.pictureBox1);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(280, 164);
            this.panelLogo.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(23)))), ((int)(((byte)(234)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(280, 621);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(919, 120);
            this.panel1.TabIndex = 13;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(50, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(144, 148);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1199, 741);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Panelsidemenu);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dtgdirectorios);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbqueue);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDir);
            this.Name = "Form1";
            this.Text = "Creador de directorios";
            this.Deactivate += new System.EventHandler(this.Form1_Deactivate);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dtgdirectorios)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.Panelsidemenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.TextBox txtDir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbqueue;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnHacer;
        private System.Windows.Forms.Button btninstrucciones;
        private System.Windows.Forms.DataGridView dtgdirectorios;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtdirectorios;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtbuscar;
        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnsalir;
        private System.Windows.Forms.Panel Panelsidemenu;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

