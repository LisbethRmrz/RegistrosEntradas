namespace RegistroExpedientes
{
    partial class RecuperarContraseña
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RecuperarContraseña));
            this.panel1 = new System.Windows.Forms.Panel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.correotext = new System.Windows.Forms.MaskedTextBox();
            this.RecuperarBT = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.VerificacionLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.UsuarioText = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnminimizar = new System.Windows.Forms.PictureBox();
            this.close = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnminimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.close)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(110)))), ((int)(((byte)(144)))));
            this.panel1.Controls.Add(this.linkLabel1);
            this.panel1.Controls.Add(this.correotext);
            this.panel1.Controls.Add(this.RecuperarBT);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.VerificacionLabel);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.UsuarioText);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(823, 306);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // linkLabel1
            // 
            this.linkLabel1.ActiveLinkColor = System.Drawing.Color.White;
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.linkLabel1.ImageKey = "(ninguno)";
            this.linkLabel1.LinkColor = System.Drawing.Color.White;
            this.linkLabel1.Location = new System.Drawing.Point(355, 215);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(66, 18);
            this.linkLabel1.TabIndex = 10;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Regresar";
            this.linkLabel1.VisitedLinkColor = System.Drawing.Color.White;
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // correotext
            // 
            this.correotext.Location = new System.Drawing.Point(267, 129);
            this.correotext.Name = "correotext";
            this.correotext.Size = new System.Drawing.Size(244, 20);
            this.correotext.TabIndex = 9;
            this.correotext.KeyUp += new System.Windows.Forms.KeyEventHandler(this.correotext_KeyUp);
            // 
            // RecuperarBT
            // 
            this.RecuperarBT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.RecuperarBT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RecuperarBT.FlatAppearance.BorderSize = 0;
            this.RecuperarBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RecuperarBT.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RecuperarBT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(49)))), ((int)(((byte)(67)))));
            this.RecuperarBT.Image = global::RegistroExpedientes.Properties.Resources.buscar;
            this.RecuperarBT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.RecuperarBT.Location = new System.Drawing.Point(276, 170);
            this.RecuperarBT.Name = "RecuperarBT";
            this.RecuperarBT.Size = new System.Drawing.Size(225, 30);
            this.RecuperarBT.TabIndex = 8;
            this.RecuperarBT.Text = "Recuperar contraseña";
            this.RecuperarBT.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.RecuperarBT.UseVisualStyleBackColor = false;
            this.RecuperarBT.Click += new System.EventHandler(this.RecuperarBT_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(191, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "Correo:";
            // 
            // VerificacionLabel
            // 
            this.VerificacionLabel.AutoSize = true;
            this.VerificacionLabel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VerificacionLabel.ForeColor = System.Drawing.Color.White;
            this.VerificacionLabel.Location = new System.Drawing.Point(535, 81);
            this.VerificacionLabel.Name = "VerificacionLabel";
            this.VerificacionLabel.Size = new System.Drawing.Size(104, 19);
            this.VerificacionLabel.TabIndex = 3;
            this.VerificacionLabel.Text = "Verificación";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(184, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Usuario:";
            // 
            // UsuarioText
            // 
            this.UsuarioText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UsuarioText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.UsuarioText.Location = new System.Drawing.Point(267, 81);
            this.UsuarioText.Name = "UsuarioText";
            this.UsuarioText.Size = new System.Drawing.Size(244, 19);
            this.UsuarioText.TabIndex = 1;
            this.UsuarioText.KeyUp += new System.Windows.Forms.KeyEventHandler(this.UsuarioText_KeyUp);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Controls.Add(this.btnminimizar);
            this.panel2.Controls.Add(this.close);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(823, 31);
            this.panel2.TabIndex = 0;
            // 
            // btnminimizar
            // 
            this.btnminimizar.Image = global::RegistroExpedientes.Properties.Resources.minimizarM;
            this.btnminimizar.Location = new System.Drawing.Point(771, 3);
            this.btnminimizar.Name = "btnminimizar";
            this.btnminimizar.Size = new System.Drawing.Size(21, 23);
            this.btnminimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnminimizar.TabIndex = 24;
            this.btnminimizar.TabStop = false;
            this.btnminimizar.Click += new System.EventHandler(this.btnminimizar_Click);
            // 
            // close
            // 
            this.close.Image = global::RegistroExpedientes.Properties.Resources.close;
            this.close.Location = new System.Drawing.Point(798, 3);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(21, 23);
            this.close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.close.TabIndex = 25;
            this.close.TabStop = false;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(49)))), ((int)(((byte)(67)))));
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Restablecer contraseña";
            // 
            // RecuperarContraseña
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 306);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RecuperarContraseña";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RecuperarContraseña";
            this.Load += new System.EventHandler(this.RecuperarContraseña_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnminimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.close)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MaskedTextBox correotext;
        private System.Windows.Forms.Button RecuperarBT;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label VerificacionLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox UsuarioText;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox btnminimizar;
        private System.Windows.Forms.PictureBox close;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}