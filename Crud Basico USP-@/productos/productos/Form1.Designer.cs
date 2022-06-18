namespace productos
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.primaryGrid = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.cliente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.idempleado = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.idpublicacion = new System.Windows.Forms.TextBox();
            this.cantidad1 = new System.Windows.Forms.Label();
            this.cantidad = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.preciode = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dcto = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.subtotal = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.impuesto = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.primaryGrid)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // primaryGrid
            // 
            this.primaryGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.primaryGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.primaryGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(32)))), ((int)(((byte)(52)))));
            this.primaryGrid.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.primaryGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(32)))), ((int)(((byte)(52)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Yu Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.primaryGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.primaryGrid.ColumnHeadersHeight = 30;
            this.primaryGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.primaryGrid.EnableHeadersVisualStyles = false;
            this.primaryGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(253)))), ((int)(((byte)(62)))));
            this.primaryGrid.Location = new System.Drawing.Point(3, 0);
            this.primaryGrid.Name = "primaryGrid";
            this.primaryGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(32)))), ((int)(((byte)(52)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Yu Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.primaryGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.primaryGrid.RowHeadersVisible = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(32)))), ((int)(((byte)(52)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Yu Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            this.primaryGrid.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.primaryGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.primaryGrid.Size = new System.Drawing.Size(916, 642);
            this.primaryGrid.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.primaryGrid);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(919, 642);
            this.panel1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(950, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Cliente";
            // 
            // cliente
            // 
            this.cliente.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cliente.Location = new System.Drawing.Point(1036, 25);
            this.cliente.Name = "cliente";
            this.cliente.Size = new System.Drawing.Size(207, 28);
            this.cliente.TabIndex = 7;
            this.cliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(940, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "idempleado";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // idempleado
            // 
            this.idempleado.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idempleado.Location = new System.Drawing.Point(1036, 93);
            this.idempleado.Name = "idempleado";
            this.idempleado.Size = new System.Drawing.Size(207, 28);
            this.idempleado.TabIndex = 9;
            this.idempleado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(929, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "idpublicacion";
            // 
            // idpublicacion
            // 
            this.idpublicacion.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idpublicacion.Location = new System.Drawing.Point(1036, 161);
            this.idpublicacion.Name = "idpublicacion";
            this.idpublicacion.Size = new System.Drawing.Size(207, 28);
            this.idpublicacion.TabIndex = 11;
            this.idpublicacion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cantidad1
            // 
            this.cantidad1.AutoSize = true;
            this.cantidad1.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cantidad1.ForeColor = System.Drawing.Color.White;
            this.cantidad1.Location = new System.Drawing.Point(940, 215);
            this.cantidad1.Name = "cantidad1";
            this.cantidad1.Size = new System.Drawing.Size(68, 20);
            this.cantidad1.TabIndex = 12;
            this.cantidad1.Text = "cantidad";
            // 
            // cantidad
            // 
            this.cantidad.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cantidad.Location = new System.Drawing.Point(1036, 207);
            this.cantidad.Name = "cantidad";
            this.cantidad.Size = new System.Drawing.Size(207, 28);
            this.cantidad.TabIndex = 13;
            this.cantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(32)))), ((int)(((byte)(52)))));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(972, 593);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(251, 37);
            this.button1.TabIndex = 14;
            this.button1.Text = "Guardar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // preciode
            // 
            this.preciode.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.preciode.Location = new System.Drawing.Point(1036, 254);
            this.preciode.Name = "preciode";
            this.preciode.Size = new System.Drawing.Size(207, 28);
            this.preciode.TabIndex = 15;
            this.preciode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(950, 262);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 20);
            this.label4.TabIndex = 16;
            this.label4.Text = "preciode";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // dcto
            // 
            this.dcto.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dcto.Location = new System.Drawing.Point(1036, 303);
            this.dcto.Name = "dcto";
            this.dcto.Size = new System.Drawing.Size(207, 28);
            this.dcto.TabIndex = 17;
            this.dcto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(968, 303);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 20);
            this.label5.TabIndex = 18;
            this.label5.Text = "dct";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // subtotal
            // 
            this.subtotal.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtotal.Location = new System.Drawing.Point(1036, 352);
            this.subtotal.Name = "subtotal";
            this.subtotal.Size = new System.Drawing.Size(207, 28);
            this.subtotal.TabIndex = 19;
            this.subtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(968, 352);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 20);
            this.label6.TabIndex = 20;
            this.label6.Text = "sub";
            // 
            // impuesto
            // 
            this.impuesto.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.impuesto.Location = new System.Drawing.Point(1036, 407);
            this.impuesto.Name = "impuesto";
            this.impuesto.Size = new System.Drawing.Size(207, 28);
            this.impuesto.TabIndex = 21;
            this.impuesto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(950, 407);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 20);
            this.label7.TabIndex = 22;
            this.label7.Text = "impuesto";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(32)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(1276, 642);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.impuesto);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.subtotal);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dcto);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.preciode);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cantidad);
            this.Controls.Add(this.cantidad1);
            this.Controls.Add(this.idpublicacion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.idempleado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cliente);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.primaryGrid)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView primaryGrid;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox cliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox idempleado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox idpublicacion;
        private System.Windows.Forms.Label cantidad1;
        private System.Windows.Forms.TextBox cantidad;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox preciode;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox dcto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox subtotal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox impuesto;
        private System.Windows.Forms.Label label7;
    }
}

