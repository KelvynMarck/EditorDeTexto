namespace Editor_De_Texto
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivo = new System.Windows.Forms.ToolStripMenuItem();
            this.edición = new System.Windows.Forms.ToolStripMenuItem();
            this.colorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formatoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrir = new System.Windows.Forms.ToolStripMenuItem();
            this.guardar = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrar = new System.Windows.Forms.ToolStripMenuItem();
            this.atras = new System.Windows.Forms.ToolStripMenuItem();
            this.adelante = new System.Windows.Forms.ToolStripMenuItem();
            this.copiar = new System.Windows.Forms.ToolStripMenuItem();
            this.cortar = new System.Windows.Forms.ToolStripMenuItem();
            this.pegar = new System.Windows.Forms.ToolStripMenuItem();
            this.seleccionarTodo = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarTodo = new System.Windows.Forms.ToolStripMenuItem();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btn_Copiar = new System.Windows.Forms.ToolStripButton();
            this.btn_Cortar = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.ComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivo,
            this.edición,
            this.colorToolStripMenuItem,
            this.formatoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(558, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivo
            // 
            this.archivo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrir,
            this.guardar,
            this.cerrar});
            this.archivo.Name = "archivo";
            this.archivo.Size = new System.Drawing.Size(60, 20);
            this.archivo.Text = "Archivo";
            // 
            // edición
            // 
            this.edición.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.atras,
            this.adelante,
            this.copiar,
            this.cortar,
            this.pegar,
            this.seleccionarTodo,
            this.eliminarTodo});
            this.edición.Name = "edición";
            this.edición.Size = new System.Drawing.Size(58, 20);
            this.edición.Text = "Edición";
            // 
            // colorToolStripMenuItem
            // 
            this.colorToolStripMenuItem.Name = "colorToolStripMenuItem";
            this.colorToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.colorToolStripMenuItem.Text = "Color";
            // 
            // formatoToolStripMenuItem
            // 
            this.formatoToolStripMenuItem.Name = "formatoToolStripMenuItem";
            this.formatoToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.formatoToolStripMenuItem.Text = "Formato";
            // 
            // abrir
            // 
            this.abrir.Image = ((System.Drawing.Image)(resources.GetObject("abrir.Image")));
            this.abrir.Name = "abrir";
            this.abrir.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.abrir.Size = new System.Drawing.Size(180, 22);
            this.abrir.Text = "Abrir";
            // 
            // guardar
            // 
            this.guardar.Image = ((System.Drawing.Image)(resources.GetObject("guardar.Image")));
            this.guardar.Name = "guardar";
            this.guardar.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.guardar.Size = new System.Drawing.Size(180, 22);
            this.guardar.Text = "Guardar";
            // 
            // cerrar
            // 
            this.cerrar.Image = ((System.Drawing.Image)(resources.GetObject("cerrar.Image")));
            this.cerrar.Name = "cerrar";
            this.cerrar.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.cerrar.Size = new System.Drawing.Size(180, 22);
            this.cerrar.Text = "Cerrar";
            // 
            // atras
            // 
            this.atras.Image = ((System.Drawing.Image)(resources.GetObject("atras.Image")));
            this.atras.Name = "atras";
            this.atras.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.atras.Size = new System.Drawing.Size(210, 22);
            this.atras.Text = "Atras";
            // 
            // adelante
            // 
            this.adelante.Image = ((System.Drawing.Image)(resources.GetObject("adelante.Image")));
            this.adelante.Name = "adelante";
            this.adelante.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.adelante.Size = new System.Drawing.Size(210, 22);
            this.adelante.Text = "Adelante";
            // 
            // copiar
            // 
            this.copiar.Image = ((System.Drawing.Image)(resources.GetObject("copiar.Image")));
            this.copiar.Name = "copiar";
            this.copiar.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copiar.Size = new System.Drawing.Size(210, 22);
            this.copiar.Text = "Copiar";
            // 
            // cortar
            // 
            this.cortar.Image = ((System.Drawing.Image)(resources.GetObject("cortar.Image")));
            this.cortar.Name = "cortar";
            this.cortar.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.cortar.Size = new System.Drawing.Size(210, 22);
            this.cortar.Text = "Cortar";
            // 
            // pegar
            // 
            this.pegar.Image = ((System.Drawing.Image)(resources.GetObject("pegar.Image")));
            this.pegar.Name = "pegar";
            this.pegar.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.pegar.Size = new System.Drawing.Size(210, 22);
            this.pegar.Text = "Pegar";
            // 
            // seleccionarTodo
            // 
            this.seleccionarTodo.Image = ((System.Drawing.Image)(resources.GetObject("seleccionarTodo.Image")));
            this.seleccionarTodo.Name = "seleccionarTodo";
            this.seleccionarTodo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.seleccionarTodo.Size = new System.Drawing.Size(210, 22);
            this.seleccionarTodo.Text = "Seleccionar Todo";
            // 
            // eliminarTodo
            // 
            this.eliminarTodo.Image = ((System.Drawing.Image)(resources.GetObject("eliminarTodo.Image")));
            this.eliminarTodo.Name = "eliminarTodo";
            this.eliminarTodo.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.X)));
            this.eliminarTodo.Size = new System.Drawing.Size(210, 22);
            this.eliminarTodo.Text = "Eliminar Todo";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 52);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(533, 280);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_Copiar,
            this.btn_Cortar,
            this.toolStripButton3,
            this.ComboBox1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(558, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btn_Copiar
            // 
            this.btn_Copiar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_Copiar.Image = ((System.Drawing.Image)(resources.GetObject("btn_Copiar.Image")));
            this.btn_Copiar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Copiar.Name = "btn_Copiar";
            this.btn_Copiar.Size = new System.Drawing.Size(23, 22);
            this.btn_Copiar.Text = "Copiar";
            // 
            // btn_Cortar
            // 
            this.btn_Cortar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_Cortar.Image = ((System.Drawing.Image)(resources.GetObject("btn_Cortar.Image")));
            this.btn_Cortar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Cortar.Name = "btn_Cortar";
            this.btn_Cortar.Size = new System.Drawing.Size(23, 22);
            this.btn_Cortar.Text = "Cortar";
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton3.Text = "Pegar";
            // 
            // ComboBox1
            // 
            this.ComboBox1.Name = "ComboBox1";
            this.ComboBox1.Size = new System.Drawing.Size(121, 25);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 341);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivo;
        private System.Windows.Forms.ToolStripMenuItem abrir;
        private System.Windows.Forms.ToolStripMenuItem guardar;
        private System.Windows.Forms.ToolStripMenuItem cerrar;
        private System.Windows.Forms.ToolStripMenuItem edición;
        private System.Windows.Forms.ToolStripMenuItem atras;
        private System.Windows.Forms.ToolStripMenuItem adelante;
        private System.Windows.Forms.ToolStripMenuItem copiar;
        private System.Windows.Forms.ToolStripMenuItem cortar;
        private System.Windows.Forms.ToolStripMenuItem pegar;
        private System.Windows.Forms.ToolStripMenuItem seleccionarTodo;
        private System.Windows.Forms.ToolStripMenuItem eliminarTodo;
        private System.Windows.Forms.ToolStripMenuItem colorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formatoToolStripMenuItem;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btn_Copiar;
        private System.Windows.Forms.ToolStripButton btn_Cortar;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripComboBox ComboBox1;
    }
}

