namespace UI
{
    partial class AgregarBalanceUserControl
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
            this.buttonIrAExtraerMonto = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonIrAExtraerMonto
            // 
            this.buttonIrAExtraerMonto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonIrAExtraerMonto.Location = new System.Drawing.Point(367, 350);
            this.buttonIrAExtraerMonto.Name = "buttonIrAExtraerMonto";
            this.buttonIrAExtraerMonto.Size = new System.Drawing.Size(329, 125);
            this.buttonIrAExtraerMonto.TabIndex = 0;
            this.buttonIrAExtraerMonto.Text = "Ir a Extraer Monto";
            this.buttonIrAExtraerMonto.UseVisualStyleBackColor = true;
            this.buttonIrAExtraerMonto.Click += new System.EventHandler(this.buttonIrAExtraerMonto_Click);
            // 
            // AgregarBalanceUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.Controls.Add(this.buttonIrAExtraerMonto);
            this.Name = "AgregarBalanceUserControl";
            this.Size = new System.Drawing.Size(1070, 838);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonIrAExtraerMonto;
    }
}
