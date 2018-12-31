namespace StardewValley
{
    partial class Agregar_Habitantes
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
            this.lbl_Habitante = new System.Windows.Forms.Label();
            this.txt_Habitante = new System.Windows.Forms.TextBox();
            this.lbl_Imagen = new System.Windows.Forms.Label();
            this.pbox_Imagen = new System.Windows.Forms.PictureBox();
            this.btn_Examinar_Imagen = new System.Windows.Forms.Button();
            this.btn_Agregar = new System.Windows.Forms.Button();
            this.lbl_Ruta = new System.Windows.Forms.Label();
            this.txt_Ruta = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_Imagen)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Habitante
            // 
            this.lbl_Habitante.AutoSize = true;
            this.lbl_Habitante.Location = new System.Drawing.Point(35, 52);
            this.lbl_Habitante.Name = "lbl_Habitante";
            this.lbl_Habitante.Size = new System.Drawing.Size(110, 13);
            this.lbl_Habitante.TabIndex = 0;
            this.lbl_Habitante.Text = "Nombre del Habitante";
            // 
            // txt_Habitante
            // 
            this.txt_Habitante.Location = new System.Drawing.Point(173, 50);
            this.txt_Habitante.Name = "txt_Habitante";
            this.txt_Habitante.Size = new System.Drawing.Size(222, 20);
            this.txt_Habitante.TabIndex = 1;
            // 
            // lbl_Imagen
            // 
            this.lbl_Imagen.AutoSize = true;
            this.lbl_Imagen.Location = new System.Drawing.Point(31, 232);
            this.lbl_Imagen.Name = "lbl_Imagen";
            this.lbl_Imagen.Size = new System.Drawing.Size(42, 13);
            this.lbl_Imagen.TabIndex = 2;
            this.lbl_Imagen.Text = "Imagen";
            // 
            // pbox_Imagen
            // 
            this.pbox_Imagen.Location = new System.Drawing.Point(156, 200);
            this.pbox_Imagen.Name = "pbox_Imagen";
            this.pbox_Imagen.Size = new System.Drawing.Size(217, 176);
            this.pbox_Imagen.TabIndex = 3;
            this.pbox_Imagen.TabStop = false;
            // 
            // btn_Examinar_Imagen
            // 
            this.btn_Examinar_Imagen.Location = new System.Drawing.Point(129, 429);
            this.btn_Examinar_Imagen.Name = "btn_Examinar_Imagen";
            this.btn_Examinar_Imagen.Size = new System.Drawing.Size(243, 75);
            this.btn_Examinar_Imagen.TabIndex = 4;
            this.btn_Examinar_Imagen.Text = "Examinar";
            this.btn_Examinar_Imagen.UseVisualStyleBackColor = true;
            this.btn_Examinar_Imagen.Click += new System.EventHandler(this.btn_Examinar_Imagen_Click);
            // 
            // btn_Agregar
            // 
            this.btn_Agregar.Location = new System.Drawing.Point(474, 429);
            this.btn_Agregar.Name = "btn_Agregar";
            this.btn_Agregar.Size = new System.Drawing.Size(273, 74);
            this.btn_Agregar.TabIndex = 5;
            this.btn_Agregar.Text = "Agregar";
            this.btn_Agregar.UseVisualStyleBackColor = true;
            this.btn_Agregar.Click += new System.EventHandler(this.btn_Agregar_Click);
            // 
            // lbl_Ruta
            // 
            this.lbl_Ruta.AutoSize = true;
            this.lbl_Ruta.Location = new System.Drawing.Point(485, 263);
            this.lbl_Ruta.Name = "lbl_Ruta";
            this.lbl_Ruta.Size = new System.Drawing.Size(68, 13);
            this.lbl_Ruta.TabIndex = 6;
            this.lbl_Ruta.Text = "Ruta Imagen";
            // 
            // txt_Ruta
            // 
            this.txt_Ruta.Location = new System.Drawing.Point(492, 317);
            this.txt_Ruta.Name = "txt_Ruta";
            this.txt_Ruta.Size = new System.Drawing.Size(223, 20);
            this.txt_Ruta.TabIndex = 7;
            // 
            // Agregar_Habitantes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 526);
            this.Controls.Add(this.txt_Ruta);
            this.Controls.Add(this.lbl_Ruta);
            this.Controls.Add(this.btn_Agregar);
            this.Controls.Add(this.btn_Examinar_Imagen);
            this.Controls.Add(this.pbox_Imagen);
            this.Controls.Add(this.lbl_Imagen);
            this.Controls.Add(this.txt_Habitante);
            this.Controls.Add(this.lbl_Habitante);
            this.Name = "Agregar_Habitantes";
            this.Text = "Agregar_Habitantes";
            ((System.ComponentModel.ISupportInitialize)(this.pbox_Imagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Habitante;
        private System.Windows.Forms.TextBox txt_Habitante;
        private System.Windows.Forms.Label lbl_Imagen;
        private System.Windows.Forms.PictureBox pbox_Imagen;
        private System.Windows.Forms.Button btn_Examinar_Imagen;
        private System.Windows.Forms.Button btn_Agregar;
        private System.Windows.Forms.Label lbl_Ruta;
        private System.Windows.Forms.TextBox txt_Ruta;
    }
}