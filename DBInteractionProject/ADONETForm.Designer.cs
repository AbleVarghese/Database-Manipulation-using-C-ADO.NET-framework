namespace DBInteractionProject
{
    partial class LearnerInformation
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
            this.learnerIdSearch = new System.Windows.Forms.TextBox();
            this.learnerId = new System.Windows.Forms.TextBox();
            this.learnerName = new System.Windows.Forms.TextBox();
            this.favoriteTeacher = new System.Windows.Forms.TextBox();
            this.coursesRemaining = new System.Windows.Forms.TextBox();
            this.coursesCompleted = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.learnerIdLabel = new System.Windows.Forms.Label();
            this.learnerNameLabel = new System.Windows.Forms.Label();
            this.favoriteTeacherLabel = new System.Windows.Forms.Label();
            this.coursesRemainingLabel = new System.Windows.Forms.Label();
            this.coursesCompletedLabel = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.learnerIdDelete = new System.Windows.Forms.TextBox();
            this.deleteButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // learnerIdSearch
            // 
            this.learnerIdSearch.Location = new System.Drawing.Point(604, 78);
            this.learnerIdSearch.Name = "learnerIdSearch";
            this.learnerIdSearch.Size = new System.Drawing.Size(100, 20);
            this.learnerIdSearch.TabIndex = 1;
            // 
            // learnerId
            // 
            this.learnerId.Location = new System.Drawing.Point(271, 31);
            this.learnerId.Name = "learnerId";
            this.learnerId.Size = new System.Drawing.Size(100, 22);
            this.learnerId.TabIndex = 3;
            // 
            // learnerName
            // 
            this.learnerName.Location = new System.Drawing.Point(271, 78);
            this.learnerName.Name = "learnerName";
            this.learnerName.Size = new System.Drawing.Size(100, 22);
            this.learnerName.TabIndex = 3;
            // 
            // favoriteTeacher
            // 
            this.favoriteTeacher.Location = new System.Drawing.Point(271, 121);
            this.favoriteTeacher.Name = "favoriteTeacher";
            this.favoriteTeacher.Size = new System.Drawing.Size(100, 22);
            this.favoriteTeacher.TabIndex = 3;
            // 
            // coursesRemaining
            // 
            this.coursesRemaining.Location = new System.Drawing.Point(271, 166);
            this.coursesRemaining.Name = "coursesRemaining";
            this.coursesRemaining.Size = new System.Drawing.Size(100, 22);
            this.coursesRemaining.TabIndex = 3;
            // 
            // coursesCompleted
            // 
            this.coursesCompleted.Location = new System.Drawing.Point(271, 210);
            this.coursesCompleted.Name = "coursesCompleted";
            this.coursesCompleted.Size = new System.Drawing.Size(100, 22);
            this.coursesCompleted.TabIndex = 3;
            // 
            // searchButton
            // 
            this.searchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButton.Location = new System.Drawing.Point(724, 68);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(85, 32);
            this.searchButton.TabIndex = 4;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // addButton
            // 
            this.addButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButton.Location = new System.Drawing.Point(144, 327);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(85, 32);
            this.addButton.TabIndex = 5;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateButton.Location = new System.Drawing.Point(271, 327);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(85, 32);
            this.updateButton.TabIndex = 7;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // learnerIdLabel
            // 
            this.learnerIdLabel.AutoSize = true;
            this.learnerIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.learnerIdLabel.Location = new System.Drawing.Point(135, 35);
            this.learnerIdLabel.Name = "learnerIdLabel";
            this.learnerIdLabel.Size = new System.Drawing.Size(70, 16);
            this.learnerIdLabel.TabIndex = 8;
            this.learnerIdLabel.Text = "Learner ID";
            // 
            // learnerNameLabel
            // 
            this.learnerNameLabel.AutoSize = true;
            this.learnerNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.learnerNameLabel.Location = new System.Drawing.Point(135, 79);
            this.learnerNameLabel.Name = "learnerNameLabel";
            this.learnerNameLabel.Size = new System.Drawing.Size(104, 16);
            this.learnerNameLabel.TabIndex = 8;
            this.learnerNameLabel.Text = "Learner\'s Name";
            // 
            // favoriteTeacherLabel
            // 
            this.favoriteTeacherLabel.AutoSize = true;
            this.favoriteTeacherLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.favoriteTeacherLabel.Location = new System.Drawing.Point(135, 125);
            this.favoriteTeacherLabel.Name = "favoriteTeacherLabel";
            this.favoriteTeacherLabel.Size = new System.Drawing.Size(111, 16);
            this.favoriteTeacherLabel.TabIndex = 8;
            this.favoriteTeacherLabel.Text = "Favorite Teacher";
            // 
            // coursesRemainingLabel
            // 
            this.coursesRemainingLabel.AutoSize = true;
            this.coursesRemainingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coursesRemainingLabel.Location = new System.Drawing.Point(135, 167);
            this.coursesRemainingLabel.Name = "coursesRemainingLabel";
            this.coursesRemainingLabel.Size = new System.Drawing.Size(126, 16);
            this.coursesRemainingLabel.TabIndex = 8;
            this.coursesRemainingLabel.Text = "Courses Remaining";
            // 
            // coursesCompletedLabel
            // 
            this.coursesCompletedLabel.AutoSize = true;
            this.coursesCompletedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coursesCompletedLabel.Location = new System.Drawing.Point(135, 214);
            this.coursesCompletedLabel.Name = "coursesCompletedLabel";
            this.coursesCompletedLabel.Size = new System.Drawing.Size(127, 16);
            this.coursesCompletedLabel.TabIndex = 8;
            this.coursesCompletedLabel.Text = "Courses Completed";
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(672, 415);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(114, 39);
            this.exitButton.TabIndex = 9;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(404, 327);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 32);
            this.button1.TabIndex = 10;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.clear_Click);
            // 
            // learnerIdDelete
            // 
            this.learnerIdDelete.Location = new System.Drawing.Point(604, 235);
            this.learnerIdDelete.Name = "learnerIdDelete";
            this.learnerIdDelete.Size = new System.Drawing.Size(100, 20);
            this.learnerIdDelete.TabIndex = 3;
            // 
            // deleteButton
            // 
            this.deleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteButton.Location = new System.Drawing.Point(722, 228);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(85, 32);
            this.deleteButton.TabIndex = 6;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(607, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Learner\'s Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(607, 207);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Learner\'s Id";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.learnerIdLabel);
            this.groupBox1.Controls.Add(this.learnerId);
            this.groupBox1.Controls.Add(this.favoriteTeacher);
            this.groupBox1.Controls.Add(this.coursesCompletedLabel);
            this.groupBox1.Controls.Add(this.coursesRemaining);
            this.groupBox1.Controls.Add(this.coursesRemainingLabel);
            this.groupBox1.Controls.Add(this.coursesCompleted);
            this.groupBox1.Controls.Add(this.favoriteTeacherLabel);
            this.groupBox1.Controls.Add(this.learnerName);
            this.groupBox1.Controls.Add(this.learnerNameLabel);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(43, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(514, 269);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Learners Information Display";
            // 
            // LearnerInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 479);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.learnerIdDelete);
            this.Controls.Add(this.learnerIdSearch);
            this.Name = "LearnerInformation";
            this.Text = "Learner Information";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox learnerIdSearch;
        private System.Windows.Forms.TextBox learnerId;
        private System.Windows.Forms.TextBox learnerName;
        private System.Windows.Forms.TextBox favoriteTeacher;
        private System.Windows.Forms.TextBox coursesRemaining;
        private System.Windows.Forms.TextBox coursesCompleted;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Label learnerIdLabel;
        private System.Windows.Forms.Label learnerNameLabel;
        private System.Windows.Forms.Label favoriteTeacherLabel;
        private System.Windows.Forms.Label coursesRemainingLabel;
        private System.Windows.Forms.Label coursesCompletedLabel;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox learnerIdDelete;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

