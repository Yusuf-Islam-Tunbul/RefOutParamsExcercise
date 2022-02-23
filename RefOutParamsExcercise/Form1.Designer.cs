
namespace RefOutParamsExcercise
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
            this.standart_button = new System.Windows.Forms.Button();
            this.out_button = new System.Windows.Forms.Button();
            this.ref_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // standart_button
            // 
            this.standart_button.Location = new System.Drawing.Point(12, 12);
            this.standart_button.Name = "standart_button";
            this.standart_button.Size = new System.Drawing.Size(115, 50);
            this.standart_button.TabIndex = 0;
            this.standart_button.Text = "Standart İşlem";
            this.standart_button.UseVisualStyleBackColor = true;
            this.standart_button.Click += new System.EventHandler(this.standart_button_Click);
            // 
            // out_button
            // 
            this.out_button.Location = new System.Drawing.Point(12, 68);
            this.out_button.Name = "out_button";
            this.out_button.Size = new System.Drawing.Size(115, 50);
            this.out_button.TabIndex = 1;
            this.out_button.Text = "Out ile İşlem";
            this.out_button.UseVisualStyleBackColor = true;
            this.out_button.Click += new System.EventHandler(this.out_button_Click);
            // 
            // ref_button
            // 
            this.ref_button.Location = new System.Drawing.Point(12, 124);
            this.ref_button.Name = "ref_button";
            this.ref_button.Size = new System.Drawing.Size(115, 50);
            this.ref_button.TabIndex = 2;
            this.ref_button.Text = "Ref ile İşlem";
            this.ref_button.UseVisualStyleBackColor = true;
            this.ref_button.Click += new System.EventHandler(this.ref_button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(148, 185);
            this.Controls.Add(this.ref_button);
            this.Controls.Add(this.out_button);
            this.Controls.Add(this.standart_button);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button standart_button;
        private System.Windows.Forms.Button out_button;
        private System.Windows.Forms.Button ref_button;
    }
}

