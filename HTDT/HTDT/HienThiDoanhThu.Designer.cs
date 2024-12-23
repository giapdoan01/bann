namespace HTDT
{
    partial class HienThiDoanhThu
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
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.btnNgay = new System.Windows.Forms.Button();
            this.btnThang = new System.Windows.Forms.Button();
            this.btnNam = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(221, 151);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(408, 375);
            this.dataGridView2.TabIndex = 0;
            // 
            // btnNgay
            // 
            this.btnNgay.Location = new System.Drawing.Point(221, 103);
            this.btnNgay.Name = "btnNgay";
            this.btnNgay.Size = new System.Drawing.Size(132, 42);
            this.btnNgay.TabIndex = 1;
            this.btnNgay.Text = "Ngay";
            this.btnNgay.UseVisualStyleBackColor = true;
            this.btnNgay.Click += new System.EventHandler(this.btnNgay_Click);
            // 
            // btnThang
            // 
            this.btnThang.Location = new System.Drawing.Point(359, 103);
            this.btnThang.Name = "btnThang";
            this.btnThang.Size = new System.Drawing.Size(132, 42);
            this.btnThang.TabIndex = 2;
            this.btnThang.Text = "Thang";
            this.btnThang.UseVisualStyleBackColor = true;
            this.btnThang.Click += new System.EventHandler(this.btnThang_Click);
            // 
            // btnNam
            // 
            this.btnNam.Location = new System.Drawing.Point(497, 103);
            this.btnNam.Name = "btnNam";
            this.btnNam.Size = new System.Drawing.Size(132, 42);
            this.btnNam.TabIndex = 3;
            this.btnNam.Text = "Nam";
            this.btnNam.UseVisualStyleBackColor = true;
            this.btnNam.Click += new System.EventHandler(this.btnNam_Click);
            // 
            // HienThiDoanhThu
            // 
            this.BackgroundImage = global::HTDT.Properties.Resources.anhnen1_01;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(846, 566);
            this.Controls.Add(this.btnNam);
            this.Controls.Add(this.btnThang);
            this.Controls.Add(this.btnNgay);
            this.Controls.Add(this.dataGridView2);
            this.DoubleBuffered = true;
            this.Name = "HienThiDoanhThu";
            this.Load += new System.EventHandler(this.HienThiDoanhThu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button btnNgay;
        private System.Windows.Forms.Button btnThang;
        private System.Windows.Forms.Button btnNam;
    }
}

