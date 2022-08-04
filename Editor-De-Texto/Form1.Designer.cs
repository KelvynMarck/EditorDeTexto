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
            this.menuStrip1.SuspendLayout();
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
            this.menuStrip1.Size = new System.Drawing.Size(538, 24);
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
            this.abrir.Name = "abrir";
            this.abrir.Size = new System.Drawing.Size(180, 22);
            this.abrir.Text = "Abrir";
            // 
            // guardar
            // 
            this.guardar.Name = "guardar";
            this.guardar.Size = new System.Drawing.Size(180, 22);
            this.guardar.Text = "Guardar";
            // 
            // cerrar
            // 
            this.cerrar.Name = "cerrar";
            this.cerrar.Size = new System.Drawing.Size(180, 22);
            this.cerrar.Text = "Cerrar";
            // 
            // atras
            // 
            this.atras.Name = "atras";
            this.atras.Size = new System.Drawing.Size(180, 22);
            this.atras.Text = "Atras";
            // 
            // adelante
            // 
            this.adelante.Name = "adelante";
            this.adelante.Size = new System.Drawing.Size(180, 22);
            this.adelante.Text = "Adelante";
            // 
            // copiar
            // 
            this.copiar.Name = "copiar";
            this.copiar.Size = new System.Drawing.Size(180, 22);
            this.copiar.Text = "Copiar";
            // 
            // cortar
            // 
            this.cortar.Name = "cortar";
            this.cortar.Size = new System.Drawing.Size(180, 22);
            this.cortar.Text = "Cortar";
            // 
            // pegar
            // 
            this.pegar.Name = "pegar";
            this.pegar.Size = new System.Drawing.Size(180, 22);
            this.pegar.Text = "Pegar";
            // 
            // seleccionarTodo
            // 
            this.seleccionarTodo.Name = "seleccionarTodo";
            this.seleccionarTodo.Size = new System.Drawing.Size(180, 22);
            this.seleccionarTodo.Text = "Seleccionar Todo";
            // 
            // eliminarTodo
            // 
            this.eliminarTodo.Name = "eliminarTodo";
            this.eliminarTodo.Size = new System.Drawing.Size(180, 22);
            this.eliminarTodo.Text = "Eliminar Todo";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 39);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(514, 280);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 331);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
    }
}

