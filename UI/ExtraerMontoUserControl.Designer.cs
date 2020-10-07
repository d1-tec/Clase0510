namespace UI
{
    partial class ExtraerMontoUserControl
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
            this.textBoxMontoAExtraer = new System.Windows.Forms.TextBox();
            this.labelTitulo = new System.Windows.Forms.Label();
            this.labelBalanceActual = new System.Windows.Forms.Label();
            this.buttonExtraer = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBoxDetalleExtraccion = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBoxMontoAExtraer
            // 
            this.textBoxMontoAExtraer.Location = new System.Drawing.Point(361, 266);
            this.textBoxMontoAExtraer.Name = "textBoxMontoAExtraer";
            this.textBoxMontoAExtraer.Size = new System.Drawing.Size(508, 31);
            this.textBoxMontoAExtraer.TabIndex = 0;
            this.textBoxMontoAExtraer.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxMontoAExtraer_KeyDown);
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitulo.Location = new System.Drawing.Point(447, 78);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(319, 42);
            this.labelTitulo.TabIndex = 1;
            this.labelTitulo.Text = "Extraer un monto";
            // 
            // labelBalanceActual
            // 
            this.labelBalanceActual.AutoSize = true;
            this.labelBalanceActual.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBalanceActual.Location = new System.Drawing.Point(361, 360);
            this.labelBalanceActual.Name = "labelBalanceActual";
            this.labelBalanceActual.Size = new System.Drawing.Size(304, 42);
            this.labelBalanceActual.TabIndex = 2;
            this.labelBalanceActual.Text = "Balance Actual: ";
            // 
            // buttonExtraer
            // 
            this.buttonExtraer.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExtraer.Location = new System.Drawing.Point(387, 462);
            this.buttonExtraer.Name = "buttonExtraer";
            this.buttonExtraer.Size = new System.Drawing.Size(482, 86);
            this.buttonExtraer.TabIndex = 3;
            this.buttonExtraer.Text = "Ejecutar extraccion";
            this.buttonExtraer.UseVisualStyleBackColor = true;
            this.buttonExtraer.Click += new System.EventHandler(this.buttonExtraer_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker1.Location = new System.Drawing.Point(387, 606);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(440, 31);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // textBoxDetalleExtraccion
            // 
            this.textBoxDetalleExtraccion.Location = new System.Drawing.Point(361, 690);
            this.textBoxDetalleExtraccion.Multiline = true;
            this.textBoxDetalleExtraccion.Name = "textBoxDetalleExtraccion";
            this.textBoxDetalleExtraccion.ReadOnly = true;
            this.textBoxDetalleExtraccion.Size = new System.Drawing.Size(530, 151);
            this.textBoxDetalleExtraccion.TabIndex = 5;
            // 
            // ExtraerMontoUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.Controls.Add(this.textBoxDetalleExtraccion);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.buttonExtraer);
            this.Controls.Add(this.labelBalanceActual);
            this.Controls.Add(this.labelTitulo);
            this.Controls.Add(this.textBoxMontoAExtraer);
            this.Name = "ExtraerMontoUserControl";
            this.Size = new System.Drawing.Size(1346, 944);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxMontoAExtraer;
        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.Label labelBalanceActual;
        private System.Windows.Forms.Button buttonExtraer;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textBoxDetalleExtraccion;
    }
}
