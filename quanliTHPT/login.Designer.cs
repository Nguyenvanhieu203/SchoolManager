namespace quanliTHPT
{
    partial class login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tb_user = new System.Windows.Forms.TextBox();
            this.tb_pass = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lb_loginwtFB = new System.Windows.Forms.Label();
            this.lb_loginwtgg = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(730, 408);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // tb_user
            // 
            this.tb_user.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb_user.Location = new System.Drawing.Point(448, 119);
            this.tb_user.Multiline = true;
            this.tb_user.Name = "tb_user";
            this.tb_user.Size = new System.Drawing.Size(173, 28);
            this.tb_user.TabIndex = 16;
            this.tb_user.Enter += new System.EventHandler(this.textBox1_Enter);
            this.tb_user.Leave += new System.EventHandler(this.textBox1_Leave);
            // 
            // tb_pass
            // 
            this.tb_pass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb_pass.Location = new System.Drawing.Point(448, 171);
            this.tb_pass.Multiline = true;
            this.tb_pass.Name = "tb_pass";
            this.tb_pass.PasswordChar = '*';
            this.tb_pass.Size = new System.Drawing.Size(173, 29);
            this.tb_pass.TabIndex = 17;
            this.tb_pass.Enter += new System.EventHandler(this.textBox2_Enter);
            this.tb_pass.Leave += new System.EventHandler(this.textBox2_Leave);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(494, 247);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 23);
            this.label1.TabIndex = 18;
            this.label1.Text = "Đăng nhập";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            this.label1.MouseEnter += new System.EventHandler(this.label1_MouseEnter);
            this.label1.MouseLeave += new System.EventHandler(this.label1_MouseLeave);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.Location = new System.Drawing.Point(424, 318);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 19);
            this.label2.TabIndex = 19;
            this.label2.Text = "Facebook";
            this.label2.MouseEnter += new System.EventHandler(this.label2_MouseEnter);
            this.label2.MouseLeave += new System.EventHandler(this.label2_MouseLeave);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Image = ((System.Drawing.Image)(resources.GetObject("label3.Image")));
            this.label3.Location = new System.Drawing.Point(608, 318);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 20);
            this.label3.TabIndex = 20;
            this.label3.Text = "Google";
            this.label3.MouseEnter += new System.EventHandler(this.label3_MouseEnter);
            this.label3.MouseLeave += new System.EventHandler(this.label3_MouseLeave);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(384, 283);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 15);
            this.label4.TabIndex = 21;
            this.label4.Text = "Quên mật khẩu";
            this.label4.MouseEnter += new System.EventHandler(this.label4_MouseEnter);
            this.label4.MouseLeave += new System.EventHandler(this.label4_MouseLeave);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(414, 371);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 15);
            this.label5.TabIndex = 22;
            this.label5.Text = "Bạn chưa có tài khoản?";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(570, 371);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 15);
            this.label6.TabIndex = 23;
            this.label6.Text = "Đăng kí";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            this.label6.MouseEnter += new System.EventHandler(this.label6_MouseEnter);
            this.label6.MouseLeave += new System.EventHandler(this.label6_MouseLeave);
            // 
            // lb_loginwtFB
            // 
            this.lb_loginwtFB.AutoSize = true;
            this.lb_loginwtFB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lb_loginwtFB.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_loginwtFB.Image = ((System.Drawing.Image)(resources.GetObject("lb_loginwtFB.Image")));
            this.lb_loginwtFB.Location = new System.Drawing.Point(387, 352);
            this.lb_loginwtFB.Name = "lb_loginwtFB";
            this.lb_loginwtFB.Size = new System.Drawing.Size(154, 19);
            this.lb_loginwtFB.TabIndex = 24;
            this.lb_loginwtFB.Text = "Đăng nhập với facebook";
            this.lb_loginwtFB.Visible = false;
            // 
            // lb_loginwtgg
            // 
            this.lb_loginwtgg.AutoSize = true;
            this.lb_loginwtgg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lb_loginwtgg.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_loginwtgg.Image = ((System.Drawing.Image)(resources.GetObject("lb_loginwtgg.Image")));
            this.lb_loginwtgg.Location = new System.Drawing.Point(563, 352);
            this.lb_loginwtgg.Name = "lb_loginwtgg";
            this.lb_loginwtgg.Size = new System.Drawing.Size(138, 19);
            this.lb_loginwtgg.TabIndex = 25;
            this.lb_loginwtgg.Text = "Đăng nhập với google";
            this.lb_loginwtgg.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Image = ((System.Drawing.Image)(resources.GetObject("label7.Image")));
            this.label7.Location = new System.Drawing.Point(480, 245);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 25);
            this.label7.TabIndex = 26;
            this.label7.Text = "Đăng nhập";
            this.label7.Visible = false;
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(730, 408);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lb_loginwtgg);
            this.Controls.Add(this.lb_loginwtFB);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_pass);
            this.Controls.Add(this.tb_user);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "login";
            this.Load += new System.EventHandler(this.login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox tb_user;
        private System.Windows.Forms.TextBox tb_pass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lb_loginwtFB;
        private System.Windows.Forms.Label lb_loginwtgg;
        private System.Windows.Forms.Label label7;
    }
}

