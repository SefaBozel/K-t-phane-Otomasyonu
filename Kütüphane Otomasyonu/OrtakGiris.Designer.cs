namespace Kütüphane_Otomasyonu
{
    partial class OrtakGiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrtakGiris));
            this.btn_YGiris = new System.Windows.Forms.Button();
            this.btn_PGiris = new System.Windows.Forms.Button();
            this.btn_KGiris = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_YGiris
            // 
            this.btn_YGiris.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_YGiris.Location = new System.Drawing.Point(177, 72);
            this.btn_YGiris.Name = "btn_YGiris";
            this.btn_YGiris.Size = new System.Drawing.Size(191, 96);
            this.btn_YGiris.TabIndex = 0;
            this.btn_YGiris.Text = "Yönetici Girişi";
            this.btn_YGiris.UseVisualStyleBackColor = true;
            this.btn_YGiris.Click += new System.EventHandler(this.btn_YGiris_Click);
            // 
            // btn_PGiris
            // 
            this.btn_PGiris.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_PGiris.Location = new System.Drawing.Point(66, 222);
            this.btn_PGiris.Name = "btn_PGiris";
            this.btn_PGiris.Size = new System.Drawing.Size(191, 96);
            this.btn_PGiris.TabIndex = 1;
            this.btn_PGiris.Text = "Personel Giriş";
            this.btn_PGiris.UseVisualStyleBackColor = true;
            this.btn_PGiris.Click += new System.EventHandler(this.btn_PGiris_Click);
            // 
            // btn_KGiris
            // 
            this.btn_KGiris.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_KGiris.Location = new System.Drawing.Point(304, 222);
            this.btn_KGiris.Name = "btn_KGiris";
            this.btn_KGiris.Size = new System.Drawing.Size(191, 96);
            this.btn_KGiris.TabIndex = 2;
            this.btn_KGiris.Text = "Kullanıcı Girişi";
            this.btn_KGiris.UseVisualStyleBackColor = true;
            this.btn_KGiris.Click += new System.EventHandler(this.btn_KGiris_Click);
            // 
            // OrtakGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(545, 467);
            this.Controls.Add(this.btn_KGiris);
            this.Controls.Add(this.btn_PGiris);
            this.Controls.Add(this.btn_YGiris);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "OrtakGiris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giriş";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_YGiris;
        private System.Windows.Forms.Button btn_PGiris;
        private System.Windows.Forms.Button btn_KGiris;
    }
}