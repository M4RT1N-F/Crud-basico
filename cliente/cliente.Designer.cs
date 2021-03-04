namespace cliente
{
    partial class cliente
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
            this.bt_nuevoCliente = new System.Windows.Forms.Button();
            this.bt_modificarCliente = new System.Windows.Forms.Button();
            this.bt_eliminarCliente = new System.Windows.Forms.Button();
            this.dg_cliente = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_cliente)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1044, 127);
            this.panel1.TabIndex = 0;
            // 
            // bt_nuevoCliente
            // 
            this.bt_nuevoCliente.Location = new System.Drawing.Point(49, 157);
            this.bt_nuevoCliente.Name = "bt_nuevoCliente";
            this.bt_nuevoCliente.Size = new System.Drawing.Size(97, 23);
            this.bt_nuevoCliente.TabIndex = 1;
            this.bt_nuevoCliente.Text = "Nuevo Cliente";
            this.bt_nuevoCliente.UseVisualStyleBackColor = true;
            this.bt_nuevoCliente.Click += new System.EventHandler(this.bt_nuevoCliente_Click);
            // 
            // bt_modificarCliente
            // 
            this.bt_modificarCliente.Location = new System.Drawing.Point(209, 157);
            this.bt_modificarCliente.Name = "bt_modificarCliente";
            this.bt_modificarCliente.Size = new System.Drawing.Size(95, 23);
            this.bt_modificarCliente.TabIndex = 2;
            this.bt_modificarCliente.Text = "Modificar Cliente";
            this.bt_modificarCliente.UseVisualStyleBackColor = true;
            this.bt_modificarCliente.Click += new System.EventHandler(this.bt_modificarCliente_Click);
            // 
            // bt_eliminarCliente
            // 
            this.bt_eliminarCliente.Location = new System.Drawing.Point(364, 157);
            this.bt_eliminarCliente.Name = "bt_eliminarCliente";
            this.bt_eliminarCliente.Size = new System.Drawing.Size(96, 23);
            this.bt_eliminarCliente.TabIndex = 3;
            this.bt_eliminarCliente.Text = "Eliminar Cliente";
            this.bt_eliminarCliente.UseVisualStyleBackColor = true;
            this.bt_eliminarCliente.Click += new System.EventHandler(this.bt_eliminarCliente_Click);
            // 
            // dg_cliente
            // 
            this.dg_cliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_cliente.Location = new System.Drawing.Point(36, 203);
            this.dg_cliente.Name = "dg_cliente";
            this.dg_cliente.Size = new System.Drawing.Size(985, 363);
            this.dg_cliente.TabIndex = 4;
            this.dg_cliente.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_cliente_CellClick);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Image = global::cliente.Properties.Resources.barba;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(36, 44);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(177, 50);
            this.button1.TabIndex = 0;
            this.button1.Text = "CLIENTE";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1044, 578);
            this.Controls.Add(this.dg_cliente);
            this.Controls.Add(this.bt_eliminarCliente);
            this.Controls.Add(this.bt_modificarCliente);
            this.Controls.Add(this.bt_nuevoCliente);
            this.Controls.Add(this.panel1);
            this.Name = "cliente";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.cliente_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dg_cliente)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button bt_nuevoCliente;
        private System.Windows.Forms.Button bt_modificarCliente;
        private System.Windows.Forms.Button bt_eliminarCliente;
        private System.Windows.Forms.DataGridView dg_cliente;
    }
}

