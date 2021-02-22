namespace RegistroExpedientes
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelcontenedor = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureboss = new System.Windows.Forms.PictureBox();
            this.btnslide = new System.Windows.Forms.PictureBox();
            this.btnregistros = new System.Windows.Forms.Button();
            this.panelmenu = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btncerrar = new System.Windows.Forms.PictureBox();
            this.btnrestart = new System.Windows.Forms.PictureBox();
            this.btnmin = new System.Windows.Forms.PictureBox();
            this.btnmax = new System.Windows.Forms.PictureBox();
            this.paneltitulo = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureboss)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnslide)).BeginInit();
            this.panelmenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btncerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnrestart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnmin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnmax)).BeginInit();
            this.paneltitulo.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelcontenedor
            // 
            this.panelcontenedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.panelcontenedor.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelcontenedor.Location = new System.Drawing.Point(234, 48);
            this.panelcontenedor.Name = "panelcontenedor";
            this.panelcontenedor.Size = new System.Drawing.Size(1050, 567);
            this.panelcontenedor.TabIndex = 5;
            this.panelcontenedor.Paint += new System.Windows.Forms.PaintEventHandler(this.panelcontenedor_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(68, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "Administrador";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureboss
            // 
            this.pictureboss.Image = ((System.Drawing.Image)(resources.GetObject("pictureboss.Image")));
            this.pictureboss.Location = new System.Drawing.Point(0, 0);
            this.pictureboss.Name = "pictureboss";
            this.pictureboss.Size = new System.Drawing.Size(60, 48);
            this.pictureboss.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureboss.TabIndex = 0;
            this.pictureboss.TabStop = false;
            this.pictureboss.Click += new System.EventHandler(this.pictureboss_Click);
            // 
            // btnslide
            // 
            this.btnslide.Image = ((System.Drawing.Image)(resources.GetObject("btnslide.Image")));
            this.btnslide.Location = new System.Drawing.Point(284, 12);
            this.btnslide.Name = "btnslide";
            this.btnslide.Size = new System.Drawing.Size(51, 30);
            this.btnslide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnslide.TabIndex = 0;
            this.btnslide.TabStop = false;
            this.btnslide.Click += new System.EventHandler(this.btnslide_Click);
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
            this.btnregistros.Location = new System.Drawing.Point(0, 267);
            this.btnregistros.Name = "btnregistros";
            this.btnregistros.Size = new System.Drawing.Size(263, 43);
            this.btnregistros.TabIndex = 6;
            this.btnregistros.Text = "Registros";
            this.btnregistros.UseVisualStyleBackColor = true;
            this.btnregistros.Click += new System.EventHandler(this.btnvendedores_Click);
            // 
            // panelmenu
            // 
            this.panelmenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(110)))), ((int)(((byte)(144)))));
            this.panelmenu.Controls.Add(this.button3);
            this.panelmenu.Controls.Add(this.button2);
            this.panelmenu.Controls.Add(this.btnregistros);
            this.panelmenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelmenu.Location = new System.Drawing.Point(0, 48);
            this.panelmenu.Name = "panelmenu";
            this.panelmenu.Size = new System.Drawing.Size(250, 567);
            this.panelmenu.TabIndex = 3;
            this.panelmenu.Paint += new System.Windows.Forms.PaintEventHandler(this.panelmenu_Paint);
            // 
            // button3
            // 
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(49)))), ((int)(((byte)(67)))));
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(49)))), ((int)(((byte)(67)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(0, 196);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(263, 43);
            this.button3.TabIndex = 11;
            this.button3.Text = "Usuarios";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
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
            this.button2.Location = new System.Drawing.Point(0, 527);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(263, 40);
            this.button2.TabIndex = 10;
            this.button2.Text = "Finalizar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btncerrar
            // 
            this.btncerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btncerrar.Image = ((System.Drawing.Image)(resources.GetObject("btncerrar.Image")));
            this.btncerrar.Location = new System.Drawing.Point(1252, 9);
            this.btncerrar.Name = "btncerrar";
            this.btncerrar.Size = new System.Drawing.Size(20, 23);
            this.btncerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btncerrar.TabIndex = 1;
            this.btncerrar.TabStop = false;
            this.btncerrar.Click += new System.EventHandler(this.btncerrar_Click);
            // 
            // btnrestart
            // 
            this.btnrestart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnrestart.Image = ((System.Drawing.Image)(resources.GetObject("btnrestart.Image")));
            this.btnrestart.Location = new System.Drawing.Point(1226, 10);
            this.btnrestart.Name = "btnrestart";
            this.btnrestart.Size = new System.Drawing.Size(20, 23);
            this.btnrestart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnrestart.TabIndex = 3;
            this.btnrestart.TabStop = false;
            this.btnrestart.Visible = false;
            this.btnrestart.Click += new System.EventHandler(this.btnrestart_Click);
            // 
            // btnmin
            // 
            this.btnmin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnmin.Image = ((System.Drawing.Image)(resources.GetObject("btnmin.Image")));
            this.btnmin.Location = new System.Drawing.Point(1200, 9);
            this.btnmin.Name = "btnmin";
            this.btnmin.Size = new System.Drawing.Size(20, 23);
            this.btnmin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnmin.TabIndex = 0;
            this.btnmin.TabStop = false;
            this.btnmin.Click += new System.EventHandler(this.btnmin_Click);
            // 
            // btnmax
            // 
            this.btnmax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnmax.Image = ((System.Drawing.Image)(resources.GetObject("btnmax.Image")));
            this.btnmax.Location = new System.Drawing.Point(1226, 9);
            this.btnmax.Name = "btnmax";
            this.btnmax.Size = new System.Drawing.Size(20, 23);
            this.btnmax.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnmax.TabIndex = 2;
            this.btnmax.TabStop = false;
            this.btnmax.Click += new System.EventHandler(this.btnmax_Click);
            // 
            // paneltitulo
            // 
            this.paneltitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(110)))), ((int)(((byte)(144)))));
            this.paneltitulo.Controls.Add(this.label1);
            this.paneltitulo.Controls.Add(this.btnmax);
            this.paneltitulo.Controls.Add(this.btnslide);
            this.paneltitulo.Controls.Add(this.btnmin);
            this.paneltitulo.Controls.Add(this.pictureboss);
            this.paneltitulo.Controls.Add(this.btnrestart);
            this.paneltitulo.Controls.Add(this.btncerrar);
            this.paneltitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.paneltitulo.Location = new System.Drawing.Point(0, 0);
            this.paneltitulo.Name = "paneltitulo";
            this.paneltitulo.Size = new System.Drawing.Size(1284, 48);
            this.paneltitulo.TabIndex = 4;
            this.paneltitulo.Paint += new System.Windows.Forms.PaintEventHandler(this.paneltitulo_Paint);
            this.paneltitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.paneltitulo_MouseDown);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 615);
            this.Controls.Add(this.panelmenu);
            this.Controls.Add(this.panelcontenedor);
            this.Controls.Add(this.paneltitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureboss)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnslide)).EndInit();
            this.panelmenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btncerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnrestart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnmin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnmax)).EndInit();
            this.paneltitulo.ResumeLayout(false);
            this.paneltitulo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelcontenedor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureboss;
        private System.Windows.Forms.PictureBox btnslide;
        private System.Windows.Forms.Button btnregistros;
        private System.Windows.Forms.Panel panelmenu;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.PictureBox btncerrar;
        private System.Windows.Forms.PictureBox btnrestart;
        private System.Windows.Forms.PictureBox btnmin;
        private System.Windows.Forms.PictureBox btnmax;
        private System.Windows.Forms.Panel paneltitulo;
    }
}

