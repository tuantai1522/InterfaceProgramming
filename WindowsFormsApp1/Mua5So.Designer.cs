
namespace WindowsFormsApp1
{
    partial class Mua5So
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtSo5 = new System.Windows.Forms.TextBox();
            this.txtSo4 = new System.Windows.Forms.TextBox();
            this.txtSo2 = new System.Windows.Forms.TextBox();
            this.txtSo3 = new System.Windows.Forms.TextBox();
            this.txtSo1 = new System.Windows.Forms.TextBox();
            this.btnXacNhan = new System.Windows.Forms.Button();
            this.btnRandom = new System.Windows.Forms.Button();
            this.cbSoLuongVe = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(240, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(389, 51);
            this.label1.TabIndex = 13;
            this.label1.Text = "Các số đã lựa chọn";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtSo5);
            this.groupBox1.Controls.Add(this.txtSo4);
            this.groupBox1.Controls.Add(this.txtSo2);
            this.groupBox1.Controls.Add(this.txtSo3);
            this.groupBox1.Controls.Add(this.txtSo1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(41, 72);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(784, 132);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            // 
            // txtSo5
            // 
            this.txtSo5.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSo5.Location = new System.Drawing.Point(640, 38);
            this.txtSo5.Name = "txtSo5";
            this.txtSo5.Size = new System.Drawing.Size(111, 64);
            this.txtSo5.TabIndex = 4;
            this.txtSo5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSo5.TextChanged += new System.EventHandler(this.txtSo1_TextChanged);
            this.txtSo5.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSo5_KeyDown);
            this.txtSo5.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSo5_KeyPress);
            // 
            // txtSo4
            // 
            this.txtSo4.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSo4.Location = new System.Drawing.Point(489, 38);
            this.txtSo4.Name = "txtSo4";
            this.txtSo4.Size = new System.Drawing.Size(111, 64);
            this.txtSo4.TabIndex = 3;
            this.txtSo4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSo4.TextChanged += new System.EventHandler(this.txtSo1_TextChanged);
            this.txtSo4.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSo4_KeyDown);
            this.txtSo4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSo4_KeyPress);
            // 
            // txtSo2
            // 
            this.txtSo2.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSo2.Location = new System.Drawing.Point(176, 38);
            this.txtSo2.Name = "txtSo2";
            this.txtSo2.Size = new System.Drawing.Size(111, 64);
            this.txtSo2.TabIndex = 2;
            this.txtSo2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSo2.TextChanged += new System.EventHandler(this.txtSo1_TextChanged);
            this.txtSo2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSo2_KeyDown);
            this.txtSo2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSo2_KeyPress);
            // 
            // txtSo3
            // 
            this.txtSo3.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSo3.Location = new System.Drawing.Point(325, 38);
            this.txtSo3.Name = "txtSo3";
            this.txtSo3.Size = new System.Drawing.Size(111, 64);
            this.txtSo3.TabIndex = 1;
            this.txtSo3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSo3.TextChanged += new System.EventHandler(this.txtSo1_TextChanged);
            this.txtSo3.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSo3_KeyDown);
            this.txtSo3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSo3_KeyPress);
            // 
            // txtSo1
            // 
            this.txtSo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSo1.Location = new System.Drawing.Point(25, 38);
            this.txtSo1.Name = "txtSo1";
            this.txtSo1.Size = new System.Drawing.Size(111, 64);
            this.txtSo1.TabIndex = 0;
            this.txtSo1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSo1.TextChanged += new System.EventHandler(this.txtSo1_TextChanged);
            this.txtSo1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSo1_KeyDown);
            this.txtSo1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSo1_KeyPress);
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.Enabled = false;
            this.btnXacNhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXacNhan.Location = new System.Drawing.Point(146, 352);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(261, 63);
            this.btnXacNhan.TabIndex = 14;
            this.btnXacNhan.Text = "Xác nhận";
            this.btnXacNhan.UseVisualStyleBackColor = true;
            this.btnXacNhan.Click += new System.EventHandler(this.btnXacNhan_Click);
            // 
            // btnRandom
            // 
            this.btnRandom.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnRandom.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.refresh_page_option;
            this.btnRandom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRandom.Location = new System.Drawing.Point(573, 354);
            this.btnRandom.Name = "btnRandom";
            this.btnRandom.Size = new System.Drawing.Size(68, 61);
            this.btnRandom.TabIndex = 12;
            this.btnRandom.UseVisualStyleBackColor = true;
            this.btnRandom.Click += new System.EventHandler(this.btnRandom_Click);
            // 
            // cbSoLuongVe
            // 
            this.cbSoLuongVe.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSoLuongVe.FormattingEnabled = true;
            this.cbSoLuongVe.Location = new System.Drawing.Point(467, 236);
            this.cbSoLuongVe.Name = "cbSoLuongVe";
            this.cbSoLuongVe.Size = new System.Drawing.Size(151, 46);
            this.cbSoLuongVe.TabIndex = 18;
            this.cbSoLuongVe.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbSoLuongVe_KeyDown);
            this.cbSoLuongVe.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbSoLuongVe_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(139, 243);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 38);
            this.label2.TabIndex = 17;
            this.label2.Text = "Số lượng vé";
            // 
            // Mua5So
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 450);
            this.Controls.Add(this.cbSoLuongVe);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnXacNhan);
            this.Controls.Add(this.btnRandom);
            this.Name = "Mua5So";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mua5So";
            this.Load += new System.EventHandler(this.Mua5So_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtSo4;
        private System.Windows.Forms.TextBox txtSo2;
        private System.Windows.Forms.TextBox txtSo3;
        private System.Windows.Forms.TextBox txtSo1;
        private System.Windows.Forms.Button btnXacNhan;
        private System.Windows.Forms.Button btnRandom;
        private System.Windows.Forms.TextBox txtSo5;
        private System.Windows.Forms.ComboBox cbSoLuongVe;
        private System.Windows.Forms.Label label2;
    }
}