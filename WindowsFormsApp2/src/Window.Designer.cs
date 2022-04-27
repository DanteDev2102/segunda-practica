namespace WindowsFormsApp2
{
    partial class Window
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
            this.GroupBox_Producto = new System.Windows.Forms.GroupBox();
            this.Button_Limpiar = new System.Windows.Forms.Button();
            this.Button_Borrar = new System.Windows.Forms.Button();
            this.Button_Insertar = new System.Windows.Forms.Button();
            this.Button_Actualizar = new System.Windows.Forms.Button();
            this.Button_Buscar = new System.Windows.Forms.Button();
            this.Input_PrecioVenta = new System.Windows.Forms.TextBox();
            this.Input_Cantidad = new System.Windows.Forms.TextBox();
            this.Input_Descripcion = new System.Windows.Forms.TextBox();
            this.Input_Codigo = new System.Windows.Forms.TextBox();
            this.Label_PrecioVenta = new System.Windows.Forms.Label();
            this.Label_Cantidad = new System.Windows.Forms.Label();
            this.Label_Descripcion = new System.Windows.Forms.Label();
            this.Label_Codigo = new System.Windows.Forms.Label();
            this.GroupBox_Producto.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupBox_Producto
            // 
            this.GroupBox_Producto.Controls.Add(this.Button_Limpiar);
            this.GroupBox_Producto.Controls.Add(this.Button_Borrar);
            this.GroupBox_Producto.Controls.Add(this.Button_Insertar);
            this.GroupBox_Producto.Controls.Add(this.Button_Actualizar);
            this.GroupBox_Producto.Controls.Add(this.Button_Buscar);
            this.GroupBox_Producto.Controls.Add(this.Input_PrecioVenta);
            this.GroupBox_Producto.Controls.Add(this.Input_Cantidad);
            this.GroupBox_Producto.Controls.Add(this.Input_Descripcion);
            this.GroupBox_Producto.Controls.Add(this.Input_Codigo);
            this.GroupBox_Producto.Controls.Add(this.Label_PrecioVenta);
            this.GroupBox_Producto.Controls.Add(this.Label_Cantidad);
            this.GroupBox_Producto.Controls.Add(this.Label_Descripcion);
            this.GroupBox_Producto.Controls.Add(this.Label_Codigo);
            this.GroupBox_Producto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.GroupBox_Producto.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.GroupBox_Producto.Location = new System.Drawing.Point(88, 30);
            this.GroupBox_Producto.Name = "GroupBox_Producto";
            this.GroupBox_Producto.Size = new System.Drawing.Size(631, 381);
            this.GroupBox_Producto.TabIndex = 0;
            this.GroupBox_Producto.TabStop = false;
            this.GroupBox_Producto.Text = "Producto";
            // 
            // Button_Limpiar
            // 
            this.Button_Limpiar.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Button_Limpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.Button_Limpiar.ForeColor = System.Drawing.Color.Brown;
            this.Button_Limpiar.Location = new System.Drawing.Point(536, 94);
            this.Button_Limpiar.Name = "Button_Limpiar";
            this.Button_Limpiar.Size = new System.Drawing.Size(85, 31);
            this.Button_Limpiar.TabIndex = 12;
            this.Button_Limpiar.Text = "Limpiar";
            this.Button_Limpiar.UseVisualStyleBackColor = false;
            this.Button_Limpiar.Click += new System.EventHandler(this.Button_Limpiar_Click);
            // 
            // Button_Borrar
            // 
            this.Button_Borrar.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Button_Borrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.Button_Borrar.ForeColor = System.Drawing.Color.Brown;
            this.Button_Borrar.Location = new System.Drawing.Point(536, 148);
            this.Button_Borrar.Name = "Button_Borrar";
            this.Button_Borrar.Size = new System.Drawing.Size(85, 31);
            this.Button_Borrar.TabIndex = 11;
            this.Button_Borrar.Text = "Borrar";
            this.Button_Borrar.UseVisualStyleBackColor = false;
            // 
            // Button_Insertar
            // 
            this.Button_Insertar.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Button_Insertar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.Button_Insertar.ForeColor = System.Drawing.Color.Brown;
            this.Button_Insertar.Location = new System.Drawing.Point(430, 148);
            this.Button_Insertar.Name = "Button_Insertar";
            this.Button_Insertar.Size = new System.Drawing.Size(85, 31);
            this.Button_Insertar.TabIndex = 10;
            this.Button_Insertar.Text = "Insertar";
            this.Button_Insertar.UseVisualStyleBackColor = false;
            // 
            // Button_Actualizar
            // 
            this.Button_Actualizar.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Button_Actualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.Button_Actualizar.ForeColor = System.Drawing.Color.Brown;
            this.Button_Actualizar.Location = new System.Drawing.Point(430, 205);
            this.Button_Actualizar.Name = "Button_Actualizar";
            this.Button_Actualizar.Size = new System.Drawing.Size(85, 31);
            this.Button_Actualizar.TabIndex = 9;
            this.Button_Actualizar.Text = "Actualizar";
            this.Button_Actualizar.UseVisualStyleBackColor = false;
            // 
            // Button_Buscar
            // 
            this.Button_Buscar.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Button_Buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.Button_Buscar.ForeColor = System.Drawing.Color.Brown;
            this.Button_Buscar.Location = new System.Drawing.Point(430, 94);
            this.Button_Buscar.Name = "Button_Buscar";
            this.Button_Buscar.Size = new System.Drawing.Size(85, 31);
            this.Button_Buscar.TabIndex = 8;
            this.Button_Buscar.Text = "Buscar";
            this.Button_Buscar.UseVisualStyleBackColor = false;
            // 
            // Input_PrecioVenta
            // 
            this.Input_PrecioVenta.BackColor = System.Drawing.SystemColors.Info;
            this.Input_PrecioVenta.Location = new System.Drawing.Point(239, 273);
            this.Input_PrecioVenta.Name = "Input_PrecioVenta";
            this.Input_PrecioVenta.Size = new System.Drawing.Size(151, 29);
            this.Input_PrecioVenta.TabIndex = 7;
            this.Input_PrecioVenta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Input_PrecioVenta_KeyPress);
            // 
            // Input_Cantidad
            // 
            this.Input_Cantidad.BackColor = System.Drawing.SystemColors.Info;
            this.Input_Cantidad.Location = new System.Drawing.Point(239, 207);
            this.Input_Cantidad.Name = "Input_Cantidad";
            this.Input_Cantidad.Size = new System.Drawing.Size(151, 29);
            this.Input_Cantidad.TabIndex = 6;
            this.Input_Cantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Input_Cantidad_KeyPress);
            // 
            // Input_Descripcion
            // 
            this.Input_Descripcion.BackColor = System.Drawing.SystemColors.Info;
            this.Input_Descripcion.Location = new System.Drawing.Point(239, 150);
            this.Input_Descripcion.Name = "Input_Descripcion";
            this.Input_Descripcion.Size = new System.Drawing.Size(151, 29);
            this.Input_Descripcion.TabIndex = 5;
            this.Input_Descripcion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Input_Descripcion_KeyPress);
            // 
            // Input_Codigo
            // 
            this.Input_Codigo.BackColor = System.Drawing.SystemColors.Info;
            this.Input_Codigo.Location = new System.Drawing.Point(239, 96);
            this.Input_Codigo.Name = "Input_Codigo";
            this.Input_Codigo.Size = new System.Drawing.Size(151, 29);
            this.Input_Codigo.TabIndex = 4;
            this.Input_Codigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Input_Codigo_KeyPress);
            // 
            // Label_PrecioVenta
            // 
            this.Label_PrecioVenta.AutoSize = true;
            this.Label_PrecioVenta.Location = new System.Drawing.Point(52, 276);
            this.Label_PrecioVenta.Name = "Label_PrecioVenta";
            this.Label_PrecioVenta.Size = new System.Drawing.Size(141, 24);
            this.Label_PrecioVenta.TabIndex = 3;
            this.Label_PrecioVenta.Text = "Precio de venta";
            // 
            // Label_Cantidad
            // 
            this.Label_Cantidad.AutoSize = true;
            this.Label_Cantidad.Location = new System.Drawing.Point(52, 212);
            this.Label_Cantidad.Name = "Label_Cantidad";
            this.Label_Cantidad.Size = new System.Drawing.Size(84, 24);
            this.Label_Cantidad.TabIndex = 2;
            this.Label_Cantidad.Text = "Cantidad";
            // 
            // Label_Descripcion
            // 
            this.Label_Descripcion.AutoSize = true;
            this.Label_Descripcion.Location = new System.Drawing.Point(52, 155);
            this.Label_Descripcion.Name = "Label_Descripcion";
            this.Label_Descripcion.Size = new System.Drawing.Size(110, 24);
            this.Label_Descripcion.TabIndex = 1;
            this.Label_Descripcion.Text = "Descripción";
            // 
            // Label_Codigo
            // 
            this.Label_Codigo.AutoSize = true;
            this.Label_Codigo.Location = new System.Drawing.Point(52, 96);
            this.Label_Codigo.Name = "Label_Codigo";
            this.Label_Codigo.Size = new System.Drawing.Size(71, 24);
            this.Label_Codigo.TabIndex = 0;
            this.Label_Codigo.Text = "Codigo";
            // 
            // Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GroupBox_Producto);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Name = "Window";
            this.Text = "APP";
            this.GroupBox_Producto.ResumeLayout(false);
            this.GroupBox_Producto.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GroupBox_Producto;
        private System.Windows.Forms.Label Label_Codigo;
        private System.Windows.Forms.Label Label_Descripcion;
        private System.Windows.Forms.Label Label_Cantidad;
        private System.Windows.Forms.Label Label_PrecioVenta;
        private System.Windows.Forms.TextBox Input_PrecioVenta;
        private System.Windows.Forms.TextBox Input_Cantidad;
        private System.Windows.Forms.TextBox Input_Descripcion;
        private System.Windows.Forms.TextBox Input_Codigo;
        private System.Windows.Forms.Button Button_Buscar;
        private System.Windows.Forms.Button Button_Actualizar;
        private System.Windows.Forms.Button Button_Limpiar;
        private System.Windows.Forms.Button Button_Borrar;
        private System.Windows.Forms.Button Button_Insertar;
    }
}

