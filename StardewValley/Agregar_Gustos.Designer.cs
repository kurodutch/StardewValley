namespace StardewValley
{
    partial class Agregar_Gustos
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
            this.rbtn_Odia = new System.Windows.Forms.RadioButton();
            this.rbtn_Gusta = new System.Windows.Forms.RadioButton();
            this.btn_Agregar = new System.Windows.Forms.Button();
            this.pbox_Item = new System.Windows.Forms.PictureBox();
            this.pbox_Habitante = new System.Windows.Forms.PictureBox();
            this.txt_Item = new System.Windows.Forms.TextBox();
            this.txt_Habitante = new System.Windows.Forms.TextBox();
            this.lbl_Item = new System.Windows.Forms.Label();
            this.lbl_Habitante = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_Item)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_Habitante)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rbtn_Odia);
            this.panel1.Controls.Add(this.rbtn_Gusta);
            this.panel1.Controls.Add(this.btn_Agregar);
            this.panel1.Controls.Add(this.pbox_Item);
            this.panel1.Controls.Add(this.pbox_Habitante);
            this.panel1.Controls.Add(this.txt_Item);
            this.panel1.Controls.Add(this.txt_Habitante);
            this.panel1.Controls.Add(this.lbl_Item);
            this.panel1.Controls.Add(this.lbl_Habitante);
            this.panel1.Location = new System.Drawing.Point(1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(799, 450);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // rbtn_Odia
            // 
            this.rbtn_Odia.AutoSize = true;
            this.rbtn_Odia.Location = new System.Drawing.Point(35, 330);
            this.rbtn_Odia.Name = "rbtn_Odia";
            this.rbtn_Odia.Size = new System.Drawing.Size(47, 17);
            this.rbtn_Odia.TabIndex = 8;
            this.rbtn_Odia.TabStop = true;
            this.rbtn_Odia.Text = "Odia";
            this.rbtn_Odia.UseVisualStyleBackColor = true;
            // 
            // rbtn_Gusta
            // 
            this.rbtn_Gusta.AutoSize = true;
            this.rbtn_Gusta.Location = new System.Drawing.Point(35, 282);
            this.rbtn_Gusta.Name = "rbtn_Gusta";
            this.rbtn_Gusta.Size = new System.Drawing.Size(53, 17);
            this.rbtn_Gusta.TabIndex = 7;
            this.rbtn_Gusta.TabStop = true;
            this.rbtn_Gusta.Text = "Gusta";
            this.rbtn_Gusta.UseVisualStyleBackColor = true;
            this.rbtn_Gusta.CheckedChanged += new System.EventHandler(this.rbtn_Gusta_CheckedChanged);
            // 
            // btn_Agregar
            // 
            this.btn_Agregar.Location = new System.Drawing.Point(555, 345);
            this.btn_Agregar.Name = "btn_Agregar";
            this.btn_Agregar.Size = new System.Drawing.Size(160, 53);
            this.btn_Agregar.TabIndex = 6;
            this.btn_Agregar.Text = "Agregar";
            this.btn_Agregar.UseVisualStyleBackColor = true;
            this.btn_Agregar.Click += new System.EventHandler(this.btn_Agregar_Click);
            // 
            // pbox_Item
            // 
            this.pbox_Item.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbox_Item.Location = new System.Drawing.Point(291, 153);
            this.pbox_Item.Name = "pbox_Item";
            this.pbox_Item.Size = new System.Drawing.Size(104, 79);
            this.pbox_Item.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbox_Item.TabIndex = 5;
            this.pbox_Item.TabStop = false;
            // 
            // pbox_Habitante
            // 
            this.pbox_Habitante.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbox_Habitante.Location = new System.Drawing.Point(291, 24);
            this.pbox_Habitante.Name = "pbox_Habitante";
            this.pbox_Habitante.Size = new System.Drawing.Size(104, 79);
            this.pbox_Habitante.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbox_Habitante.TabIndex = 4;
            this.pbox_Habitante.TabStop = false;
            // 
            // txt_Item
            // 
            this.txt_Item.Location = new System.Drawing.Point(95, 169);
            this.txt_Item.Name = "txt_Item";
            this.txt_Item.Size = new System.Drawing.Size(149, 20);
            this.txt_Item.TabIndex = 3;
            this.txt_Item.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Item_KeyDown);
            this.txt_Item.Leave += new System.EventHandler(this.txt_Item_Leave);
            // 
            // txt_Habitante
            // 
            this.txt_Habitante.Location = new System.Drawing.Point(95, 19);
            this.txt_Habitante.Name = "txt_Habitante";
            this.txt_Habitante.Size = new System.Drawing.Size(148, 20);
            this.txt_Habitante.TabIndex = 2;
            this.txt_Habitante.TextChanged += new System.EventHandler(this.txt_Habitante_TextChanged);
            this.txt_Habitante.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Habitante_KeyDown);
            this.txt_Habitante.Leave += new System.EventHandler(this.txt_Habitante_Leave);
            // 
            // lbl_Item
            // 
            this.lbl_Item.AutoSize = true;
            this.lbl_Item.Location = new System.Drawing.Point(32, 172);
            this.lbl_Item.Name = "lbl_Item";
            this.lbl_Item.Size = new System.Drawing.Size(30, 13);
            this.lbl_Item.TabIndex = 1;
            this.lbl_Item.Text = "Item:";
            // 
            // lbl_Habitante
            // 
            this.lbl_Habitante.AutoSize = true;
            this.lbl_Habitante.Location = new System.Drawing.Point(32, 22);
            this.lbl_Habitante.Name = "lbl_Habitante";
            this.lbl_Habitante.Size = new System.Drawing.Size(56, 13);
            this.lbl_Habitante.TabIndex = 0;
            this.lbl_Habitante.Text = "Habitante:";
            // 
            // Agregar_Gustos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "Agregar_Gustos";
            this.Text = "Agregar_Gustos";
            this.Load += new System.EventHandler(this.Agregar_Gustos_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_Item)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_Habitante)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txt_Habitante;
        private System.Windows.Forms.Label lbl_Item;
        private System.Windows.Forms.Label lbl_Habitante;
        private System.Windows.Forms.PictureBox pbox_Item;
        private System.Windows.Forms.PictureBox pbox_Habitante;
        private System.Windows.Forms.TextBox txt_Item;
        private System.Windows.Forms.Button btn_Agregar;
        private System.Windows.Forms.RadioButton rbtn_Odia;
        private System.Windows.Forms.RadioButton rbtn_Gusta;
    }
}