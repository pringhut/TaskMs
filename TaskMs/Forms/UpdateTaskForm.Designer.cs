namespace TaskMs.Forms
{
    partial class UpdateTaskForm
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
            label2 = new Label();
            label3 = new Label();
            lblStatus = new Label();
            txtTaskName = new TextBox();
            txtStatus = new TextBox();
            rtxtDescription = new RichTextBox();
            btnSaveTask = new Button();
            gboxUpdateForm = new GroupBox();
            gboxUpdateForm.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(161, 16);
            label1.Name = "label1";
            label1.Size = new Size(67, 15);
            label1.TabIndex = 0;
            label1.Text = "UpdateTask";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(38, 47);
            label2.Name = "label2";
            label2.Size = new Size(64, 15);
            label2.TabIndex = 1;
            label2.Text = "Task Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(38, 86);
            label3.Name = "label3";
            label3.Size = new Size(67, 15);
            label3.TabIndex = 2;
            label3.Text = "Description";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(38, 141);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(39, 15);
            lblStatus.TabIndex = 3;
            lblStatus.Text = "Status";
            // 
            // txtTaskName
            // 
            txtTaskName.Location = new Point(139, 44);
            txtTaskName.Name = "txtTaskName";
            txtTaskName.Size = new Size(109, 23);
            txtTaskName.TabIndex = 4;
            // 
            // txtStatus
            // 
            txtStatus.Location = new Point(139, 141);
            txtStatus.Name = "txtStatus";
            txtStatus.Size = new Size(109, 23);
            txtStatus.TabIndex = 5;
            // 
            // rtxtDescription
            // 
            rtxtDescription.Location = new Point(140, 83);
            rtxtDescription.Name = "rtxtDescription";
            rtxtDescription.Size = new Size(109, 46);
            rtxtDescription.TabIndex = 6;
            rtxtDescription.Text = "";
            // 
            // btnSaveTask
            // 
            btnSaveTask.Location = new Point(149, 170);
            btnSaveTask.Name = "btnSaveTask";
            btnSaveTask.Size = new Size(79, 23);
            btnSaveTask.TabIndex = 7;
            btnSaveTask.Text = "Update";
            btnSaveTask.UseVisualStyleBackColor = true;
            btnSaveTask.Click += btnSaveTask_Click;
            // 
            // gboxUpdateForm
            // 
            gboxUpdateForm.Controls.Add(btnSaveTask);
            gboxUpdateForm.Controls.Add(rtxtDescription);
            gboxUpdateForm.Controls.Add(txtStatus);
            gboxUpdateForm.Controls.Add(txtTaskName);
            gboxUpdateForm.Controls.Add(lblStatus);
            gboxUpdateForm.Controls.Add(label3);
            gboxUpdateForm.Controls.Add(label2);
            gboxUpdateForm.Controls.Add(label1);
            gboxUpdateForm.Location = new Point(60, 25);
            gboxUpdateForm.Name = "gboxUpdateForm";
            gboxUpdateForm.Size = new Size(343, 209);
            gboxUpdateForm.TabIndex = 8;
            gboxUpdateForm.TabStop = false;
            gboxUpdateForm.Text = "groupBox1";
            // 
            // UpdateTaskForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(466, 253);
            Controls.Add(gboxUpdateForm);
            Name = "UpdateTaskForm";
            Text = "UpdateTaskForm";
            gboxUpdateForm.ResumeLayout(false);
            gboxUpdateForm.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label lblStatus;
        private TextBox txtTaskName;
        private TextBox txtStatus;
        private RichTextBox rtxtDescription;
        private Button btnSaveTask;
        private GroupBox gboxUpdateForm;
    }
}