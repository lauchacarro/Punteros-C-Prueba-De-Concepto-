namespace Punteros.UI
{
    partial class FrmPunteros
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
            this.btnPosiciones = new System.Windows.Forms.Button();
            this.lstPosiciones = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lstValores = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnIncrementar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtValorIncrementar = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPunteroIncrementar = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lstPosicionArray = new System.Windows.Forms.ListBox();
            this.label9 = new System.Windows.Forms.Label();
            this.lstValorItemArray = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lstItemsArray = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnCopiar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCopiarDestino = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCopiarOrigen = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPosiciones
            // 
            this.btnPosiciones.Location = new System.Drawing.Point(49, 189);
            this.btnPosiciones.Name = "btnPosiciones";
            this.btnPosiciones.Size = new System.Drawing.Size(120, 23);
            this.btnPosiciones.TabIndex = 0;
            this.btnPosiciones.Text = "Crear Punteros";
            this.btnPosiciones.UseVisualStyleBackColor = true;
            this.btnPosiciones.Click += new System.EventHandler(this.BtnPosiciones_Click);
            // 
            // lstPosiciones
            // 
            this.lstPosiciones.FormattingEnabled = true;
            this.lstPosiciones.Location = new System.Drawing.Point(49, 64);
            this.lstPosiciones.Name = "lstPosiciones";
            this.lstPosiciones.Size = new System.Drawing.Size(120, 95);
            this.lstPosiciones.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Posiciones En Memoria";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(218, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Valores En Esas Posiciones";
            // 
            // lstValores
            // 
            this.lstValores.FormattingEnabled = true;
            this.lstValores.Location = new System.Drawing.Point(221, 64);
            this.lstValores.Name = "lstValores";
            this.lstValores.Size = new System.Drawing.Size(120, 95);
            this.lstValores.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lstValores);
            this.groupBox1.Controls.Add(this.btnPosiciones);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lstPosiciones);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(393, 239);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Declaración de punteros";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnIncrementar);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtValorIncrementar);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtPunteroIncrementar);
            this.groupBox2.Location = new System.Drawing.Point(12, 279);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(393, 100);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Incrementar Valor En Memoria";
            // 
            // btnIncrementar
            // 
            this.btnIncrementar.Enabled = false;
            this.btnIncrementar.Location = new System.Drawing.Point(289, 51);
            this.btnIncrementar.Name = "btnIncrementar";
            this.btnIncrementar.Size = new System.Drawing.Size(75, 23);
            this.btnIncrementar.TabIndex = 6;
            this.btnIncrementar.Text = "Incrementar";
            this.btnIncrementar.UseVisualStyleBackColor = true;
            this.btnIncrementar.Click += new System.EventHandler(this.BtnIncrementar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(163, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Valor En Esa Posición";
            // 
            // txtValorIncrementar
            // 
            this.txtValorIncrementar.Enabled = false;
            this.txtValorIncrementar.Location = new System.Drawing.Point(168, 51);
            this.txtValorIncrementar.Name = "txtValorIncrementar";
            this.txtValorIncrementar.Size = new System.Drawing.Size(100, 20);
            this.txtValorIncrementar.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Posición En Memoria";
            // 
            // txtPunteroIncrementar
            // 
            this.txtPunteroIncrementar.Enabled = false;
            this.txtPunteroIncrementar.Location = new System.Drawing.Point(30, 51);
            this.txtPunteroIncrementar.Name = "txtPunteroIncrementar";
            this.txtPunteroIncrementar.Size = new System.Drawing.Size(100, 20);
            this.txtPunteroIncrementar.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lstPosicionArray);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.lstValorItemArray);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.lstItemsArray);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Location = new System.Drawing.Point(411, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(393, 239);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Declarar Array Con Punteros";
            // 
            // lstPosicionArray
            // 
            this.lstPosicionArray.FormattingEnabled = true;
            this.lstPosicionArray.Location = new System.Drawing.Point(11, 64);
            this.lstPosicionArray.Name = "lstPosicionArray";
            this.lstPosicionArray.Size = new System.Drawing.Size(120, 95);
            this.lstPosicionArray.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 30);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(117, 13);
            this.label9.TabIndex = 6;
            this.label9.Text = "Posiciones En Memoria";
            // 
            // lstValorItemArray
            // 
            this.lstValorItemArray.FormattingEnabled = true;
            this.lstValorItemArray.Location = new System.Drawing.Point(263, 64);
            this.lstValorItemArray.Name = "lstValorItemArray";
            this.lstValorItemArray.Size = new System.Drawing.Size(120, 95);
            this.lstValorItemArray.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(271, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Valor De Cada Item";
            // 
            // lstItemsArray
            // 
            this.lstItemsArray.FormattingEnabled = true;
            this.lstItemsArray.Location = new System.Drawing.Point(137, 64);
            this.lstItemsArray.Name = "lstItemsArray";
            this.lstItemsArray.Size = new System.Drawing.Size(120, 95);
            this.lstItemsArray.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(125, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(147, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Index De Cada Item Del Array";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnCopiar);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.txtCopiarDestino);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.txtCopiarOrigen);
            this.groupBox4.Location = new System.Drawing.Point(411, 279);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(393, 100);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Copiar Una Matriz De Bytes Con Punteros ";
            // 
            // btnCopiar
            // 
            this.btnCopiar.Location = new System.Drawing.Point(290, 51);
            this.btnCopiar.Name = "btnCopiar";
            this.btnCopiar.Size = new System.Drawing.Size(75, 23);
            this.btnCopiar.TabIndex = 11;
            this.btnCopiar.Text = "Copiar";
            this.btnCopiar.UseVisualStyleBackColor = true;
            this.btnCopiar.Click += new System.EventHandler(this.BtnCopiar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(164, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Destino";
            // 
            // txtCopiarDestino
            // 
            this.txtCopiarDestino.Enabled = false;
            this.txtCopiarDestino.Location = new System.Drawing.Point(169, 51);
            this.txtCopiarDestino.Name = "txtCopiarDestino";
            this.txtCopiarDestino.Size = new System.Drawing.Size(100, 20);
            this.txtCopiarDestino.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(28, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Dato Origen";
            // 
            // txtCopiarOrigen
            // 
            this.txtCopiarOrigen.Location = new System.Drawing.Point(31, 51);
            this.txtCopiarOrigen.Name = "txtCopiarOrigen";
            this.txtCopiarOrigen.Size = new System.Drawing.Size(100, 20);
            this.txtCopiarOrigen.TabIndex = 7;
            // 
            // FrmPunteros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 450);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(880, 489);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(880, 489);
            this.Name = "FrmPunteros";
            this.Text = "Punteros";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPosiciones;
        private System.Windows.Forms.ListBox lstPosiciones;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lstValores;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnIncrementar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtValorIncrementar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPunteroIncrementar;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox lstValorItemArray;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox lstItemsArray;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnCopiar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCopiarDestino;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCopiarOrigen;
        private System.Windows.Forms.ListBox lstPosicionArray;
        private System.Windows.Forms.Label label9;
    }
}

