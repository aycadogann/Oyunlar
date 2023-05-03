
namespace Oyunlar
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_A = new System.Windows.Forms.Button();
            this.btn_B = new System.Windows.Forms.Button();
            this.btn_C = new System.Windows.Forms.Button();
            this.btn_D = new System.Windows.Forms.Button();
            this.btn_Basla = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_Puan = new System.Windows.Forms.Label();
            this.lbl_Dogru = new System.Windows.Forms.Label();
            this.lbl_Soru = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbl_Sure = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 21);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(413, 104);
            this.textBox1.TabIndex = 0;
            // 
            // btn_A
            // 
            this.btn_A.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_A.Location = new System.Drawing.Point(55, 176);
            this.btn_A.Name = "btn_A";
            this.btn_A.Size = new System.Drawing.Size(149, 40);
            this.btn_A.TabIndex = 1;
            this.btn_A.Text = "A";
            this.btn_A.UseVisualStyleBackColor = true;
            this.btn_A.Click += new System.EventHandler(this.btn_A_Click);
            // 
            // btn_B
            // 
            this.btn_B.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_B.Location = new System.Drawing.Point(236, 176);
            this.btn_B.Name = "btn_B";
            this.btn_B.Size = new System.Drawing.Size(149, 40);
            this.btn_B.TabIndex = 2;
            this.btn_B.Text = "B";
            this.btn_B.UseVisualStyleBackColor = true;
            this.btn_B.Click += new System.EventHandler(this.btn_B_Click);
            // 
            // btn_C
            // 
            this.btn_C.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_C.Location = new System.Drawing.Point(55, 239);
            this.btn_C.Name = "btn_C";
            this.btn_C.Size = new System.Drawing.Size(149, 40);
            this.btn_C.TabIndex = 3;
            this.btn_C.Text = "C";
            this.btn_C.UseVisualStyleBackColor = true;
            this.btn_C.Click += new System.EventHandler(this.btn_C_Click);
            // 
            // btn_D
            // 
            this.btn_D.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_D.Location = new System.Drawing.Point(236, 239);
            this.btn_D.Name = "btn_D";
            this.btn_D.Size = new System.Drawing.Size(149, 40);
            this.btn_D.TabIndex = 4;
            this.btn_D.Text = "D";
            this.btn_D.UseVisualStyleBackColor = true;
            this.btn_D.Click += new System.EventHandler(this.btn_D_Click);
            // 
            // btn_Basla
            // 
            this.btn_Basla.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Basla.Location = new System.Drawing.Point(578, 32);
            this.btn_Basla.Name = "btn_Basla";
            this.btn_Basla.Size = new System.Drawing.Size(154, 56);
            this.btn_Basla.TabIndex = 5;
            this.btn_Basla.Text = "BAŞLA";
            this.btn_Basla.UseVisualStyleBackColor = true;
            this.btn_Basla.Click += new System.EventHandler(this.btn_Basla_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(460, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "Puan :";
            // 
            // lbl_Puan
            // 
            this.lbl_Puan.AutoSize = true;
            this.lbl_Puan.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Puan.ForeColor = System.Drawing.Color.White;
            this.lbl_Puan.Location = new System.Drawing.Point(530, 57);
            this.lbl_Puan.Name = "lbl_Puan";
            this.lbl_Puan.Size = new System.Drawing.Size(20, 24);
            this.lbl_Puan.TabIndex = 7;
            this.lbl_Puan.Text = "0";
            // 
            // lbl_Dogru
            // 
            this.lbl_Dogru.AutoSize = true;
            this.lbl_Dogru.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Dogru.ForeColor = System.Drawing.Color.White;
            this.lbl_Dogru.Location = new System.Drawing.Point(460, 133);
            this.lbl_Dogru.Name = "lbl_Dogru";
            this.lbl_Dogru.Size = new System.Drawing.Size(59, 24);
            this.lbl_Dogru.TabIndex = 8;
            this.lbl_Dogru.Text = "dogru";
            this.lbl_Dogru.Visible = false;
            // 
            // lbl_Soru
            // 
            this.lbl_Soru.AutoSize = true;
            this.lbl_Soru.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Soru.ForeColor = System.Drawing.Color.White;
            this.lbl_Soru.Location = new System.Drawing.Point(530, 95);
            this.lbl_Soru.Name = "lbl_Soru";
            this.lbl_Soru.Size = new System.Drawing.Size(20, 24);
            this.lbl_Soru.TabIndex = 10;
            this.lbl_Soru.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(460, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 24);
            this.label3.TabIndex = 9;
            this.label3.Text = "Soru :";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lbl_Sure
            // 
            this.lbl_Sure.AutoSize = true;
            this.lbl_Sure.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Sure.ForeColor = System.Drawing.Color.White;
            this.lbl_Sure.Location = new System.Drawing.Point(530, 21);
            this.lbl_Sure.Name = "lbl_Sure";
            this.lbl_Sure.Size = new System.Drawing.Size(20, 24);
            this.lbl_Sure.TabIndex = 12;
            this.lbl_Sure.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(460, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 24);
            this.label4.TabIndex = 11;
            this.label4.Text = "Süre :";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(744, 321);
            this.Controls.Add(this.lbl_Sure);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbl_Soru);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_Dogru);
            this.Controls.Add(this.lbl_Puan);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Basla);
            this.Controls.Add(this.btn_D);
            this.Controls.Add(this.btn_C);
            this.Controls.Add(this.btn_B);
            this.Controls.Add(this.btn_A);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bilgi Yarışması";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_A;
        private System.Windows.Forms.Button btn_B;
        private System.Windows.Forms.Button btn_C;
        private System.Windows.Forms.Button btn_D;
        private System.Windows.Forms.Button btn_Basla;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_Puan;
        private System.Windows.Forms.Label lbl_Dogru;
        private System.Windows.Forms.Label lbl_Soru;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbl_Sure;
        private System.Windows.Forms.Label label4;
    }
}