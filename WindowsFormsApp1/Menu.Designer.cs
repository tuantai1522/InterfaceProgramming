
namespace WindowsFormsApp1
{
    partial class Menu
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
            this.MenuChon = new System.Windows.Forms.MenuStrip();
            this.muaVéToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sốToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sốToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.sốToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.xemLịchSửĐặtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LichSuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thốngKêToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTenDangNhap = new System.Windows.Forms.TextBox();
            this.txtSoDienThoai = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.MenuChon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // MenuChon
            // 
            this.MenuChon.BackColor = System.Drawing.SystemColors.HotTrack;
            this.MenuChon.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuChon.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MenuChon.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.muaVéToolStripMenuItem,
            this.xemLịchSửĐặtToolStripMenuItem,
            this.LichSuToolStripMenuItem,
            this.thốngKêToolStripMenuItem});
            this.MenuChon.Location = new System.Drawing.Point(0, 0);
            this.MenuChon.Name = "MenuChon";
            this.MenuChon.Size = new System.Drawing.Size(1035, 49);
            this.MenuChon.TabIndex = 1;
            this.MenuChon.Text = "menuStrip2";
            // 
            // muaVéToolStripMenuItem
            // 
            this.muaVéToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sốToolStripMenuItem,
            this.sốToolStripMenuItem1,
            this.sốToolStripMenuItem2});
            this.muaVéToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.muaVéToolStripMenuItem.Name = "muaVéToolStripMenuItem";
            this.muaVéToolStripMenuItem.Size = new System.Drawing.Size(129, 45);
            this.muaVéToolStripMenuItem.Text = "Mua vé";
            // 
            // sốToolStripMenuItem
            // 
            this.sốToolStripMenuItem.Name = "sốToolStripMenuItem";
            this.sốToolStripMenuItem.Size = new System.Drawing.Size(224, 46);
            this.sốToolStripMenuItem.Text = "3 số";
            this.sốToolStripMenuItem.Click += new System.EventHandler(this.sốToolStripMenuItem_Click);
            // 
            // sốToolStripMenuItem1
            // 
            this.sốToolStripMenuItem1.Name = "sốToolStripMenuItem1";
            this.sốToolStripMenuItem1.Size = new System.Drawing.Size(224, 46);
            this.sốToolStripMenuItem1.Text = "4 số";
            this.sốToolStripMenuItem1.Click += new System.EventHandler(this.sốToolStripMenuItem1_Click);
            // 
            // sốToolStripMenuItem2
            // 
            this.sốToolStripMenuItem2.Name = "sốToolStripMenuItem2";
            this.sốToolStripMenuItem2.Size = new System.Drawing.Size(224, 46);
            this.sốToolStripMenuItem2.Text = "5 số";
            this.sốToolStripMenuItem2.Click += new System.EventHandler(this.sốToolStripMenuItem2_Click);
            // 
            // xemLịchSửĐặtToolStripMenuItem
            // 
            this.xemLịchSửĐặtToolStripMenuItem.Name = "xemLịchSửĐặtToolStripMenuItem";
            this.xemLịchSửĐặtToolStripMenuItem.Size = new System.Drawing.Size(246, 45);
            this.xemLịchSửĐặtToolStripMenuItem.Text = "Lịch sử đặt cược";
            this.xemLịchSửĐặtToolStripMenuItem.Click += new System.EventHandler(this.xemLịchSửĐặtToolStripMenuItem_Click_1);
            // 
            // LichSuToolStripMenuItem
            // 
            this.LichSuToolStripMenuItem.Name = "LichSuToolStripMenuItem";
            this.LichSuToolStripMenuItem.Size = new System.Drawing.Size(309, 45);
            this.LichSuToolStripMenuItem.Text = "Lịch sử trúng thưởng";
            this.LichSuToolStripMenuItem.Click += new System.EventHandler(this.LichSuToolStripMenuItem_Click);
            // 
            // thốngKêToolStripMenuItem
            // 
            this.thốngKêToolStripMenuItem.Name = "thốngKêToolStripMenuItem";
            this.thốngKêToolStripMenuItem.Size = new System.Drawing.Size(264, 45);
            this.thốngKêToolStripMenuItem.Text = "Thống kê kết quả";
            this.thốngKêToolStripMenuItem.Click += new System.EventHandler(this.thốngKêToolStripMenuItem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(232, 207);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(206, 32);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tên đăng nhập";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(232, 273);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(182, 32);
            this.label3.TabIndex = 4;
            this.label3.Text = "Số điện thoại";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(232, 336);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 32);
            this.label5.TabIndex = 6;
            this.label5.Text = "Email";
            // 
            // txtTenDangNhap
            // 
            this.txtTenDangNhap.Enabled = false;
            this.txtTenDangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenDangNhap.Location = new System.Drawing.Point(454, 201);
            this.txtTenDangNhap.Name = "txtTenDangNhap";
            this.txtTenDangNhap.Size = new System.Drawing.Size(390, 38);
            this.txtTenDangNhap.TabIndex = 7;
            // 
            // txtSoDienThoai
            // 
            this.txtSoDienThoai.Enabled = false;
            this.txtSoDienThoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoDienThoai.Location = new System.Drawing.Point(454, 267);
            this.txtSoDienThoai.Name = "txtSoDienThoai";
            this.txtSoDienThoai.Size = new System.Drawing.Size(390, 38);
            this.txtSoDienThoai.TabIndex = 8;
            // 
            // txtEmail
            // 
            this.txtEmail.Enabled = false;
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(454, 333);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(390, 38);
            this.txtEmail.TabIndex = 9;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.icons8_name_tag_100;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(483, 78);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(153, 98);
            this.pictureBox3.TabIndex = 10;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.id_card;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(164, 211);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(52, 28);
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.telephone_call;
            this.pictureBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox6.Location = new System.Drawing.Point(164, 277);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(52, 28);
            this.pictureBox6.TabIndex = 22;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.gmail;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(164, 336);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(52, 28);
            this.pictureBox2.TabIndex = 23;
            this.pictureBox2.TabStop = false;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1035, 450);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtSoDienThoai);
            this.Controls.Add(this.txtTenDangNhap);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.MenuChon);
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Menu_FormClosing);
            this.Load += new System.EventHandler(this.Menu_Load);
            this.MenuChon.ResumeLayout(false);
            this.MenuChon.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip MenuChon;
        private System.Windows.Forms.ToolStripMenuItem muaVéToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sốToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sốToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem sốToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem LichSuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thốngKêToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTenDangNhap;
        private System.Windows.Forms.TextBox txtSoDienThoai;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.ToolStripMenuItem xemLịchSửĐặtToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}