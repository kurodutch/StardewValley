namespace StardewValley
{
    partial class Agregar_Items
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
            this.lbl_Item = new System.Windows.Forms.Label();
            this.txt_Item = new System.Windows.Forms.TextBox();
            this.lbl_Imagen = new System.Windows.Forms.Label();
            this.pbox_Imagen = new System.Windows.Forms.PictureBox();
            this.btn_Examinar_Imagen = new System.Windows.Forms.Button();
            this.btn_Agregar = new System.Windows.Forms.Button();
            this.txt_Ruta = new System.Windows.Forms.TextBox();
            this.lbl_Ruta = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_Imagen)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Item
            // 
            this.lbl_Item.AutoSize = true;
            this.lbl_Item.Location = new System.Drawing.Point(29, 61);
            this.lbl_Item.Name = "lbl_Item";
            this.lbl_Item.Size = new System.Drawing.Size(84, 13);
            this.lbl_Item.TabIndex = 0;
            this.lbl_Item.Text = "Nombre del Item";
            // 
            // txt_Item
            // 
            this.txt_Item.Location = new System.Drawing.Point(144, 54);
            this.txt_Item.Name = "txt_Item";
            this.txt_Item.Size = new System.Drawing.Size(246, 20);
            this.txt_Item.TabIndex = 1;
            // 
            // lbl_Imagen
            // 
            this.lbl_Imagen.AutoSize = true;
            this.lbl_Imagen.Location = new System.Drawing.Point(32, 185);
            this.lbl_Imagen.Name = "lbl_Imagen";
            this.lbl_Imagen.Size = new System.Drawing.Size(42, 13);
            this.lbl_Imagen.TabIndex = 2;
            this.lbl_Imagen.Text = "Imagen";
            // 
            // pbox_Imagen
            // 
            this.pbox_Imagen.Location = new System.Drawing.Point(144, 147);
            this.pbox_Imagen.Name = "pbox_Imagen";
            this.pbox_Imagen.Size = new System.Drawing.Size(246, 187);
            this.pbox_Imagen.TabIndex = 3;
            this.pbox_Imagen.TabStop = false;
            // 
            // btn_Examinar_Imagen
            // 
            this.btn_Examinar_Imagen.Location = new System.Drawing.Point(144, 363);
            this.btn_Examinar_Imagen.Name = "btn_Examinar_Imagen";
            this.btn_Examinar_Imagen.Size = new System.Drawing.Size(246, 62);
            this.btn_Examinar_Imagen.TabIndex = 4;
            this.btn_Examinar_Imagen.Text = "Examinar";
            this.btn_Examinar_Imagen.UseVisualStyleBackColor = true;
            this.btn_Examinar_Imagen.Click += new System.EventHandler(this.btn_Examinar_Imagen_Click);
            // 
            // btn_Agregar
            // 
            this.btn_Agregar.Location = new System.Drawing.Point(497, 363);
            this.btn_Agregar.Name = "btn_Agregar";
            this.btn_Agregar.Size = new System.Drawing.Size(247, 62);
            this.btn_Agregar.TabIndex = 5;
            this.btn_Agregar.Text = "Agregar";
            this.btn_Agregar.UseVisualStyleBackColor = true;
            this.btn_Agregar.Click += new System.EventHandler(this.btn_Agregar_Click);
            // 
            // txt_Ruta
            // 
            this.txt_Ruta.Location = new System.Drawing.Point(485, 307);
            this.txt_Ruta.Name = "txt_Ruta";
            this.txt_Ruta.Size = new System.Drawing.Size(259, 20);
            this.txt_Ruta.TabIndex = 6;
            // 
            // lbl_Ruta
            // 
            this.lbl_Ruta.AutoSize = true;
            this.lbl_Ruta.Location = new System.Drawing.Point(480, 266);
            this.lbl_Ruta.Name = "lbl_Ruta";
            this.lbl_Ruta.Size = new System.Drawing.Size(94, 13);
            this.lbl_Ruta.TabIndex = 7;
            this.lbl_Ruta.Text = "Ruta de la Imagen";
            // 
            // Agregar_Items
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_Ruta);
            this.Controls.Add(this.txt_Ruta);
            this.Controls.Add(this.btn_Agregar);
            this.Controls.Add(this.btn_Examinar_Imagen);
            this.Controls.Add(this.pbox_Imagen);
            this.Controls.Add(this.lbl_Imagen);
            this.Controls.Add(this.txt_Item);
            this.Controls.Add(this.lbl_Item);
            this.Name = "Agregar_Items";
            this.Text = "Agregar_Items";
            this.Load += new System.EventHandler(this.Agregar_Items_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbox_Imagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Item;
        private System.Windows.Forms.TextBox txt_Item;
        private System.Windows.Forms.Label lbl_Imagen;
        private System.Windows.Forms.PictureBox pbox_Imagen;
        private System.Windows.Forms.Button btn_Examinar_Imagen;
        private System.Windows.Forms.Button btn_Agregar;
        private System.Windows.Forms.TextBox txt_Ruta;
        private System.Windows.Forms.Label lbl_Ruta;
    }
}