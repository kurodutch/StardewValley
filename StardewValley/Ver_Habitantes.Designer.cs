namespace StardewValley
{
    partial class Ver_Habitantes
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_siguiente = new System.Windows.Forms.Button();
            this.btn_atras = new System.Windows.Forms.Button();
            this.txt_Filtro = new System.Windows.Forms.TextBox();
            this.pbox_Filtrar = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_Filtrar)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(2, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(560, 744);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btn_siguiente);
            this.panel2.Controls.Add(this.btn_atras);
            this.panel2.Controls.Add(this.txt_Filtro);
            this.panel2.Controls.Add(this.pbox_Filtrar);
            this.panel2.Location = new System.Drawing.Point(2, 787);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(554, 262);
            this.panel2.TabIndex = 1;
            // 
            // btn_siguiente
            // 
            this.btn_siguiente.Location = new System.Drawing.Point(291, 165);
            this.btn_siguiente.Name = "btn_siguiente";
            this.btn_siguiente.Size = new System.Drawing.Size(83, 45);
            this.btn_siguiente.TabIndex = 3;
            this.btn_siguiente.Text = "button2";
            this.btn_siguiente.UseVisualStyleBackColor = true;
            this.btn_siguiente.Click += new System.EventHandler(this.btn_siguiente_Click);
            // 
            // btn_atras
            // 
            this.btn_atras.Location = new System.Drawing.Point(74, 165);
            this.btn_atras.Name = "btn_atras";
            this.btn_atras.Size = new System.Drawing.Size(83, 45);
            this.btn_atras.TabIndex = 2;
            this.btn_atras.Text = "button1";
            this.btn_atras.UseVisualStyleBackColor = true;
            this.btn_atras.Click += new System.EventHandler(this.btn_atras_Click);
            // 
            // txt_Filtro
            // 
            this.txt_Filtro.Location = new System.Drawing.Point(318, 65);
            this.txt_Filtro.Name = "txt_Filtro";
            this.txt_Filtro.Size = new System.Drawing.Size(183, 20);
            this.txt_Filtro.TabIndex = 1;
            this.txt_Filtro.Enter += new System.EventHandler(this.txt_Filtro_Enter);
            this.txt_Filtro.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Filtro_KeyDown);
            this.txt_Filtro.Leave += new System.EventHandler(this.txt_Filtro_Leave);
            // 
            // pbox_Filtrar
            // 
            this.pbox_Filtrar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbox_Filtrar.Location = new System.Drawing.Point(74, 37);
            this.pbox_Filtrar.Name = "pbox_Filtrar";
            this.pbox_Filtrar.Size = new System.Drawing.Size(90, 90);
            this.pbox_Filtrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbox_Filtrar.TabIndex = 0;
            this.pbox_Filtrar.TabStop = false;
            this.pbox_Filtrar.Click += new System.EventHandler(this.pbox_Filtrar_Click);
            // 
            // Ver_Habitantes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 1061);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(16, 1000);
            this.Name = "Ver_Habitantes";
            this.Text = "Ver_Habitantes";
            this.Load += new System.EventHandler(this.Ver_Habitantes_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_Filtrar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txt_Filtro;
        private System.Windows.Forms.PictureBox pbox_Filtrar;
        private System.Windows.Forms.Button btn_siguiente;
        private System.Windows.Forms.Button btn_atras;
    }
}