
namespace WindowsFormsApp1
{
    partial class ThongKeKetQua
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
            this.rdToday = new System.Windows.Forms.RadioButton();
            this.rdTatCa = new System.Windows.Forms.RadioButton();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.lvThongKe = new System.Windows.Forms.ListView();
            this.rdHomNay = new System.Windows.Forms.RadioButton();
            this.rdLuaChon = new System.Windows.Forms.RadioButton();
            this.rdAll = new System.Windows.Forms.RadioButton();
            this.dtpNgayKetThuc = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpNgayBatDau = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(394, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(332, 51);
            this.label1.TabIndex = 10;
            this.label1.Text = "Kết quả quay số";
            // 
            // rdToday
            // 
            this.rdToday.AutoSize = true;
            this.rdToday.Location = new System.Drawing.Point(-100, 100);
            this.rdToday.Name = "rdToday";
            this.rdToday.Size = new System.Drawing.Size(85, 21);
            this.rdToday.TabIndex = 27;
            this.rdToday.Text = "Hôm nay";
            this.rdToday.UseVisualStyleBackColor = true;
            // 
            // rdTatCa
            // 
            this.rdTatCa.AutoSize = true;
            this.rdTatCa.Checked = true;
            this.rdTatCa.Location = new System.Drawing.Point(-100, -69);
            this.rdTatCa.Name = "rdTatCa";
            this.rdTatCa.Size = new System.Drawing.Size(69, 21);
            this.rdTatCa.TabIndex = 25;
            this.rdTatCa.TabStop = true;
            this.rdTatCa.Text = "Tất cả";
            this.rdTatCa.UseVisualStyleBackColor = true;
            // 
            // btnThongKe
            // 
            this.btnThongKe.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThongKe.Image = global::WindowsFormsApp1.Properties.Resources.vcsnormal_93488;
            this.btnThongKe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThongKe.Location = new System.Drawing.Point(459, 621);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(214, 50);
            this.btnThongKe.TabIndex = 22;
            this.btnThongKe.Text = "Thống kê";
            this.btnThongKe.UseVisualStyleBackColor = true;
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // lvThongKe
            // 
            this.lvThongKe.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvThongKe.HideSelection = false;
            this.lvThongKe.Location = new System.Drawing.Point(77, 334);
            this.lvThongKe.Name = "lvThongKe";
            this.lvThongKe.Size = new System.Drawing.Size(960, 253);
            this.lvThongKe.TabIndex = 19;
            this.lvThongKe.UseCompatibleStateImageBehavior = false;
            // 
            // rdHomNay
            // 
            this.rdHomNay.AutoSize = true;
            this.rdHomNay.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdHomNay.Location = new System.Drawing.Point(121, 258);
            this.rdHomNay.Name = "rdHomNay";
            this.rdHomNay.Size = new System.Drawing.Size(169, 42);
            this.rdHomNay.TabIndex = 34;
            this.rdHomNay.Text = "Hôm nay";
            this.rdHomNay.UseVisualStyleBackColor = true;
            // 
            // rdLuaChon
            // 
            this.rdLuaChon.AutoSize = true;
            this.rdLuaChon.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdLuaChon.Location = new System.Drawing.Point(121, 171);
            this.rdLuaChon.Name = "rdLuaChon";
            this.rdLuaChon.Size = new System.Drawing.Size(252, 42);
            this.rdLuaChon.TabIndex = 33;
            this.rdLuaChon.Text = "Lựa chọn ngày";
            this.rdLuaChon.UseVisualStyleBackColor = true;
            // 
            // rdAll
            // 
            this.rdAll.AutoSize = true;
            this.rdAll.Checked = true;
            this.rdAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdAll.Location = new System.Drawing.Point(121, 89);
            this.rdAll.Name = "rdAll";
            this.rdAll.Size = new System.Drawing.Size(129, 42);
            this.rdAll.TabIndex = 32;
            this.rdAll.TabStop = true;
            this.rdAll.Text = "Tất cả";
            this.rdAll.UseVisualStyleBackColor = true;
            // 
            // dtpNgayKetThuc
            // 
            this.dtpNgayKetThuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayKetThuc.Location = new System.Drawing.Point(504, 210);
            this.dtpNgayKetThuc.Name = "dtpNgayKetThuc";
            this.dtpNgayKetThuc.Size = new System.Drawing.Size(413, 34);
            this.dtpNgayKetThuc.TabIndex = 31;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(405, 210);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 29);
            this.label3.TabIndex = 30;
            this.label3.Text = "TO";
            // 
            // dtpNgayBatDau
            // 
            this.dtpNgayBatDau.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayBatDau.Location = new System.Drawing.Point(504, 152);
            this.dtpNgayBatDau.Name = "dtpNgayBatDau";
            this.dtpNgayBatDau.Size = new System.Drawing.Size(413, 34);
            this.dtpNgayBatDau.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(405, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 29);
            this.label2.TabIndex = 28;
            this.label2.Text = "FROM";
            // 
            // ThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1114, 718);
            this.Controls.Add(this.rdHomNay);
            this.Controls.Add(this.rdLuaChon);
            this.Controls.Add(this.rdAll);
            this.Controls.Add(this.dtpNgayKetThuc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpNgayBatDau);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rdToday);
            this.Controls.Add(this.rdTatCa);
            this.Controls.Add(this.btnThongKe);
            this.Controls.Add(this.lvThongKe);
            this.Controls.Add(this.label1);
            this.Name = "ThongKe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ThongKe";
            this.Load += new System.EventHandler(this.ThongKe_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdToday;
        private System.Windows.Forms.RadioButton rdTatCa;
        private System.Windows.Forms.Button btnThongKe;
        private System.Windows.Forms.ListView lvThongKe;
        private System.Windows.Forms.RadioButton rdHomNay;
        private System.Windows.Forms.RadioButton rdLuaChon;
        private System.Windows.Forms.RadioButton rdAll;
        private System.Windows.Forms.DateTimePicker dtpNgayKetThuc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpNgayBatDau;
        private System.Windows.Forms.Label label2;
    }
}