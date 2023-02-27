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
            label1.Location = new Point(212, 35);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 2;
            label1.Text = "Name:";
            // 
            // lbxInfo
            // 
            lbxInfo.FormattingEnabled = true;
            lbxInfo.ItemHeight = 15;
            lbxInfo.Location = new Point(432, 30);
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
            // frmCourses
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(694, 435);
            Controls.Add(statusStrip1);
            Controls.Add(lbxInfo);
            Controls.Add(label1);
            Controls.Add(txtName);
            Controls.Add(btnCreate);
            Name = "frmCourses";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Course Work";
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
    }
}