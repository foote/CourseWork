namespace BDF.CourseWork.UI
{
    partial class frmCourses
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnCreate = new Button();
            txtName = new TextBox();
            label1 = new Label();
            lbxInfo = new ListBox();
            statusStrip1 = new StatusStrip();
            lblStatus = new ToolStripStatusLabel();
            btnMakeCourse = new Button();
            btnGetCourse = new Button();
            btnMakeCourse2 = new Button();
            btnCallMethods = new Button();
            btnAssignSectionNo = new Button();
            label2 = new Label();
            txtSectionNo = new TextBox();
            btnAddCourseToList = new Button();
            btnAddStringToList = new Button();
            btnRemoveFromList = new Button();
            btnRemoveAllNames = new Button();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(29, 30);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(118, 23);
            btnCreate.TabIndex = 0;
            btnCreate.Text = "Create Course";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // txtName
            // 
            txtName.Location = new Point(261, 30);
            txtName.Name = "txtName";
            txtName.Size = new Size(138, 23);
            txtName.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(213, 34);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 2;
            label1.Text = "Name:";
            // 
            // lbxInfo
            // 
            lbxInfo.FormattingEnabled = true;
            lbxInfo.ItemHeight = 15;
            lbxInfo.Location = new Point(464, 30);
            lbxInfo.Name = "lbxInfo";
            lbxInfo.Size = new Size(207, 349);
            lbxInfo.TabIndex = 3;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { lblStatus });
            statusStrip1.Location = new Point(0, 413);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(694, 22);
            statusStrip1.TabIndex = 4;
            statusStrip1.Text = "statusStrip1";
            // 
            // lblStatus
            // 
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(0, 17);
            // 
            // btnMakeCourse
            // 
            btnMakeCourse.Location = new Point(29, 59);
            btnMakeCourse.Name = "btnMakeCourse";
            btnMakeCourse.Size = new Size(118, 23);
            btnMakeCourse.TabIndex = 5;
            btnMakeCourse.Text = "Make Course";
            btnMakeCourse.UseVisualStyleBackColor = true;
            btnMakeCourse.Click += btnMakeCourse_Click;
            // 
            // btnGetCourse
            // 
            btnGetCourse.Location = new Point(29, 88);
            btnGetCourse.Name = "btnGetCourse";
            btnGetCourse.Size = new Size(118, 23);
            btnGetCourse.TabIndex = 6;
            btnGetCourse.Text = "Get Course";
            btnGetCourse.UseVisualStyleBackColor = true;
            btnGetCourse.Click += btnGetCourse_Click;
            // 
            // btnMakeCourse2
            // 
            btnMakeCourse2.Location = new Point(29, 117);
            btnMakeCourse2.Name = "btnMakeCourse2";
            btnMakeCourse2.Size = new Size(118, 23);
            btnMakeCourse2.TabIndex = 7;
            btnMakeCourse2.Text = "Make Course";
            btnMakeCourse2.UseVisualStyleBackColor = true;
            btnMakeCourse2.Click += btnMakeCourse2_Click;
            // 
            // btnCallMethods
            // 
            btnCallMethods.Location = new Point(29, 146);
            btnCallMethods.Name = "btnCallMethods";
            btnCallMethods.Size = new Size(118, 23);
            btnCallMethods.TabIndex = 8;
            btnCallMethods.Text = "Call Methods";
            btnCallMethods.UseVisualStyleBackColor = true;
            btnCallMethods.Click += btnCallMethods_Click;
            // 
            // btnAssignSectionNo
            // 
            btnAssignSectionNo.Location = new Point(29, 175);
            btnAssignSectionNo.Name = "btnAssignSectionNo";
            btnAssignSectionNo.Size = new Size(118, 23);
            btnAssignSectionNo.TabIndex = 9;
            btnAssignSectionNo.Text = "Assign Section No";
            btnAssignSectionNo.UseVisualStyleBackColor = true;
            btnAssignSectionNo.Click += btnAssignSectionNo_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(187, 67);
            label2.Name = "label2";
            label2.Size = new Size(68, 15);
            label2.TabIndex = 11;
            label2.Text = "Section No:";
            // 
            // txtSectionNo
            // 
            txtSectionNo.Location = new Point(261, 60);
            txtSectionNo.Name = "txtSectionNo";
            txtSectionNo.Size = new Size(138, 23);
            txtSectionNo.TabIndex = 10;
            // 
            // btnAddCourseToList
            // 
            btnAddCourseToList.Location = new Point(29, 289);
            btnAddCourseToList.Name = "btnAddCourseToList";
            btnAddCourseToList.Size = new Size(118, 23);
            btnAddCourseToList.TabIndex = 12;
            btnAddCourseToList.Text = "Add Course To List";
            btnAddCourseToList.UseVisualStyleBackColor = true;
            btnAddCourseToList.Click += btnAddCourseToList_Click;
            // 
            // btnAddStringToList
            // 
            btnAddStringToList.Location = new Point(29, 203);
            btnAddStringToList.Name = "btnAddStringToList";
            btnAddStringToList.Size = new Size(118, 23);
            btnAddStringToList.TabIndex = 13;
            btnAddStringToList.Text = "Add String To List";
            btnAddStringToList.UseVisualStyleBackColor = true;
            btnAddStringToList.Click += btnAddStringToList_Click;
            // 
            // btnRemoveFromList
            // 
            btnRemoveFromList.Location = new Point(29, 232);
            btnRemoveFromList.Name = "btnRemoveFromList";
            btnRemoveFromList.Size = new Size(118, 23);
            btnRemoveFromList.TabIndex = 14;
            btnRemoveFromList.Text = "Remove From List";
            btnRemoveFromList.UseVisualStyleBackColor = true;
            btnRemoveFromList.Click += btnRemoveFromList_Click;
            // 
            // btnRemoveAllNames
            // 
            btnRemoveAllNames.Location = new Point(29, 260);
            btnRemoveAllNames.Name = "btnRemoveAllNames";
            btnRemoveAllNames.Size = new Size(118, 23);
            btnRemoveAllNames.TabIndex = 15;
            btnRemoveAllNames.Text = "Remove All Names";
            btnRemoveAllNames.UseVisualStyleBackColor = true;
            btnRemoveAllNames.Click += btnRemoveAllNames_Click;
            // 
            // frmCourses
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(694, 435);
            Controls.Add(btnRemoveAllNames);
            Controls.Add(btnRemoveFromList);
            Controls.Add(btnAddStringToList);
            Controls.Add(btnAddCourseToList);
            Controls.Add(label2);
            Controls.Add(txtSectionNo);
            Controls.Add(btnAssignSectionNo);
            Controls.Add(btnCallMethods);
            Controls.Add(btnMakeCourse2);
            Controls.Add(btnGetCourse);
            Controls.Add(btnMakeCourse);
            Controls.Add(statusStrip1);
            Controls.Add(lbxInfo);
            Controls.Add(label1);
            Controls.Add(txtName);
            Controls.Add(btnCreate);
            Name = "frmCourses";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Course Work";
            Load += frmCourses_Load;
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCreate;
        private TextBox txtName;
        private Label label1;
        private ListBox lbxInfo;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel lblStatus;
        private Button btnMakeCourse;
        private Button btnGetCourse;
        private Button btnMakeCourse2;
        private Button btnCallMethods;
        private Button btnAssignSectionNo;
        private Label label2;
        private TextBox txtSectionNo;
        private Button btnAddCourseToList;
        private Button btnAddStringToList;
        private Button btnRemoveFromList;
        private Button btnRemoveAllNames;
    }
}