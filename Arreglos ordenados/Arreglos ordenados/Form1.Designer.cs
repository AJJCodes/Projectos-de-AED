
namespace Arreglos_ordenados
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
            this.btnbuscar = new System.Windows.Forms.Button();
            this.btnestablecer = new System.Windows.Forms.Button();
            this.lbmostrar = new System.Windows.Forms.ListBox();
            this.btnmostrar = new System.Windows.Forms.Button();
            this.btnborrar = new System.Windows.Forms.Button();
            this.btnactualizar = new System.Windows.Forms.Button();
            this.btningresar = new System.Windows.Forms.Button();
            this.txtedad = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtcant = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnbuscar
            // 
            this.btnbuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbuscar.Location = new System.Drawing.Point(546, 91);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(114, 61);
            this.btnbuscar.TabIndex = 29;
            this.btnbuscar.Text = "Buscar";
            this.btnbuscar.UseVisualStyleBackColor = true;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // btnestablecer
            // 
            this.btnestablecer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnestablecer.Location = new System.Drawing.Point(496, 47);
            this.btnestablecer.Name = "btnestablecer";
            this.btnestablecer.Size = new System.Drawing.Size(146, 29);
            this.btnestablecer.TabIndex = 28;
            this.btnestablecer.Text = "Establecer";
            this.btnestablecer.UseVisualStyleBackColor = true;
            this.btnestablecer.Click += new System.EventHandler(this.btnestablecer_Click);
            // 
            // lbmostrar
            // 
            this.lbmostrar.FormattingEnabled = true;
            this.lbmostrar.Location = new System.Drawing.Point(6, 229);
            this.lbmostrar.Name = "lbmostrar";
            this.lbmostrar.Size = new System.Drawing.Size(654, 95);
            this.lbmostrar.TabIndex = 27;
            // 
            // btnmostrar
            // 
            this.btnmostrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmostrar.Location = new System.Drawing.Point(6, 161);
            this.btnmostrar.Name = "btnmostrar";
            this.btnmostrar.Size = new System.Drawing.Size(654, 62);
            this.btnmostrar.TabIndex = 26;
            this.btnmostrar.Text = "Mostrar";
            this.btnmostrar.UseVisualStyleBackColor = true;
            this.btnmostrar.Click += new System.EventHandler(this.btnmostrar_Click);
            // 
            // btnborrar
            // 
            this.btnborrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnborrar.Location = new System.Drawing.Point(240, 123);
            this.btnborrar.Name = "btnborrar";
            this.btnborrar.Size = new System.Drawing.Size(146, 29);
            this.btnborrar.TabIndex = 25;
            this.btnborrar.Text = "Borrar";
            this.btnborrar.UseVisualStyleBackColor = true;
            this.btnborrar.Click += new System.EventHandler(this.btnborrar_Click);
            // 
            // btnactualizar
            // 
            this.btnactualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnactualizar.Location = new System.Drawing.Point(394, 123);
            this.btnactualizar.Name = "btnactualizar";
            this.btnactualizar.Size = new System.Drawing.Size(146, 29);
            this.btnactualizar.TabIndex = 24;
            this.btnactualizar.Text = "Actualizar";
            this.btnactualizar.UseVisualStyleBackColor = true;
            this.btnactualizar.Click += new System.EventHandler(this.btnactualizar_Click);
            // 
            // btningresar
            // 
            this.btningresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btningresar.Location = new System.Drawing.Point(12, 123);
            this.btningresar.Name = "btningresar";
            this.btningresar.Size = new System.Drawing.Size(222, 29);
            this.btningresar.TabIndex = 23;
            this.btningresar.Text = "Ingresar";
            this.btningresar.UseVisualStyleBackColor = true;
            this.btningresar.Click += new System.EventHandler(this.btningresar_Click);
            // 
            // txtedad
            // 
            this.txtedad.Location = new System.Drawing.Point(394, 97);
            this.txtedad.Name = "txtedad";
            this.txtedad.Size = new System.Drawing.Size(146, 20);
            this.txtedad.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(388, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 33);
            this.label4.TabIndex = 21;
            this.label4.Text = "Edad";
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(240, 97);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(146, 20);
            this.txtnombre.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(234, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 33);
            this.label3.TabIndex = 19;
            this.label3.Text = "Nombre\r\n";
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(12, 97);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(222, 20);
            this.txtid.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(82, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 33);
            this.label2.TabIndex = 17;
            this.label2.Text = "ID:\r\n";
            // 
            // txtcant
            // 
            this.txtcant.Location = new System.Drawing.Point(496, 21);
            this.txtcant.Name = "txtcant";
            this.txtcant.Size = new System.Drawing.Size(146, 20);
            this.txtcant.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(484, 33);
            this.label1.TabIndex = 15;
            this.label1.Text = "Cantidad de elementos a ingresar";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 342);
            this.Controls.Add(this.btnbuscar);
            this.Controls.Add(this.btnestablecer);
            this.Controls.Add(this.lbmostrar);
            this.Controls.Add(this.btnmostrar);
            this.Controls.Add(this.btnborrar);
            this.Controls.Add(this.btnactualizar);
            this.Controls.Add(this.btningresar);
            this.Controls.Add(this.txtedad);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtcant);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.Button btnestablecer;
        private System.Windows.Forms.ListBox lbmostrar;
        private System.Windows.Forms.Button btnmostrar;
        private System.Windows.Forms.Button btnborrar;
        private System.Windows.Forms.Button btnactualizar;
        private System.Windows.Forms.Button btningresar;
        private System.Windows.Forms.TextBox txtedad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtcant;
        private System.Windows.Forms.Label label1;
    }
}

