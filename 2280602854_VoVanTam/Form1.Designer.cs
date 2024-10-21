namespace _2280602854_VoVanTam
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
            this.dgvBenhNhan = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMaBN = new System.Windows.Forms.TextBox();
            this.txtTenBN = new System.Windows.Forms.TextBox();
            this.cmbTinhTrang = new System.Windows.Forms.ComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.rtbGhiChu = new System.Windows.Forms.RichTextBox();
            this.cmbLayNhiem = new System.Windows.Forms.ComboBox();
            this.chứcNăngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.truyVếtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MaBN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenBN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TinhTrang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GhiChu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LayNhiem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBenhNhan)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvBenhNhan
            // 
            this.dgvBenhNhan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBenhNhan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBenhNhan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaBN,
            this.TenBN,
            this.TinhTrang,
            this.GhiChu,
            this.LayNhiem});
            this.dgvBenhNhan.Location = new System.Drawing.Point(360, 96);
            this.dgvBenhNhan.Name = "dgvBenhNhan";
            this.dgvBenhNhan.Size = new System.Drawing.Size(430, 290);
            this.dgvBenhNhan.TabIndex = 0;
            this.dgvBenhNhan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBenhNhan_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rtbGhiChu);
            this.groupBox1.Controls.Add(this.cmbLayNhiem);
            this.groupBox1.Controls.Add(this.cmbTinhTrang);
            this.groupBox1.Controls.Add(this.txtTenBN);
            this.groupBox1.Controls.Add(this.txtMaBN);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 96);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(327, 315);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(159, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(578, 36);
            this.label1.TabIndex = 2;
            this.label1.Text = "Thông tin ca bệnh Covid-19 tại Việt Nam";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã BN";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tên BN";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(26, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "Tình trạng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(26, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 15);
            this.label5.TabIndex = 3;
            this.label5.Text = "Ghi chú";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 265);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 15);
            this.label6.TabIndex = 4;
            this.label6.Text = "Lây nhiễm từ";
            // 
            // txtMaBN
            // 
            this.txtMaBN.Location = new System.Drawing.Point(102, 30);
            this.txtMaBN.Name = "txtMaBN";
            this.txtMaBN.Size = new System.Drawing.Size(95, 20);
            this.txtMaBN.TabIndex = 5;
            // 
            // txtTenBN
            // 
            this.txtTenBN.Location = new System.Drawing.Point(102, 72);
            this.txtTenBN.Name = "txtTenBN";
            this.txtTenBN.Size = new System.Drawing.Size(100, 20);
            this.txtTenBN.TabIndex = 6;
            // 
            // cmbTinhTrang
            // 
            this.cmbTinhTrang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTinhTrang.FormattingEnabled = true;
            this.cmbTinhTrang.Location = new System.Drawing.Point(101, 111);
            this.cmbTinhTrang.Name = "cmbTinhTrang";
            this.cmbTinhTrang.Size = new System.Drawing.Size(121, 21);
            this.cmbTinhTrang.TabIndex = 9;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chứcNăngToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(816, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Location = new System.Drawing.Point(77, 437);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(75, 23);
            this.btnCapNhat.TabIndex = 4;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(223, 437);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 6;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // rtbGhiChu
            // 
            this.rtbGhiChu.Location = new System.Drawing.Point(97, 146);
            this.rtbGhiChu.Name = "rtbGhiChu";
            this.rtbGhiChu.Size = new System.Drawing.Size(154, 96);
            this.rtbGhiChu.TabIndex = 10;
            this.rtbGhiChu.Text = "";
            // 
            // cmbLayNhiem
            // 
            this.cmbLayNhiem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLayNhiem.FormattingEnabled = true;
            this.cmbLayNhiem.Location = new System.Drawing.Point(97, 259);
            this.cmbLayNhiem.Name = "cmbLayNhiem";
            this.cmbLayNhiem.Size = new System.Drawing.Size(121, 21);
            this.cmbLayNhiem.TabIndex = 9;
            // 
            // chứcNăngToolStripMenuItem
            // 
            this.chứcNăngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.truyVếtToolStripMenuItem,
            this.thoátToolStripMenuItem});
            this.chứcNăngToolStripMenuItem.Name = "chứcNăngToolStripMenuItem";
            this.chứcNăngToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.chứcNăngToolStripMenuItem.Text = "Chức năng";
            // 
            // truyVếtToolStripMenuItem
            // 
            this.truyVếtToolStripMenuItem.Name = "truyVếtToolStripMenuItem";
            this.truyVếtToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.truyVếtToolStripMenuItem.Text = "Truy vết Ctrl+T";
            this.truyVếtToolStripMenuItem.Click += new System.EventHandler(this.truyVếtToolStripMenuItem_Click);
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.thoátToolStripMenuItem.Text = "Thoát";
            this.thoátToolStripMenuItem.Click += new System.EventHandler(this.thoátToolStripMenuItem_Click);
            // 
            // MaBN
            // 
            this.MaBN.HeaderText = "Mã BN";
            this.MaBN.Name = "MaBN";
            // 
            // TenBN
            // 
            this.TenBN.HeaderText = "Tên BN";
            this.TenBN.Name = "TenBN";
            // 
            // TinhTrang
            // 
            this.TinhTrang.HeaderText = "Tình Trạng";
            this.TinhTrang.Name = "TinhTrang";
            // 
            // GhiChu
            // 
            this.GhiChu.HeaderText = "Ghi Chú";
            this.GhiChu.Name = "GhiChu";
            // 
            // LayNhiem
            // 
            this.LayNhiem.HeaderText = "Cấp độ lây nhiễm";
            this.LayNhiem.Name = "LayNhiem";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 492);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnCapNhat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvBenhNhan);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBenhNhan)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBenhNhan;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbTinhTrang;
        private System.Windows.Forms.TextBox txtTenBN;
        private System.Windows.Forms.TextBox txtMaBN;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.RichTextBox rtbGhiChu;
        private System.Windows.Forms.ComboBox cmbLayNhiem;
        private System.Windows.Forms.ToolStripMenuItem chứcNăngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem truyVếtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaBN;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenBN;
        private System.Windows.Forms.DataGridViewTextBoxColumn TinhTrang;
        private System.Windows.Forms.DataGridViewTextBoxColumn GhiChu;
        private System.Windows.Forms.DataGridViewTextBoxColumn LayNhiem;
    }
}

