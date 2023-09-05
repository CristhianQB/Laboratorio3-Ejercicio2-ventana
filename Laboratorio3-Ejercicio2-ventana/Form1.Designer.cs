namespace Laboratorio3_Ejercicio2_ventana
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            txtb1 = new System.Windows.Forms.TextBox();
            label5 = new System.Windows.Forms.Label();
            txtb2 = new System.Windows.Forms.TextBox();
            label6 = new System.Windows.Forms.Label();
            lbl = new System.Windows.Forms.Label();
            button1 = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(59, 24);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(97, 28);
            label1.TabIndex = 0;
            label1.Text = "Categoría";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(186, 30);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(103, 21);
            label2.TabIndex = 1;
            label2.Text = "3 Estrellas (0)";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label3.Location = new System.Drawing.Point(314, 31);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(103, 21);
            label3.TabIndex = 2;
            label3.Text = "5 Estrellas (1)";
            // 
            // txtb1
            // 
            txtb1.Location = new System.Drawing.Point(281, 67);
            txtb1.Name = "txtb1";
            txtb1.Size = new System.Drawing.Size(43, 23);
            txtb1.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label5.Location = new System.Drawing.Point(126, 136);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(159, 21);
            label5.TabIndex = 5;
            label5.Text = "¿Cuántos días estará?";
            // 
            // txtb2
            // 
            txtb2.Location = new System.Drawing.Point(164, 173);
            txtb2.Name = "txtb2";
            txtb2.Size = new System.Drawing.Size(86, 23);
            txtb2.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label6.Location = new System.Drawing.Point(152, 280);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(63, 28);
            label6.TabIndex = 7;
            label6.Text = "Total :";
            // 
            // lbl
            // 
            lbl.AutoSize = true;
            lbl.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbl.Location = new System.Drawing.Point(221, 273);
            lbl.Name = "lbl";
            lbl.Size = new System.Drawing.Size(62, 37);
            lbl.TabIndex = 8;
            lbl.Text = "000";
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(186, 331);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(78, 40);
            button1.TabIndex = 9;
            button1.Text = "Calcular";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(474, 450);
            Controls.Add(button1);
            Controls.Add(lbl);
            Controls.Add(label6);
            Controls.Add(txtb2);
            Controls.Add(label5);
            Controls.Add(txtb1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtb1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtb2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Button button1;
    }
}
