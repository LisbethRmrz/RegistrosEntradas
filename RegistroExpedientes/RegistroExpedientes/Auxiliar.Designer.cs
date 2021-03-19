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
            this.paneltitulo = new System.Windows.Forms.Panel();
            this.btnmin = new System.Windows.Forms.PictureBox();
            this.btnrestart = new System.Windows.Forms.PictureBox();
            this.btncerrar = new System.Windows.Forms.PictureBox();
            this.panelmenu = new System.Windows.Forms.Panel();
            this.bton_violencia = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnregistros = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnslide = new System.Windows.Forms.PictureBox();
            this.pictureboss = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btnmax)).BeginInit();
            this.paneltitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnmin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnrestart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btncerrar)).BeginInit();
            this.panelmenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnslide)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureboss)).BeginInit();
            this.SuspendLayout();
            // 
            // panelcontenedor
            // 
            this.panelcontenedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.panelcontenedor.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelcontenedor.Location = new System.Drawing.Point(218, 48);
            this.panelcontenedor.Name = "panelcontenedor";
            this.panelcontenedor.Size = new System.Drawing.Size(1050, 602);
            this.panelcontenedor.TabIndex = 8;
            this.panelcontenedor.Paint += new System.Windows.Forms.PaintEventHandler(this.panelcontenedor_Paint);
            // 
            // btnmax
            // 
            this.btnmax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnmax.Image = ((System.Drawing.Image)(resources.GetObject("btnmax.Image")));
            this.btnmax.Location = new System.Drawing.Point(1210, 9);
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
            this.paneltitulo.Controls.Add(this.btnslide);
            this.paneltitulo.Controls.Add(this.pictureboss);
            this.paneltitulo.Controls.Add(this.btnmax);
            this.paneltitulo.Controls.Add(this.btnmin);
            this.paneltitulo.Controls.Add(this.btnrestart);
            this.paneltitulo.Controls.Add(this.btncerrar);
            this.paneltitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.paneltitulo.Location = new System.Drawing.Point(0, 0);
            this.paneltitulo.Name = "paneltitulo";
            this.paneltitulo.Size = new System.Drawing.Size(1268, 48);
            this.paneltitulo.TabIndex = 7;
            this.paneltitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.paneltitulo_MouseDown);
            // 
            // btnmin
            // 
            this.btnmin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnmin.Image = ((System.Drawing.Image)(resources.GetObject("btnmin.Image")));
            this.btnmin.Location = new System.Drawing.Point(1184, 9);
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
            this.btnrestart.Location = new System.Drawing.Point(1210, 10);
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
            this.btncerrar.Location = new System.Drawing.Point(1236, 9);
            this.btncerrar.Name = "btncerrar";
            this.btncerrar.Size = new System.Drawing.Size(20, 23);
            this.btncerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btncerrar.TabIndex = 1;
            this.btncerrar.TabStop = false;
            this.btncerrar.Click += new System.EventHandler(this.btncerrar_Click);
            // 
            // panelmenu
            // 
            this.panelmenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(110)))), ((int)(((byte)(144)))));
            this.panelmenu.Controls.Add(this.bton_violencia);
            this.panelmenu.Controls.Add(this.button2);
            this.panelmenu.Controls.Add(this.btnregistros);
            this.panelmenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelmenu.Location = new System.Drawing.Point(0, 48);
            this.panelmenu.Name = "panelmenu";
            this.panelmenu.Size = new System.Drawing.Size(250, 602);
            this.panelmenu.TabIndex = 9;
            // 
            // bton_violencia
            // 
            this.bton_violencia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bton_violencia.FlatAppearance.BorderSize = 0;
            this.bton_violencia.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(49)))), ((int)(((byte)(67)))));
            this.bton_violencia.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(49)))), ((int)(((byte)(67)))));
            this.bton_violencia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bton_violencia.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bton_violencia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.bton_violencia.Image = ((System.Drawing.Image)(resources.GetObject("bton_violencia.Image")));
            this.bton_violencia.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bton_violencia.Location = new System.Drawing.Point(0, 281);
            this.bton_violencia.Name = "bton_violencia";
            this.bton_violencia.Size = new System.Drawing.Size(263, 43);
            this.bton_violencia.TabIndex = 12;
            this.bton_violencia.Text = "Violencia Intrafamiliar";
            this.bton_violencia.UseVisualStyleBackColor = true;
            this.bton_violencia.Click += new System.EventHandler(this.bton_violencia_Click);
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
            this.button2.Location = new System.Drawing.Point(0, 562);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(263, 40);
            this.button2.TabIndex = 10;
            this.button2.Text = "Finalizar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
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
            this.btnregistros.Location = new System.Drawing.Point(0, 218);
            this.btnregistros.Name = "btnregistros";
            this.btnregistros.Size = new System.Drawing.Size(263, 43);
            this.btnregistros.TabIndex = 6;
            this.btnregistros.Text = "Registros Penales";
            this.btnregistros.UseVisualStyleBackColor = true;
            this.btnregistros.Click += new System.EventHandler(this.btnregistros_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(99, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 36);
            this.label1.TabIndex = 6;
            this.label1.Text = "Auxiliar";
            // 
            // btnslide
            // 
            this.btnslide.Image = ((System.Drawing.Image)(resources.GetObject("btnslide.Image")));
            this.btnslide.Location = new System.Drawing.Point(285, 15);
            this.btnslide.Name = "btnslide";
            this.btnslide.Size = new System.Drawing.Size(51, 30);
            this.btnslide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnslide.TabIndex = 4;
            this.btnslide.TabStop = false;
            this.btnslide.Click += new System.EventHandler(this.btnslide_Click);
            // 
            // pictureboss
            // 
            this.pictureboss.Image = global::RegistroExpedientes.Properties.Resources.c_removebg_preview__1_;
            this.pictureboss.Location = new System.Drawing.Point(1, 3);
            this.pictureboss.Name = "pictureboss";
            this.pictureboss.Size = new System.Drawing.Size(60, 48);
            this.pictureboss.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureboss.TabIndex = 5;
            this.pictureboss.TabStop = false;
            // 
            // Auxiliar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1268, 650);
            this.Controls.Add(this.panelmenu);
            this.Controls.Add(this.panelcontenedor);
            this.Controls.Add(this.paneltitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Auxiliar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Auxiliar";
            this.Load += new System.EventHandler(this.Auxiliar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnmax)).EndInit();
            this.paneltitulo.ResumeLayout(false);
            this.paneltitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnmin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnrestart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btncerrar)).EndInit();
            this.panelmenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnslide)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureboss)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelcontenedor;
        private System.Windows.Forms.Panel paneltitulo;
        private System.Windows.Forms.PictureBox btnmax;
        private System.Windows.Forms.PictureBox btnmin;
        private System.Windows.Forms.PictureBox btnrestart;
        private System.Windows.Forms.PictureBox btncerrar;
        private System.Windows.Forms.Panel panelmenu;
        private System.Windows.Forms.Button bton_violencia;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnregistros;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox btnslide;
        private System.Windows.Forms.PictureBox pictureboss;
    }
}