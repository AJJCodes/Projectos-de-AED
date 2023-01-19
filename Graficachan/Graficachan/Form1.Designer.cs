
namespace Graficachan
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
            this.txtvertices = new System.Windows.Forms.TextBox();
            this.btningresar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbcosas = new System.Windows.Forms.ListBox();
            this.btncalcular = new System.Windows.Forms.Button();
            this.cbmetodo = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtverticesa = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnvertices = new System.Windows.Forms.Button();
            this.txtmatriz = new System.Windows.Forms.TextBox();
            this.txtconocidos = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtvertices
            // 
            this.txtvertices.Location = new System.Drawing.Point(13, 119);
            this.txtvertices.Name = "txtvertices";
            this.txtvertices.Size = new System.Drawing.Size(184, 20);
            this.txtvertices.TabIndex = 0;
            this.txtvertices.TextChanged += new System.EventHandler(this.txtvertices_TextChanged);
            this.txtvertices.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtvertices_KeyPress);
            // 
            // btningresar
            // 
            this.btningresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btningresar.Location = new System.Drawing.Point(13, 145);
            this.btningresar.Name = "btningresar";
            this.btningresar.Size = new System.Drawing.Size(181, 32);
            this.btningresar.TabIndex = 1;
            this.btningresar.Text = "Ingresar";
            this.btningresar.UseVisualStyleBackColor = true;
            this.btningresar.Click += new System.EventHandler(this.btningresar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Vertices";
            // 
            // lbcosas
            // 
            this.lbcosas.FormattingEnabled = true;
            this.lbcosas.Location = new System.Drawing.Point(254, 28);
            this.lbcosas.Name = "lbcosas";
            this.lbcosas.Size = new System.Drawing.Size(534, 212);
            this.lbcosas.TabIndex = 3;
            // 
            // btncalcular
            // 
            this.btncalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncalcular.Location = new System.Drawing.Point(6, 58);
            this.btncalcular.Name = "btncalcular";
            this.btncalcular.Size = new System.Drawing.Size(148, 32);
            this.btncalcular.TabIndex = 4;
            this.btncalcular.Text = "Calcular";
            this.btncalcular.UseVisualStyleBackColor = true;
            this.btncalcular.Click += new System.EventHandler(this.btncalcular_Click);
            // 
            // cbmetodo
            // 
            this.cbmetodo.FormattingEnabled = true;
            this.cbmetodo.Location = new System.Drawing.Point(6, 19);
            this.cbmetodo.Name = "cbmetodo";
            this.cbmetodo.Size = new System.Drawing.Size(121, 21);
            this.cbmetodo.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbmetodo);
            this.groupBox1.Controls.Add(this.btncalcular);
            this.groupBox1.Location = new System.Drawing.Point(13, 183);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(170, 113);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Metodo";
            // 
            // txtverticesa
            // 
            this.txtverticesa.Location = new System.Drawing.Point(12, 28);
            this.txtverticesa.Name = "txtverticesa";
            this.txtverticesa.Size = new System.Drawing.Size(227, 20);
            this.txtverticesa.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(227, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Ingrese numero de vertices";
            // 
            // btnvertices
            // 
            this.btnvertices.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnvertices.Location = new System.Drawing.Point(12, 54);
            this.btnvertices.Name = "btnvertices";
            this.btnvertices.Size = new System.Drawing.Size(227, 32);
            this.btnvertices.TabIndex = 10;
            this.btnvertices.Text = "Ingresar";
            this.btnvertices.UseVisualStyleBackColor = true;
            this.btnvertices.Click += new System.EventHandler(this.btnvertices_Click);
            // 
            // txtmatriz
            // 
            this.txtmatriz.Location = new System.Drawing.Point(19, 315);
            this.txtmatriz.Multiline = true;
            this.txtmatriz.Name = "txtmatriz";
            this.txtmatriz.Size = new System.Drawing.Size(769, 275);
            this.txtmatriz.TabIndex = 11;
            this.txtmatriz.TextChanged += new System.EventHandler(this.txtmatriz_TextChanged);
            // 
            // txtconocidos
            // 
            this.txtconocidos.Location = new System.Drawing.Point(237, 289);
            this.txtconocidos.Name = "txtconocidos";
            this.txtconocidos.Size = new System.Drawing.Size(535, 20);
            this.txtconocidos.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(384, 266);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Vertices Conocidos\r\n";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 623);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtconocidos);
            this.Controls.Add(this.txtmatriz);
            this.Controls.Add(this.btnvertices);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtverticesa);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbcosas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btningresar);
            this.Controls.Add(this.txtvertices);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtvertices;
        private System.Windows.Forms.Button btningresar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbcosas;
        private System.Windows.Forms.Button btncalcular;
        private System.Windows.Forms.ComboBox cbmetodo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtverticesa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnvertices;
        private System.Windows.Forms.TextBox txtmatriz;
        private System.Windows.Forms.TextBox txtconocidos;
        private System.Windows.Forms.Label label3;
    }
}

