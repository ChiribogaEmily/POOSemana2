namespace _01_Mi_Primera_Vez.Presentacion
{
    partial class ControlUsuarios
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelsuperior = new System.Windows.Forms.Panel();
            this.listaUsuarios = new System.Windows.Forms.ListBox();
            this.barra = new System.Windows.Forms.TextBox();
            this.botonbuscar = new System.Windows.Forms.Button();
            this.botonAgregar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panelsuperior.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelsuperior
            // 
            this.panelsuperior.Controls.Add(this.button1);
            this.panelsuperior.Controls.Add(this.botonAgregar);
            this.panelsuperior.Controls.Add(this.botonbuscar);
            this.panelsuperior.Controls.Add(this.barra);
            this.panelsuperior.Location = new System.Drawing.Point(3, 3);
            this.panelsuperior.Name = "panelsuperior";
            this.panelsuperior.Size = new System.Drawing.Size(931, 100);
            this.panelsuperior.TabIndex = 0;
            // 
            // listaUsuarios
            // 
            this.listaUsuarios.FormattingEnabled = true;
            this.listaUsuarios.Location = new System.Drawing.Point(3, 112);
            this.listaUsuarios.Name = "listaUsuarios";
            this.listaUsuarios.Size = new System.Drawing.Size(931, 641);
            this.listaUsuarios.TabIndex = 1;
            // 
            // barra
            // 
            this.barra.Location = new System.Drawing.Point(180, 25);
            this.barra.Name = "barra";
            this.barra.Size = new System.Drawing.Size(251, 20);
            this.barra.TabIndex = 0;
            // 
            // botonbuscar
            // 
            this.botonbuscar.Location = new System.Drawing.Point(272, 51);
            this.botonbuscar.Name = "botonbuscar";
            this.botonbuscar.Size = new System.Drawing.Size(75, 23);
            this.botonbuscar.TabIndex = 1;
            this.botonbuscar.Text = "Buscar";
            this.botonbuscar.UseVisualStyleBackColor = true;
            // 
            // botonAgregar
            // 
            this.botonAgregar.Location = new System.Drawing.Point(18, 25);
            this.botonAgregar.Name = "botonAgregar";
            this.botonAgregar.Size = new System.Drawing.Size(75, 49);
            this.botonAgregar.TabIndex = 2;
            this.botonAgregar.Text = "Agregar";
            this.botonAgregar.UseVisualStyleBackColor = true;
            this.botonAgregar.Click += new System.EventHandler(this.botonAgregar_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(99, 25);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 49);
            this.button1.TabIndex = 3;
            this.button1.Text = "Quitar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // ControlUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.listaUsuarios);
            this.Controls.Add(this.panelsuperior);
            this.Name = "ControlUsuarios";
            this.Size = new System.Drawing.Size(937, 761);
            this.panelsuperior.ResumeLayout(false);
            this.panelsuperior.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelsuperior;
        private System.Windows.Forms.ListBox listaUsuarios;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button botonAgregar;
        private System.Windows.Forms.Button botonbuscar;
        private System.Windows.Forms.TextBox barra;
    }
}
