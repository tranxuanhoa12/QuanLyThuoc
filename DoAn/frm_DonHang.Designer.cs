namespace DoAn
{
    partial class frm_DonHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_DonHang));
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_madh = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_makhDH = new System.Windows.Forms.TextBox();
            this.dtp_ngaydathang = new System.Windows.Forms.DateTimePicker();
            this.btn_taodonhang = new System.Windows.Forms.Button();
            this.dtgv_donhang = new System.Windows.Forms.DataGridView();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_xoá = new System.Windows.Forms.Button();
            this.btn_xemchitiet = new System.Windows.Forms.Button();
            this.btn_nhaplai = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_donhang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(330, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 26);
            this.label1.TabIndex = 3;
            this.label1.Text = "Đơn Hàng";
            // 
            // lbl_madh
            // 
            this.lbl_madh.AutoSize = true;
            this.lbl_madh.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_madh.Location = new System.Drawing.Point(50, 110);
            this.lbl_madh.Name = "lbl_madh";
            this.lbl_madh.Size = new System.Drawing.Size(166, 24);
            this.lbl_madh.TabIndex = 6;
            this.lbl_madh.Text = "Mã Khách Hàng:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(50, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 24);
            this.label2.TabIndex = 7;
            this.label2.Text = "Ngày Đặt Hàng:";
            // 
            // txt_makhDH
            // 
            this.txt_makhDH.Location = new System.Drawing.Point(218, 110);
            this.txt_makhDH.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_makhDH.Name = "txt_makhDH";
            this.txt_makhDH.Size = new System.Drawing.Size(264, 26);
            this.txt_makhDH.TabIndex = 8;
            // 
            // dtp_ngaydathang
            // 
            this.dtp_ngaydathang.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_ngaydathang.Location = new System.Drawing.Point(218, 188);
            this.dtp_ngaydathang.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtp_ngaydathang.Name = "dtp_ngaydathang";
            this.dtp_ngaydathang.Size = new System.Drawing.Size(264, 26);
            this.dtp_ngaydathang.TabIndex = 9;
            // 
            // btn_taodonhang
            // 
            this.btn_taodonhang.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_taodonhang.Location = new System.Drawing.Point(63, 270);
            this.btn_taodonhang.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_taodonhang.Name = "btn_taodonhang";
            this.btn_taodonhang.Size = new System.Drawing.Size(135, 48);
            this.btn_taodonhang.TabIndex = 10;
            this.btn_taodonhang.Text = "TẠO ĐƠN HÀNG";
            this.btn_taodonhang.UseVisualStyleBackColor = true;
            this.btn_taodonhang.Click += new System.EventHandler(this.btn_taodonhang_Click);
            // 
            // dtgv_donhang
            // 
            this.dtgv_donhang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_donhang.Location = new System.Drawing.Point(54, 434);
            this.dtgv_donhang.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtgv_donhang.Name = "dtgv_donhang";
            this.dtgv_donhang.RowHeadersWidth = 51;
            this.dtgv_donhang.RowTemplate.Height = 24;
            this.dtgv_donhang.Size = new System.Drawing.Size(885, 243);
            this.dtgv_donhang.TabIndex = 11;
            this.dtgv_donhang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_donhang_CellClick);
            // 
            // btn_sua
            // 
            this.btn_sua.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sua.Location = new System.Drawing.Point(218, 270);
            this.btn_sua.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(135, 48);
            this.btn_sua.TabIndex = 16;
            this.btn_sua.Text = "SỬA";
            this.btn_sua.UseVisualStyleBackColor = true;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_xoá
            // 
            this.btn_xoá.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xoá.Location = new System.Drawing.Point(378, 270);
            this.btn_xoá.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_xoá.Name = "btn_xoá";
            this.btn_xoá.Size = new System.Drawing.Size(135, 48);
            this.btn_xoá.TabIndex = 17;
            this.btn_xoá.Text = "XOÁ";
            this.btn_xoá.UseVisualStyleBackColor = true;
            this.btn_xoá.Click += new System.EventHandler(this.btn_xoá_Click);
            // 
            // btn_xemchitiet
            // 
            this.btn_xemchitiet.BackColor = System.Drawing.Color.Yellow;
            this.btn_xemchitiet.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xemchitiet.ForeColor = System.Drawing.Color.Red;
            this.btn_xemchitiet.Location = new System.Drawing.Point(507, 355);
            this.btn_xemchitiet.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_xemchitiet.Name = "btn_xemchitiet";
            this.btn_xemchitiet.Size = new System.Drawing.Size(228, 59);
            this.btn_xemchitiet.TabIndex = 18;
            this.btn_xemchitiet.Text = "XEM CHI TIẾT ĐƠN HÀNG";
            this.btn_xemchitiet.UseVisualStyleBackColor = false;
            this.btn_xemchitiet.Click += new System.EventHandler(this.btn_xemchitiet_Click);
            // 
            // btn_nhaplai
            // 
            this.btn_nhaplai.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_nhaplai.Location = new System.Drawing.Point(536, 270);
            this.btn_nhaplai.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_nhaplai.Name = "btn_nhaplai";
            this.btn_nhaplai.Size = new System.Drawing.Size(122, 48);
            this.btn_nhaplai.TabIndex = 24;
            this.btn_nhaplai.Text = "NHẬP LẠI";
            this.btn_nhaplai.UseVisualStyleBackColor = true;
            this.btn_nhaplai.Click += new System.EventHandler(this.btn_nhaplai_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(722, 30);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(217, 249);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // frm_DonHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1047, 726);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_nhaplai);
            this.Controls.Add(this.btn_xemchitiet);
            this.Controls.Add(this.btn_xoá);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.dtgv_donhang);
            this.Controls.Add(this.btn_taodonhang);
            this.Controls.Add(this.dtp_ngaydathang);
            this.Controls.Add(this.txt_makhDH);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_madh);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frm_DonHang";
            this.Text = "Đơn Hàng";
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_donhang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_madh;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_makhDH;
        private System.Windows.Forms.DateTimePicker dtp_ngaydathang;
        private System.Windows.Forms.Button btn_taodonhang;
        private System.Windows.Forms.DataGridView dtgv_donhang;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_xoá;
        private System.Windows.Forms.Button btn_xemchitiet;
        private System.Windows.Forms.Button btn_nhaplai;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}