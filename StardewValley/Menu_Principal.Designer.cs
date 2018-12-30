namespace StardewValley
{
    partial class Menu_Principal
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
            this.Btn_CrearCarpeta = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Menu_Habitantes = new System.Windows.Forms.ToolStripMenuItem();
            this.Agregar_Habitantes = new System.Windows.Forms.ToolStripMenuItem();
            this.Ver_Habitantes = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Items = new System.Windows.Forms.ToolStripMenuItem();
            this.Agregar_Items = new System.Windows.Forms.ToolStripMenuItem();
            this.Ver_Items = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Gustos = new System.Windows.Forms.ToolStripMenuItem();
            this.Agregar_Gustos = new System.Windows.Forms.ToolStripMenuItem();
            this.Ver_Gustos = new System.Windows.Forms.ToolStripMenuItem();
            this.txt_1 = new System.Windows.Forms.TextBox();
            this.txt_2 = new System.Windows.Forms.TextBox();
            this.btn_Destino = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Btn_CrearCarpeta
            // 
            this.Btn_CrearCarpeta.Location = new System.Drawing.Point(295, 141);
            this.Btn_CrearCarpeta.Name = "Btn_CrearCarpeta";
            this.Btn_CrearCarpeta.Size = new System.Drawing.Size(258, 110);
            this.Btn_CrearCarpeta.TabIndex = 0;
            this.Btn_CrearCarpeta.Text = "Crear Carpeta";
            this.Btn_CrearCarpeta.UseVisualStyleBackColor = true;
            this.Btn_CrearCarpeta.Click += new System.EventHandler(this.Btn_CrearCarpeta_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(71, 42);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(175, 75);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu_Habitantes,
            this.Menu_Items,
            this.Menu_Gustos});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Menu_Habitantes
            // 
            this.Menu_Habitantes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Agregar_Habitantes,
            this.Ver_Habitantes});
            this.Menu_Habitantes.Name = "Menu_Habitantes";
            this.Menu_Habitantes.Size = new System.Drawing.Size(76, 20);
            this.Menu_Habitantes.Text = "Habitantes";
            this.Menu_Habitantes.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // Agregar_Habitantes
            // 
            this.Agregar_Habitantes.Name = "Agregar_Habitantes";
            this.Agregar_Habitantes.Size = new System.Drawing.Size(176, 22);
            this.Agregar_Habitantes.Text = "Agregar Habitantes";
            // 
            // Ver_Habitantes
            // 
            this.Ver_Habitantes.Name = "Ver_Habitantes";
            this.Ver_Habitantes.Size = new System.Drawing.Size(176, 22);
            this.Ver_Habitantes.Text = "Ver Habitantes";
            this.Ver_Habitantes.Click += new System.EventHandler(this.toolStripMenuItem1_Click_1);
            // 
            // Menu_Items
            // 
            this.Menu_Items.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Agregar_Items,
            this.Ver_Items});
            this.Menu_Items.Name = "Menu_Items";
            this.Menu_Items.Size = new System.Drawing.Size(48, 20);
            this.Menu_Items.Text = "Items";
            // 
            // Agregar_Items
            // 
            this.Agregar_Items.Name = "Agregar_Items";
            this.Agregar_Items.Size = new System.Drawing.Size(148, 22);
            this.Agregar_Items.Text = "Agregar Items";
            this.Agregar_Items.Click += new System.EventHandler(this.Agregar_Items_Click);
            // 
            // Ver_Items
            // 
            this.Ver_Items.Name = "Ver_Items";
            this.Ver_Items.Size = new System.Drawing.Size(148, 22);
            this.Ver_Items.Text = "Ver Items";
            this.Ver_Items.Click += new System.EventHandler(this.Ver_Items_Click);
            // 
            // Menu_Gustos
            // 
            this.Menu_Gustos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Agregar_Gustos,
            this.Ver_Gustos});
            this.Menu_Gustos.Name = "Menu_Gustos";
            this.Menu_Gustos.Size = new System.Drawing.Size(55, 20);
            this.Menu_Gustos.Text = "Gustos";
            // 
            // Agregar_Gustos
            // 
            this.Agregar_Gustos.Name = "Agregar_Gustos";
            this.Agregar_Gustos.Size = new System.Drawing.Size(155, 22);
            this.Agregar_Gustos.Text = "Agregar Gustos";
            // 
            // Ver_Gustos
            // 
            this.Ver_Gustos.Name = "Ver_Gustos";
            this.Ver_Gustos.Size = new System.Drawing.Size(155, 22);
            this.Ver_Gustos.Text = "Ver Gustos";
            // 
            // txt_1
            // 
            this.txt_1.Location = new System.Drawing.Point(147, 306);
            this.txt_1.Name = "txt_1";
            this.txt_1.Size = new System.Drawing.Size(406, 20);
            this.txt_1.TabIndex = 3;
            // 
            // txt_2
            // 
            this.txt_2.Location = new System.Drawing.Point(140, 357);
            this.txt_2.Name = "txt_2";
            this.txt_2.Size = new System.Drawing.Size(412, 20);
            this.txt_2.TabIndex = 4;
            // 
            // btn_Destino
            // 
            this.btn_Destino.Location = new System.Drawing.Point(631, 317);
            this.btn_Destino.Name = "btn_Destino";
            this.btn_Destino.Size = new System.Drawing.Size(139, 59);
            this.btn_Destino.TabIndex = 5;
            this.btn_Destino.Text = "button2";
            this.btn_Destino.UseVisualStyleBackColor = true;
            this.btn_Destino.Click += new System.EventHandler(this.btn_Destino_Click);
            // 
            // Menu_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Destino);
            this.Controls.Add(this.txt_2);
            this.Controls.Add(this.txt_1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Btn_CrearCarpeta);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Menu_Principal";
            this.Text = "Menu Principal";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_CrearCarpeta;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Menu_Habitantes;
        private System.Windows.Forms.ToolStripMenuItem Ver_Habitantes;
        private System.Windows.Forms.ToolStripMenuItem Agregar_Habitantes;
        private System.Windows.Forms.ToolStripMenuItem Menu_Items;
        private System.Windows.Forms.ToolStripMenuItem Agregar_Items;
        private System.Windows.Forms.ToolStripMenuItem Ver_Items;
        private System.Windows.Forms.ToolStripMenuItem Menu_Gustos;
        private System.Windows.Forms.ToolStripMenuItem Agregar_Gustos;
        private System.Windows.Forms.ToolStripMenuItem Ver_Gustos;
        private System.Windows.Forms.TextBox txt_1;
        private System.Windows.Forms.TextBox txt_2;
        private System.Windows.Forms.Button btn_Destino;
    }
}

