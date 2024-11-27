namespace TaskMs.Forms
{
    partial class AddTaskForm
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
            label1 = new Label();
            lblStatus = new Label();
            label3 = new Label();
            txtTaskName = new TextBox();
            txtStatus = new TextBox();
            rtxtDescription = new RichTextBox();
            btnSaveTask = new Button();
            gboxAddForm = new GroupBox();
            label2 = new Label();
            gboxAddForm.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 51);
            label1.Name = "label1";
            label1.Size = new Size(61, 15);
            label1.TabIndex = 0;
            label1.Text = "TaskName";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(18, 147);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(39, 15);
            lblStatus.TabIndex = 1;
            lblStatus.Text = "Status";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 86);
            label3.Name = "label3";
            label3.Size = new Size(67, 15);
            label3.TabIndex = 2;
            label3.Text = "Description";
            // 
            // txtTaskName
            // 
            txtTaskName.Location = new Point(134, 48);
            txtTaskName.Name = "txtTaskName";
            txtTaskName.Size = new Size(117, 23);
            txtTaskName.TabIndex = 3;
            // 
            // txtStatus
            // 
            txtStatus.Location = new Point(134, 139);
            txtStatus.Name = "txtStatus";
            txtStatus.Size = new Size(117, 23);
            txtStatus.TabIndex = 4;
            // 
            // rtxtDescription
            // 
            rtxtDescription.Location = new Point(135, 77);
            rtxtDescription.Name = "rtxtDescription";
            rtxtDescription.Size = new Size(116, 56);
            rtxtDescription.TabIndex = 5;
            rtxtDescription.Text = "";
            // 
            // btnSaveTask
            // 
            btnSaveTask.Location = new Point(148, 172);
            btnSaveTask.Name = "btnSaveTask";
            btnSaveTask.Size = new Size(90, 29);
            btnSaveTask.TabIndex = 6;
            btnSaveTask.Text = "Save";
            btnSaveTask.UseVisualStyleBackColor = true;
            btnSaveTask.Click += btnSaveTask_Click;
            // 
            // gboxAddForm
            // 
            gboxAddForm.Controls.Add(label2);
            gboxAddForm.Controls.Add(btnSaveTask);
            gboxAddForm.Controls.Add(rtxtDescription);
            gboxAddForm.Controls.Add(txtStatus);
            gboxAddForm.Controls.Add(txtTaskName);
            gboxAddForm.Controls.Add(label3);
            gboxAddForm.Controls.Add(lblStatus);
            gboxAddForm.Controls.Add(label1);
            gboxAddForm.Location = new Point(56, 25);
            gboxAddForm.Name = "gboxAddForm";
            gboxAddForm.Size = new Size(300, 215);
            gboxAddForm.TabIndex = 7;
            gboxAddForm.TabStop = false;
            gboxAddForm.Text = "groupBox1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(163, 30);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 7;
            label2.Text = "Add Task";
            // 
            // AddTaskForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(395, 269);
            Controls.Add(gboxAddForm);
            Name = "AddTaskForm";
            Text = "AddTaskForm";
            gboxAddForm.ResumeLayout(false);
            gboxAddForm.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label lblStatus;
        private Label label3;
        private TextBox txtTaskName;
        private TextBox txtStatus;
        private RichTextBox rtxtDescription;
        private Button btnSaveTask;
        private GroupBox gboxAddForm;
        private Label label2;
    }
}