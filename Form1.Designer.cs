namespace Tarea_3
{
    partial class Form
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblInfo = new System.Windows.Forms.Label();
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.txtCadena = new System.Windows.Forms.TextBox();
            this.botonAnalizar = new System.Windows.Forms.Button();
            this.labelValidacion = new System.Windows.Forms.Label();
            this.labelTexto = new System.Windows.Forms.Label();
            this.labelExpresion = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.Location = new System.Drawing.Point(317, 22);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(305, 20);
            this.lblInfo.TabIndex = 0;
            this.lblInfo.Text = "Kimberly Mireya Elias Diaz          201700507";
            this.lblInfo.Click += new System.EventHandler(this.label1_Click);
            // 
            // comboBox
            // 
            this.comboBox.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Items.AddRange(new object[] {
            "Lenguaje 1",
            "Lenguaje 2",
            "Lenguaje 3",
            "Lenguaje 4",
            "Lenguaje 5",
            "Lenguaje 6",
            "Lenguaje 7",
            "Lenguaje 8",
            "Lenguaje 9",
            "Lenguaje 10"});
            this.comboBox.Location = new System.Drawing.Point(217, 64);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(240, 28);
            this.comboBox.TabIndex = 1;
            this.comboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox_SelectedIndexChanged);
            // 
            // txtCadena
            // 
            this.txtCadena.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCadena.Location = new System.Drawing.Point(490, 64);
            this.txtCadena.Name = "txtCadena";
            this.txtCadena.Size = new System.Drawing.Size(240, 26);
            this.txtCadena.TabIndex = 2;
            this.txtCadena.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // botonAnalizar
            // 
            this.botonAnalizar.Font = new System.Drawing.Font("Monotype Corsiva", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonAnalizar.Location = new System.Drawing.Point(426, 118);
            this.botonAnalizar.Name = "botonAnalizar";
            this.botonAnalizar.Size = new System.Drawing.Size(91, 33);
            this.botonAnalizar.TabIndex = 3;
            this.botonAnalizar.Text = "Analizar";
            this.botonAnalizar.UseVisualStyleBackColor = true;
            this.botonAnalizar.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelValidacion
            // 
            this.labelValidacion.AutoSize = true;
            this.labelValidacion.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelValidacion.Location = new System.Drawing.Point(369, 169);
            this.labelValidacion.MinimumSize = new System.Drawing.Size(200, 15);
            this.labelValidacion.Name = "labelValidacion";
            this.labelValidacion.Size = new System.Drawing.Size(200, 20);
            this.labelValidacion.TabIndex = 4;
            this.labelValidacion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelValidacion.Click += new System.EventHandler(this.labelValidacion_Click);
            // 
            // labelTexto
            // 
            this.labelTexto.AutoSize = true;
            this.labelTexto.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTexto.Location = new System.Drawing.Point(30, 215);
            this.labelTexto.Name = "labelTexto";
            this.labelTexto.Size = new System.Drawing.Size(200, 20);
            this.labelTexto.TabIndex = 5;
            this.labelTexto.Text = "Expresión regular utilizada:";
            this.labelTexto.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // labelExpresion
            // 
            this.labelExpresion.AutoSize = true;
            this.labelExpresion.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelExpresion.ForeColor = System.Drawing.Color.Purple;
            this.labelExpresion.Location = new System.Drawing.Point(263, 215);
            this.labelExpresion.MinimumSize = new System.Drawing.Size(650, 15);
            this.labelExpresion.Name = "labelExpresion";
            this.labelExpresion.Size = new System.Drawing.Size(650, 20);
            this.labelExpresion.TabIndex = 6;
            this.labelExpresion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 270);
            this.Controls.Add(this.txtCadena);
            this.Controls.Add(this.labelExpresion);
            this.Controls.Add(this.labelTexto);
            this.Controls.Add(this.labelValidacion);
            this.Controls.Add(this.botonAnalizar);
            this.Controls.Add(this.comboBox);
            this.Controls.Add(this.lblInfo);
            this.Name = "Form";
            this.Text = "Tarea 3";
            this.Load += new System.EventHandler(this.Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.ComboBox comboBox;
        private System.Windows.Forms.TextBox txtCadena;
        private System.Windows.Forms.Button botonAnalizar;
        private System.Windows.Forms.Label labelValidacion;
        private System.Windows.Forms.Label labelTexto;
        private System.Windows.Forms.Label labelExpresion;
    }
}

