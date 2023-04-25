namespace Presentacion
{
    partial class FormPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            btnEntrada = new Button();
            btnSalida = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            btnFacturacion = new Button();
            SuspendLayout();
            // 
            // btnEntrada
            // 
            btnEntrada.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnEntrada.Location = new Point(52, 362);
            btnEntrada.Name = "btnEntrada";
            btnEntrada.Size = new Size(94, 29);
            btnEntrada.TabIndex = 0;
            btnEntrada.Text = "Entrada";
            btnEntrada.UseVisualStyleBackColor = true;
            // 
            // btnSalida
            // 
            btnSalida.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSalida.Location = new Point(218, 362);
            btnSalida.Name = "btnSalida";
            btnSalida.Size = new Size(94, 29);
            btnSalida.TabIndex = 1;
            btnSalida.Text = "Salida";
            btnSalida.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(52, 99);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(197, 99);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 3;
            // 
            // btnFacturacion
            // 
            btnFacturacion.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnFacturacion.Location = new Point(378, 362);
            btnFacturacion.Name = "btnFacturacion";
            btnFacturacion.Size = new Size(105, 29);
            btnFacturacion.TabIndex = 4;
            btnFacturacion.Text = "Facturacion";
            btnFacturacion.UseVisualStyleBackColor = true;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(btnFacturacion);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(btnSalida);
            Controls.Add(btnEntrada);
            DoubleBuffered = true;
            Enabled = false;
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormPrincipal";
            Text = "*** Estacionamiento Barbuto ***";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEntrada;
        private Button btnSalida;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button btnFacturacion;
    }
}