
namespace Oyunlar
{
    partial class Form1
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
            this.btn_BilgiYarismasi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_BilgiYarismasi
            // 
            this.btn_BilgiYarismasi.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_BilgiYarismasi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_BilgiYarismasi.Location = new System.Drawing.Point(12, 12);
            this.btn_BilgiYarismasi.Name = "btn_BilgiYarismasi";
            this.btn_BilgiYarismasi.Size = new System.Drawing.Size(125, 75);
            this.btn_BilgiYarismasi.TabIndex = 0;
            this.btn_BilgiYarismasi.Text = "Bilgi Yarışması";
            this.btn_BilgiYarismasi.UseVisualStyleBackColor = false;
            this.btn_BilgiYarismasi.Click += new System.EventHandler(this.btn_BilgiYarismasi_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(563, 441);
            this.Controls.Add(this.btn_BilgiYarismasi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ana Sayfa";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_BilgiYarismasi;
    }
}

