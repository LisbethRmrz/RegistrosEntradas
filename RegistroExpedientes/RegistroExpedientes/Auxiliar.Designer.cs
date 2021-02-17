namespace RegistroExpedientes
{
    partial class Auxiliar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Auxiliar));
            this.panelcontenedor = new System.Windows.Forms.Panel();
            this.btnmax = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureboss = new System.Windows.Forms.PictureBox();
            this.paneltitulo = new System.Windows.Forms.Panel();
            this.btnmin = new System.Windows.Forms.PictureBox();
            this.btnrestart = new System.Windows.Forms.PictureBox();
            this.btncerrar = new System.Windows.Forms.PictureBox();
            this.btnregistros = new System.Windows.Forms.Button();
            this.panelmenu = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.btnmax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureboss)).BeginInit();
            this.paneltitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnmin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnrestart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btncerrar)).BeginInit();
            this.panelmenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelcontenedor
            // 
            this.panelcontenedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.panelcontenedor.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelcontenedor.Location = new System.Drawing.Point(218, 48);
            this.panelcontenedor.Name = "panelcontenedor";
            this.panelcontenedor.Size = new System.Drawing.Size(1050, 524);
            this.panelcontenedor.TabIndex = 8;
            this.panelcontenedor.Paint += new System.Windows.Forms.PaintEventHandler(this.panelcontenedor_Paint);
            // 
            // btnmax
            // 
            this.btnmax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnmax.Image = ((System.Drawing.Image)(resources.GetObject("btnmax.Image")));
            this.btnmax.Location = new System.Drawing.Point(980, 9);
            this.btnmax.Name = "btnmax";
            this.btnmax.Size = new System.Drawing.Size(20, 23);
            this.btnmax.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnmax.TabIndex = 2;
            this.btnmax.TabStop = false;
            this.btnmax.Click += new System.EventHandler(this.btnmax_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(57, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "Auxiliar";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureboss
            // 
            this.pictureboss.Image = ((System.Drawing.Image)(resources.GetObject("pictureboss.Image")));
            this.pictureboss.Location = new System.Drawing.Point(0, 3);
            this.pictureboss.Name = "pictureboss";
            this.pictureboss.Size = new System.Drawing.Size(60, 48);
            this.pictureboss.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureboss.TabIndex = 0;
            this.pictureboss.TabStop = false;
            this.pictureboss.Click += new System.EventHandler(this.pictureboss_Click);
            // 
            // paneltitulo
            // 
            this.paneltitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(110)))), ((int)(((byte)(144)))));
            this.paneltitulo.Controls.Add(this.btnmax);
            this.paneltitulo.Controls.Add(this.btnmin);
            this.paneltitulo.Controls.Add(this.btnrestart);
            this.paneltitulo.Controls.Add(this.btncerrar);
            this.paneltitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.paneltitulo.Location = new System.Drawing.Point(230, 0);
            this.paneltitulo.Name = "paneltitulo";
            this.paneltitulo.Size = new System.Drawing.Size(1038, 48);
            this.paneltitulo.TabIndex = 7;
            this.paneltitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.paneltitulo_MouseDown);
            // 
            // btnmin
            // 
            this.btnmin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnmin.Image = ((System.Drawing.Image)(resources.GetObject("btnmin.Image")));
            this.btnmin.Location = new System.Drawing.Point(954, 9);
            this.btnmin.Name = "btnmin";
            this.btnmin.Size = new System.Drawing.Size(20, 23);
            this.btnmin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnmin.TabIndex = 0;
            this.btnmin.TabStop = false;
            this.btnmin.Click += new System.EventHandler(this.btnmin_Click);
            // 
            // btnrestart
            // 
            this.btnrestart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnrestart.Image = ((System.Drawing.Image)(resources.GetObject("btnrestart.Image")));
            this.btnrestart.Location = new System.Drawing.Point(980, 10);
            this.btnrestart.Name = "btnrestart";
            this.btnrestart.Size = new System.Drawing.Size(20, 23);
            this.btnrestart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnrestart.TabIndex = 3;
            this.btnrestart.TabStop = false;
            this.btnrestart.Visible = false;
            this.btnrestart.Click += new System.EventHandler(this.btnrestart_Click);
            // 
            // btncerrar
            // 
            this.btncerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btncerrar.Image = ((System.Drawing.Image)(resources.GetObject("btncerrar.Image")));
            this.btncerrar.Location = new System.Drawing.Point(1006, 9);
            this.btncerrar.Name = "btncerrar";
            this.btncerrar.Size = new System.Drawing.Size(20, 23);
            this.btncerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btncerrar.TabIndex = 1;
            this.btncerrar.TabStop = false;
            this.btncerrar.Click += new System.EventHandler(this.btncerrar_Click);
            // 
            // btnregistros
            // 
            this.btnregistros.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnregistros.FlatAppearance.BorderSize = 0;
            this.btnregistros.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(49)))), ((int)(((byte)(67)))));
            this.btnregistros.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(49)))), ((int)(((byte)(67)))));
            this.btnregistros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnregistros.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnregistros.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.btnregistros.Image = ((System.Drawing.Image)(resources.GetObject("btnregistros.Image")));
            this.btnregistros.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnregistros.Location = new System.Drawing.Point(0, 251);
            this.btnregistros.Name = "btnregistros";
            this.btnregistros.Size = new System.Drawing.Size(227, 43);
            this.btnregistros.TabIndex = 6;
            this.btnregistros.Text = "Registros";
            this.btnregistros.UseVisualStyleBackColor = true;
            this.btnregistros.Click += new System.EventHandler(this.btnregistros_Click);
            // 
            // panelmenu
            // 
            this.panelmenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(110)))), ((int)(((byte)(144)))));
            this.panelmenu.Controls.Add(this.pictureboss);
            this.panelmenu.Controls.Add(this.button2);
            this.panelmenu.Controls.Add(this.btnregistros);
            this.panelmenu.Controls.Add(this.label1);
            this.panelmenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelmenu.Location = new System.Drawing.Point(0, 0);
            this.panelmenu.Name = "panelmenu";
            this.panelmenu.Size = new System.Drawing.Size(230, 572);
            this.panelmenu.TabIndex = 6;
            // 
            // button2
            // 
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(49)))), ((int)(((byte)(67)))));
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(49)))), ((int)(((byte)(67)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(0, 532);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(227, 40);
            this.button2.TabIndex = 10;
            this.button2.Text = "Finalizar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Auxiliar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1268, 572);
            this.Controls.Add(this.panelcontenedor);
            this.Controls.Add(this.paneltitulo);
            this.Controls.Add(this.panelmenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Auxiliar";
            this.Text = "Auxiliar";
            this.Load += new System.EventHandler(this.Auxiliar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnmax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureboss)).EndInit();
            this.paneltitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnmin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnrestart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btncerrar)).EndInit();
            this.panelmenu.ResumeLayout(false);
            this.panelmenu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelcontenedor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureboss;
        private System.Windows.Forms.Panel paneltitulo;
        private System.Windows.Forms.PictureBox btnmax;
        private System.Windows.Forms.PictureBox btnmin;
        private System.Windows.Forms.PictureBox btnrestart;
        private System.Windows.Forms.PictureBox btncerrar;
        private System.Windows.Forms.Button btnregistros;
        private System.Windows.Forms.Panel panelmenu;
        private System.Windows.Forms.Button button2;
    }
}