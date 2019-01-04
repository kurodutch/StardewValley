namespace StardewValley
{
    partial class Ver_Items
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
            this.txt_Filtro = new System.Windows.Forms.TextBox();
            this.btn_siguiente = new System.Windows.Forms.Button();
            this.btn_atrás = new System.Windows.Forms.Button();
            this.pbox_Filtrar = new System.Windows.Forms.PictureBox();
            this.cmbox_Filtrar = new System.Windows.Forms.ComboBox();
            this.txt_Filtrar = new System.Windows.Forms.TextBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_Filtrar)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(2, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(560, 481);
            this.panel1.TabIndex = 32;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txt_Filtro);
            this.panel2.Controls.Add(this.btn_siguiente);
            this.panel2.Controls.Add(this.btn_atrás);
            this.panel2.Controls.Add(this.pbox_Filtrar);
            this.panel2.Controls.Add(this.cmbox_Filtrar);
            this.panel2.Controls.Add(this.txt_Filtrar);
            this.panel2.Location = new System.Drawing.Point(2, 602);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(554, 266);
            this.panel2.TabIndex = 33;
            // 
            // txt_Filtro
            // 
            this.txt_Filtro.Location = new System.Drawing.Point(306, 80);
            this.txt_Filtro.Name = "txt_Filtro";
            this.txt_Filtro.Size = new System.Drawing.Size(154, 20);
            this.txt_Filtro.TabIndex = 5;
            this.txt_Filtro.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txt_Filtro_MouseClick);
            this.txt_Filtro.TextChanged += new System.EventHandler(this.txt_Filtro_TextChanged);
            this.txt_Filtro.Enter += new System.EventHandler(this.txt_Filtro_Enter);
            this.txt_Filtro.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Filtro_KeyDown);
            this.txt_Filtro.Leave += new System.EventHandler(this.txt_Filtro_Leave);
            // 
            // btn_siguiente
            // 
            this.btn_siguiente.Image = global::StardewValley.Properties.Resources.flecha_derecha;
            this.btn_siguiente.Location = new System.Drawing.Point(307, 182);
            this.btn_siguiente.Name = "btn_siguiente";
            this.btn_siguiente.Size = new System.Drawing.Size(100, 49);
            this.btn_siguiente.TabIndex = 4;
            this.btn_siguiente.Text = "Siguiente";
            this.btn_siguiente.UseVisualStyleBackColor = true;
            this.btn_siguiente.Click += new System.EventHandler(this.btn_siguiente_Click);
            this.btn_siguiente.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btn_siguiente_KeyDown);
            // 
            // btn_atrás
            // 
            this.btn_atrás.Location = new System.Drawing.Point(112, 182);
            this.btn_atrás.Name = "btn_atrás";
            this.btn_atrás.Size = new System.Drawing.Size(100, 49);
            this.btn_atrás.TabIndex = 3;
            this.btn_atrás.Text = "Atrás";
            this.btn_atrás.UseVisualStyleBackColor = true;
            this.btn_atrás.Click += new System.EventHandler(this.btn_atrás_Click);
            // 
            // pbox_Filtrar
            // 
            this.pbox_Filtrar.Location = new System.Drawing.Point(99, 68);
            this.pbox_Filtrar.Name = "pbox_Filtrar";
            this.pbox_Filtrar.Size = new System.Drawing.Size(102, 68);
            this.pbox_Filtrar.TabIndex = 2;
            this.pbox_Filtrar.TabStop = false;
            // 
            // cmbox_Filtrar
            // 
            this.cmbox_Filtrar.FormattingEnabled = true;
            this.cmbox_Filtrar.Location = new System.Drawing.Point(307, 21);
            this.cmbox_Filtrar.Name = "cmbox_Filtrar";
            this.cmbox_Filtrar.Size = new System.Drawing.Size(154, 21);
            this.cmbox_Filtrar.TabIndex = 1;
            this.cmbox_Filtrar.SelectedIndexChanged += new System.EventHandler(this.cmbox_Filtrar_SelectedIndexChanged);
            // 
            // txt_Filtrar
            // 
            this.txt_Filtrar.Location = new System.Drawing.Point(91, 17);
            this.txt_Filtrar.Name = "txt_Filtrar";
            this.txt_Filtrar.Size = new System.Drawing.Size(156, 20);
            this.txt_Filtrar.TabIndex = 0;
            // 
            // Ver_Items
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(557, 1026);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Ver_Items";
            this.Text = "Ver Items";
            this.Load += new System.EventHandler(this.Ver_Items_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_Filtrar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txt_Filtrar;
        private System.Windows.Forms.ComboBox cmbox_Filtrar;
        private System.Windows.Forms.PictureBox pbox_Filtrar;
        private System.Windows.Forms.Button btn_siguiente;
        private System.Windows.Forms.Button btn_atrás;
        private System.Windows.Forms.TextBox txt_Filtro;
    }
}