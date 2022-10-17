namespace Lab8
{
    partial class CourseForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.roomNumberLabel = new System.Windows.Forms.Label();
            this.instructorLabel = new System.Windows.Forms.Label();
            this.meetingTimeLabel = new System.Windows.Forms.Label();
            this.courseListBox = new System.Windows.Forms.ListBox();
            this.getCourseButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(311, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select Course Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Room Number:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Instructor:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Meeting Time:";
            // 
            // roomNumberLabel
            // 
            this.roomNumberLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.roomNumberLabel.Location = new System.Drawing.Point(150, 34);
            this.roomNumberLabel.Name = "roomNumberLabel";
            this.roomNumberLabel.Size = new System.Drawing.Size(100, 23);
            this.roomNumberLabel.TabIndex = 8;
            // 
            // instructorLabel
            // 
            this.instructorLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.instructorLabel.Location = new System.Drawing.Point(150, 69);
            this.instructorLabel.Name = "instructorLabel";
            this.instructorLabel.Size = new System.Drawing.Size(100, 23);
            this.instructorLabel.TabIndex = 10;
            // 
            // meetingTimeLabel
            // 
            this.meetingTimeLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.meetingTimeLabel.Location = new System.Drawing.Point(150, 101);
            this.meetingTimeLabel.Name = "meetingTimeLabel";
            this.meetingTimeLabel.Size = new System.Drawing.Size(100, 23);
            this.meetingTimeLabel.TabIndex = 12;
            // 
            // courseListBox
            // 
            this.courseListBox.FormattingEnabled = true;
            this.courseListBox.ItemHeight = 15;
            this.courseListBox.Location = new System.Drawing.Point(285, 86);
            this.courseListBox.Name = "courseListBox";
            this.courseListBox.Size = new System.Drawing.Size(193, 154);
            this.courseListBox.TabIndex = 13;
            // 
            // getCourseButton
            // 
            this.getCourseButton.Location = new System.Drawing.Point(311, 246);
            this.getCourseButton.Name = "getCourseButton";
            this.getCourseButton.Size = new System.Drawing.Size(130, 23);
            this.getCourseButton.TabIndex = 14;
            this.getCourseButton.Text = "Get Course Info";
            this.getCourseButton.UseVisualStyleBackColor = true;
            this.getCourseButton.Click += new System.EventHandler(this.getCourseButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.meetingTimeLabel);
            this.groupBox1.Controls.Add(this.roomNumberLabel);
            this.groupBox1.Controls.Add(this.instructorLabel);
            this.groupBox1.Location = new System.Drawing.Point(244, 275);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(266, 124);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Course Information";
            // 
            // CourseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.getCourseButton);
            this.Controls.Add(this.courseListBox);
            this.Controls.Add(this.label1);
            this.Name = "CourseForm";
            this.Text = "CourseForm";
            this.Load += new System.EventHandler(this.CourseForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label roomNumberLabel;
        private Label instructorLabel;
        private Label meetingTimeLabel;
        private ListBox courseListBox;
        private Button getCourseButton;
        private GroupBox groupBox1;
    }
}