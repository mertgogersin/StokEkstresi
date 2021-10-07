
namespace StokEkstresi
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
            this.txtMalKodu = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBaslangicTarihi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBitisTarihi = new System.Windows.Forms.TextBox();
            this.btnAra = new System.Windows.Forms.Button();
            this.gcStokEkstresi = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.gcStokEkstresi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMalKodu
            // 
            this.txtMalKodu.Location = new System.Drawing.Point(235, 37);
            this.txtMalKodu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMalKodu.Name = "txtMalKodu";
            this.txtMalKodu.Size = new System.Drawing.Size(214, 26);
            this.txtMalKodu.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mal Kodu : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Başlangıç Tarihi : ";
            // 
            // txtBaslangicTarihi
            // 
            this.txtBaslangicTarihi.Location = new System.Drawing.Point(235, 84);
            this.txtBaslangicTarihi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBaslangicTarihi.Name = "txtBaslangicTarihi";
            this.txtBaslangicTarihi.Size = new System.Drawing.Size(214, 26);
            this.txtBaslangicTarihi.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(68, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Bitiş Tarihi : ";
            // 
            // txtBitisTarihi
            // 
            this.txtBitisTarihi.Location = new System.Drawing.Point(235, 131);
            this.txtBitisTarihi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBitisTarihi.Name = "txtBitisTarihi";
            this.txtBitisTarihi.Size = new System.Drawing.Size(214, 26);
            this.txtBitisTarihi.TabIndex = 4;
            // 
            // btnAra
            // 
            this.btnAra.Location = new System.Drawing.Point(490, 37);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(147, 120);
            this.btnAra.TabIndex = 6;
            this.btnAra.Text = "ARA";
            this.btnAra.UseVisualStyleBackColor = true;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // gcStokEkstresi
            // 
            this.gcStokEkstresi.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gcStokEkstresi.Location = new System.Drawing.Point(0, 174);
            this.gcStokEkstresi.MainView = this.gridView1;
            this.gcStokEkstresi.Name = "gcStokEkstresi";
            this.gcStokEkstresi.Size = new System.Drawing.Size(900, 477);
            this.gcStokEkstresi.TabIndex = 7;
            this.gcStokEkstresi.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gcStokEkstresi;
            this.gridView1.Name = "gridView1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 651);
            this.Controls.Add(this.gcStokEkstresi);
            this.Controls.Add(this.btnAra);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBitisTarihi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBaslangicTarihi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMalKodu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gcStokEkstresi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMalKodu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBaslangicTarihi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBitisTarihi;
        private System.Windows.Forms.Button btnAra;
        private DevExpress.XtraGrid.GridControl gcStokEkstresi;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
    }
}

