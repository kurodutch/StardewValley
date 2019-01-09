namespace StardewValley
{
    partial class Ver_Gustos
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pbox_Habitante = new System.Windows.Forms.PictureBox();
            this.txt_Habitante = new System.Windows.Forms.TextBox();
            this.lbl_Habitante = new System.Windows.Forms.Label();
            this.btn_Buscar = new System.Windows.Forms.Button();
            this.Panel_Gusta = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Panel_Odia = new System.Windows.Forms.Panel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_Habitante)).BeginInit();
            this.Panel_Gusta.SuspendLayout();
            this.Panel_Odia.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pbox_Habitante);
            this.panel1.Controls.Add(this.txt_Habitante);
            this.panel1.Controls.Add(this.lbl_Habitante);
            this.panel1.Controls.Add(this.btn_Buscar);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(735, 138);
            this.panel1.TabIndex = 0;
            // 
            // pbox_Habitante
            // 
            this.pbox_Habitante.Location = new System.Drawing.Point(326, 20);
            this.pbox_Habitante.Name = "pbox_Habitante";
            this.pbox_Habitante.Size = new System.Drawing.Size(126, 96);
            this.pbox_Habitante.TabIndex = 3;
            this.pbox_Habitante.TabStop = false;
            // 
            // txt_Habitante
            // 
            this.txt_Habitante.Location = new System.Drawing.Point(97, 20);
            this.txt_Habitante.Name = "txt_Habitante";
            this.txt_Habitante.Size = new System.Drawing.Size(207, 20);
            this.txt_Habitante.TabIndex = 2;
            this.txt_Habitante.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Habitante_KeyDown);
            this.txt_Habitante.Leave += new System.EventHandler(this.txt_Habitante_Leave);
            // 
            // lbl_Habitante
            // 
            this.lbl_Habitante.AutoSize = true;
            this.lbl_Habitante.Location = new System.Drawing.Point(19, 16);
            this.lbl_Habitante.Name = "lbl_Habitante";
            this.lbl_Habitante.Size = new System.Drawing.Size(53, 13);
            this.lbl_Habitante.TabIndex = 1;
            this.lbl_Habitante.Text = "Habitante";
            // 
            // btn_Buscar
            // 
            this.btn_Buscar.Location = new System.Drawing.Point(540, 20);
            this.btn_Buscar.Name = "btn_Buscar";
            this.btn_Buscar.Size = new System.Drawing.Size(162, 44);
            this.btn_Buscar.TabIndex = 0;
            this.btn_Buscar.Text = "Buscar";
            this.btn_Buscar.UseVisualStyleBackColor = true;
            this.btn_Buscar.Click += new System.EventHandler(this.btn_Buscar_Click);
            // 
            // Panel_Gusta
            // 
            this.Panel_Gusta.AutoScroll = true;
            this.Panel_Gusta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel_Gusta.Controls.Add(this.textBox1);
            this.Panel_Gusta.Location = new System.Drawing.Point(0, 142);
            this.Panel_Gusta.Name = "Panel_Gusta";
            this.Panel_Gusta.Size = new System.Drawing.Size(360, 455);
            this.Panel_Gusta.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(-1, -1);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(360, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "GUSTA";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Panel_Odia
            // 
            this.Panel_Odia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel_Odia.Controls.Add(this.textBox2);
            this.Panel_Odia.Location = new System.Drawing.Point(366, 142);
            this.Panel_Odia.Name = "Panel_Odia";
            this.Panel_Odia.Size = new System.Drawing.Size(370, 455);
            this.Panel_Odia.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(-2, -2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(367, 20);
            this.textBox2.TabIndex = 1;
            this.textBox2.Text = "ODIA";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Ver_Gustos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 600);
            this.Controls.Add(this.Panel_Odia);
            this.Controls.Add(this.Panel_Gusta);
            this.Controls.Add(this.panel1);
            this.Name = "Ver_Gustos";
            this.Text = "Ver_Gustos";
            this.Load += new System.EventHandler(this.Ver_Gustos_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_Habitante)).EndInit();
            this.Panel_Gusta.ResumeLayout(false);
            this.Panel_Gusta.PerformLayout();
            this.Panel_Odia.ResumeLayout(false);
            this.Panel_Odia.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pbox_Habitante;
        private System.Windows.Forms.TextBox txt_Habitante;
        private System.Windows.Forms.Label lbl_Habitante;
        private System.Windows.Forms.Button btn_Buscar;
        private System.Windows.Forms.Panel Panel_Gusta;
        private System.Windows.Forms.Panel Panel_Odia;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
    }
}