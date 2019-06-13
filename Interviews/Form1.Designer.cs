namespace Interviews
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
            this.tabInterviews = new System.Windows.Forms.TabPage();
            this.txtRecruiter = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbMonth = new System.Windows.Forms.ComboBox();
            this.btnShowByMonths = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.cmbResult = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnIntUpdate = new System.Windows.Forms.Button();
            this.cmbStatusInt = new System.Windows.Forms.ComboBox();
            this.dtpTime = new System.Windows.Forms.DateTimePicker();
            this.lblTimeInt = new System.Windows.Forms.Label();
            this.lblStatusInt = new System.Windows.Forms.Label();
            this.rbtnDeActive = new System.Windows.Forms.RadioButton();
            this.rbtnActive = new System.Windows.Forms.RadioButton();
            this.dgvInterview = new System.Windows.Forms.DataGridView();
            this.btnShowAllInt = new System.Windows.Forms.Button();
            this.txtCompany = new System.Windows.Forms.TextBox();
            this.txtSlnos = new System.Windows.Forms.TextBox();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnIntDelete = new System.Windows.Forms.Button();
            this.btnIntAdd = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabInterviews.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInterview)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabInterviews
            // 
            this.tabInterviews.BackColor = System.Drawing.Color.Aquamarine;
            this.tabInterviews.Controls.Add(this.txtRecruiter);
            this.tabInterviews.Controls.Add(this.label2);
            this.tabInterviews.Controls.Add(this.panel1);
            this.tabInterviews.Controls.Add(this.btnClose);
            this.tabInterviews.Controls.Add(this.cmbResult);
            this.tabInterviews.Controls.Add(this.label1);
            this.tabInterviews.Controls.Add(this.btnIntUpdate);
            this.tabInterviews.Controls.Add(this.cmbStatusInt);
            this.tabInterviews.Controls.Add(this.dtpTime);
            this.tabInterviews.Controls.Add(this.lblTimeInt);
            this.tabInterviews.Controls.Add(this.lblStatusInt);
            this.tabInterviews.Controls.Add(this.rbtnDeActive);
            this.tabInterviews.Controls.Add(this.rbtnActive);
            this.tabInterviews.Controls.Add(this.dgvInterview);
            this.tabInterviews.Controls.Add(this.btnShowAllInt);
            this.tabInterviews.Controls.Add(this.txtCompany);
            this.tabInterviews.Controls.Add(this.txtSlnos);
            this.tabInterviews.Controls.Add(this.dtpDate);
            this.tabInterviews.Controls.Add(this.label8);
            this.tabInterviews.Controls.Add(this.label9);
            this.tabInterviews.Controls.Add(this.label10);
            this.tabInterviews.Controls.Add(this.label11);
            this.tabInterviews.Controls.Add(this.btnIntDelete);
            this.tabInterviews.Controls.Add(this.btnIntAdd);
            this.tabInterviews.Location = new System.Drawing.Point(4, 22);
            this.tabInterviews.Name = "tabInterviews";
            this.tabInterviews.Padding = new System.Windows.Forms.Padding(3);
            this.tabInterviews.Size = new System.Drawing.Size(767, 668);
            this.tabInterviews.TabIndex = 0;
            this.tabInterviews.Text = "Status";
            // 
            // txtRecruiter
            // 
            this.txtRecruiter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRecruiter.Location = new System.Drawing.Point(627, 27);
            this.txtRecruiter.Name = "txtRecruiter";
            this.txtRecruiter.Size = new System.Drawing.Size(119, 22);
            this.txtRecruiter.TabIndex = 50;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(534, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 16);
            this.label2.TabIndex = 49;
            this.label2.Text = "Recruiter :-";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PaleGreen;
            this.panel1.Controls.Add(this.cmbMonth);
            this.panel1.Controls.Add(this.btnShowByMonths);
            this.panel1.Location = new System.Drawing.Point(537, 55);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(209, 70);
            this.panel1.TabIndex = 48;
            // 
            // cmbMonth
            // 
            this.cmbMonth.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbMonth.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbMonth.FormattingEnabled = true;
            this.cmbMonth.Items.AddRange(new object[] {
            "Jan",
            "Feb",
            "Mar",
            "Apr",
            "May",
            "Jun",
            "Jul",
            "Aug",
            "Sep",
            "Oct",
            "Nov",
            "Dec"});
            this.cmbMonth.Location = new System.Drawing.Point(25, 11);
            this.cmbMonth.Name = "cmbMonth";
            this.cmbMonth.Size = new System.Drawing.Size(159, 21);
            this.cmbMonth.TabIndex = 46;
            this.cmbMonth.Text = "Select";
            this.cmbMonth.SelectedIndexChanged += new System.EventHandler(this.cmbMonth_SelectedIndexChanged);
            // 
            // btnShowByMonths
            // 
            this.btnShowByMonths.Location = new System.Drawing.Point(25, 38);
            this.btnShowByMonths.Name = "btnShowByMonths";
            this.btnShowByMonths.Size = new System.Drawing.Size(159, 24);
            this.btnShowByMonths.TabIndex = 45;
            this.btnShowByMonths.Text = "Show By Months";
            this.btnShowByMonths.UseVisualStyleBackColor = true;
            this.btnShowByMonths.Click += new System.EventHandler(this.btnShowByMonths_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(643, 131);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(105, 35);
            this.btnClose.TabIndex = 47;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // cmbResult
            // 
            this.cmbResult.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbResult.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbResult.FormattingEnabled = true;
            this.cmbResult.Items.AddRange(new object[] {
            "Others",
            "Postponed",
            "Rejected",
            "Selected"});
            this.cmbResult.Location = new System.Drawing.Point(357, 96);
            this.cmbResult.Name = "cmbResult";
            this.cmbResult.Size = new System.Drawing.Size(164, 21);
            this.cmbResult.TabIndex = 44;
            this.cmbResult.Text = "Awaiting";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(265, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 16);
            this.label1.TabIndex = 43;
            this.label1.Text = "Result :-";
            // 
            // btnIntUpdate
            // 
            this.btnIntUpdate.Enabled = false;
            this.btnIntUpdate.Location = new System.Drawing.Point(280, 131);
            this.btnIntUpdate.Name = "btnIntUpdate";
            this.btnIntUpdate.Size = new System.Drawing.Size(105, 35);
            this.btnIntUpdate.TabIndex = 42;
            this.btnIntUpdate.Text = "Update";
            this.btnIntUpdate.UseVisualStyleBackColor = true;
            this.btnIntUpdate.Click += new System.EventHandler(this.btnIntUpdate_Click);
            // 
            // cmbStatusInt
            // 
            this.cmbStatusInt.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbStatusInt.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbStatusInt.FormattingEnabled = true;
            this.cmbStatusInt.Items.AddRange(new object[] {
            "Applied for",
            "Cancelled",
            "Client Round",
            "Face to Face",
            "First Round",
            "HR Round",
            "Telephonic/Skype"});
            this.cmbStatusInt.Location = new System.Drawing.Point(83, 99);
            this.cmbStatusInt.Name = "cmbStatusInt";
            this.cmbStatusInt.Size = new System.Drawing.Size(164, 21);
            this.cmbStatusInt.TabIndex = 41;
            this.cmbStatusInt.Text = "Select";
            // 
            // dtpTime
            // 
            this.dtpTime.CustomFormat = "h:mm tt";
            this.dtpTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTime.Location = new System.Drawing.Point(357, 61);
            this.dtpTime.Name = "dtpTime";
            this.dtpTime.Size = new System.Drawing.Size(166, 20);
            this.dtpTime.TabIndex = 40;
            // 
            // lblTimeInt
            // 
            this.lblTimeInt.AutoSize = true;
            this.lblTimeInt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimeInt.ForeColor = System.Drawing.Color.Black;
            this.lblTimeInt.Location = new System.Drawing.Point(265, 63);
            this.lblTimeInt.Name = "lblTimeInt";
            this.lblTimeInt.Size = new System.Drawing.Size(56, 16);
            this.lblTimeInt.TabIndex = 39;
            this.lblTimeInt.Text = "Time :-";
            // 
            // lblStatusInt
            // 
            this.lblStatusInt.AutoSize = true;
            this.lblStatusInt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatusInt.ForeColor = System.Drawing.Color.Black;
            this.lblStatusInt.Location = new System.Drawing.Point(16, 101);
            this.lblStatusInt.Name = "lblStatusInt";
            this.lblStatusInt.Size = new System.Drawing.Size(64, 16);
            this.lblStatusInt.TabIndex = 37;
            this.lblStatusInt.Text = "Status :-";
            // 
            // rbtnDeActive
            // 
            this.rbtnDeActive.AutoSize = true;
            this.rbtnDeActive.Location = new System.Drawing.Point(80, 140);
            this.rbtnDeActive.Name = "rbtnDeActive";
            this.rbtnDeActive.Size = new System.Drawing.Size(72, 17);
            this.rbtnDeActive.TabIndex = 36;
            this.rbtnDeActive.Text = "De-Active";
            this.rbtnDeActive.UseVisualStyleBackColor = true;
            this.rbtnDeActive.CheckedChanged += new System.EventHandler(this.rbtnDeActive_CheckedChanged);
            // 
            // rbtnActive
            // 
            this.rbtnActive.AutoSize = true;
            this.rbtnActive.Checked = true;
            this.rbtnActive.Location = new System.Drawing.Point(16, 140);
            this.rbtnActive.Name = "rbtnActive";
            this.rbtnActive.Size = new System.Drawing.Size(55, 17);
            this.rbtnActive.TabIndex = 35;
            this.rbtnActive.TabStop = true;
            this.rbtnActive.Text = "Active";
            this.rbtnActive.UseVisualStyleBackColor = true;
            this.rbtnActive.CheckedChanged += new System.EventHandler(this.rbtnActive_CheckedChanged);
            // 
            // dgvInterview
            // 
            this.dgvInterview.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvInterview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvInterview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInterview.Location = new System.Drawing.Point(4, 177);
            this.dgvInterview.Name = "dgvInterview";
            this.dgvInterview.Size = new System.Drawing.Size(753, 487);
            this.dgvInterview.TabIndex = 34;
            this.dgvInterview.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInterview_CellContentClick);
            this.dgvInterview.SelectionChanged += new System.EventHandler(this.dgvInterview_SelectionChanged);
            // 
            // btnShowAllInt
            // 
            this.btnShowAllInt.Location = new System.Drawing.Point(522, 131);
            this.btnShowAllInt.Name = "btnShowAllInt";
            this.btnShowAllInt.Size = new System.Drawing.Size(105, 35);
            this.btnShowAllInt.TabIndex = 33;
            this.btnShowAllInt.Text = "Show All Records";
            this.btnShowAllInt.UseVisualStyleBackColor = true;
            this.btnShowAllInt.Click += new System.EventHandler(this.btnShowAllInt_Click);
            // 
            // txtCompany
            // 
            this.txtCompany.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCompany.Location = new System.Drawing.Point(357, 27);
            this.txtCompany.Name = "txtCompany";
            this.txtCompany.Size = new System.Drawing.Size(166, 22);
            this.txtCompany.TabIndex = 32;
            // 
            // txtSlnos
            // 
            this.txtSlnos.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtSlnos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSlnos.Location = new System.Drawing.Point(83, 27);
            this.txtSlnos.Name = "txtSlnos";
            this.txtSlnos.ReadOnly = true;
            this.txtSlnos.Size = new System.Drawing.Size(166, 22);
            this.txtSlnos.TabIndex = 20;
            // 
            // dtpDate
            // 
            this.dtpDate.CustomFormat = "dd -MMMM- yyyy";
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Location = new System.Drawing.Point(83, 63);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(166, 20);
            this.dtpDate.TabIndex = 31;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(16, 65);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 16);
            this.label8.TabIndex = 29;
            this.label8.Text = "Date :-";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(265, 30);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 16);
            this.label9.TabIndex = 28;
            this.label9.Text = "Company :-";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(16, 30);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 16);
            this.label10.TabIndex = 27;
            this.label10.Text = "Sl No :-";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.DarkRed;
            this.label11.Location = new System.Drawing.Point(302, 7);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(167, 16);
            this.label11.TabIndex = 26;
            this.label11.Text = "INTERVIEWS STATUS";
            // 
            // btnIntDelete
            // 
            this.btnIntDelete.Enabled = false;
            this.btnIntDelete.Location = new System.Drawing.Point(401, 131);
            this.btnIntDelete.Name = "btnIntDelete";
            this.btnIntDelete.Size = new System.Drawing.Size(105, 35);
            this.btnIntDelete.TabIndex = 23;
            this.btnIntDelete.Text = "Delete";
            this.btnIntDelete.UseVisualStyleBackColor = true;
            this.btnIntDelete.Click += new System.EventHandler(this.btnIntDelete_Click);
            // 
            // btnIntAdd
            // 
            this.btnIntAdd.Location = new System.Drawing.Point(159, 131);
            this.btnIntAdd.Name = "btnIntAdd";
            this.btnIntAdd.Size = new System.Drawing.Size(105, 35);
            this.btnIntAdd.TabIndex = 22;
            this.btnIntAdd.Text = "Add";
            this.btnIntAdd.UseVisualStyleBackColor = true;
            this.btnIntAdd.Click += new System.EventHandler(this.btnIntAdd_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tabControl1.Controls.Add(this.tabInterviews);
            this.tabControl1.Location = new System.Drawing.Point(0, -1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(775, 694);
            this.tabControl1.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 693);
            this.ControlBox = false;
            this.Controls.Add(this.tabControl1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Interview Status";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabInterviews.ResumeLayout(false);
            this.tabInterviews.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInterview)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabInterviews;
        private System.Windows.Forms.ComboBox cmbResult;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnIntUpdate;
        private System.Windows.Forms.ComboBox cmbStatusInt;
        private System.Windows.Forms.DateTimePicker dtpTime;
        private System.Windows.Forms.Label lblTimeInt;
        private System.Windows.Forms.Label lblStatusInt;
        private System.Windows.Forms.RadioButton rbtnDeActive;
        private System.Windows.Forms.RadioButton rbtnActive;
        private System.Windows.Forms.DataGridView dgvInterview;
        private System.Windows.Forms.Button btnShowAllInt;
        private System.Windows.Forms.TextBox txtCompany;
        private System.Windows.Forms.TextBox txtSlnos;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnIntDelete;
        private System.Windows.Forms.Button btnIntAdd;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.ComboBox cmbMonth;
        private System.Windows.Forms.Button btnShowByMonths;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtRecruiter;
        private System.Windows.Forms.Label label2;


    }
}