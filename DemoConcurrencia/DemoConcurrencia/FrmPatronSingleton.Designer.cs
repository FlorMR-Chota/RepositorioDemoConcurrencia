namespace DemoConcurrencia
{
    partial class FrmPatronSingleton
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
            btnAsignar = new Button();
            btnRecuperar = new Button();
            LblCadenaDeConexion = new Label();
            txtCadenaConexion = new TextBox();
            lblCadenaConexionRecuperada = new Label();
            SuspendLayout();
            // 
            // btnAsignar
            // 
            btnAsignar.Location = new Point(86, 151);
            btnAsignar.Name = "btnAsignar";
            btnAsignar.Size = new Size(94, 98);
            btnAsignar.TabIndex = 0;
            btnAsignar.Text = "Asignar cadena de conexion";
            btnAsignar.UseVisualStyleBackColor = true;
            btnAsignar.Click += btnAsignar_Click;
            // 
            // btnRecuperar
            // 
            btnRecuperar.Location = new Point(86, 296);
            btnRecuperar.Name = "btnRecuperar";
            btnRecuperar.Size = new Size(94, 87);
            btnRecuperar.TabIndex = 1;
            btnRecuperar.Text = "Obtener cadena de conexion";
            btnRecuperar.UseVisualStyleBackColor = true;
            btnRecuperar.Click += btnRecuperar_Click;
            // 
            // LblCadenaDeConexion
            // 
            LblCadenaDeConexion.AutoSize = true;
            LblCadenaDeConexion.Location = new Point(86, 36);
            LblCadenaDeConexion.Name = "LblCadenaDeConexion";
            LblCadenaDeConexion.Size = new Size(144, 20);
            LblCadenaDeConexion.TabIndex = 2;
            LblCadenaDeConexion.Text = "Cadena de conexion";
            // 
            // txtCadenaConexion
            // 
            txtCadenaConexion.Location = new Point(86, 82);
            txtCadenaConexion.Name = "txtCadenaConexion";
            txtCadenaConexion.Size = new Size(611, 27);
            txtCadenaConexion.TabIndex = 3;
            // 
            // lblCadenaConexionRecuperada
            // 
            lblCadenaConexionRecuperada.AutoSize = true;
            lblCadenaConexionRecuperada.Location = new Point(286, 329);
            lblCadenaConexionRecuperada.Name = "lblCadenaConexionRecuperada";
            lblCadenaConexionRecuperada.Size = new Size(18, 20);
            lblCadenaConexionRecuperada.TabIndex = 4;
            lblCadenaConexionRecuperada.Text = "...";
            // 
            // FrmPatronSingleton
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblCadenaConexionRecuperada);
            Controls.Add(txtCadenaConexion);
            Controls.Add(LblCadenaDeConexion);
            Controls.Add(btnRecuperar);
            Controls.Add(btnAsignar);
            Name = "FrmPatronSingleton";
            Text = "Demostracion del Patron Singleton";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAsignar;
        private Button btnRecuperar;
        private Label LblCadenaDeConexion;
        private TextBox txtCadenaConexion;
        private Label lblCadenaConexionRecuperada;
    }
}