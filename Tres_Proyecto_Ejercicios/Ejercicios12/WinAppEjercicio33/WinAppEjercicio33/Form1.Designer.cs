namespace WinAppEjercicio33
{
    partial class FormTreintaYTres
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
            this.lbl_respuesta = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGredMatriz = new System.Windows.Forms.DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_LlenadoMatriz = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_NumFilasMatriz = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGredMatriz)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_respuesta
            // 
            this.lbl_respuesta.AutoSize = true;
            this.lbl_respuesta.Location = new System.Drawing.Point(618, 406);
            this.lbl_respuesta.Name = "lbl_respuesta";
            this.lbl_respuesta.Size = new System.Drawing.Size(17, 19);
            this.lbl_respuesta.TabIndex = 71;
            this.lbl_respuesta.Text = "?";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(286, 406);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(308, 18);
            this.label4.TabIndex = 70;
            this.label4.Text = "El mayor elemento de la diagonal principal es:";
            // 
            // dataGredMatriz
            // 
            this.dataGredMatriz.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGredMatriz.Location = new System.Drawing.Point(22, 341);
            this.dataGredMatriz.Name = "dataGredMatriz";
            this.dataGredMatriz.RowHeadersWidth = 51;
            this.dataGredMatriz.RowTemplate.Height = 24;
            this.dataGredMatriz.Size = new System.Drawing.Size(258, 186);
            this.dataGredMatriz.TabIndex = 69;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(70, 309);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(136, 19);
            this.label10.TabIndex = 68;
            this.label10.Text = "MATRIZ INGRESADA\r\n";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(604, 74);
            this.label1.TabIndex = 67;
            this.label1.Text = "MAYOR ELEMENTO DIAGONAL PRINCIPAL\r\n\r\n";
            // 
            // txt_LlenadoMatriz
            // 
            this.txt_LlenadoMatriz.Location = new System.Drawing.Point(325, 184);
            this.txt_LlenadoMatriz.Name = "txt_LlenadoMatriz";
            this.txt_LlenadoMatriz.Size = new System.Drawing.Size(175, 23);
            this.txt_LlenadoMatriz.TabIndex = 62;
            this.txt_LlenadoMatriz.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_LlenadoMatriz_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(313, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 19);
            this.label2.TabIndex = 65;
            this.label2.Text = ":";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(160, 183);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(159, 21);
            this.label7.TabIndex = 64;
            this.label7.Text = "Ingrese elemento ";
            // 
            // txt_NumFilasMatriz
            // 
            this.txt_NumFilasMatriz.Location = new System.Drawing.Point(394, 101);
            this.txt_NumFilasMatriz.Name = "txt_NumFilasMatriz";
            this.txt_NumFilasMatriz.Size = new System.Drawing.Size(166, 23);
            this.txt_NumFilasMatriz.TabIndex = 60;
            this.txt_NumFilasMatriz.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_NumFilasMatriz_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(59, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(329, 42);
            this.label5.TabIndex = 63;
            this.label5.Text = "Ingrese numero para Filas Y Columnas:\r\n\r\n";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(80)))), ((int)(((byte)(91)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(674, 77);
            this.panel1.TabIndex = 72;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(80)))), ((int)(((byte)(91)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(489, 491);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 36);
            this.button1.TabIndex = 73;
            this.button1.Text = "SALIR";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormTreintaYTres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 554);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbl_respuesta);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGredMatriz);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txt_LlenadoMatriz);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_NumFilasMatriz);
            this.Controls.Add(this.label5);
            this.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormTreintaYTres";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TreintaYTres";
            ((System.ComponentModel.ISupportInitialize)(this.dataGredMatriz)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_respuesta;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGredMatriz;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_LlenadoMatriz;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_NumFilasMatriz;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
    }
}

