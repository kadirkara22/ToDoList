
namespace ToDoList
{
    partial class kayitListe
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.grpBoxListe = new System.Windows.Forms.GroupBox();
            this.grdListe = new System.Windows.Forms.DataGridView();
            this.btnTümListe = new System.Windows.Forms.Button();
            this.btnTamamlandı = new System.Windows.Forms.Button();
            this.btnTamamlanamadı = new System.Windows.Forms.Button();
            this.btnIptalEdildi = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.grpBoxListe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdListe)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnIptalEdildi);
            this.groupBox1.Controls.Add(this.btnTamamlanamadı);
            this.groupBox1.Controls.Add(this.btnTamamlandı);
            this.groupBox1.Controls.Add(this.btnTümListe);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(147, 374);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "İşlem Listesi";
            // 
            // grpBoxListe
            // 
            this.grpBoxListe.Controls.Add(this.grdListe);
            this.grpBoxListe.Location = new System.Drawing.Point(165, 12);
            this.grpBoxListe.Name = "grpBoxListe";
            this.grpBoxListe.Size = new System.Drawing.Size(662, 374);
            this.grpBoxListe.TabIndex = 1;
            this.grpBoxListe.TabStop = false;
            this.grpBoxListe.Text = "Liste";
            // 
            // grdListe
            // 
            this.grdListe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdListe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdListe.Location = new System.Drawing.Point(3, 16);
            this.grdListe.Name = "grdListe";
            this.grdListe.Size = new System.Drawing.Size(656, 355);
            this.grdListe.TabIndex = 0;
            // 
            // btnTümListe
            // 
            this.btnTümListe.Location = new System.Drawing.Point(6, 60);
            this.btnTümListe.Name = "btnTümListe";
            this.btnTümListe.Size = new System.Drawing.Size(135, 23);
            this.btnTümListe.TabIndex = 0;
            this.btnTümListe.Text = "Tüm Liste";
            this.btnTümListe.UseVisualStyleBackColor = true;
            this.btnTümListe.Click += new System.EventHandler(this.btnTümListe_Click);
            // 
            // btnTamamlandı
            // 
            this.btnTamamlandı.Location = new System.Drawing.Point(6, 89);
            this.btnTamamlandı.Name = "btnTamamlandı";
            this.btnTamamlandı.Size = new System.Drawing.Size(135, 23);
            this.btnTamamlandı.TabIndex = 0;
            this.btnTamamlandı.Text = "Tamamlandı";
            this.btnTamamlandı.UseVisualStyleBackColor = true;
            this.btnTamamlandı.Click += new System.EventHandler(this.btnTamamlandı_Click);
            // 
            // btnTamamlanamadı
            // 
            this.btnTamamlanamadı.Location = new System.Drawing.Point(6, 118);
            this.btnTamamlanamadı.Name = "btnTamamlanamadı";
            this.btnTamamlanamadı.Size = new System.Drawing.Size(135, 23);
            this.btnTamamlanamadı.TabIndex = 0;
            this.btnTamamlanamadı.Text = "Tamamlanamadı";
            this.btnTamamlanamadı.UseVisualStyleBackColor = true;
            this.btnTamamlanamadı.Click += new System.EventHandler(this.btnTamamlanamadı_Click);
            // 
            // btnIptalEdildi
            // 
            this.btnIptalEdildi.Location = new System.Drawing.Point(6, 147);
            this.btnIptalEdildi.Name = "btnIptalEdildi";
            this.btnIptalEdildi.Size = new System.Drawing.Size(135, 23);
            this.btnIptalEdildi.TabIndex = 0;
            this.btnIptalEdildi.Text = "İptal Edildi";
            this.btnIptalEdildi.UseVisualStyleBackColor = true;
            this.btnIptalEdildi.Click += new System.EventHandler(this.btnIptalEdildi_Click);
            // 
            // kayitListe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 398);
            this.Controls.Add(this.grpBoxListe);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "kayitListe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kayıt Liste";
            this.Load += new System.EventHandler(this.kayitListe_Load);
            this.groupBox1.ResumeLayout(false);
            this.grpBoxListe.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdListe)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnIptalEdildi;
        private System.Windows.Forms.Button btnTamamlanamadı;
        private System.Windows.Forms.Button btnTamamlandı;
        private System.Windows.Forms.Button btnTümListe;
        private System.Windows.Forms.GroupBox grpBoxListe;
        private System.Windows.Forms.DataGridView grdListe;
    }
}