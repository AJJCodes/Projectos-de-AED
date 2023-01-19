
namespace RA5
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
            this.label1 = new System.Windows.Forms.Label();
            this.cbmetodos = new System.Windows.Forms.ComboBox();
            this.lbnumeros = new System.Windows.Forms.ListBox();
            this.txtnumero = new System.Windows.Forms.TextBox();
            this.btnlimpiar = new System.Windows.Forms.Button();
            this.IEtiqueta = new System.Windows.Forms.Label();
            this.txtOrden = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(306, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(326, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Elija el Metodo de ordenación";
            // 
            // cbmetodos
            // 
            this.cbmetodos.FormattingEnabled = true;
            this.cbmetodos.Location = new System.Drawing.Point(311, 87);
            this.cbmetodos.Name = "cbmetodos";
            this.cbmetodos.Size = new System.Drawing.Size(321, 21);
            this.cbmetodos.TabIndex = 1;
            this.cbmetodos.SelectedIndexChanged += new System.EventHandler(this.cbmetodos_SelectedIndexChanged);
            // 
            // lbnumeros
            // 
            this.lbnumeros.FormattingEnabled = true;
            this.lbnumeros.Location = new System.Drawing.Point(12, 114);
            this.lbnumeros.Name = "lbnumeros";
            this.lbnumeros.Size = new System.Drawing.Size(190, 173);
            this.lbnumeros.TabIndex = 3;
            // 
            // txtnumero
            // 
            this.txtnumero.Location = new System.Drawing.Point(12, 87);
            this.txtnumero.Name = "txtnumero";
            this.txtnumero.Size = new System.Drawing.Size(190, 20);
            this.txtnumero.TabIndex = 4;
            this.txtnumero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtnumero_KeyPress);
            // 
            // btnlimpiar
            // 
            this.btnlimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlimpiar.Location = new System.Drawing.Point(208, 250);
            this.btnlimpiar.Name = "btnlimpiar";
            this.btnlimpiar.Size = new System.Drawing.Size(75, 37);
            this.btnlimpiar.TabIndex = 5;
            this.btnlimpiar.Text = "Limpiar";
            this.btnlimpiar.UseVisualStyleBackColor = true;
            this.btnlimpiar.Click += new System.EventHandler(this.btnlimpiar_Click);
            // 
            // IEtiqueta
            // 
            this.IEtiqueta.AutoSize = true;
            this.IEtiqueta.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IEtiqueta.Location = new System.Drawing.Point(7, 302);
            this.IEtiqueta.Name = "IEtiqueta";
            this.IEtiqueta.Size = new System.Drawing.Size(259, 25);
            this.IEtiqueta.TabIndex = 6;
            this.IEtiqueta.Text = "0 Elementos insertados";
            // 
            // txtOrden
            // 
            this.txtOrden.Location = new System.Drawing.Point(311, 114);
            this.txtOrden.Multiline = true;
            this.txtOrden.Name = "txtOrden";
            this.txtOrden.Size = new System.Drawing.Size(321, 173);
            this.txtOrden.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtOrden);
            this.Controls.Add(this.IEtiqueta);
            this.Controls.Add(this.btnlimpiar);
            this.Controls.Add(this.txtnumero);
            this.Controls.Add(this.lbnumeros);
            this.Controls.Add(this.cbmetodos);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbmetodos;
        private System.Windows.Forms.ListBox lbnumeros;
        private System.Windows.Forms.TextBox txtnumero;
        private System.Windows.Forms.Button btnlimpiar;
        private System.Windows.Forms.Label IEtiqueta;
        private System.Windows.Forms.TextBox txtOrden;
    }
}

