namespace DemoConcurrencia
{
    partial class FrmchatConcurrente
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
            splitContainer1 = new SplitContainer();
            btnReanudar = new Button();
            BtnPausarUsuario = new Button();
            btnDetenerChat = new Button();
            btnIniciarchat = new Button();
            TxtMensajes = new TextBox();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(btnReanudar);
            splitContainer1.Panel1.Controls.Add(BtnPausarUsuario);
            splitContainer1.Panel1.Controls.Add(btnDetenerChat);
            splitContainer1.Panel1.Controls.Add(btnIniciarchat);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(TxtMensajes);
            splitContainer1.Size = new Size(800, 450);
            splitContainer1.SplitterDistance = 266;
            splitContainer1.TabIndex = 0;
            // 
            // btnReanudar
            // 
            btnReanudar.Location = new Point(79, 372);
            btnReanudar.Name = "btnReanudar";
            btnReanudar.Size = new Size(94, 29);
            btnReanudar.TabIndex = 3;
            btnReanudar.Text = "Reanudar";
            btnReanudar.UseVisualStyleBackColor = true;
            // 
            // BtnPausarUsuario
            // 
            BtnPausarUsuario.Location = new Point(86, 269);
            BtnPausarUsuario.Name = "BtnPausarUsuario";
            BtnPausarUsuario.Size = new Size(94, 29);
            BtnPausarUsuario.TabIndex = 2;
            BtnPausarUsuario.Text = "Pausar";
            BtnPausarUsuario.UseVisualStyleBackColor = true;
            // 
            // btnDetenerChat
            // 
            btnDetenerChat.Location = new Point(86, 168);
            btnDetenerChat.Name = "btnDetenerChat";
            btnDetenerChat.Size = new Size(94, 29);
            btnDetenerChat.TabIndex = 1;
            btnDetenerChat.Text = "Detener";
            btnDetenerChat.UseVisualStyleBackColor = true;
            // 
            // btnIniciarchat
            // 
            btnIniciarchat.Location = new Point(86, 63);
            btnIniciarchat.Name = "btnIniciarchat";
            btnIniciarchat.Size = new Size(94, 29);
            btnIniciarchat.TabIndex = 0;
            btnIniciarchat.Text = "Iniciar";
            btnIniciarchat.UseVisualStyleBackColor = true;
            btnIniciarchat.Click += btnIniciarchat_Click;
            // 
            // TxtMensajes
            // 
            TxtMensajes.Dock = DockStyle.Fill;
            TxtMensajes.Location = new Point(0, 0);
            TxtMensajes.Multiline = true;
            TxtMensajes.Name = "TxtMensajes";
            TxtMensajes.ScrollBars = ScrollBars.Vertical;
            TxtMensajes.Size = new Size(530, 450);
            TxtMensajes.TabIndex = 1;
            // 
            // FrmchatConcurrente
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(splitContainer1);
            Name = "FrmchatConcurrente";
            Text = "FrmchatConcurrente";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private Button btnIniciarchat;
        private TextBox TxtMensajes;
        private Button btnDetenerChat;
        private Button btnReanudar;
        private Button BtnPausarUsuario;
    }
}