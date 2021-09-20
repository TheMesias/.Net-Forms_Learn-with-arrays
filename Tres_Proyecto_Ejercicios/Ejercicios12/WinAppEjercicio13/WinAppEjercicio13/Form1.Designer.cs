namespace WinAppEjercicio13
{
    partial class FormTrece
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dataGredMatriz = new System.Windows.Forms.DataGridView();
            this.C1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_NumColumnasMatriz = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_LlenadoMatriz = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_NumFilasMatriz = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGredMatriz)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 17;
            this.listBox1.Location = new System.Drawing.Point(503, 332);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(287, 174);
            this.listBox1.TabIndex = 47;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(512, 287);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(249, 19);
            this.label10.TabIndex = 46;
            this.label10.Text = "MAYORES ELEMENTOS DE CADA FILA";
            // 
            // dataGredMatriz
            // 
            this.dataGredMatriz.AllowUserToAddRows = false;
            this.dataGredMatriz.AllowUserToDeleteRows = false;
            this.dataGredMatriz.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGredMatriz.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.C1,
            this.C2,
            this.C3});
            this.dataGredMatriz.Location = new System.Drawing.Point(28, 332);
            this.dataGredMatriz.Margin = new System.Windows.Forms.Padding(4);
            this.dataGredMatriz.Name = "dataGredMatriz";
            this.dataGredMatriz.ReadOnly = true;
            this.dataGredMatriz.RowHeadersWidth = 51;
            this.dataGredMatriz.Size = new System.Drawing.Size(320, 185);
            this.dataGredMatriz.TabIndex = 45;
            // 
            // C1
            // 
            this.C1.HeaderText = "1";
            this.C1.MinimumWidth = 6;
            this.C1.Name = "C1";
            this.C1.ReadOnly = true;
            this.C1.Width = 125;
            // 
            // C2
            // 
            this.C2.HeaderText = "2";
            this.C2.MinimumWidth = 6;
            this.C2.Name = "C2";
            this.C2.ReadOnly = true;
            this.C2.Width = 125;
            // 
            // C3
            // 
            this.C3.HeaderText = "3";
            this.C3.MinimumWidth = 6;
            this.C3.Name = "C3";
            this.C3.ReadOnly = true;
            this.C3.Width = 125;
            // 
            // txt_NumColumnasMatriz
            // 
            this.txt_NumColumnasMatriz.Location = new System.Drawing.Point(457, 150);
            this.txt_NumColumnasMatriz.Name = "txt_NumColumnasMatriz";
            this.txt_NumColumnasMatriz.Size = new System.Drawing.Size(166, 23);
            this.txt_NumColumnasMatriz.TabIndex = 37;
            this.txt_NumColumnasMatriz.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_NumColumnasMatriz_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(118, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(333, 42);
            this.label3.TabIndex = 44;
            this.label3.Text = "De cuantas columnas quiere la matriz :\r\n\r\n";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(104, 287);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(136, 19);
            this.label6.TabIndex = 43;
            this.label6.Text = "MATRIZ INGRESADA";
            // 
            // txt_LlenadoMatriz
            // 
            this.txt_LlenadoMatriz.Location = new System.Drawing.Point(427, 236);
            this.txt_LlenadoMatriz.Name = "txt_LlenadoMatriz";
            this.txt_LlenadoMatriz.Size = new System.Drawing.Size(175, 23);
            this.txt_LlenadoMatriz.TabIndex = 38;
            this.txt_LlenadoMatriz.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_LlenadoMatriz_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(415, 239);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 19);
            this.label2.TabIndex = 42;
            this.label2.Text = ":";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(262, 235);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(159, 21);
            this.label7.TabIndex = 41;
            this.label7.Text = "Ingrese elemento ";
            // 
            // txt_NumFilasMatriz
            // 
            this.txt_NumFilasMatriz.Location = new System.Drawing.Point(457, 93);
            this.txt_NumFilasMatriz.Name = "txt_NumFilasMatriz";
            this.txt_NumFilasMatriz.Size = new System.Drawing.Size(166, 23);
            this.txt_NumFilasMatriz.TabIndex = 36;
            this.txt_NumFilasMatriz.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_NumFilasMatriz_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(118, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(284, 42);
            this.label5.TabIndex = 40;
            this.label5.Text = "De cuantas filas quiere la matriz :\r\n\r\n";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(75, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(674, 37);
            this.label1.TabIndex = 39;
            this.label1.Text = "ENCONTRAR ELEMENTO MAYOR DE CADA FILA\r\n";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(80)))), ((int)(((byte)(91)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(814, 77);
            this.panel1.TabIndex = 48;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(80)))), ((int)(((byte)(91)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(644, 536);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 36);
            this.button1.TabIndex = 49;
            this.button1.Text = "SALIR";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormTrece
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 594);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dataGredMatriz);
            this.Controls.Add(this.txt_NumColumnasMatriz);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_LlenadoMatriz);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_NumFilasMatriz);
            this.Controls.Add(this.label5);
            this.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormTrece";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGredMatriz)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dataGredMatriz;
        private System.Windows.Forms.DataGridViewTextBoxColumn C1;
        private System.Windows.Forms.DataGridViewTextBoxColumn C2;
        private System.Windows.Forms.DataGridViewTextBoxColumn C3;
        private System.Windows.Forms.TextBox txt_NumColumnasMatriz;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_LlenadoMatriz;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_NumFilasMatriz;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
    }
}

