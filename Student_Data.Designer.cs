namespace Skill123
{
    partial class Student_Data
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.regnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateofBirthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.homephoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.parentNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nICNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imgeDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.registerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.loginDatasDataSet3 = new Skill123.LoginDatasDataSet3();
            this.loginDatasDataSet2 = new Skill123.LoginDatasDataSet2();
            this.About_btc = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.login_close = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.registerTableAdapter1 = new Skill123.LoginDatasDataSet2TableAdapters.RegisterTableAdapter();
            this.registerTableAdapter2 = new Skill123.LoginDatasDataSet3TableAdapters.RegisterTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.registerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginDatasDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginDatasDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Font = new System.Drawing.Font(" HEXCO", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(955, 308);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Students Profiles";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.regnoDataGridViewTextBoxColumn,
            this.firstnameDataGridViewTextBoxColumn,
            this.lastnameDataGridViewTextBoxColumn,
            this.dateofBirthDataGridViewTextBoxColumn,
            this.genderDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn,
            this.homephoneDataGridViewTextBoxColumn,
            this.parentNameDataGridViewTextBoxColumn,
            this.nICNumberDataGridViewTextBoxColumn,
            this.contactNumberDataGridViewTextBoxColumn,
            this.imgeDataGridViewImageColumn});
            this.dataGridView1.DataSource = this.registerBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(6, 31);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(938, 261);
            this.dataGridView1.TabIndex = 0;
            // 
            // regnoDataGridViewTextBoxColumn
            // 
            this.regnoDataGridViewTextBoxColumn.DataPropertyName = "Regno";
            this.regnoDataGridViewTextBoxColumn.HeaderText = "Regno";
            this.regnoDataGridViewTextBoxColumn.Name = "regnoDataGridViewTextBoxColumn";
            // 
            // firstnameDataGridViewTextBoxColumn
            // 
            this.firstnameDataGridViewTextBoxColumn.DataPropertyName = "Firstname";
            this.firstnameDataGridViewTextBoxColumn.HeaderText = "Firstname";
            this.firstnameDataGridViewTextBoxColumn.Name = "firstnameDataGridViewTextBoxColumn";
            // 
            // lastnameDataGridViewTextBoxColumn
            // 
            this.lastnameDataGridViewTextBoxColumn.DataPropertyName = "Lastname";
            this.lastnameDataGridViewTextBoxColumn.HeaderText = "Lastname";
            this.lastnameDataGridViewTextBoxColumn.Name = "lastnameDataGridViewTextBoxColumn";
            // 
            // dateofBirthDataGridViewTextBoxColumn
            // 
            this.dateofBirthDataGridViewTextBoxColumn.DataPropertyName = "DateofBirth";
            this.dateofBirthDataGridViewTextBoxColumn.HeaderText = "DateofBirth";
            this.dateofBirthDataGridViewTextBoxColumn.Name = "dateofBirthDataGridViewTextBoxColumn";
            // 
            // genderDataGridViewTextBoxColumn
            // 
            this.genderDataGridViewTextBoxColumn.DataPropertyName = "Gender";
            this.genderDataGridViewTextBoxColumn.HeaderText = "Gender";
            this.genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "address";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "phone";
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            // 
            // homephoneDataGridViewTextBoxColumn
            // 
            this.homephoneDataGridViewTextBoxColumn.DataPropertyName = "homephone";
            this.homephoneDataGridViewTextBoxColumn.HeaderText = "homephone";
            this.homephoneDataGridViewTextBoxColumn.Name = "homephoneDataGridViewTextBoxColumn";
            // 
            // parentNameDataGridViewTextBoxColumn
            // 
            this.parentNameDataGridViewTextBoxColumn.DataPropertyName = "ParentName";
            this.parentNameDataGridViewTextBoxColumn.HeaderText = "ParentName";
            this.parentNameDataGridViewTextBoxColumn.Name = "parentNameDataGridViewTextBoxColumn";
            // 
            // nICNumberDataGridViewTextBoxColumn
            // 
            this.nICNumberDataGridViewTextBoxColumn.DataPropertyName = "NICNumber";
            this.nICNumberDataGridViewTextBoxColumn.HeaderText = "NICNumber";
            this.nICNumberDataGridViewTextBoxColumn.Name = "nICNumberDataGridViewTextBoxColumn";
            // 
            // contactNumberDataGridViewTextBoxColumn
            // 
            this.contactNumberDataGridViewTextBoxColumn.DataPropertyName = "ContactNumber";
            this.contactNumberDataGridViewTextBoxColumn.HeaderText = "ContactNumber";
            this.contactNumberDataGridViewTextBoxColumn.Name = "contactNumberDataGridViewTextBoxColumn";
            // 
            // imgeDataGridViewImageColumn
            // 
            this.imgeDataGridViewImageColumn.DataPropertyName = "imge";
            this.imgeDataGridViewImageColumn.HeaderText = "imge";
            this.imgeDataGridViewImageColumn.Name = "imgeDataGridViewImageColumn";
            // 
            // registerBindingSource
            // 
            this.registerBindingSource.DataMember = "Register";
            this.registerBindingSource.DataSource = this.loginDatasDataSet3;
            // 
            // loginDatasDataSet3
            // 
            this.loginDatasDataSet3.DataSetName = "LoginDatasDataSet3";
            this.loginDatasDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // loginDatasDataSet2
            // 
            this.loginDatasDataSet2.DataSetName = "LoginDatasDataSet2";
            this.loginDatasDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.About_btc.Location = new System.Drawing.Point(794, 336);
            this.About_btc.Name = "About_btc";
            this.About_btc.Size = new System.Drawing.Size(162, 40);
            this.About_btc.TabIndex = 9;
            this.About_btc.Text = "DASHBOARD";
            this.About_btc.UseVisualStyleBackColor = false;
            this.About_btc.Click += new System.EventHandler(this.About_btc_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(97)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(794, 461);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(162, 40);
            this.button1.TabIndex = 10;
            this.button1.Text = "BACK";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // login_close
            // 
            this.login_close.AutoSize = true;
            this.login_close.BackColor = System.Drawing.Color.Transparent;
            this.login_close.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.login_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.login_close.Font = new System.Drawing.Font("ROG Fonts", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_close.ForeColor = System.Drawing.Color.Red;
            this.login_close.Location = new System.Drawing.Point(932, 0);
            this.login_close.Name = "login_close";
            this.login_close.Size = new System.Drawing.Size(24, 20);
            this.login_close.TabIndex = 25;
            this.login_close.Text = "X";
            this.login_close.Click += new System.EventHandler(this.login_close_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Skill123.Properties.Resources.students_cartoon_character_ready_to_go_back_home_after_school_time_free_vector;
            this.pictureBox1.Location = new System.Drawing.Point(12, 336);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(776, 165);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // registerTableAdapter1
            // 
            this.registerTableAdapter1.ClearBeforeFill = true;
            // 
            // registerTableAdapter2
            // 
            this.registerTableAdapter2.ClearBeforeFill = true;
            // 
            // Student_Data
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(974, 513);
            this.Controls.Add(this.login_close);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.About_btc);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Student_Data";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student_Data";
            this.Load += new System.EventHandler(this.Student_Data_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.registerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginDatasDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginDatasDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button About_btc;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label login_close;
       
        private LoginDatasDataSetTableAdapters.RegisterTableAdapter registerTableAdapter;
        private LoginDatasDataSet2 loginDatasDataSet2;
        private LoginDatasDataSet2TableAdapters.RegisterTableAdapter registerTableAdapter1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private LoginDatasDataSet3 loginDatasDataSet3;
        private System.Windows.Forms.BindingSource registerBindingSource;
        private LoginDatasDataSet3TableAdapters.RegisterTableAdapter registerTableAdapter2;
        private System.Windows.Forms.DataGridViewTextBoxColumn regnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateofBirthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn homephoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn parentNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nICNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn imgeDataGridViewImageColumn;
    }
}