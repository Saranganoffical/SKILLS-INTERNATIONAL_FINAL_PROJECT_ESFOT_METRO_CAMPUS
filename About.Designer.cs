namespace Skill123
{
    partial class About
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(About));
            this.label1 = new System.Windows.Forms.Label();
            this.login_close = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.About_btc = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Marvel", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(306, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "ABOUT US";
            // 
            // login_close
            // 
            this.login_close.AutoSize = true;
            this.login_close.BackColor = System.Drawing.Color.Transparent;
            this.login_close.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.login_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.login_close.Font = new System.Drawing.Font("ROG Fonts", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_close.ForeColor = System.Drawing.Color.Red;
            this.login_close.Location = new System.Drawing.Point(764, 9);
            this.login_close.Name = "login_close";
            this.login_close.Size = new System.Drawing.Size(24, 20);
            this.login_close.TabIndex = 27;
            this.login_close.Text = "X";
            this.login_close.Click += new System.EventHandler(this.login_close_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 345);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Skill123.Properties.Resources._8073622wwww1;
            this.pictureBox1.Location = new System.Drawing.Point(561, 204);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(176, 135);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(761, 210);
            this.label2.TabIndex = 0;
            this.label2.Text = resources.GetString("label2.Text");
            // 
            // About_btc
            // 
            this.About_btc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(97)))));
            this.About_btc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.About_btc.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.About_btc.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.About_btc.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.About_btc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.About_btc.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.About_btc.ForeColor = System.Drawing.Color.White;
            this.About_btc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.About_btc.Location = new System.Drawing.Point(22, 398);
            this.About_btc.Name = "About_btc";
            this.About_btc.Size = new System.Drawing.Size(162, 40);
            this.About_btc.TabIndex = 13;
            this.About_btc.Text = "DASHBOARD";
            this.About_btc.UseVisualStyleBackColor = false;
            this.About_btc.Click += new System.EventHandler(this.About_btc_Click);
            // 
            // About
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.About_btc);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.login_close);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "About";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "About";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label login_close;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button About_btc;
    }
}