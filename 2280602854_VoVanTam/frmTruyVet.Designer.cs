namespace _2280602854_VoVanTam
{
    partial class frmTruyVet
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbBenhNhan = new System.Windows.Forms.ComboBox();
            this.dgvTruyVet = new System.Windows.Forms.DataGridView();
            this.MaBN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenBN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TinhTrang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CapDoLayNhiem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTruyVet)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbBenhNhan);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(162, 75);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(318, 124);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Truy vết theo nguồn lây nhiễm từ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bệnh nhân";
            // 
            // cmbBenhNhan
            // 
            this.cmbBenhNhan.FormattingEnabled = true;
            this.cmbBenhNhan.Location = new System.Drawing.Point(86, 49);
            this.cmbBenhNhan.Name = "cmbBenhNhan";
            this.cmbBenhNhan.Size = new System.Drawing.Size(173, 21);
            this.cmbBenhNhan.TabIndex = 1;
            this.cmbBenhNhan.SelectedIndexChanged += new System.EventHandler(this.cmbBenhNhan_SelectedIndexChanged);
            // 
            // dgvTruyVet
            // 
            this.dgvTruyVet.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTruyVet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTruyVet.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaBN,
            this.TenBN,
            this.TinhTrang,
            this.CapDoLayNhiem});
            this.dgvTruyVet.Location = new System.Drawing.Point(12, 223);
            this.dgvTruyVet.Name = "dgvTruyVet";
            this.dgvTruyVet.Size = new System.Drawing.Size(626, 274);
            this.dgvTruyVet.TabIndex = 1;
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
            // CapDoLayNhiem
            // 
            this.CapDoLayNhiem.HeaderText = "Cấp độ lây nhiễm";
            this.CapDoLayNhiem.Name = "CapDoLayNhiem";
            // 
            // frmTruyVet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 509);
            this.Controls.Add(this.dgvTruyVet);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmTruyVet";
            this.Text = "frmTruyVet";
            this.Load += new System.EventHandler(this.frmTruyVet_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTruyVet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbBenhNhan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvTruyVet;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaBN;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenBN;
        private System.Windows.Forms.DataGridViewTextBoxColumn TinhTrang;
        private System.Windows.Forms.DataGridViewTextBoxColumn CapDoLayNhiem;
    }
}