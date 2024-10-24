namespace test
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.Close_button = new System.Windows.Forms.Button();
            this.Terminate_current_instance = new System.Windows.Forms.Button();
            this.New_instance = new System.Windows.Forms.Button();
            this.Terminate_all_process = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AccessibleName = "";
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.Close_button);
            this.panel1.Location = new System.Drawing.Point(-1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(804, 30);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // Close_button
            // 
            this.Close_button.AutoSize = true;
            this.Close_button.Location = new System.Drawing.Point(761, 1);
            this.Close_button.Name = "Close_button";
            this.Close_button.Size = new System.Drawing.Size(40, 26);
            this.Close_button.TabIndex = 0;
            this.Close_button.Text = "X";
            this.Close_button.UseVisualStyleBackColor = true;
            this.Close_button.Click += new System.EventHandler(this.Close_button_Click);
            // 
            // Terminate_current_instance
            // 
            this.Terminate_current_instance.AutoSize = true;
            this.Terminate_current_instance.Location = new System.Drawing.Point(47, 69);
            this.Terminate_current_instance.Name = "Terminate_current_instance";
            this.Terminate_current_instance.Size = new System.Drawing.Size(138, 36);
            this.Terminate_current_instance.TabIndex = 1;
            this.Terminate_current_instance.Text = "Terminate this application";
            this.Terminate_current_instance.UseVisualStyleBackColor = true;
            this.Terminate_current_instance.Click += new System.EventHandler(this.Terminate_current_instance_Click);
            // 
            // New_instance
            // 
            this.New_instance.AutoSize = true;
            this.New_instance.Location = new System.Drawing.Point(318, 69);
            this.New_instance.Name = "New_instance";
            this.New_instance.Size = new System.Drawing.Size(138, 36);
            this.New_instance.TabIndex = 2;
            this.New_instance.Text = "New instance";
            this.New_instance.UseVisualStyleBackColor = true;
            this.New_instance.Click += new System.EventHandler(this.New_instance_Click);
            // 
            // Terminate_all_process
            // 
            this.Terminate_all_process.AutoSize = true;
            this.Terminate_all_process.Location = new System.Drawing.Point(592, 69);
            this.Terminate_all_process.Name = "Terminate_all_process";
            this.Terminate_all_process.Size = new System.Drawing.Size(186, 36);
            this.Terminate_all_process.TabIndex = 3;
            this.Terminate_all_process.Text = "Terminate all instance of application";
            this.Terminate_all_process.UseVisualStyleBackColor = true;
            this.Terminate_all_process.Click += new System.EventHandler(this.Terminate_all_process_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Terminate_all_process);
            this.Controls.Add(this.New_instance);
            this.Controls.Add(this.Terminate_current_instance);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Close_button;
        private System.Windows.Forms.Button Terminate_current_instance;
        private System.Windows.Forms.Button New_instance;
        private System.Windows.Forms.Button Terminate_all_process;
    }
}

