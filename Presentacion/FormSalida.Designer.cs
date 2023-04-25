namespace Presentacion
{
    partial class FormSalida
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSalida));
            txtBuscarPatente = new TextBox();
            btnBuscarPantente = new Button();
            SuspendLayout();
            // 
            // txtBuscarPatente
            // 
            txtBuscarPatente.Location = new Point(35, 34);
            txtBuscarPatente.Name = "txtBuscarPatente";
            txtBuscarPatente.Size = new Size(125, 27);
            txtBuscarPatente.TabIndex = 0;
            // 
            // btnBuscarPantente
            // 
            btnBuscarPantente.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnBuscarPantente.Location = new Point(35, 114);
            btnBuscarPantente.Name = "btnBuscarPantente";
            btnBuscarPantente.Size = new Size(94, 29);
            btnBuscarPantente.TabIndex = 1;
            btnBuscarPantente.Text = "Buscar";
            btnBuscarPantente.UseVisualStyleBackColor = true;
            // 
            // FormSalida
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(btnBuscarPantente);
            Controls.Add(txtBuscarPatente);
            DoubleBuffered = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormSalida";
            Text = "*** Formulario De Salida ***";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtBuscarPatente;
        private Button btnBuscarPantente;
    }
}