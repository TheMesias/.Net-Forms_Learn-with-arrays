namespace WinAppEjercicio8
{
    partial class FormOcho
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
            this.label7 = new System.Windows.Forms.Label();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_LlenarVector = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_NumElemento = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.txt_NumElementosVector = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_ElementoEliminar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(563, 372);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(122, 17);
            this.label7.TabIndex = 25;
            this.label7.Text = "NUEVO VECTOR \r\n";
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 16;
            this.listBox2.Location = new System.Drawing.Point(511, 406);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(226, 164);
            this.listBox2.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(554, 155);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(151, 17);
            this.label6.TabIndex = 23;
            this.label6.Text = "VECTOR INGRESADO";
            // 
            // txt_LlenarVector
            // 
            this.txt_LlenarVector.Location = new System.Drawing.Point(218, 260);
            this.txt_LlenarVector.Name = "txt_LlenarVector";
            this.txt_LlenarVector.Size = new System.Drawing.Size(175, 22);
            this.txt_LlenarVector.TabIndex = 16;
            this.txt_LlenarVector.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_LlenarVector_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(197, 264);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(12, 17);
            this.label5.TabIndex = 22;
            this.label5.Text = ":";
            // 
            // lbl_NumElemento
            // 
            this.lbl_NumElemento.AutoSize = true;
            this.lbl_NumElemento.Location = new System.Drawing.Point(170, 263);
            this.lbl_NumElemento.Name = "lbl_NumElemento";
            this.lbl_NumElemento.Size = new System.Drawing.Size(16, 17);
            this.lbl_NumElemento.TabIndex = 21;
            this.lbl_NumElemento.Text = "1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 259);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(159, 21);
            this.label4.TabIndex = 20;
            this.label4.Text = "Ingrese elemento ";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(511, 187);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(226, 164);
            this.listBox1.TabIndex = 19;
            // 
            // txt_NumElementosVector
            // 
            this.txt_NumElementosVector.Location = new System.Drawing.Point(363, 90);
            this.txt_NumElementosVector.Name = "txt_NumElementosVector";
            this.txt_NumElementosVector.Size = new System.Drawing.Size(310, 22);
            this.txt_NumElementosVector.TabIndex = 14;
            this.txt_NumElementosVector.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_NumElementosVector_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(345, 42);
            this.label3.TabIndex = 17;
            this.label3.Text = "De cuantos elementos quiere el vector :\r\n\r\n";
            // 
            // txt_ElementoEliminar
            // 
            this.txt_ElementoEliminar.Location = new System.Drawing.Point(363, 490);
            this.txt_ElementoEliminar.Name = "txt_ElementoEliminar";
            this.txt_ElementoEliminar.Size = new System.Drawing.Size(127, 22);
            this.txt_ElementoEliminar.TabIndex = 18;
            this.txt_ElementoEliminar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_ElementoEliminar_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 493);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(345, 21);
            this.label2.TabIndex = 15;
            this.label2.Text = "Ingrese el elemento que quiere eliminar: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(93, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(572, 37);
            this.label1.TabIndex = 13;
            this.label1.Text = "ELIMINAR UN ELEMENTO DE UN VECTOR";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(80)))), ((int)(((byte)(91)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(749, 73);
            this.panel1.TabIndex = 26;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(80)))), ((int)(((byte)(91)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(591, 625);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 36);
            this.button1.TabIndex = 37;
            this.button1.Text = "SALIR";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormOcho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 673);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_LlenarVector);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbl_NumElemento);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.txt_NumElementosVector);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_ElementoEliminar);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormOcho";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ocho";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_LlenarVector;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_NumElemento;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox txt_NumElementosVector;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_ElementoEliminar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
    }
}

