
namespace ks2
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.kdEksen = new System.Windows.Forms.Button();
            this.kontrolNok = new System.Windows.Forms.Button();
            this.bezierEgri = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // kdEksen
            // 
            this.kdEksen.Location = new System.Drawing.Point(8, 12);
            this.kdEksen.Name = "kdEksen";
            this.kdEksen.Size = new System.Drawing.Size(95, 45);
            this.kdEksen.TabIndex = 0;
            this.kdEksen.Text = "Koordinat Eksenlerini Çiz";
            this.kdEksen.UseVisualStyleBackColor = true;
            this.kdEksen.Click += new System.EventHandler(this.kdEksen_Click);
            // 
            // kontrolNok
            // 
            this.kontrolNok.Location = new System.Drawing.Point(8, 84);
            this.kontrolNok.Name = "kontrolNok";
            this.kontrolNok.Size = new System.Drawing.Size(95, 40);
            this.kontrolNok.TabIndex = 1;
            this.kontrolNok.Text = "Kontrol Noktalarını Çiz";
            this.kontrolNok.UseVisualStyleBackColor = true;
            this.kontrolNok.Click += new System.EventHandler(this.kontrolNok_Click);
            // 
            // bezierEgri
            // 
            this.bezierEgri.Location = new System.Drawing.Point(8, 156);
            this.bezierEgri.Name = "bezierEgri";
            this.bezierEgri.Size = new System.Drawing.Size(95, 43);
            this.bezierEgri.TabIndex = 2;
            this.bezierEgri.Text = "Bezier Eğrisi Çiz";
            this.bezierEgri.Click += new System.EventHandler(this.bezierEgri_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.bezierEgri);
            this.Controls.Add(this.kontrolNok);
            this.Controls.Add(this.kdEksen);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button kdEksen;
        private System.Windows.Forms.Button kontrolNok;
        private System.Windows.Forms.Button bezierEgri;
    }
}

