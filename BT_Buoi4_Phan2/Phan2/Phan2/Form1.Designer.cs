
namespace Phan2
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtHoSv = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.txtSBD = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.txtDC = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.txtTenSv = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.txtSDT = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.StudentRecordData = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.StudentRecordData)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Họ sinh viên";
            // 
            // txtHoSv
            // 
            this.txtHoSv.Location = new System.Drawing.Point(142, 45);
            this.txtHoSv.Name = "txtHoSv";
            this.txtHoSv.Size = new System.Drawing.Size(100, 20);
            this.txtHoSv.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(142, 80);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 3;
            // 
            // txtSBD
            // 
            this.txtSBD.AutoSize = true;
            this.txtSBD.Location = new System.Drawing.Point(64, 83);
            this.txtSBD.Name = "txtSBD";
            this.txtSBD.Size = new System.Drawing.Size(68, 13);
            this.txtSBD.TabIndex = 2;
            this.txtSBD.Text = "Số báo danh";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(142, 116);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 5;
            // 
            // txtDC
            // 
            this.txtDC.AutoSize = true;
            this.txtDC.Location = new System.Drawing.Point(92, 119);
            this.txtDC.Name = "txtDC";
            this.txtDC.Size = new System.Drawing.Size(40, 13);
            this.txtDC.TabIndex = 4;
            this.txtDC.Text = "Địa chỉ";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(462, 45);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 7;
            // 
            // txtTenSv
            // 
            this.txtTenSv.AutoSize = true;
            this.txtTenSv.Location = new System.Drawing.Point(385, 48);
            this.txtTenSv.Name = "txtTenSv";
            this.txtTenSv.Size = new System.Drawing.Size(71, 13);
            this.txtTenSv.TabIndex = 6;
            this.txtTenSv.Text = "Tên sinh viên";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(462, 80);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 9;
            // 
            // txtSDT
            // 
            this.txtSDT.AutoSize = true;
            this.txtSDT.Location = new System.Drawing.Point(386, 83);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(70, 13);
            this.txtSDT.TabIndex = 8;
            this.txtSDT.Text = "Số điện thoại";
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(28, 173);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 10;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Location = new System.Drawing.Point(167, 173);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(75, 23);
            this.btnCapNhat.TabIndex = 11;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(320, 173);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 12;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(462, 173);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 13;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(613, 173);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 14;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            // 
            // StudentRecordData
            // 
            this.StudentRecordData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StudentRecordData.Location = new System.Drawing.Point(12, 217);
            this.StudentRecordData.Name = "StudentRecordData";
            this.StudentRecordData.Size = new System.Drawing.Size(687, 221);
            this.StudentRecordData.TabIndex = 15;
            this.StudentRecordData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.StudentRecordData_CellClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(711, 450);
            this.Controls.Add(this.StudentRecordData);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnCapNhat);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.txtSDT);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.txtTenSv);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.txtDC);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.txtSBD);
            this.Controls.Add(this.txtHoSv);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student Information";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.StudentRecordData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtHoSv;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label txtSBD;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label txtDC;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label txtTenSv;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label txtSDT;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.DataGridView StudentRecordData;
    }
}

