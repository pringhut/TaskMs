namespace TaskMs
{
    partial class Form1
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
            taskPanel = new FlowLayoutPanel();
            panel1 = new Panel();
            btnAddTask = new Button();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // taskPanel
            // 
            taskPanel.Location = new Point(-2, 69);
            taskPanel.Name = "taskPanel";
            taskPanel.Size = new Size(401, 177);
            taskPanel.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnAddTask);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-2, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(398, 64);
            panel1.TabIndex = 1;
            // 
            // btnAddTask
            // 
            btnAddTask.Location = new Point(277, 20);
            btnAddTask.Name = "btnAddTask";
            btnAddTask.Size = new Size(79, 22);
            btnAddTask.TabIndex = 1;
            btnAddTask.Text = "Add Task";
            btnAddTask.UseVisualStyleBackColor = true;
            btnAddTask.Click += btnAddTask_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 24);
            label1.Name = "label1";
            label1.Size = new Size(103, 15);
            label1.TabIndex = 0;
            label1.Text = "Task Management";
            label1.Click += label1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(398, 245);
            Controls.Add(panel1);
            Controls.Add(taskPanel);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel taskPanel;
        private Panel panel1;
        private Label label1;
        private Button btnAddTask;
    }
}
