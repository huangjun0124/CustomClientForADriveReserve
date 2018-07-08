namespace PPYC
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.label2 = new System.Windows.Forms.Label();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTeacherID = new System.Windows.Forms.TextBox();
            this.btnLogIn = new System.Windows.Forms.Button();
            this.btnDay1 = new System.Windows.Forms.Button();
            this.btnDay2 = new System.Windows.Forms.Button();
            this.btnDay3 = new System.Windows.Forms.Button();
            this.btnDay4 = new System.Windows.Forms.Button();
            this.gbReserveInfo = new System.Windows.Forms.GroupBox();
            this.grdReserveInfo = new System.Windows.Forms.DataGridView();
            this.btnReserve = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtMessage = new System.Windows.Forms.RichTextBox();
            this.txtCountDown = new System.Windows.Forms.TextBox();
            this.gbReserveInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdReserveInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(10, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "登录账户手机号";
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Font = new System.Drawing.Font("Microsoft YaHei", 9F);
            this.txtPhoneNumber.Location = new System.Drawing.Point(101, 12);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(174, 23);
            this.txtPhoneNumber.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(304, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "密码";
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Microsoft YaHei", 9F);
            this.txtPassword.Location = new System.Drawing.Point(345, 12);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(168, 23);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(10, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "用户名";
            // 
            // txtUserName
            // 
            this.txtUserName.Font = new System.Drawing.Font("Microsoft YaHei", 9F);
            this.txtUserName.Location = new System.Drawing.Point(101, 51);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(174, 23);
            this.txtUserName.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(304, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "教练ID";
            // 
            // txtTeacherID
            // 
            this.txtTeacherID.Font = new System.Drawing.Font("Microsoft YaHei", 9F);
            this.txtTeacherID.Location = new System.Drawing.Point(345, 51);
            this.txtTeacherID.Name = "txtTeacherID";
            this.txtTeacherID.Size = new System.Drawing.Size(168, 23);
            this.txtTeacherID.TabIndex = 1;
            // 
            // btnLogIn
            // 
            this.btnLogIn.AutoSize = true;
            this.btnLogIn.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnLogIn.Location = new System.Drawing.Point(551, 15);
            this.btnLogIn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLogIn.Name = "btnLogIn";
            this.btnLogIn.Size = new System.Drawing.Size(56, 27);
            this.btnLogIn.TabIndex = 2;
            this.btnLogIn.Text = "登录";
            this.btnLogIn.UseVisualStyleBackColor = true;
            this.btnLogIn.Click += new System.EventHandler(this.btnLogIn_Click);
            // 
            // btnDay1
            // 
            this.btnDay1.AutoSize = true;
            this.btnDay1.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnDay1.Location = new System.Drawing.Point(42, 118);
            this.btnDay1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDay1.Name = "btnDay1";
            this.btnDay1.Size = new System.Drawing.Size(93, 44);
            this.btnDay1.TabIndex = 2;
            this.btnDay1.Text = "星期六\r\n07-7";
            this.btnDay1.UseVisualStyleBackColor = true;
            this.btnDay1.Click += new System.EventHandler(this.btnDay_Click);
            // 
            // btnDay2
            // 
            this.btnDay2.AutoSize = true;
            this.btnDay2.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnDay2.Location = new System.Drawing.Point(181, 118);
            this.btnDay2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDay2.Name = "btnDay2";
            this.btnDay2.Size = new System.Drawing.Size(93, 44);
            this.btnDay2.TabIndex = 2;
            this.btnDay2.Text = "星期日\r\n07-8";
            this.btnDay2.UseVisualStyleBackColor = true;
            this.btnDay2.Click += new System.EventHandler(this.btnDay_Click);
            // 
            // btnDay3
            // 
            this.btnDay3.AutoSize = true;
            this.btnDay3.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnDay3.Location = new System.Drawing.Point(319, 118);
            this.btnDay3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDay3.Name = "btnDay3";
            this.btnDay3.Size = new System.Drawing.Size(93, 44);
            this.btnDay3.TabIndex = 2;
            this.btnDay3.Text = "星期一\r\n07-9";
            this.btnDay3.UseVisualStyleBackColor = true;
            this.btnDay3.Click += new System.EventHandler(this.btnDay_Click);
            // 
            // btnDay4
            // 
            this.btnDay4.AutoSize = true;
            this.btnDay4.BackColor = System.Drawing.Color.SpringGreen;
            this.btnDay4.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnDay4.Location = new System.Drawing.Point(452, 118);
            this.btnDay4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDay4.Name = "btnDay4";
            this.btnDay4.Size = new System.Drawing.Size(93, 44);
            this.btnDay4.TabIndex = 2;
            this.btnDay4.Text = "星期四\r\n07-21";
            this.btnDay4.UseVisualStyleBackColor = false;
            this.btnDay4.Click += new System.EventHandler(this.btnDay_Click);
            // 
            // gbReserveInfo
            // 
            this.gbReserveInfo.Controls.Add(this.grdReserveInfo);
            this.gbReserveInfo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gbReserveInfo.Location = new System.Drawing.Point(13, 176);
            this.gbReserveInfo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbReserveInfo.Name = "gbReserveInfo";
            this.gbReserveInfo.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbReserveInfo.Size = new System.Drawing.Size(812, 405);
            this.gbReserveInfo.TabIndex = 3;
            this.gbReserveInfo.TabStop = false;
            this.gbReserveInfo.Text = "预约信息";
            // 
            // grdReserveInfo
            // 
            this.grdReserveInfo.AllowUserToAddRows = false;
            this.grdReserveInfo.AllowUserToDeleteRows = false;
            this.grdReserveInfo.AllowUserToOrderColumns = true;
            this.grdReserveInfo.AllowUserToResizeRows = false;
            this.grdReserveInfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.grdReserveInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdReserveInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdReserveInfo.Location = new System.Drawing.Point(2, 16);
            this.grdReserveInfo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grdReserveInfo.Name = "grdReserveInfo";
            this.grdReserveInfo.ReadOnly = true;
            this.grdReserveInfo.RowHeadersVisible = false;
            this.grdReserveInfo.RowTemplate.Height = 27;
            this.grdReserveInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.grdReserveInfo.Size = new System.Drawing.Size(808, 387);
            this.grdReserveInfo.TabIndex = 0;
            this.grdReserveInfo.DataSourceChanged += new System.EventHandler(this.grdReserveInfo_DataSourceChanged);
            this.grdReserveInfo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdReserveInfo_CellClick);
            // 
            // btnReserve
            // 
            this.btnReserve.AutoSize = true;
            this.btnReserve.BackColor = System.Drawing.SystemColors.Control;
            this.btnReserve.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnReserve.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnReserve.Location = new System.Drawing.Point(600, 126);
            this.btnReserve.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnReserve.Name = "btnReserve";
            this.btnReserve.Size = new System.Drawing.Size(90, 27);
            this.btnReserve.TabIndex = 2;
            this.btnReserve.Text = "预约所选时间";
            this.btnReserve.UseVisualStyleBackColor = false;
            this.btnReserve.Click += new System.EventHandler(this.btnReserve_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.AutoSize = true;
            this.btnCancel.BackColor = System.Drawing.SystemColors.Control;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnCancel.ForeColor = System.Drawing.Color.Red;
            this.btnCancel.Location = new System.Drawing.Point(703, 126);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(102, 27);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "取消今天的预约";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(15, 587);
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.ReadOnly = true;
            this.txtMessage.Size = new System.Drawing.Size(806, 88);
            this.txtMessage.TabIndex = 4;
            this.txtMessage.Text = "";
            // 
            // txtCountDown
            // 
            this.txtCountDown.BackColor = System.Drawing.Color.RosyBrown;
            this.txtCountDown.Font = new System.Drawing.Font("Microsoft YaHei", 9F);
            this.txtCountDown.ForeColor = System.Drawing.Color.Blue;
            this.txtCountDown.Location = new System.Drawing.Point(600, 98);
            this.txtCountDown.Name = "txtCountDown";
            this.txtCountDown.ReadOnly = true;
            this.txtCountDown.Size = new System.Drawing.Size(77, 23);
            this.txtCountDown.TabIndex = 1;
            this.txtCountDown.Text = "17:59:59:999";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 677);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.gbReserveInfo);
            this.Controls.Add(this.btnDay4);
            this.Controls.Add(this.btnDay3);
            this.Controls.Add(this.btnDay2);
            this.Controls.Add(this.btnDay1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnReserve);
            this.Controls.Add(this.btnLogIn);
            this.Controls.Add(this.txtCountDown);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.txtTeacherID);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtPhoneNumber);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMain";
            this.Text = "鹏鹏约车";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.gbReserveInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdReserveInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTeacherID;
        private System.Windows.Forms.Button btnLogIn;
        private System.Windows.Forms.Button btnDay1;
        private System.Windows.Forms.Button btnDay2;
        private System.Windows.Forms.Button btnDay3;
        private System.Windows.Forms.Button btnDay4;
        private System.Windows.Forms.GroupBox gbReserveInfo;
        private System.Windows.Forms.DataGridView grdReserveInfo;
        private System.Windows.Forms.Button btnReserve;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.RichTextBox txtMessage;
        private System.Windows.Forms.TextBox txtCountDown;
    }
}

